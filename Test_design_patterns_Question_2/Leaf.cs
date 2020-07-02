using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Test_design_patterns_Question_2
{
    /// <summary>
    /// leaf class
    /// </summary>
    public class Leaf : Component
    {        
        public decimal OnlyMyValue { get; private set; }

        public Leaf(string file, int number)
        {            
            FileOrDirectory = file;
            OnlyMyValue = number;
            Number += number;
            //Number = number * 2;
        }

        public override void AddChild(Component c)
        {
            throw new NotSupportedException("Leaf element cannot add child!");
        }

        public override IList<Component> GetChildren()
        {
            return null;
        }


        public override void RemoveChild(Component c)
        {
            throw new NotSupportedException("Leaf element cannot remove child!");
        }


        public override int GetNumber()
        {
            if (isIEven() == false) isEven = new Lazy<bool>(() => { return isIEven(); });
            return Number;
        }

        public override int Sum()
        {
            Console.WriteLine($"-= in leaf: {Number} =-");
            return Number;
        }

    }
}
