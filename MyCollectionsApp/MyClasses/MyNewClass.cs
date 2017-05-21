using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionsApp
{


    public class MyNewClass
    {
        public enum Colors {RED, GREEN, BLUE, YELLOW}

        public string name;
        public string description;
        public Colors color;

        public MyNewClass(string name, string description) {
            this.name = name;
            this.description = description;
        }

        public override string ToString()
        {


            return name + " : " + description + "color : " + Enum.GetName(typeof (Colors), color);
        }
    }

    
}
