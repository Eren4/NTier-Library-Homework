using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Author : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Nationality { get; set; }

        // Relational properties
        public virtual ICollection<Book> Books { get; set; }
    }
}
