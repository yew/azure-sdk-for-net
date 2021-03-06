// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.FlexibleServers.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Location capabilities.
    /// </summary>
    public partial class CapabilityProperties
    {
        /// <summary>
        /// Initializes a new instance of the CapabilityProperties class.
        /// </summary>
        public CapabilityProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CapabilityProperties class.
        /// </summary>
        /// <param name="zone">zone name</param>
        public CapabilityProperties(string zone = default(string), IList<ServerEditionCapability> supportedFlexibleServerEditions = default(IList<ServerEditionCapability>))
        {
            Zone = zone;
            SupportedFlexibleServerEditions = supportedFlexibleServerEditions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets zone name
        /// </summary>
        [JsonProperty(PropertyName = "zone")]
        public string Zone { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supportedFlexibleServerEditions")]
        public IList<ServerEditionCapability> SupportedFlexibleServerEditions { get; private set; }

    }
}
