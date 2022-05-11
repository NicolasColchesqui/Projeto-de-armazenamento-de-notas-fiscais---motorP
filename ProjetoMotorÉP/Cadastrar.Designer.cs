
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
            this.lblLocalFoto = new System.Windows.Forms.Label();
            this.txtbLocalFoto = new System.Windows.Forms.TextBox();
            this.btnInserirImagem = new System.Windows.Forms.Button();
            this.picbNota = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbNota)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(795, 510);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(274, 99);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.ForeColor = System.Drawing.Color.White;
            this.lblCadastrar.Location = new System.Drawing.Point(843, 32);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(199, 31);
            this.lblCadastrar.TabIndex = 1;
            this.lblCadastrar.Text = "Cadastrar Nota";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.ForeColor = System.Drawing.Color.White;
            this.lblCNPJ.Location = new System.Drawing.Point(642, 91);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCNPJ.TabIndex = 2;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // txtbCNPJ
            // 
            this.txtbCNPJ.Location = new System.Drawing.Point(682, 88);
            this.txtbCNPJ.MaxLength = 14;
            this.txtbCNPJ.Name = "txtbCNPJ";
            this.txtbCNPJ.Size = new System.Drawing.Size(396, 20);
            this.txtbCNPJ.TabIndex = 1;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.ForeColor = System.Drawing.Color.White;
            this.lblFornecedor.Location = new System.Drawing.Point(642, 122);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 4;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // txtbFornecedor
            // 
            this.txtbFornecedor.Location = new System.Drawing.Point(709, 119);
            this.txtbFornecedor.MaxLength = 45;
            this.txtbFornecedor.Name = "txtbFornecedor";
            this.txtbFornecedor.Size = new System.Drawing.Size(520, 20);
            this.txtbFornecedor.TabIndex = 2;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.ForeColor = System.Drawing.Color.White;
            this.lblDia.Location = new System.Drawing.Point(1115, 64);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(23, 13);
            this.lblDia.TabIndex = 6;
            this.lblDia.Text = "Dia";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.ForeColor = System.Drawing.Color.White;
            this.lblMes.Location = new System.Drawing.Point(1154, 64);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 7;
            this.lblMes.Text = "Mês";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.ForeColor = System.Drawing.Color.White;
            this.lblAno.Location = new System.Drawing.Point(1193, 65);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 8;
            this.lblAno.Text = "Ano";
            // 
            // txtbDia
            // 
            this.txtbDia.Location = new System.Drawing.Point(1118, 88);
            this.txtbDia.MaxLength = 2;
            this.txtbDia.Name = "txtbDia";
            this.txtbDia.Size = new System.Drawing.Size(35, 20);
            this.txtbDia.TabIndex = 4;
            // 
            // txtbMes
            // 
            this.txtbMes.Location = new System.Drawing.Point(1157, 88);
            this.txtbMes.MaxLength = 2;
            this.txtbMes.Name = "txtbMes";
            this.txtbMes.Size = new System.Drawing.Size(35, 20);
            this.txtbMes.TabIndex = 5;
            // 
            // txtbAno
            // 
            this.txtbAno.Location = new System.Drawing.Point(1196, 88);
            this.txtbAno.MaxLength = 4;
            this.txtbAno.Name = "txtbAno";
            this.txtbAno.Size = new System.Drawing.Size(35, 20);
            this.txtbAno.TabIndex = 6;
            // 
            // lblValorTotalProduto
            // 
            this.lblValorTotalProduto.AutoSize = true;
            this.lblValorTotalProduto.ForeColor = System.Drawing.Color.White;
            this.lblValorTotalProduto.Location = new System.Drawing.Point(642, 157);
            this.lblValorTotalProduto.Name = "lblValorTotalProduto";
            this.lblValorTotalProduto.Size = new System.Drawing.Size(98, 13);
            this.lblValorTotalProduto.TabIndex = 18;
            this.lblValorTotalProduto.Text = "Valor Total Produto";
            // 
            // txtbValorTotalProduto
            // 
            this.txtbValorTotalProduto.Location = new System.Drawing.Point(746, 150);
            this.txtbValorTotalProduto.Name = "txtbValorTotalProduto";
            this.txtbValorTotalProduto.Size = new System.Drawing.Size(219, 20);
            this.txtbValorTotalProduto.TabIndex = 3;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pendente",
            "Pago"});
            this.cmbStatus.Location = new System.Drawing.Point(1108, 149);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 7;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.ForeColor = System.Drawing.Color.White;
            this.lblSituacao.Location = new System.Drawing.Point(1053, 153);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(49, 13);
            this.lblSituacao.TabIndex = 21;
            this.lblSituacao.Text = "Situação";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(615, 676);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // lblLocalFoto
            // 
            this.lblLocalFoto.AutoSize = true;
            this.lblLocalFoto.ForeColor = System.Drawing.Color.White;
            this.lblLocalFoto.Location = new System.Drawing.Point(646, 266);
            this.lblLocalFoto.Name = "lblLocalFoto";
            this.lblLocalFoto.Size = new System.Drawing.Size(57, 13);
            this.lblLocalFoto.TabIndex = 27;
            this.lblLocalFoto.Text = "Local Foto";
            // 
            // txtbLocalFoto
            // 
            this.txtbLocalFoto.Location = new System.Drawing.Point(709, 263);
            this.txtbLocalFoto.MaxLength = 100;
            this.txtbLocalFoto.Name = "txtbLocalFoto";
            this.txtbLocalFoto.Size = new System.Drawing.Size(520, 20);
            this.txtbLocalFoto.TabIndex = 8;
            // 
            // btnInserirImagem
            // 
            this.btnInserirImagem.BackColor = System.Drawing.Color.LightBlue;
            this.btnInserirImagem.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnInserirImagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInserirImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirImagem.Location = new System.Drawing.Point(835, 289);
            this.btnInserirImagem.Name = "btnInserirImagem";
            this.btnInserirImagem.Size = new System.Drawing.Size(194, 54);
            this.btnInserirImagem.TabIndex = 9;
            this.btnInserirImagem.Text = "Inserir Imagem";
            this.btnInserirImagem.UseVisualStyleBackColor = false;
            this.btnInserirImagem.Click += new System.EventHandler(this.btnInserirImagem_Click);
            // 
            // picbNota
            // 
            this.picbNota.Location = new System.Drawing.Point(12, 12);
            this.picbNota.Name = "picbNota";
            this.picbNota.Size = new System.Drawing.Size(582, 687);
            this.picbNota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbNota.TabIndex = 26;
            this.picbNota.TabStop = false;
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1269, 711);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastrar_FormClosing);
            this.Load += new System.EventHandler(this.Cadastrar_Load);
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