using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities
{
    public class Like
    {
        public int Id { get; set; }

        public string Author { get; set; } = string.Empty;

        public DateTime Date { get; set; }
    }
}
