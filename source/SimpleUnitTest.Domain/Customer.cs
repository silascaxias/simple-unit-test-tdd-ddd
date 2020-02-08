using System;

namespace SimpleUnitTest.Domain {
    public sealed class Customer {
        public Guid Id { get; }
        public string Name { get; }
        public string PhoneNumber { get; }

        public Customer (string name, string phoneNumber) {
            this.Id = Guid.NewGuid ();
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }
    }
}