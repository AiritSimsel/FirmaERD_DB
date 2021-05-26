using System;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Tervisekontroll
    {
        [Key]
        public Guid TervisId { get; set; }
        public Employee Employee { get; set; }
        public DateTime Kuupäev { get; set; }
        public String Kommentaar { get; set; }
    }
}