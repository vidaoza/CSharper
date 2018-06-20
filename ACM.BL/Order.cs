using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        #region Constructor

        public Order(){}

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        #endregion

        #region Properties

        public int OrderId { get; private set; }

        public int ProductId { get; private set; }

        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public string ShippingAddress { get; set; }

        #endregion

        #region Methods

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
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
