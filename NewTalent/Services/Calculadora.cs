using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalent.Services
{
    public class Calculadora
    {
        
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int Somar(int num1, int num2)
        {

            listaHistorico.Insert(0, "Res:" + (num1 + num2) + " - data: " + data);

            return num1 + num2;
        }
        public int Subtrair(int num1, int num2)
        {

            listaHistorico.Insert(0, "Res:" + (num1 - num2) + " - data: " + data);

            return num1 - num2;
        }
        public int Multiplicar(int num1, int num2)
        {

            listaHistorico.Insert(0, "Res:" + (num1 * num2) + " - data: " + data);

            return num1 * num2;
        }
        public int Dividir(int num1, int num2)
        {

            listaHistorico.Insert(0, "Res:" + (num1 / num2) + " - data: " + data);

            return num1 / num2;
        }

        public List<string> Historico()
        {
            //List<string> res;
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);

            return listaHistorico;
        }

    }
}