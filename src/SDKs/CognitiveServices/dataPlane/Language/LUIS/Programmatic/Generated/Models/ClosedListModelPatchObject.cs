// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Object model for adding a batch of sublists to an existing closedlist.
    /// </summary>
    public partial class ClosedListModelPatchObject
    {
        /// <summary>
        /// Initializes a new instance of the ClosedListModelPatchObject class.
        /// </summary>
        public ClosedListModelPatchObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClosedListModelPatchObject class.
        /// </summary>
        /// <param name="subLists">Sublists to add.</param>
        public ClosedListModelPatchObject(IList<WordListObject> subLists = default(IList<WordListObject>))
        {
            SubLists = subLists;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets sublists to add.
        /// </summary>
        [JsonProperty(PropertyName = "subLists")]
        public IList<WordListObject> SubLists { get; set; }

    }
}
