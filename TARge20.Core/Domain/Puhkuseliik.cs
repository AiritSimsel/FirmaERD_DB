using System;

namespace TARge20.Core.Domain
{
    public class Puhkuseliik
    {
        public Guid Id { get; set; }
        public DateTime Algus { get; set; }
        public DateTime Lõpp { get; set; }
        public string Kommentaar { get; set; }
    }
}