﻿using Net.Demandware.Ocapi.Documents.Common;
using Newtonsoft.Json;

namespace Net.Demandware.Ocapi.Documents.Shop
{
    /// <summary>
    /// Represents a product list item link.
    /// </summary>
    public sealed class ProductListItemLink : SimpleLink
    {
        #region Properties

        /// <summary>
        /// The link title.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        #endregion
    }
}
