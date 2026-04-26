using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class User : ModelBase<Guid>
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public byte[] Password { get; set; }
        public List<Item> inventory { get; set; }
        public User() 
        {
            Id = Guid.NewGuid();
        }
        public User(string name, string login, byte[] password, List<Item> inventory)
        {
            Id = Guid.NewGuid();
            Name = name;
            Login = login;
            Password = password;
            this.inventory = inventory;
        }
    }
}
