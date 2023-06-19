using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCL
{
    public class ShoppingCart
    {
        private List<CartItem> items;

        public ShoppingCart()
        {
            items = new List<CartItem>();
        }

        public void AddItem(int productId, int quantity)
        {
            CartItem existingItem = items.Find(item => item.ProductId == productId);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                items.Add(new CartItem(productId, quantity));
            }
        }

        public void RemoveItem(int productId)
        {
            items.RemoveAll(item => item.ProductId == productId);
        }

        public void ClearCart()
        {
            items.Clear();
        }
    }
}
