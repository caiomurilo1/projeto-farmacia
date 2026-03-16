using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmaciaSiMedique.Models
{

    //Classe do Objeto Fabricante

    public class Fabricante
    {
        public string fbrCNPJ { get; set; }
        public string fbrNome { get; set; }
        public string fbrRazaoSocial { get; set; }

        //Concatenação do CNPJ e Nome

        public string fbrCNPJNome
        {
            get
            {
                return fbrCNPJ + " - " + fbrNome;
            }
        }
    }
}
