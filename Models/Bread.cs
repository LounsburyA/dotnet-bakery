using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DotnetBakery.Models
{
    public enum BreadType {
        Sourdough,
        Focaccia,
        Shokupan,
        Rye,
        Wheat
    }

        
    
    public class Bread 
    {
        public int id {get; set;}
        public string name {get; set;}
        public string description {get; set;}
        public int count {get; set;}

        [ForeignKey("bakedBy")]
        public int baker_id {get; set;}
        public Baker bakedBy {get; set;}
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public BreadType type {get; set;}

    }
}
