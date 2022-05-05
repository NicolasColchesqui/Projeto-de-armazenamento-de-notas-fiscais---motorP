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
                dados = "('','" + CNPJ + "','" + fornecedor + "','" + dia + "','" + mes + "','" + ano + "','" + nomeProduto +
                    "','" + precoUnitario + "','" + quantidade + "','" + valorTotalProduto + "','" + situacao + "')";
                comando = "insert into telaPrincipal(codigo, CNPJ, fornecedor, dia, mes, ano, nomeProduto, precoUnitario, quantidade, " +
                    "valorTotalProduto, situacao) values" + dados;
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
            CNPJ = txtbCNPJ.Text;
            fornecedor = txtbFornecedor.Text;
            dia = txtbDia.Text;
            mes = txtbMes.Text;
            ano = txtbAno.Text;
            nomeProduto = txtbProduto.Text;
            precoUnitario = Convert.ToDouble(txtbPreco.Text);
            quantidade = Convert.ToInt32(txtbQtd.Text);
            valorTotalProduto = Convert.ToDouble(txtbValorTotalProduto.Text);

            if (Convert.ToString(cmbStatus.SelectedItem) == "Pendente")
            {
                situacao = 1; //coluna situacao vai receber 1 para valor que ainda será pago
            }
            else
            {
                situacao = 0; //coluna situacao vai receber 0 para valor já pago
            }

            Inserir();
        }//fim do botão cadastrar


        private void txtbCNPJ_TextChanged(object sender, EventArgs e)
        {

        }//fim do textbox CNPJ

        private void lblconexao_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu mostrar = new Menu();
            mostrar.Show();
        }//fim do método voltar

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu mostrar = new Menu();
            mostrar.Show();
        }//fim do botão Voltar
    }//fim da classe
}//fim do projeto
