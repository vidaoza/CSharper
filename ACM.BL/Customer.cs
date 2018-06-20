using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
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

        public bool Validate()
        {
            return !(string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(EmailAddress));
        }

        #endregion
    }
}
