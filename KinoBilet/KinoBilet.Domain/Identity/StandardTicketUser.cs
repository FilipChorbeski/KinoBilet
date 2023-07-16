using KinoBilet.Domain.Models.ShoppingList;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoBilet.Domain.Identity
{
    public class StandardTicketUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public virtual ShoppingList StandardShoppingList { get; set; }
    }
}
