using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SisLanchonete
{
    public partial class FormLogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\SisLanchonete\\DbLanchonete.mdf;Integrated Security=True");

        public FormLogin()
        {
            InitializeComponent();
            FormSplashScreen formSplash = new FormSplashScreen();
            formSplash.Show();
            Thread.Sleep(3000);
            formSplash.Close();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string usu = "SELECT login, senha FROM Usuario WHERE login = @login AND senha = @senha";
            SqlCommand cmd = new SqlCommand(usu, con);
            cmd.Parameters.AddWithValue("@login", SqlDbType.NChar).Value = txtUsuario.Text.Trim();
            cmd.Parameters.AddWithValue("@senha", SqlDbType.NChar).Value = txtSenha.Text.Trim();
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataReader usuario = cmd.ExecuteReader();
            if (usuario.HasRows)
            {
                this.Hide();
                FormPrincipal pri = new FormPrincipal();
                pri.Show();
                con.Close();
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
                con.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
