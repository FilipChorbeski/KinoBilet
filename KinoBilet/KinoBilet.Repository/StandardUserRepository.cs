using KinoBilet.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoBilet.Repository
{
    internal class StandardUserRepository : IUserRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<StandardTicketUser> entities;
        string errorMessage = string.Empty;

        public StandardUserRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<StandardTicketUser>();
        }
        public IEnumerable<StandardTicketUser> GetAll()
        {
            return entities.AsEnumerable();
        }

        public StandardTicketUser Get(string id)
        {
            return entities
               .Include(z => z.StandardShoppingList)
               .Include("UserCart.ProductInShoppingCarts")
               .Include("UserCart.ProductInShoppingCarts.CurrnetProduct")
               .SingleOrDefault(s => s.Id == id);
        }
        public void Insert(StandardTicketUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(StandardTicketUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(StandardTicketUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
    }