// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsModelFlattening.Models
{
    using Fixtures.AcceptanceTestsModelFlattening;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Generic URL.
    /// </summary>
    public partial class GenericUrl
    {
        /// <summary>
        /// Initializes a new instance of the GenericUrl class.
        /// </summary>
        public GenericUrl()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GenericUrl class.
        /// </summary>
        /// <param name="genericValue">Generic URL value.</param>
        public GenericUrl(string genericValue = default(string))
        {
            GenericValue = genericValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets generic URL value.
        /// </summary>
        [JsonProperty(PropertyName = "generic_value")]
        public string GenericValue { get; set; }

    }
}