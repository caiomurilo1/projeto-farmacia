namespace farmaciaSiMedique.Views
{
    partial class frmVisVisualizacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisVisualizacao));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtCodBarra = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtMedControlado = new System.Windows.Forms.TextBox();
            this.txtIndicacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fabricante :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código de Barras :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoria :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 416);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Indicação :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 368);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Medicamento Controlado :";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(19, 28);
            this.txtFabricante.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.ReadOnly = true;
            this.txtFabricante.Size = new System.Drawing.Size(375, 20);
            this.txtFabricante.TabIndex = 14;
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Location = new System.Drawing.Point(19, 81);
            this.txtCodBarra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.ReadOnly = true;
            this.txtCodBarra.Size = new System.Drawing.Size(375, 20);
            this.txtCodBarra.TabIndex = 15;
            this.txtCodBarra.TextChanged += new System.EventHandler(this.txtCodBarra_TextChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(13, 260);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(375, 42);
            this.txtDescricao.TabIndex = 16;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(13, 341);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(184, 20);
            this.txtPreco.TabIndex = 17;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(216, 341);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(171, 20);
            this.txtCategoria.TabIndex = 18;
            // 
            // txtMedControlado
            // 
            this.txtMedControlado.Location = new System.Drawing.Point(14, 383);
            this.txtMedControlado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMedControlado.Name = "txtMedControlado";
            this.txtMedControlado.ReadOnly = true;
            this.txtMedControlado.Size = new System.Drawing.Size(129, 20);
            this.txtMedControlado.TabIndex = 19;
            // 
            // txtIndicacao
            // 
            this.txtIndicacao.Location = new System.Drawing.Point(13, 431);
            this.txtIndicacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIndicacao.Multiline = true;
            this.txtIndicacao.Name = "txtIndicacao";
            this.txtIndicacao.ReadOnly = true;
            this.txtIndicacao.Size = new System.Drawing.Size(375, 42);
            this.txtIndicacao.TabIndex = 20;
            // 
            // frmVisVisualizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(410, 485);
            this.Controls.Add(this.txtIndicacao);
            this.Controls.Add(this.txtMedControlado);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodBarra);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmVisVisualizacao";
            this.Text = "Medicamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtCodBarra;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtMedControlado;
        private System.Windows.Forms.TextBox txtIndicacao;
    }
}