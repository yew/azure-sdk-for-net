// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Iot.TimeSeriesInsights
{
    /// <summary> Variables are named calculations over values from the events. Time Series Insights variable definitions contain formula and computation rules. Variables are stored in the type definition in Time Series Model and can be provided inline via Query APIs to override the stored definition. </summary>
    public partial class TimeSeriesVariable
    {
        /// <summary> Initializes a new instance of TimeSeriesVariable. </summary>
        public TimeSeriesVariable()
        {
        }

        /// <summary> Initializes a new instance of TimeSeriesVariable. </summary>
        /// <param name="kind"> Allowed &quot;kind&quot; values are - &quot;numeric&quot; or &quot;aggregate&quot;. While &quot;numeric&quot; allows you to specify value of the reconstructed signal and the expression to aggregate them, the &quot;aggregate&quot; kind lets you directly aggregate on the event properties without specifying value. </param>
        /// <param name="filter"> Filter over the events that restricts the number of events being considered for computation. Example: &quot;$event.Status.String=&apos;Good&apos;&quot;. Optional. </param>
        internal TimeSeriesVariable(string kind, TimeSeriesExpression filter)
        {
            Kind = kind;
            Filter = filter;
        }

        /// <summary> Allowed &quot;kind&quot; values are - &quot;numeric&quot; or &quot;aggregate&quot;. While &quot;numeric&quot; allows you to specify value of the reconstructed signal and the expression to aggregate them, the &quot;aggregate&quot; kind lets you directly aggregate on the event properties without specifying value. </summary>
        internal string Kind { get; set; }
        /// <summary> Filter over the events that restricts the number of events being considered for computation. Example: &quot;$event.Status.String=&apos;Good&apos;&quot;. Optional. </summary>
        public TimeSeriesExpression Filter { get; set; }
    }
}
