using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary_Task_6
{
    class Program
    {  
        static void Main(string[] args)
        {
            UI.UI_Console.CallMenu();
            int i = 0;
            HappyTickets h = PiterMethod.PiterMethodInitialize(100100, 446500);

            HappyTickets h1 = MoscowMethod.MoscovMethodInitialize(100100, 446500);
            foreach (Ticket t in h1.GetTickets())
            {
                i++;
            }
            Console.WriteLine(h1.CountOfHappyTicket);

            Console.ReadLine();
        }
    }
}
