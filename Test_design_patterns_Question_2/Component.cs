using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_design_patterns_Question_2
{

    public abstract class Component
    {
        public int Number { get; set; }

        public string FileOrDirectory { get; protected set; }

        public abstract void AddChild(Component c);

        public abstract void RemoveChild(Component c);

        public abstract IList<Component> GetChildren();

        public abstract int Sum();

        public abstract int GetNumber();

        public static Lazy<bool> isEven;


        public bool isIEven()
        {          
           return  Number % 2 == 0;
        }
    }
}
