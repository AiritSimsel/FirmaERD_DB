using System;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Vihjed
    {
        [Key]
        public Guid Id { get; set; }
        public Firma Firma { get; set; }
        public string Vihje { get; set; }
        public string Kommentaar { get; set; }
    }
}