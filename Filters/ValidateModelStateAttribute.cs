using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace UberAPI.Filters
{
    public class ValidateModelStateAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            ControllerActionDescriptor? controllerActionDescriptor = context.ActionDescriptor as ControllerActionDescriptor;
            if (controllerActionDescriptor != null)
            {
                ParameterInfo[] parameters = controllerActionDescriptor.MethodInfo.GetParameters();
                foreach (ParameterInfo parameterInfo in parameters)
                {
                    object? args = null;
                    if (context.ActionArguments.ContainsKey(parameterInfo.Name!))
                    {
                        args = context.ActionArguments[parameterInfo.Name];
                    }

                    ValidateAttributes(parameterInfo, args, context.ModelState);
                }
            }

            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }

        private void ValidateAttributes(ParameterInfo parameter, object args, ModelStateDictionary modelState)
        {
            foreach (CustomAttributeData customAttribute in parameter.CustomAttributes)
            {
                ValidationAttribute? validationAttribute = parameter.GetCustomAttribute(customAttribute.AttributeType) as ValidationAttribute;
                if (validationAttribute != null && !validationAttribute.IsValid(args))
                {
                    modelState.AddModelError(parameter.Name!, validationAttribute.FormatErrorMessage(parameter.Name!));
                }
            }
        }
    }
}
