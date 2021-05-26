using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Isikukood { get; set; }
        public string Aadress { get; set; }
        public string Kontakttelefon { get; set; }
        public DateTime TöölAlates { get; set; }
        public string Kommentaar { get; set; }






        /// TEINE HINDELINE HARJUTUS
        ///
        /// 1. Teha Teie meeskonna poolt esitletud FirmaDB-st objektide struktuur.
        /// 2. Kui see on valmis, siis teha code first migration. Vajadusel võib mitu migrationit teha.
        /// 3. NB! Kasutate enda meeskonna poolt esitatud FirmaDB ERD-d, aga igaüks teeb individuaalselt.
        /// 4. Järgida hea programmeerimise tava.
        /// 5. Kogu solution laadida GitHubi ja link valmis tööst saata mulle.
        /// 6. Järgmisena teha print screen MS SQL-s database diagrams all olevast auto-genereeritud ERD-st pilt. See lisada readMe.md failina sama projekti alla GitHubis.

        /// Mõned muutujad võivad olla ka NULL väärtusega ja need tuleb ära märkida


       
        public ICollection<Children> Childrens { get; set; }
        public List<Puhkus> Puhkuss { get; set; }
        public List<Haigusleht> Haiguslehtss { get; set; }
        public ICollection<Laenutus> Laenutuss { get; set; }
        public List<Tervisekontroll> Tervisekontrolls { get; set; }
        public ICollection<Ametinimetus> Ametinimetuss { get; set; }
        public ICollection<Töötamine> Töötamines { get; set; }
        public ICollection<Ligipääs> Ligipääss { get; set; }
        public IEnumerable<Ettepanek> Ettepaneks { get; set; }
        
      
    }

}
