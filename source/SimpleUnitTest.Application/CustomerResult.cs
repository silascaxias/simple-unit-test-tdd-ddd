using System;
using SimpleUnitTest.Domain;

namespace SimpleUnitTest.Application {
    public class CustomerResult {
        public CustomerResult (Customer customer) {
            this.Id = customer.Id;
            this.Name = customer.Name;
            this.PhoneNumber = customer.PhoneNumber;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}