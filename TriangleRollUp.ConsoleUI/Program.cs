using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleRollUp.Domain;

namespace TriangleRollUp.ConsoleUI {
    class Program {
        static void Main(string[] args) {
            Generator g = new Generator();
            List<int> nums = new List<int>() { 4, 7, 3, 6, 7 };

            Console.Write(g.BuildTriangle(nums));
            Console.ReadLine();
        }
    }
}
