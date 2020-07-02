using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Test_design_patterns_Question_2
{
    class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine(GetNumberTreeTop());
            Console.WriteLine();

            if(Component.isEven == null)
                Console.WriteLine($"Is the tree contains only even numbers: True");

            else
            Console.WriteLine($"Is the tree contains only even numbers: {Component.isEven.Value}");
        }

        static decimal GetNumberTreeTop()
        {

            Branch rootBranch = new Branch(@"F:\temp");
            rootBranch = CreateNumbersTree(rootBranch);

            return rootBranch.Sum();
            


        }


        static Branch CreateNumbersTree(Branch rootBranch)
        {

            string[] files = Directory.GetFiles(rootBranch.FileOrDirectory);
            string[] folders = Directory.GetDirectories(rootBranch.FileOrDirectory);
            int count = 0;
            foreach (string s in files)
            {
                rootBranch.AddChild(new Leaf(s, count));
                count++;
            }
            foreach (string s in folders)
            {
                Branch branch = new Branch(s, count);
                try
                {

                    branch = CreateNumbersTree(branch);
                }
                catch (UnauthorizedAccessException)
                {
                    continue;
                }
                rootBranch.AddChild(branch);
                rootBranch.Number = rootBranch.GetNumber();
                count++;
            }

            return rootBranch;
        }
    }
}
