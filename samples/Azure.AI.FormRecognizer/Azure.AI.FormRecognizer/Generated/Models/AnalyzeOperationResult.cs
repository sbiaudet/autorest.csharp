// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Status and result of the queued analyze operation. </summary>
    public partial class AnalyzeOperationResult
    {
        /// <summary> Initializes a new instance of AnalyzeOperationResult. </summary>
        internal AnalyzeOperationResult()
        {
        }

        /// <summary> Initializes a new instance of AnalyzeOperationResult. </summary>
        /// <param name="status"> Operation status. </param>
        /// <param name="createdDateTime"> Date and time (UTC) when the analyze operation was submitted. </param>
        /// <param name="lastUpdatedDateTime"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="analyzeResult"> Results of the analyze operation. </param>
        internal AnalyzeOperationResult(OperationStatus status, DateTimeOffset createdDateTime, DateTimeOffset lastUpdatedDateTime, AnalyzeResult analyzeResult)
        {
            Status = status;
            CreatedDateTime = createdDateTime;
            LastUpdatedDateTime = lastUpdatedDateTime;
            AnalyzeResult = analyzeResult;
        }

        /// <summary> Operation status. </summary>
        public OperationStatus Status { get; internal set; }
        /// <summary> Date and time (UTC) when the analyze operation was submitted. </summary>
        public DateTimeOffset CreatedDateTime { get; internal set; }
        /// <summary> Date and time (UTC) when the status was last updated. </summary>
        public DateTimeOffset LastUpdatedDateTime { get; internal set; }
        /// <summary> Results of the analyze operation. </summary>
        public AnalyzeResult AnalyzeResult { get; internal set; }
    }
}
