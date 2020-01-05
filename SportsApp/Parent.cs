using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsApp
{
    public class Parent
    {
        public string name { get; set; }
        public List<string> children { get; set; }

        public Parent()
        {
            children = new List<string>();
        }

        public Parent(string name) : base()
        {
            this.name = name;
        }

        public Parent(string name, List<string> children)
        {
            this.name = name;
            this.children = children;
        }
    }
}
