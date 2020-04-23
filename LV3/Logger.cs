using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LV3
{
    class Logger
    {
        private static Logger instance;
        private string filePath;

        public static Logger GetInstance()
        {
            if (instance == null)
                instance = new Logger();
            return instance;
        }

        public void SetPath(string filePath)
        {
            this.filePath = filePath;
        }
        public Logger()
        {
            filePath = @"C:\log.txt";
        }
        //Zad 3. Uporaba loggera na drugim mjestima će pisati u istu datoteku
        public void Log(string message)
        {
            StreamWriter file = new StreamWriter(filePath, true);
            file.Write(message);
            file.Close();
        }
    }
}
