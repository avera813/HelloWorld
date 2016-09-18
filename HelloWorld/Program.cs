using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder output = new StringBuilder();
            if(args.Length > 0) {
                output.Append("Hello,");
                foreach (string s in args)
                {
                    output.Append(" ").Append(s);
                }
            }
            else
            {
                output.Append("Hello, World");
            }
            output.Append("!");
            Console.WriteLine(output.ToString());
        }
    }
}
