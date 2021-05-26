using System;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class LaenutatavAsi
    {
        [Key]
        public Guid Id { get; set; }
        public Laenutus Laenutus { get; set; }
        public DateTime Algus { get; set; }
        public DateTime Lõpp { get; set; }
        public string Kommentaar { get; set; }
    }
}