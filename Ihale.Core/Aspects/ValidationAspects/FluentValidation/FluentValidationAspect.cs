using System;
using System.Linq;
using FluentValidation;
using Ihale.Core.CrossCuttingConcerns.Validation.FluentValidation;
using PostSharp.Aspects;

namespace Ihale.Core.Aspects.ValidationAspects.FluentValidation
{
    [Serializable]
    public class FluentValidationAspect :OnMethodBoundaryAspect
    {
        private Type _validatorType;
        public FluentValidationAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {

            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = args.Arguments.Where(s => s.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.FluentValidate(validator, entity);
            }

        }
    }
}