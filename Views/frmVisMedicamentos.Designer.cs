namespace farmaciaSiMedique.Views
{
    partial class frmVisMedicamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisMedicamentos));
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodBarra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.cbbMedControlado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errpValidacao = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txtIndicacao = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lstMedicamentos = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errpValidacao)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(180, 110);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(130, 20);
            this.txtCNPJ.TabIndex = 0;
            this.txtCNPJ.Validating += new System.ComponentModel.CancelEventHandler(this.txtCNPJ_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "CNPJ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome :";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(318, 110);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(187, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Razão Social :";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(180, 149);
            this.txtRazaoSocial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(325, 20);
            this.txtRazaoSocial.TabIndex = 4;
            this.txtRazaoSocial.Validating += new System.ComponentModel.CancelEventHandler(this.txtRazaoSocial_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descrição :";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(180, 193);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(325, 46);
            this.txtDescricao.TabIndex = 6;
            this.txtDescricao.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescricao_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Código de Barras :";
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Location = new System.Drawing.Point(180, 264);
            this.txtCodBarra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.Size = new System.Drawing.Size(325, 20);
            this.txtCodBarra.TabIndex = 8;
            this.txtCodBarra.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodBarra_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 292);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Preço :";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(180, 306);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(114, 20);
            this.txtPreco.TabIndex = 10;
            this.txtPreco.Validating += new System.ComponentModel.CancelEventHandler(this.txtPreco_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(327, 291);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "Categoria :";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(331, 306);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(174, 20);
            this.txtCategoria.TabIndex = 12;
            this.txtCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.txtCategoria_Validating);
            // 
            // cbbMedControlado
            // 
            this.cbbMedControlado.FormattingEnabled = true;
            this.cbbMedControlado.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbbMedControlado.Location = new System.Drawing.Point(182, 351);
            this.cbbMedControlado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbbMedControlado.Name = "cbbMedControlado";
            this.cbbMedControlado.Size = new System.Drawing.Size(84, 20);
            this.cbbMedControlado.TabIndex = 15;
            this.cbbMedControlado.Validating += new System.ComponentModel.CancelEventHandler(this.cbbMedControlado_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(182, 337);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "Medicamento Controlado :";
            // 
            // errpValidacao
            // 
            this.errpValidacao.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(180, 378);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "Indicação  :";
            // 
            // txtIndicacao
            // 
            this.txtIndicacao.Location = new System.Drawing.Point(184, 393);
            this.txtIndicacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIndicacao.Multiline = true;
            this.txtIndicacao.Name = "txtIndicacao";
            this.txtIndicacao.Size = new System.Drawing.Size(221, 46);
            this.txtIndicacao.TabIndex = 17;
            this.txtIndicacao.Validating += new System.ComponentModel.CancelEventHandler(this.txtIndicacao_Validating);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(184, 444);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(126, 32);
            this.btnAdicionar.TabIndex = 19;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(706, 464);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(126, 32);
            this.btnVisualizar.TabIndex = 20;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(836, 464);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(126, 32);
            this.btnRemover.TabIndex = 21;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lstMedicamentos
            // 
            this.lstMedicamentos.FormattingEnabled = true;
            this.lstMedicamentos.ItemHeight = 12;
            this.lstMedicamentos.Location = new System.Drawing.Point(661, 70);
            this.lstMedicamentos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstMedicamentos.Name = "lstMedicamentos";
            this.lstMedicamentos.Size = new System.Drawing.Size(338, 388);
            this.lstMedicamentos.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(178, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = "Cadastros";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(657, 40);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 22);
            this.label11.TabIndex = 24;
            this.label11.Text = "Medicamentos";
            // 
            // frmVisMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1185, 537);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lstMedicamentos);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIndicacao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbMedControlado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodBarra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCNPJ);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmVisMedicamentos";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmVisMedicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errpValidacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodBarra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.ComboBox cbbMedControlado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errpValidacao;
        private System.Windows.Forms.ListBox lstMedicamentos;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIndicacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}