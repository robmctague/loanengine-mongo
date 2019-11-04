using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace customers.Models
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime DOB { get; set; }

        List<Address> AddressLst = new List<Address>();

        public List<Address> GetAddresses
        {
            get
            {
                return AddressLst;
            }
            set
            {
                AddressLst = value;
            }
        }
    }
}
