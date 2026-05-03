using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Item : ModelBase<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] ImagePath { get; set; }
        public User Owner { get; set; }
        public Guid OwnerId { get; set; }
        public Type Type { get; set; }
        public Item(string name, string description, User owner, Type type) 
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Owner = owner;
            Type = type;
        }
        public Item() 
        {
            Id = Guid.NewGuid();
        }
    }
    public enum Type
    {
        Skin,
        Consumable
    }
}
