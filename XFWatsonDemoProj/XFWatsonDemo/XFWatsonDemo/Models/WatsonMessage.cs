using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace XFWatsonDemo.Models
{
    public partial class WatsonMessage
    {
        [JsonProperty("input")]
        public Input Input { get; set; }

        [JsonProperty("intents")]
        public Intent[] Intents { get; set; }

        [JsonProperty("entities")]
        public object[] Entities { get; set; }

        [JsonProperty("context")]
        public Context Context { get; set; }

        [JsonProperty("output")]
        public Output Output { get; set; }
    }

    public partial class Context
    {
        [JsonProperty("conversation_id")]
        public Guid ConversationId { get; set; }

        [JsonProperty("system")]
        public SystemClass System { get; set; }
    }

    public partial class SystemClass
    {
        [JsonProperty("dialog_stack")]
        public DialogStack[] DialogStack { get; set; }

        [JsonProperty("dialog_turn_counter")]
        public long DialogTurnCounter { get; set; }

        [JsonProperty("dialog_request_counter")]
        public long DialogRequestCounter { get; set; }

        [JsonProperty("_node_output_map")]
        public NodeOutputMap NodeOutputMap { get; set; }

        [JsonProperty("branch_exited")]
        public bool BranchExited { get; set; }

        [JsonProperty("branch_exited_reason")]
        public string BranchExitedReason { get; set; }
    }

    public partial class DialogStack
    {
        [JsonProperty("dialog_node")]
        public string DialogNode { get; set; }
    }

    public partial class NodeOutputMap
    {
        [JsonProperty("node_1_1536836032105")]
        public Node1_1536836032105 Node1_1536836032105 { get; set; }
    }

    public partial class Node1_1536836032105
    {
        [JsonProperty("1")]
        public long[] The1 { get; set; }
    }

    public partial class Input
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public partial class Intent
    {
        [JsonProperty("intent")]
        public string IntentIntent { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public partial class Output
    {
        [JsonProperty("generic")]
        public Generic[] Generic { get; set; }

        [JsonProperty("text")]
        public string[] Text { get; set; }

        [JsonProperty("nodes_visited")]
        public string[] NodesVisited { get; set; }

        [JsonProperty("log_messages")]
        public object[] LogMessages { get; set; }
    }

    public partial class Generic
    {
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Source { get; set; }

        [JsonProperty("response_type")]
        public string ResponseType { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
    }

    public partial class WatsonMessage
    {
        public static WatsonMessage FromJson(string json) => JsonConvert.DeserializeObject<WatsonMessage>(json, XFWatsonDemo.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this WatsonMessage self) => JsonConvert.SerializeObject(self, XFWatsonDemo.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
