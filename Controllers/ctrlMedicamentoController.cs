using farmaciaSiMedique.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace farmaciaSiMedique.Controllers
{

    //Classe para Controle e Execução de Objetos
 
    public class ctrlMedicamentoController
    {

        //Criação da Lista Principal para salvar o cadastro dos medicamentos

        private List<Medicamento> listMedicamentos = new List<Medicamento>();
        

        //Método Para Adicionar Medicamentos a Lista 

        public void ctrlAddMedicamento(Medicamento medicamento)
        {
            listMedicamentos.Add(medicamento);
        }

            //Método Para Remover os Medicamentos da Lista

        public void ctrlRmvMedicamento(Medicamento medicamento)
        {
            listMedicamentos.Remove(medicamento);
        }
            //Método Para Visualizar todos os Medicamentos da Lista

        public List<Medicamento> ctrlVisMedicamento(string medicamento)
        {
            List<Medicamento> list = new List<Medicamento>();

            list = listMedicamentos.FindAll(x => x.fbrNome.Contains(medicamento));

            return list;
        }
    }
}
