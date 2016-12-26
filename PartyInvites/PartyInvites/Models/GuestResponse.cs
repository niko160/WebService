using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Prosze podać swoje imię i nazwisko!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podać swój adres e-mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Proszę podać prawidlowy adres e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podać numer telefonu")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Proszę określić czy weźmiesz udział")]
        public bool? WillAttend { get; set; }

    }
}