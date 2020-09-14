using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class EntityRelationship : DynamicsModel
    {
        [JsonProperty("entityrelationshipid")]
        public Guid? EntityRelationshipId { get; set; }

        [JsonProperty("schemaname")]
        public string SchemaName { get; set; }

        [JsonProperty("componentstate")]
        public string ComponentState { get; set; }

        [JsonProperty("solutionid")]
        public Guid? SolutionId { get; set; }

        [JsonProperty("overwritetime")]
        public DateTimeOffset? OverwriteTime { get; set; }


    }
}

