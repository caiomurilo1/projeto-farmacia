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
    public partial class frmVisMenu: Form
    {
        public frmVisMenu()
        {
            InitializeComponent();
        }

        //Instaciar a tela de Cadastro e mostrar sem poder mexer em outra tela



        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisMedicamentos tela = new frmVisMedicamentos();

            tela.ShowDialog();
        }

        private void frmVisMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
