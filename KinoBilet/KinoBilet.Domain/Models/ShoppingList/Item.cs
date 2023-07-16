using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KinoBilet.Domain.Models.ShoppingList
{
    internal class Item
    {
        [Required]
        public virtual Bilet Bilet { get; set; }
        public int Amount { get; set; }

        public Item(Bilet bilet, int amount)
        {
            this.Bilet = bilet;
            this.Amount = amount;
        }
}
