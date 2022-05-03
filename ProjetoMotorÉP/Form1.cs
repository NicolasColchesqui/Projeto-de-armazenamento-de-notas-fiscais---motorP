using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMotorÉP
{
    public partial class Form1 : Form
    {
        CriarLogin crilog;

        public Form1()
        {//criando construtor
            InitializeComponent();
            crilog = new CriarLogin();
        }//fim construtor
        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Acessar_Click(object sender, EventArgs e)
        {

        }

        private void Criar_Click(object sender, EventArgs e)
        {
            Visible = false;
            crilog.ShowDialog();
            Visible = true;
        }

        private void Esquecer_Click(object sender, EventArgs e)
        {

        }
    }
}
