using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Harukontor
    {
        [Key]
        public Guid Id { get; set; }
        public string Aadress { get; set; }
        public string Kontaktisik { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Kommentaar { get; set; }
        public ICollection<Firma> Firmas { get; set; }
    }
}