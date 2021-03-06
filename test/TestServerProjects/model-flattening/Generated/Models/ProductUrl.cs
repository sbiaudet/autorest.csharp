// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace model_flattening.Models
{
    /// <summary> The product URL. </summary>
    public partial class ProductUrl : GenericUrl
    {
        /// <summary> Initializes a new instance of ProductUrl. </summary>
        public ProductUrl()
        {
        }

        /// <summary> Initializes a new instance of ProductUrl. </summary>
        /// <param name="odataValue"> URL value. </param>
        /// <param name="genericValue"> Generic URL value. </param>
        internal ProductUrl(string odataValue, string genericValue) : base(genericValue)
        {
            OdataValue = odataValue;
        }

        /// <summary> URL value. </summary>
        public string OdataValue { get; set; }
    }
}
