using KinoBilet.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoBilet.Service
{
    internal class ShoppingListService
    {
        private readonly Repository<ShoppingList> _shoppinglistRepository;
        private readonly Repository<Order> _orderRepository;
        private readonly StandardTicketUser _standarduserRepository;

        public ShoppingListService(Repository<ShoppingList> shoppinglistRepository, StandardUserRepository userRepository, Repository<Order> orderRepository)
        {
            _shoppinglistRepository = shoppinglistRepository;
            _standarduserRepository = userRepository;
            _orderRepository = orderRepository;
        }


        public bool deleteProductFromSoppingCart(string userId, Guid itemId)
        {
            if (!string.IsNullOrEmpty(userId) && itemId != null)
            {
                var loggedInUser = this._standarduserRepository.Get(userId);

                var userCart = loggedInUser.UserCart;

                var itemToDelete = userCart.Items.Where(z => z.ItemId.Equals(itemId)).FirstOrDefault();

                userCart.Items.Remove(itemToDelete);

                this._cartRepository.Update(userCart);

                return true;
            }
            return false;
        }
    }
}
