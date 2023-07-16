using KinoBilet.Domain.Models.Film;
using Microsoft.WindowsAzure.MediaServices.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoBilet.Domain
{
    public class Bilet : BaseEntity
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public virtual Film Film { get; set; }
        [Required]
        public double Price { get; set; }

        public Bilet(DateTime date, int amount, Film film, double price)
        {
            Date = date;
            Amount = amount;
            Film = film;
            Price = price;
        }
    }
}