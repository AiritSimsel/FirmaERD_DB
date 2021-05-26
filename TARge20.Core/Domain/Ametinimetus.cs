using System;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Ametinimetus
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public string Nimetus { get; set; }
        public string Kommentaar { get; set; }


    }
}