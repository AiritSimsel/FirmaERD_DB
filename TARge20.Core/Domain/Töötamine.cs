using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Töötamine
    {
        [Key]
        public Guid TöötamineId { get; set; }
        public Ametinimetus Ametinimetus { get; set; }
        public Employee Employee { get; set; }
        public DateTime Alates { get; set; }
        public DateTime Kuni { get; set; }
        public ICollection<Harukontor> Harukontors { get; set; }

    }
}