using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmaciaSiMedique.Models
{

    //Classe do Objeto Produto

    public class Produto : Fabricante
    {
        public string proCodBarras { get; set; }
        public string proDescricao { get; set; }
        public decimal proPreco { get; set; }

        //Concatenação do Codigo de barras e Descrição 

        public string proCodBarDescricao
        {
            get
            {
                return proCodBarras + " - " + proDescricao;
            }
        }
    }
}
