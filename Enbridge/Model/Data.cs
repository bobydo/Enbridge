using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enbridge.Model
{
    public class Data
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string Phone { get; set; }
        public string Age { get; set; }
        public string Alive { get; set; }
        public Data(string first, string last, string phone, string age, string alive)
        {
            First = first;
            Last = last;
            Phone = phone;
            Age = age;
            Alive = alive;
        }
    }
}
