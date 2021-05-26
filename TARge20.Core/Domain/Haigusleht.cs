using System;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Haigusleht
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public DateTime Algus { get; set; }
        public DateTime Lõpp { get; set; }
        public string Kommentaar { get; set; }

    }
}