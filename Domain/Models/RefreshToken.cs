using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class RefreshToken : ModelBase<Guid>
    {
        public string Name { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
        public DateTime ExpirateAt { get; set; }
        public bool IsExpired { get; set; }
    }
}
