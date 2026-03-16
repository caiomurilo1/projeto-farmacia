using farmaciaSiMedique.Controllers;
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
    public partial class frmVisMedicamentos: Form
    {

        //Instaciar o MedicamentoController 

        ctrlMedicamentoController medicamentoController = new ctrlMedicamentoController();

        //Desativa a Validação automatica

        
        public frmVisMedicamentos()
        {
            InitializeComponent();

            AutoValidate = AutoValidate.Disable;
        }

        //Extrair o Medicamento selecionado da listBox

        Medicamento ExtUsuario()
        {
            return lstMedicamentos.SelectedItem as Medicamento;
        }

        //Atualizar a listbox 
        //Primeiro limpando ela
        //Segundo buscando a lista
        //Terceiro Nomeando os Itens da Lista

        void AttListBox()
        {
            lstMedicamentos.DataSource = null;

            lstMedicamentos.DataSource = medicamentoController.ctrlVisMedicamento("");

            lstMedicamentos.DisplayMember = "medCodBarDesCatNome";

        }



        //Botao Adicionar, Dispara a Validação de todos os Campos se estiver tudo OK
        //Limpa os campos e adiciona o novo item na lista, se Não dispara uma MessageBox de Aviso

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Medicamento medicamento = new Medicamento();

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                medicamento.fbrCNPJ = txtCNPJ.Text;
                medicamento.fbrNome = txtNome.Text;
                medicamento.fbrRazaoSocial = txtRazaoSocial.Text;
                medicamento.proCodBarras = txtCodBarra.Text;
                medicamento.proDescricao = txtDescricao.Text;
                medicamento.proPreco = decimal.Parse(txtPreco.Text);
                medicamento.medmedControlado = cbbMedControlado.Text;
                medicamento.medCategoria = txtCategoria.Text;
                medicamento.medIndicacao = txtIndicacao.Text;

                medicamentoController.ctrlAddMedicamento(medicamento);

                AttListBox();

                txtCNPJ.Clear();
                txtNome.Clear();
                txtRazaoSocial.Clear();
                txtCodBarra.Clear();
                txtDescricao.Clear();
                txtPreco.Clear();
                cbbMedControlado.SelectedIndex = -1;
                txtCategoria.Clear();
                txtIndicacao.Clear();
            }
            else
            {
                MessageBox.Show("Preencha todos os Campos Corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        //Bota Visualizar mostra o item selecionado na listbox em outra tela
        //Extraindo o Medicamento e salvando ele para ser instanciado na outra tela

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if(lstMedicamentos.SelectedItems != null)
            {
                Medicamento UsuSelecionado = new Medicamento();
                UsuSelecionado = ExtUsuario();

                frmVisVisualizacao tela = new frmVisVisualizacao(UsuSelecionado);
                tela.ShowDialog();

            }
        }

        //Remove o Medicamento Selecionado da listbox, e Atualiza a listbox

        private void btnRemover_Click(object sender, EventArgs e)
        {
            medicamentoController.ctrlRmvMedicamento(ExtUsuario());

            AttListBox();
        }

        //Abaixo estao as validações dos campos

        private void txtCNPJ_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCNPJ.Text))
            {
                e.Cancel = true;

                errpValidacao.SetError(txtCNPJ, "Preencha os campos Corretamente");
            }
            else
            {
                e.Cancel = false;
                errpValidacao.SetError(txtCNPJ, "");
            }
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                e.Cancel = true;

                errpValidacao.SetError(txtNome, "Preencha os campos Corretamente");
            }
            else
            {
                e.Cancel = false;
                errpValidacao.SetError(txtNome, "");
            }
        }

        private void txtRazaoSocial_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRazaoSocial.Text))
            {
                e.Cancel = true;

                errpValidacao.SetError(txtRazaoSocial, "Preencha os campos Corretamente");
            }
            else
            {
                e.Cancel = false;
                errpValidacao.SetError(txtRazaoSocial, "");
            }
        }

        private void txtDescricao_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                e.Cancel = true;

                errpValidacao.SetError(txtDescricao, "Preencha os campos Corretamente");
            }
            else
            {
                e.Cancel = false;
                errpValidacao.SetError(txtDescricao, "");
            }
        }

        private void txtCodBarra_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodBarra.Text))
            {
                e.Cancel = true;

                errpValidacao.SetError(txtCodBarra, "Preencha os campos Corretamente");
            }
            else
            {
                e.Cancel = false;
                errpValidacao.SetError(txtCodBarra, "");
            }
        }

        private void txtPreco_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPreco.Text))
            {
                e.Cancel = true;

                errpValidacao.SetError(txtPreco, "Preencha os campos Corretamente");
            }
            else
            {
                e.Cancel = false;
                errpValidacao.SetError(txtPreco, "");
            }
        }

        private void txtCategoria_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                e.Cancel = true;

                errpValidacao.SetError(txtCategoria, "Preencha os campos Corretamente");
            }
            else
            {
                e.Cancel = false;
                errpValidacao.SetError(txtCategoria, "");
            }
        }

        private void cbbMedControlado_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbbMedControlado.Text))
            {
                e.Cancel = true;

                errpValidacao.SetError(cbbMedControlado, "Preencha os campos Corretamente");
            }
            else
            {
                e.Cancel = false;
                errpValidacao.SetError(cbbMedControlado, "");
            }
        }

        private void txtIndicacao_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIndicacao.Text))
            {
                e.Cancel = true;

                errpValidacao.SetError(txtIndicacao, "Preencha os campos Corretamente");
            }
            else
            {
                e.Cancel = false;
                errpValidacao.SetError(txtIndicacao, "");
            }
        }

        private void frmVisMedicamentos_Load(object sender, EventArgs e)
        {

        }
    }
}
