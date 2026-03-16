using farmaciaSiMedique.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmaciaSiMedique.Views
{

    public partial class frmVisVisualizacao: Form
    {
        public frmVisVisualizacao(Medicamento medicamento)
        {
            InitializeComponent();

            txtFabricante.Text = medicamento.fbrCNPJNome;
            txtCodBarra.Text = medicamento.proCodBarras;
            txtDescricao.Text = medicamento.proDescricao;
            txtPreco.Text = medicamento.proPreco.ToString();
            txtCategoria.Text = medicamento.medCategoria;
            txtMedControlado.Text = medicamento.medmedControlado;
            txtIndicacao.Text = medicamento.medIndicacao;

        }

        private void txtCodBarra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
