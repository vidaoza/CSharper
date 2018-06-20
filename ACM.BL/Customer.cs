using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        #region Constructor

        public Customer(){}

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
      
        #endregion

        #region Properties

        public int CustomerId { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string HomeAddress { get; set; }

        public string BusinessAddress { get; set; }

        public string FullName
        {
            get
            {
                var fullName = LastName;

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName = $"{fullName}, ";
                    }
                    fullName = $"{fullName}{FirstName}";
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        #endregion

        #region Methods

        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            return !(string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(EmailAddress));
        }

        #endregion
    }
}
