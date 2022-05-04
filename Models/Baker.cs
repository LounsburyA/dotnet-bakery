using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DotnetBakery.Models
{
    public class Baker 
    {
        // behind the scenes EF knows id is a primary key, serial
        public int id {get; set;}


        // makes this field not null// public string name
        [Required]
        public string name {get; set;} 
        public int age {get; set;}



    }
}
