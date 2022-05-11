using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProjetoMotorÉP
{
    public partial class Cadastrar : Form
    {
        MySqlConnection conexao;

        public string dados = "";
        public string comando = "";

        public string CNPJ = "";
        public string fornecedor = "";
        public string dia = "";
        public string mes = "";
        public string ano = "";
        public string nomeProduto = "";
        public double precoUnitario = 0;
        public int quantidade = 0;
        public double valorTotalProduto = 0;
        public double valorTotalNota = 0;
        public byte situacao;
        public string imagem;

        public Cadastrar()
        {
            InitializeComponent();

            conexao = new MySqlConnection("server=localhost;DataBase=notaConsumidor;Uid=root;Password=;");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo deu errado!\n\n" + e);
                conexao.Close();
            }//fim da conexão

        }//fim do construtor

        public void Inserir()
        {
            try
            {
                dados = "('','" + CNPJ + "','" + fornecedor + "','" + dia + "','" + mes + "','" + ano + "','" + 
                    valorTotalProduto + "','" + situacao + "','" + imagem + "')";
                comando = "insert into telaPrincipal(codigo, CNPJ, fornecedor, dia, mes, ano," +
                    "valorTotalProduto, situacao, foto) values" + dados;
                MySqlCommand sql = new MySqlCommand(comando, conexao);
                comando = "" + sql.ExecuteNonQuery();
                MessageBox.Show("Linha(s) afetada(s)!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo deu errado!\n\n" + e);
            }
        }//fim do método inserir

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool ok = campoVazio();
            if (ok == true)
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                CNPJ = txtbCNPJ.Text;
                fornecedor = txtbFornecedor.Text;
                dia = txtbDia.Text;
                mes = txtbMes.Text;
                ano = txtbAno.Text;
                valorTotalProduto = Convert.ToDouble(txtbValorTotalProduto.Text);

                imagem = txtbLocalFoto.Text;
                imagem = imagem.Replace("\\", "\\\\");

                if (Convert.ToString(cmbStatus.SelectedItem) == "Pendente")
                {
                    situacao = 1; //coluna situacao vai receber 1 para valor que ainda será pago
                }
                else
                {
                    situacao = 0; //coluna situacao vai receber 0 para valor já pago
                }

                Inserir();
            }

        }//fim do botão cadastrar


        private void txtbCNPJ_TextChanged(object sender, EventArgs e)
        {

        }//fim do textbox CNPJ

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mostrar = new Menu();
            mostrar.Show();
        }//fim do método voltar

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu mostrar = new Menu();
            mostrar.Show();
        }//fim do botão Voltar

        private bool campoVazio()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBoxBase)
                {
                    var txt = (TextBoxBase)item;
                    if (String.IsNullOrEmpty(txt.Text))
                        return true;
                }
            }//fim da validação de campo nulo

            return false;
        }

        private void btnInserirImagem_Click(object sender, EventArgs e)
        {
            //Esssa classe abre o windows explorer para encontrar as imagens
            OpenFileDialog dialog = new OpenFileDialog();
            //Aqui é aplicado o filtro de busca no windows explorer
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.PNG|AllFiles(*.*)|*.*";

            //Quando o botão da caixa de diálogo "ok" do windows explorer for clicado os textboxes receberão as informações
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                txtbLocalFoto.Text = foto;
                picbNota.ImageLocation = foto;
            }
        }//fim do botão inserir imagem

        private void Cadastrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }//fim do botão encerrar

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }
    }//fim da classe
}//fim do projeto
