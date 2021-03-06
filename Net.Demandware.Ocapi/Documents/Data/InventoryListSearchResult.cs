﻿using System.Collections.Generic;
using Net.Demandware.Ocapi.Documents.Base;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Data
{
    /// <summary>
    /// Represents a result containing an array of inventory lists.
    /// </summary>
    public sealed class InventoryListSearchResult : BaseResult<InventoryList>
    {
        #region Properties

        /// <summary>
        /// The sorted array of search hits. Can be empty.
        /// </summary>
        [JsonProperty(PropertyName = "hits")]
        public override IEnumerable<InventoryList> Data { get; set; }

        /// <summary>
        /// The fields that you want to select.
        /// </summary>
        public string Select { get; set; }

        #endregion
    }
}
