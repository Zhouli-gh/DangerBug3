using System;
using System.Collections.Generic;
using DangerBug;

namespace DangerBug
{
    class Program
    {

        private static List<Bug> bugs = new List<Bug>
        {
            new Mygg(),
            new Husflue(),
            new Edderkopp(),
            new Flått(),
            new Veps()
        };

        private static void ShowBugList()
        {
            Console.WriteLine("Choose one of the bugs to see info");
            for (int i = 0; i < bugs.Count; i++)
            {
                Console.WriteLine($"{i + 1} {bugs[i].Name}");
            }

        }

        //
        // Se liste over insekter  -- her skal alle insektene listes opp,
        // og man skal kunne velge ett og gå inn å så på egenskapene dens (om den er farlig, plagende eller annet)
        public static void Main(string[] args)
        {
            while (true)
            {
                ShowBugList();
                
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        bugs[0].VisInfo();
                        break;
                    case "2":
                        bugs[1].VisInfo();
                        break;
                    case "3":
                        bugs[2].VisInfo();
                        break;
                    case "4":
                        bugs[3].VisInfo();
                        break;
                    case "5":
                        bugs[4].VisInfo();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                    
                }

                Console.WriteLine("Press any key to go back");
                
                Console.ReadKey();
            }
            
        }
        
    }

}
