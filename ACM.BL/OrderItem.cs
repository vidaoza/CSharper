using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        #region Constructor

        public OrderItem(){}

        public OrderItem(int itemId)
        {
            OrderItemId = itemId;
        }

        #endregion

        #region Properties

        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }

        #endregion

        #region Methods

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
           // return !(string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(EmailAddress));
        }

        #endregion
    }
}
