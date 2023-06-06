using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_37
{
    public class Atendente
    {
        public string nomeFilme(string nome)
        { return nome; }  

        public string  Sesao(string sesao)
        { return sesao; }

        public double IngressoValor(double valor)
        { return valor; }


        public int QuantidadeIngresso (int quantidadeIngresso)
        { return quantidadeIngresso;  }


        public bool VendaIngresso(string nome , string sesao , double valor , int QuantidadeIngresso)
        {
            if (nome != "" && sesao != "" && valor != 0 && QuantidadeIngresso != 0)
            {
                return true;
            }

            else
            {
                return false;

            }

        }








    }
}
