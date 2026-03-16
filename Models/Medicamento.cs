using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmaciaSiMedique.Models
{

    //Classe do Objeto Medicamento

    public class Medicamento : Produto
    {
        public string medCategoria { get; set; }
        public string medmedControlado { get; set; }
        public string medIndicacao { get; set; }

        //Concatenação do Código de barra , Descrição e Categoria

        public string medCodBarDesCategoria
        {
            get
            {
                return proCodBarDescricao + " - " + medCategoria;
            }
        }

        //Concatenação do Código de barra , Descrição , Categoria e Nome

        public string medCodBarDesCatNome
        {
            get
            {
                return medCodBarDesCategoria + " - " + fbrNome;
            }
        }
    }
}
