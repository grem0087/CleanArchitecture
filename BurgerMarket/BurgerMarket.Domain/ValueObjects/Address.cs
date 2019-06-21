using System;
using System.Collections.Generic;
using BurgerMarket.Domain.Exceptions;
using BurgerMarket.Domain.Infrastructure;

namespace BurgerMarket.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        private Address(string street, string city, string house, string flat)
        {
            Street = street;
            City = city;
            House = house;
            Flat = flat;
        }

        public string Street { get; private set; }
        public string City { get; private set; }
        public string House { get; private set; }
        public string Flat { get; private set; }

        public static implicit operator string(Address account)
        {
            return account.ToString();
        }

        public override string ToString()
        {
            return $"{City}, {Street},{House}-{Flat}";
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Street;
            yield return City;
            yield return House;
            yield return Flat;
        }
    }
}