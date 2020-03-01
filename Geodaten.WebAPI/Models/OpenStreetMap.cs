using System;
using System.ComponentModel.DataAnnotations;

namespace Geodaten.WebAPI.Models
    {
    public class OpenStreetMap
        {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Anzahl { get; set; }

        }
    }
