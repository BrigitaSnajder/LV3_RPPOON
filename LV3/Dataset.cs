using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3
{
    class Dataset : Prototype
    {
        private List<List<string>> data; //list of lists of strings
        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }

        public Prototype Clone()
        {
            //Zad 1.za danu klasu nije potrebno duboko kopiranje jer nije previše složena
            Dataset copy = (Dataset)this.MemberwiseClone();
            List<List<string>> dataCopy = new List<List<string>>();
            foreach(List<string> stringList in data)
            {
                List<string> datalistCopy = new List<string>();
                foreach (string s in stringList)
                {
                    datalistCopy.Add(s);
                }
                dataCopy.Add(datalistCopy);
            }
            copy.data = dataCopy;
            return (Prototype)copy;
        }
    }
}