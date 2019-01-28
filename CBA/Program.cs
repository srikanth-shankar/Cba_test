using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBA
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the countingrules class and pass the strings to the corresponding methods cr1,cr2,cr3,cr4
            var cr = new CountingRules();

            //cr1
            cr.Cr1(new List<string>() { "ate", "bite", "apple" }, "b");

            //cr2
            cr.Cr2(new List<string>() { "ben", "bite", "buy", "axe", "file" });

            //cr3
            cr.Cr3(new List<string>() { "a", "bb", "ccc", "dddd", "eeeee", "ffffff", "ggggggg"}, "abg");

            //cr4
            cr.Cr4(new List<string>() { "are", "cat", "apple", "tan", "care", "aimed" }, "b");
        }
    }
}
