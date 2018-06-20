using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        #region Constructor

        public Product(){}

        public Product(int productId)
        {
            ProductId = productId;
        }

        #endregion

        #region Properties

        public int ProductId { get; set; }
        public string Description { get; set; }
        public decimal CurrentPrice { get; set; }

        #endregion

        #region Methods

        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
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
