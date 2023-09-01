using MediatR;
using Gtwave.App.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Gtwave.App.Domain.Commands
{
    /// <summary>
    ///  The Base Command for requests
    /// </summary>
    public abstract class BaseCommand<T> : IRequest<T>, IValidCommand
    {
        /// <summary>
        /// Validation result
        /// </summary>
        [JsonIgnore]
        public ValidationResult ValidatiAppesult { get; set; }

        /// <inheritdoc/>
        public abstract bool IsValid();
    }
}
