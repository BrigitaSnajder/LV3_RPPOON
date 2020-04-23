using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset d1 = new Dataset(@"C:\csv.csv");
            Debug(d1);
            Dataset d2 = (Dataset)d1.Clone();
            Debug(d2);

            double[][] matrica = RandomMatrica.GetInstance().CreateMatrica(2,3);
            Debug(matrica);

            Logger logger = Logger.GetInstance();
            logger.SetPath(@"C:\Users\Korisnik\Desktop\druga godina\dat.txt");
            funkc();
            funkc2();

            ConsoleNotification notification = new ConsoleNotification("Marko", "Danas je kisa", "Ja volim sunce", DateTime.Now, Category.INFO, ConsoleColor.DarkRed);
            NotificationManager manager = new NotificationManager();
            manager.Display(notification);
        }
        
        static void funkc()
        {
            Logger logger = Logger.GetInstance();
            logger.Log("Pocetak neke ");
        }

        static void funkc2()
        {
            Logger logger = Logger.GetInstance();
            logger.Log("recenice");
        }

        static void Debug(Dataset d)
        {
            foreach (List<string> listString in d.GetData())
            {
                foreach (string s in listString)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Debug(double[][] f)
        {
            for (int i = 0; i < f.Length; i++)
            {
                for (int j = 0; j < f[i].Length; j++)
                {
                    Console.Write(f[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
