using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Enums;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;


        private ValidationStates _validationStates;
        public ValidationAspect(Type validatorType, ValidationStates validationStates = ValidationStates.Add)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                // throw new System.Exception(AspectMessages.WrongValidationType);
                throw new System.Exception("Yanlış validator  tipi");

            }

            _validatorType = validatorType;
            _validationStates = validationStates;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            // REF https://stackoverflow.com/questions/2451336/how-to-pass-parameters-to-activator-createinstancet
            var validator = (IValidator)Activator.CreateInstance(_validatorType, _validationStates);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];


            //TODO:  Write a Generic Pattern -
            var argumantype = invocation.Arguments[0].GetType();
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);

            var argumantypeWithBaseType = invocation.Arguments[0].GetType().BaseType;
            var entitiesWithBaseType = invocation.Arguments.Where(t => t.GetType().BaseType == entityType);

            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
            foreach (var entity in entitiesWithBaseType)
            {
                ValidationTool.Validate(validator, entity);

            }
        }
    }
}

