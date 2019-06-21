using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BurgerMarket.Domain.Enums;
using BurgerMarket.Domain.Exceptions;

namespace BurgerMarket.Domain.Entities
{
    public class Burger
    {
        public Burger(int id, string name, BurgerType type, decimal price, string pictureUrl, string description)
        {
            if (price <= 0)
            {
                throw new InvalidPriceException("Burger price can not be zero or less.");
            }
            
            if (string.IsNullOrEmpty(name))
            {
                throw new InvalidNameException("Burger name can not be empty.");
            }
            
            Id = id;
            Name = name;
            Type = type;
            Price = price;
            PictureUrl = pictureUrl;
            Description = description;
        }
        
        public int Id { get; private set; }
        
        public string Name { get; private set; }
        
        public decimal Price { get; private set; }
        
        public BurgerType Type { get; set; }
        
        public string PictureUrl { get; set; }
        
        public string Description { get; set; }

        public void ChangeName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new InvalidNameException("Burger name can not be empty.");
            }
            
            Name = name;
        }

        public void ChangePrice(decimal price)
        {
            if (price <= 0)
            {
                throw new InvalidPriceException("Burger price can not be zero or less.");
            }
            
            Price = price;
        }
    }
}
