using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test_design_patterns_Question_2
{
    /// <summary>
    /// Composite class
    /// </summary>
    public class Branch : Component
    {
        public decimal OnlyMyValue { get; private set; }

        private IList<Component> _children = new List<Component>();

        public Branch(string directory, int number)
        {        
            FileOrDirectory = directory;
            Number += number;
            //Number = number * 2;
            OnlyMyValue = number;
        }
        public Branch(string directory)
        {
            FileOrDirectory = directory;
            OnlyMyValue = Number;
        }

        public override void AddChild(Component c)
        {
            _children.Add(c);
        }

        public override IList<Component> GetChildren()
        {
            return _children;
        }



        public override void RemoveChild(Component c)
        {
            _children.Remove(c);
        }

        public override int Sum()
        {
            int onlyNimeChildren = default(int);
            foreach(Component comp in _children)
            {

                onlyNimeChildren += comp.Number;
                Number += comp.Sum();
            }
            Console.WriteLine($"-= in branch: {Number} =-");
            
            return Number;
        }

        public override int GetNumber()
        {
            Sum();
            if(isIEven() == false) isEven = new Lazy<bool>(() => { return isIEven(); });
            return Number;            
        }


    }
}
