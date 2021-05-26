using System;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Ettepanek
    {
        [Key]
        public Guid ID { get; set; }
        public Employee Employee { get; set; }
        public string Kommentaar { get; set; }

    }
}