// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The resource whose properties describes the Adaptive Network Hardening
    /// settings for some Azure resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AdaptiveNetworkHardening : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AdaptiveNetworkHardening class.
        /// </summary>
        public AdaptiveNetworkHardening()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdaptiveNetworkHardening class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="rules">The security rules which are recommended to be
        /// effective on the VM</param>
        /// <param name="rulesCalculationTime">The UTC time on which the rules
        /// were calculated</param>
        /// <param name="effectiveNetworkSecurityGroups">The Network Security
        /// Groups effective on the network interfaces of the protected
        /// resource</param>
        public AdaptiveNetworkHardening(string id = default(string), string name = default(string), string type = default(string), IList<Rule> rules = default(IList<Rule>), System.DateTime? rulesCalculationTime = default(System.DateTime?), IList<EffectiveNetworkSecurityGroups> effectiveNetworkSecurityGroups = default(IList<EffectiveNetworkSecurityGroups>))
            : base(id, name, type)
        {
            Rules = rules;
            RulesCalculationTime = rulesCalculationTime;
            EffectiveNetworkSecurityGroups = effectiveNetworkSecurityGroups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the security rules which are recommended to be
        /// effective on the VM
        /// </summary>
        [JsonProperty(PropertyName = "properties.rules")]
        public IList<Rule> Rules { get; set; }

        /// <summary>
        /// Gets or sets the UTC time on which the rules were calculated
        /// </summary>
        [JsonProperty(PropertyName = "properties.rulesCalculationTime")]
        public System.DateTime? RulesCalculationTime { get; set; }

        /// <summary>
        /// Gets or sets the Network Security Groups effective on the network
        /// interfaces of the protected resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.effectiveNetworkSecurityGroups")]
        public IList<EffectiveNetworkSecurityGroups> EffectiveNetworkSecurityGroups { get; set; }

    }
}
