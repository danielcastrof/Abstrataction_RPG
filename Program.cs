using System;
using Abstracao_RPG.src.Entities.Human;
using Abstracao_RPG.src.Entities.Savage;
using Abstracao_RPG.src.Entities.Winged;

namespace Abstracao_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nick;
            int Level;
            
            Console.WriteLine("Welcome to Perfect World!");
            Console.WriteLine("");
            Console.WriteLine("Select your favorite class:");
            Console.WriteLine("1 - Human");
            Console.WriteLine("2 - Savage");
            Console.WriteLine("3 - Winged");

            int op = int.Parse(Console.ReadLine());

            switch(op){
                case 1: Console.WriteLine("Select your favorite Hero:");
                Console.WriteLine("1 - Wizard");
                Console.WriteLine("2 - Warrior");
                op = int.Parse(Console.ReadLine());
                switch(op){
                    case 1: Console.WriteLine("You chose Wizard!" + "\n");
                    Console.WriteLine("What is your nickname?");
                    Nick = Console.ReadLine();
                    Console.WriteLine("\n" + "What is your level?");
                    Level = int.Parse(Console.ReadLine());
                    Wizard wz = new Wizard(Nick, Level);
                    Console.WriteLine("Hello, " + wz.Name + "!");
                    Console.WriteLine("\n" + "Select one action:");
                    Console.WriteLine("\n" + "1 - Analyse Status");
                    Console.WriteLine("2 - Make an attack" + "\n");
                    op = int.Parse(Console.ReadLine());

                    switch(op){
                        case 1: Console.WriteLine(wz.ToString());
                        break;

                        case 2: wz.attack();
                        break;
                    }
                    break;
                    
                    case 2: Console.WriteLine("You chose Warrior!" + "\n");
                    Console.WriteLine("What is your nickname?");
                    Nick = Console.ReadLine();
                    Console.WriteLine("\n" + "What is your level?");
                    Level = int.Parse(Console.ReadLine());
                    Warrior wr = new Warrior(Nick, Level);
                    Console.WriteLine("\n" + "Hello, " + wr.Name + "!");
                    Console.WriteLine("\n" + "Select one action:");
                    Console.WriteLine("\n" + "1 - Analyse Status");
                    Console.WriteLine("2 - Make an attack" + "\n");
                    op = int.Parse(Console.ReadLine());

                    switch(op){
                        case 1: Console.WriteLine(wr.ToString());
                        break;

                        case 2: wr.attack();
                        break;
                    }
                    break;

                    default: Console.Clear();
                    break;
                }
                break;
                
                case 2: Console.WriteLine("Select your favorite Hero:");
                Console.WriteLine("1 - Werebeast");
                Console.WriteLine("2 - Werefox");
                op = int.Parse(Console.ReadLine());
                switch(op){
                    case 1: Console.WriteLine("You chose Werebeast!" + "\n");
                    Console.WriteLine("What is your nickname?");
                    Nick = Console.ReadLine();
                    Console.WriteLine("\n" + "What is your level?");
                    Level = int.Parse(Console.ReadLine());
                    Werebeast wb = new Werebeast(Nick, Level);
                    Console.WriteLine("Hello, " + wb.Name + "!");
                    Console.WriteLine("\n" + "Select one action:");
                    Console.WriteLine("\n" + "1 - Analyse Status");
                    Console.WriteLine("2 - Make an attack" + "\n");
                    op = int.Parse(Console.ReadLine());

                    switch(op){
                        case 1: Console.WriteLine(wb.ToString());
                        break;

                        case 2: wb.attack();
                        break;
                    }
                    break;
                    
                    case 2: Console.WriteLine("You chose Werefox!" + "\n");
                    Console.WriteLine("What is your nickname?");
                    Nick = Console.ReadLine();
                    Console.WriteLine("\n" + "What is your level?");
                    Level = int.Parse(Console.ReadLine());
                    Werefox wf = new Werefox(Nick, Level);
                    Console.WriteLine("\n" + "Hello, " + wf.Name + "!");
                    Console.WriteLine("\n" + "Select one action:");
                    Console.WriteLine("\n" + "1 - Analyse Status");
                    Console.WriteLine("2 - Make an attack" + "\n");
                    op = int.Parse(Console.ReadLine());

                    switch(op){
                        case 1: Console.WriteLine(wf.ToString());
                        break;

                        case 2: wf.attack();
                        break;
                    }
                    break;

                    default: Console.Clear();
                    break;
                }
                break;

                case 3: Console.WriteLine("Select your favorite Hero:");
                Console.WriteLine("1 - Elf Archer");
                Console.WriteLine("2 - Elf Priest");
                op = int.Parse(Console.ReadLine());
                switch(op){
                    case 1: Console.WriteLine("You chose Elf Archer!" + "\n");
                    Console.WriteLine("What is your nickname?");
                    Nick = Console.ReadLine();
                    Console.WriteLine("\n" + "What is your level?");
                    Level = int.Parse(Console.ReadLine());
                    ElfArcher ea = new ElfArcher(Nick, Level);
                    Console.WriteLine("Hello, " + ea.Name + "!");
                    Console.WriteLine("\n" + "Select one action:");
                    Console.WriteLine("\n" + "1 - Analyse Status");
                    Console.WriteLine("2 - Make an attack" + "\n");
                    op = int.Parse(Console.ReadLine());

                    switch(op){
                        case 1: Console.WriteLine(ea.ToString());
                        break;

                        case 2: ea.attack();
                        break;
                    }
                    break;
                    
                    case 2: Console.WriteLine("You chose Elf Priest!" + "\n");
                    Console.WriteLine("What is your nickname?");
                    Nick = Console.ReadLine();
                    Console.WriteLine("\n" + "What is your level?");
                    Level = int.Parse(Console.ReadLine());
                    ElfPriest ep = new ElfPriest(Nick, Level);
                    Console.WriteLine("\n" + "Hello, " + ep.Name + "!");
                    Console.WriteLine("\n" + "Select one action:");
                    Console.WriteLine("\n" + "1 - Analyse Status");
                    Console.WriteLine("2 - Make an attack");
                    Console.WriteLine("3 - Cure a hero" + "\n");
                    op = int.Parse(Console.ReadLine());

                    switch(op){
                        case 1: Console.WriteLine(ep.ToString());
                        break;

                        case 2: ep.attack();
                        break;

                        case 3: ep.cure();
                        break;
                    }
                    break;

                    default: Console.Clear();
                    break;
                }
                break;

                default: Console.Clear();
                break;
            }
        }
    }
}
