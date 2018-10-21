using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary_Task_6.UI
{
    class UI_Console
    {
        public static void CallMenu()
        {
            const int RIGHT_COUNT_OF_ARGS = 2;
            string[] args = Environment.GetCommandLineArgs();
            Instruction();
            try
            {
                switch (args.Length)
                {
                    case RIGHT_COUNT_OF_ARGS:
                        {
                            Console.WriteLine("Please input left border:"); 
                            int.TryParse(Console.ReadLine(), out int leftborder);
                            Console.WriteLine("Please input right border:");
                            int.TryParse(Console.ReadLine(), out int rightborder);
                            HappyTickets h;
                            if (ReadFile(args[1]) == "Piter")
                            {
                                h = PiterMethod.PiterMethodInitialize(leftborder, rightborder);
                                Console.WriteLine(h.CountOfHappyTicket);
                            }
                            if (ReadFile(args[1]) == "Moskow")
                            {
                                h = MoscowMethod.MoscovMethodInitialize(leftborder, rightborder);
                                Console.WriteLine(h.CountOfHappyTicket);            
                            }
                            Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Instruction();
                            break;
                        }
                }
            }
            catch (Exception)
            {
                Instruction();
            }
        }
        private static string ReadFile(string path)
        {
            string result;
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    result = reader.ReadLine();
                }
            }
            catch (FileNotFoundException)
            {
                result = "File not found";
            }
            return result;
        }

        public static void Instruction()
        {
            Console.WriteLine("Specify the path to the file with the workmode" 
                              + Environment.NewLine
                              + "After correct choosing of Method input range of Tickets to check"
                              + Environment.NewLine
                              + "In case leftborder = rightborder, we chack ticket with that number");           
        }
    }
}
