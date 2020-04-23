using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3
{
    class RandomMatrica
    {
        public static RandomMatrica instance;

        public static RandomMatrica GetInstance()
        {
            if (instance == null)
                instance = new RandomMatrica();
            return instance;
        }
        //Zad 2. Ova metoda ima 3 odgovornosti
        public double[][] CreateMatrica(int stupci,int retci)
        {
            double[][] matrica = new double[retci][];
            for(int i = 0; i<matrica.Length; i++)
            {
                matrica[i] = new double[stupci];
            }

            for (int i = 0; i < matrica.Length; i++)
            {
                for (int j = 0; j < matrica[i].Length; j++)
                {
                    matrica[i][j] = RandomGenerator.GetInstance().NextDouble();
                }
            }

            return matrica;
        }
    }
}
