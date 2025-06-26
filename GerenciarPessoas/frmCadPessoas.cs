using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciarPessoas
{
    public partial class frmCadPessoas : Form
    {
        public frmCadPessoas()
        {
            InitializeComponent();
        }
        public frmCadPessoas(string nome)
        {
            InitializeComponent();
            txtNome.Text = nome;
        }


        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //executando a classe pessoa
            Pessoa ps = new Pessoa();

            ps.Nome = txtNome.Text;
            ps.Email = txtEmail.Text;
            ps.TelCel = mskTelefone.Text;

            ltbItensCadastrados.Items.Add(ps.Nome + " - " + ps.Email + " - " + ps.TelCel);
            //executando os método limpar campos
            limparCampos();
        }

        //limpar campos
        public void limparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            mskTelefone.Clear();
            txtNome.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            ltbItensCadastrados.Items.Clear();
        }

        private void btnTestarClasse_Click(object sender, EventArgs e)
        {
            //executand a classe pessoa
            Pessoa ps = new Pessoa(txtNome.Text,txtEmail.Text,mskTelefone.Text);

            ltbItensCadastrados.Items.Add(ps.Nome + ps.Email + ps.TelCel);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmBuscaPessoas abrir = new frmBuscaPessoas();
            abrir.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
          //this.Close(); fecha a janela mas deixa rodando em background
          Application.Exit();  //fecha todas as janelas
        }
    }
}
