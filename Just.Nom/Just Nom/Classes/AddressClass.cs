using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom.Classes
    /// this class shows the physical address and its properties the street, city, postcode and also has a constructer to initialize the properties
{
    public class Address
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string PostCode { get; private set;}

        public Address(string street, string city, string postCode)
        {
            Street = street;
            City = city;
            PostCode = postCode;
        }
    }
}
