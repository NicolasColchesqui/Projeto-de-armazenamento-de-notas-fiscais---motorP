
namespace ProjetoMotorÉP
{
    partial class Cadastrar
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txtbCNPJ = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtbFornecedor = new System.Windows.Forms.TextBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtbDia = new System.Windows.Forms.TextBox();
            this.txtbMes = new System.Windows.Forms.TextBox();
            this.txtbAno = new System.Windows.Forms.TextBox();
            this.lblValorTotalProduto = new System.Windows.Forms.Label();
            this.txtbValorTotalProduto = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.picbNota = new System.Windows.Forms.PictureBox();
            this.lblLocalFoto = new System.Windows.Forms.Label();
            this.txtbLocalFoto = new System.Windows.Forms.TextBox();
            this.btnInserirImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbNota)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(769, 459);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(232, 64);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Location = new System.Drawing.Point(641, 35);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(52, 13);
            this.lblCadastrar.TabIndex = 1;
            this.lblCadastrar.Text = "Cadastrar";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(643, 121);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCNPJ.TabIndex = 2;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // txtbCNPJ
            // 
            this.txtbCNPJ.Location = new System.Drawing.Point(683, 122);
            this.txtbCNPJ.MaxLength = 14;
            this.txtbCNPJ.Name = "txtbCNPJ";
            this.txtbCNPJ.Size = new System.Drawing.Size(283, 20);
            this.txtbCNPJ.TabIndex = 3;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(645, 190);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(58, 13);
            this.lblFornecedor.TabIndex = 4;
            this.lblFornecedor.Text = "fornecedor";
            // 
            // txtbFornecedor
            // 
            this.txtbFornecedor.Location = new System.Drawing.Point(710, 190);
            this.txtbFornecedor.MaxLength = 45;
            this.txtbFornecedor.Name = "txtbFornecedor";
            this.txtbFornecedor.Size = new System.Drawing.Size(255, 20);
            this.txtbFornecedor.TabIndex = 5;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(647, 228);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(23, 13);
            this.lblDia.TabIndex = 6;
            this.lblDia.Text = "Dia";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(686, 228);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 7;
            this.lblMes.Text = "Mês";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(725, 229);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 8;
            this.lblAno.Text = "Ano";
            // 
            // txtbDia
            // 
            this.txtbDia.Location = new System.Drawing.Point(648, 256);
            this.txtbDia.MaxLength = 2;
            this.txtbDia.Name = "txtbDia";
            this.txtbDia.Size = new System.Drawing.Size(35, 20);
            this.txtbDia.TabIndex = 9;
            // 
            // txtbMes
            // 
            this.txtbMes.Location = new System.Drawing.Point(687, 256);
            this.txtbMes.MaxLength = 2;
            this.txtbMes.Name = "txtbMes";
            this.txtbMes.Size = new System.Drawing.Size(35, 20);
            this.txtbMes.TabIndex = 10;
            // 
            // txtbAno
            // 
            this.txtbAno.Location = new System.Drawing.Point(726, 256);
            this.txtbAno.Name = "txtbAno";
            this.txtbAno.Size = new System.Drawing.Size(35, 20);
            this.txtbAno.TabIndex = 11;
            // 
            // lblValorTotalProduto
            // 
            this.lblValorTotalProduto.AutoSize = true;
            this.lblValorTotalProduto.Location = new System.Drawing.Point(641, 151);
            this.lblValorTotalProduto.Name = "lblValorTotalProduto";
            this.lblValorTotalProduto.Size = new System.Drawing.Size(98, 13);
            this.lblValorTotalProduto.TabIndex = 18;
            this.lblValorTotalProduto.Text = "Valor Total Produto";
            // 
            // txtbValorTotalProduto
            // 
            this.txtbValorTotalProduto.Location = new System.Drawing.Point(745, 148);
            this.txtbValorTotalProduto.Name = "txtbValorTotalProduto";
            this.txtbValorTotalProduto.Size = new System.Drawing.Size(221, 20);
            this.txtbValorTotalProduto.TabIndex = 19;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pendente",
            "Pago"});
            this.cmbStatus.Location = new System.Drawing.Point(844, 255);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 20;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(789, 258);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(49, 13);
            this.lblSituacao.TabIndex = 21;
            this.lblSituacao.Text = "Situação";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(626, 500);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // picbNota
            // 
            this.picbNota.Location = new System.Drawing.Point(32, 12);
            this.picbNota.Name = "picbNota";
            this.picbNota.Size = new System.Drawing.Size(540, 533);
            this.picbNota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbNota.TabIndex = 26;
            this.picbNota.TabStop = false;
            // 
            // lblLocalFoto
            // 
            this.lblLocalFoto.AutoSize = true;
            this.lblLocalFoto.Location = new System.Drawing.Point(647, 322);
            this.lblLocalFoto.Name = "lblLocalFoto";
            this.lblLocalFoto.Size = new System.Drawing.Size(57, 13);
            this.lblLocalFoto.TabIndex = 27;
            this.lblLocalFoto.Text = "Local Foto";
            // 
            // txtbLocalFoto
            // 
            this.txtbLocalFoto.Location = new System.Drawing.Point(650, 338);
            this.txtbLocalFoto.MaxLength = 100;
            this.txtbLocalFoto.Name = "txtbLocalFoto";
            this.txtbLocalFoto.Size = new System.Drawing.Size(305, 20);
            this.txtbLocalFoto.TabIndex = 28;
            // 
            // btnInserirImagem
            // 
            this.btnInserirImagem.Location = new System.Drawing.Point(711, 364);
            this.btnInserirImagem.Name = "btnInserirImagem";
            this.btnInserirImagem.Size = new System.Drawing.Size(183, 30);
            this.btnInserirImagem.TabIndex = 29;
            this.btnInserirImagem.Text = "Inserir Imagem";
            this.btnInserirImagem.UseVisualStyleBackColor = true;
            this.btnInserirImagem.Click += new System.EventHandler(this.btnInserirImagem_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 557);
            this.Controls.Add(this.btnInserirImagem);
            this.Controls.Add(this.txtbLocalFoto);
            this.Controls.Add(this.lblLocalFoto);
            this.Controls.Add(this.picbNota);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtbValorTotalProduto);
            this.Controls.Add(this.lblValorTotalProduto);
            this.Controls.Add(this.txtbAno);
            this.Controls.Add(this.txtbMes);
            this.Controls.Add(this.txtbDia);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.txtbFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txtbCNPJ);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            ((System.ComponentModel.ISupportInitialize)(this.picbNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txtbCNPJ;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtbFornecedor;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtbDia;
        private System.Windows.Forms.TextBox txtbMes;
        private System.Windows.Forms.TextBox txtbAno;
        private System.Windows.Forms.Label lblValorTotalProduto;
        private System.Windows.Forms.TextBox txtbValorTotalProduto;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox picbNota;
        private System.Windows.Forms.Label lblLocalFoto;
        private System.Windows.Forms.TextBox txtbLocalFoto;
        private System.Windows.Forms.Button btnInserirImagem;
    }
}