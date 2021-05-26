using System;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Children
    {
        [Key]
        public Guid Id { get; set; }
        public string Eesnimi { get; set; }
        public string Perekonnanimi { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Isikukood { get; set; }
        public string Kommentaar { get; set; }
        public Employee Employee { get; set; }
    }
}