using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cego.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Place { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public bool IsDelleted { get; set; } = false;

        internal Contact FirstOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
