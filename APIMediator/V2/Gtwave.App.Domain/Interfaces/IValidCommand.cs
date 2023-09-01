using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtwave.App.Domain.Interfaces
{
    /// <summary>
    /// Interface for Validation - Validation Results and IsValid methods
    /// </summary>
    /// <remarks>
    /// For implementing must implement:
    /// ValidatiAppesult
    /// IsValid
    /// </remarks>
    public interface IValidCommand
    {
        /// <summary>
        /// Result of Validation
        /// </summary>
        /// <returns> ValidatiAppesults Object</returns>
        public ValidationResult ValidatiAppesult { get; set; }

        /// <summary>
        /// Check if the command parameters are valid
        /// </summary>
        /// <returns>A boolean representing if the object is valid or not</returns>
        bool IsValid();
    }
}
