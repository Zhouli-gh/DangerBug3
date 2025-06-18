using System;
using System.Collections.Generic;
using DangerBug;

namespace DangerBug
{
    class Program
    {
        private List<Bug> bugs = new List<Bug>
        {
            new Mygg(),
            new Husflue(),
            new Edderkopp(),
            new Flått(),
            new Veps()
        };
        static void Main(string[] args)
        {
            var program = new Program();
            foreach (var bug in program.bugs)
            {
                bug.VisInfo();
                Console.WriteLine();
            }
        }
    }
}