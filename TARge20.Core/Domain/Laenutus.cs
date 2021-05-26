using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Laenutus
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public string Kommentaar { get; set; }
        public List<LaenutatavAsi> LaenutatavAsis { get; set; }
    }
}