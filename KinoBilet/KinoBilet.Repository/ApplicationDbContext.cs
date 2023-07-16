using KinoBilet.Domain.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Entity;
using System.Net.Mail;
using System.Reflection.Emit;

namespace KinoBilet.Repository
{
    internal class ApplicationDbContext : IdentityDbContext<StandardTicketUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
        {
        }

        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<ShoppingList> ShoppingLists { get; set; }
        public virtual DbSet<Items> Items { get; set; }

    }
}
}