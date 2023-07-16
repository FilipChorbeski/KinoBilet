using KinoBilet.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoBilet.Domain.Models.ShoppingList
{
    internal class ShoppingList
    {
        public virtual List<Item> Items { get; set; } = new List<Item>();
        public double TotalPrice { get; set; }
        public virtual StandardTicketUser Owner { get; set; }
    }
}
