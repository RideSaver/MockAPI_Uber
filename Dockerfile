FROM --platform=amd64 mcr.microsoft.com/devcontainers/dotnet:0-6.0 AS builder

ARG github_username
ARG github_token
ARG TARGETPLATFORM

# Install tools
RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
    && apt-get -y install --no-install-recommends default-jre


WORKDIR /server

RUN echo $github_token | base64
RUN dotnet nuget add source --username $github_username --password $github_token --store-password-in-clear-text --name github "https://nuget.pkg.github.com/RideSaver/index.json"

COPY UberAPI.csproj .
RUN dotnet restore

# Copy all files
COPY . .
RUN dotnet publish -p:PublishProfile=PublishTrimmed --sc --os="linux-musl" -o publish

FROM --platform=$TARGETPLATFORM alpine:3.16 AS runtime
# Add labels to add information to the image
LABEL org.opencontainers.image.source=https://github.com/RideSaver/MockAPI_Uber
LABEL org.opencontainers.image.description="Mock Uber API for RideSaver"
LABEL org.opencontainers.image.licenses=MIT

# Add tags to define the api image

# Add some libs required by .NET runtime
RUN apk add --no-cache libstdc++ libintl

EXPOSE 80
EXPOSE 443
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=1

# Copy
WORKDIR /app
COPY --from=builder /server/publish ./

ENTRYPOINT ["./UberAPI", "--urls", "http://0.0.0.0:80;https://0.0.0.0:443"]
