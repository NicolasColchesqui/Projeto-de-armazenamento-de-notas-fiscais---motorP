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
    public partial class Consultar : Form
    {
        MySqlConnection conexao;

        public string total;
        public string atualizacao;
        public int validacao = 0;

        public string codigo;
        public string CNPJ;
        public string mes;
        public string ano;
        public byte situacao;

        public string foto;

        public Consultar()
        {
            InitializeComponent();

            //permite o usuario mudar o tamanho da coluna
            lsvConsultaDados.AllowColumnReorder = true;
            //cada item vai ser exibido em uma linha separada
            lsvConsultaDados.View = View.Details;
            //clicar em um item seleciona toda a linha
            lsvConsultaDados.FullRowSelect = true;
            //desenha linhas de grade
            lsvConsultaDados.GridLines = true;

            //adiciona dentro do listBox as colunas com nomes, tamanhos e alinhamentos
            lsvConsultaDados.Columns.Add("codigo", 50, HorizontalAlignment.Left);
            lsvConsultaDados.Columns.Add("CNPJ", 100, HorizontalAlignment.Left);
            lsvConsultaDados.Columns.Add("fornecedor", 100, HorizontalAlignment.Left);
            lsvConsultaDados.Columns.Add("dia", 50, HorizontalAlignment.Left);
            lsvConsultaDados.Columns.Add("mes", 50, HorizontalAlignment.Left);
            lsvConsultaDados.Columns.Add("ano", 50, HorizontalAlignment.Left);
            lsvConsultaDados.Columns.Add("valorTotalProduto", 100, HorizontalAlignment.Left);

            conexao = new MySqlConnection("server=localhost;DataBase=notaConsumidor;Uid=root;password=;");
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

        public void ConsultarDados()
        {
            try
            {
                string query = "select * from telaPrincipal where(CNPJ = " + CNPJ + ") and (mes = " + mes + ") and (ano = " + ano + ") and (situacao = " + situacao + ")";

                MySqlCommand comando = new MySqlCommand(query, conexao);

                MySqlDataReader ler = comando.ExecuteReader();

                lsvConsultaDados.Items.Clear();

                while (ler.Read())
                {
                    string[] linha =
                    {
                        ler.GetString(0),
                        ler.GetString(1),
                        ler.GetString(2),
                        ler.GetString(3),
                        ler.GetString(4),
                        ler.GetString(5),
                        ler.GetString(6),
                    };

                    var linha_view = new ListViewItem(linha);

                    lsvConsultaDados.Items.Add(linha_view);
                }//fim do while          

                ler.Close();

            }//fim da consulta ao banco
            catch (Exception e)
            {
                MessageBox.Show("Algo deu errado!\n\n" + e);
            }

        }//fim do método Preencher

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtbCNPJ.Text == "" || cmbAno.SelectedItem == null || cmbMes.SelectedItem == null || cmbSituacao.SelectedItem == null)//impede o erro caso o campo esteja vazio
            {
                MessageBox.Show("Preencha todos os campos para realizar a consulta!");
            }
            else
            {
                validacao = 1;//variavel que habilita o funcionamento do botao "consulta"


                CNPJ = txtbCNPJ.Text;
                mes = Convert.ToString(cmbMes.SelectedItem);
                ano = Convert.ToString(cmbAno.SelectedItem);

                if (Convert.ToString(cmbSituacao.SelectedItem) == "Pendente")
                {
                    situacao = 1;
                }
                else
                {
                    situacao = 0;
                }

                ConsultarDados();
                valorTotal();
            }//fim da validação consulta
        }//fim do botão Consultar 

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu mostrar = new Menu();
            mostrar.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (validacao == 1)
            {
                var msg = MessageBox.Show("Você tem certeza que deseja realizar essa operação?", "Aviso", MessageBoxButtons.YesNo);

                if (msg == DialogResult.Yes)
                {
                    CNPJ = txtbCNPJ.Text;
                    mes = Convert.ToString(cmbMes.SelectedItem);

                    if ((Convert.ToString(cmbSituacao.SelectedItem) == "Pendente"))
                    {
                        atualizacao = "update telaPrincipal set situacao = '0' where (CNPJ = " + CNPJ + ") and (mes =" + mes +
                                        ") and (situacao =" + situacao + ")";
                        MySqlCommand atual = new MySqlCommand(atualizacao, conexao);
                        atualizacao = "" + atual.ExecuteNonQuery();
                        MessageBox.Show("Nota atualizada!");
                    }//fim da atualização
                }//fim da ação de atualização em caso positivo
                if (msg == DialogResult.No)
                {
                    Consultar mostrar = new Consultar();
                    mostrar.Show();
                }//fim da ação que encerra o textbox               
            }//fim da condição necessária para atualizar o dado

            lsvConsultaDados.Items.Clear();
            txtbTotal.Text = "";
            validacao = 0;

        }//fim do botão atualizar

        private void valorTotal()//Joga a soma da coluna preço em um textBox
        {
            string funcao = "select SUM(valorTotalProduto) AS total FROM telaPrincipal where(CNPJ = " + CNPJ + ") and (mes = " + mes + ") and (situacao = " +
                                situacao + ")";

            MySqlCommand comando = new MySqlCommand(funcao, conexao);

            MySqlDataReader valorTotal = comando.ExecuteReader();

            while (valorTotal.Read())
            {
                total = Convert.ToString(valorTotal["total"]);
            }

            valorTotal.Close();

            txtbTotal.Text = Convert.ToString(total);
        }//fim do método valorTotal

        private void Deletar()//deleta da base de dados TODA uma linha de acordo com o código
        {
            if(txtbDeletar.Text == "")//impede o erro caso o campo esteja vazio
            {
                MessageBox.Show("Preencha o campo que deseja deletar!");
            }
            else
            {
                string funcao = "delete from telaPrincipal where codigo =" + txtbDeletar.Text + "";

                MySqlCommand comando = new MySqlCommand(funcao, conexao);

                funcao = "" + comando.ExecuteNonQuery();

                MessageBox.Show("Linha deletada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }//fim da validação 
        }//fim do método deletar linha

        private void btnVerNota_Click(object sender, EventArgs e)
        {
            codigo = txtbVerFoto.Text;
            try
            {
                string query = "SELECT foto FROM telaPrincipal WHERE(codigo =" + codigo + ")";

                MySqlCommand comando = new MySqlCommand(query, conexao);

                MySqlDataReader ler = comando.ExecuteReader();

                if (ler.Read())
                {
                    foto = ler["foto"] + "";

                    if (foto == null)
                    {
                        pictureNota.Image = null;
                        MessageBox.Show("Não foi inserido a nota nessa entrada. Por favor, insira uma imagem no cadastro");
                    }
                    else
                    {
                        pictureNota.ImageLocation = foto;
                    }
                }

                ler.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo de errado!\n\n" + erro);
            }
        }//fim do botão verNota

        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            Deletar();
        }//fim do botão deletar

        private void Consultar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }//fim do encerramento da aplicação

        private void txtbTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Consultar_Load(object sender, EventArgs e)
        {

        }

        private void txtbCNPJ_TextChanged(object sender, EventArgs e)
        {

        }
    }//fim da classe
}//fim do projeto