using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Puhkus
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public IEnumerable<Puhkuseliik> Puhkuseliiks { get; set; }
        
    }
}