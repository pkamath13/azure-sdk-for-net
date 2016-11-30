// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using System.Linq;

    /// <summary>
    /// Output of custom domain validation.
    /// </summary>
    public partial class ValidateCustomDomainOutput
    {
        /// <summary>
        /// Initializes a new instance of the ValidateCustomDomainOutput class.
        /// </summary>
        public ValidateCustomDomainOutput() { }

        /// <summary>
        /// Initializes a new instance of the ValidateCustomDomainOutput class.
        /// </summary>
        /// <param name="customDomainValidated">Indicates whether the custom
        /// domain is validated or not.</param>
        /// <param name="reason">The reason why the custom domain is not
        /// valid.</param>
        /// <param name="message">The message describing why the custom domain
        /// is not valid.</param>
        public ValidateCustomDomainOutput(bool? customDomainValidated = default(bool?), string reason = default(string), string message = default(string))
        {
            CustomDomainValidated = customDomainValidated;
            Reason = reason;
            Message = message;
        }

        /// <summary>
        /// Gets or sets indicates whether the custom domain is validated or
        /// not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "customDomainValidated")]
        public bool? CustomDomainValidated { get; set; }

        /// <summary>
        /// Gets or sets the reason why the custom domain is not valid.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets the message describing why the custom domain is not
        /// valid.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}