using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Server.IIS.Core;
using Gtwave.App.Application.Authentication.Common;
using Gtwave.App.Application.Authentication.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtwave.App.Application.Common
{
    public class ValidationBehavior<TRequest,TResponse> : 
        IPipelineBehavior<TRequest, TResponse>
            where TRequest : IRequest<TResponse>
            where TResponse : AuthenticatiAppesult
 
    {
        private readonly IValidator<TRequest>? _validator;
         
        public ValidationBehavior(IValidator<TRequest>? validator = null)
        {
            _validator = validator;   
        }

        public async Task<TResponse> Handle(
            TRequest request,
            RequestHandlerDelegate<TResponse> next,
            CancellationToken cancellationToken)
        {
            var validatiAppesult = await _validator.ValidateAsync(request, cancellationToken);

            if (validatiAppesult.IsValid) return await next();
            
            return await next();
            //var errors = validatiAppesult.Errors.Select(validationFailure => Error.Validation );
            //return new Exception(errors.ToString( ));
        }
    }
}
