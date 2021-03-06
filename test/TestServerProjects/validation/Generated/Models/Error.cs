// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace validation.Models
{
    /// <summary> The Error. </summary>
    public partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        internal Error()
        {
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"> . </param>
        /// <param name="message"> . </param>
        /// <param name="fields"> . </param>
        internal Error(int? code, string message, string fields)
        {
            Code = code;
            Message = message;
            Fields = fields;
        }

        public int? Code { get; internal set; }
        public string Message { get; internal set; }
        public string Fields { get; internal set; }
    }
}
