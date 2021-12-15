﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tamaian_Rares_Lab8.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Required, StringLength(150, MinimumLength =3)]
        [Display(Name = "Book Title")]
        public string Title { get; set; }
        [RegularExpression(@"^[A-Z][a-z]+\s[A-Z][a-z]+$", ErrorMessage = 
            "Numele autorului trebuie sa fie de forma 'Nume Prenume'"), Required, 
            StringLength(50, MinimumLength =3)]
        //^ marcheaza inceputul sirului de caractere
        //[A-Z][a-z]+ prenumele -litera mare urmata de oricate litere mici
        //\s spatiu
        //[A-Z][a-z]+ numele- litera mare urmata de oricate litere mici
        //$ marcheaza sfarsitul sirului de caractere
        public string Author { get; set; }
        [Column(TypeName = "decimal(6, 2")]
        [Range(1, 300)]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int PublisherID { get; set; }

        public Publisher Publisher { get; set; } // nav property
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
