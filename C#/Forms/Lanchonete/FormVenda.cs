using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SisLanchonete
{
    public partial class FormVenda : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\SisLanchonete\\DbLanchonete.mdf;Integrated Security=True");

        public FormVenda()
        {
            InitializeComponent();
        }

        public void CarregaCbxCliente()
        {
            string cli = "SELECT * FROM Cliente";
            SqlCommand cmd = new SqlCommand(cli, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cli, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "cliente");
            cbxCliente.ValueMember = "cpf";
            cbxCliente.DisplayMember = "nome";
            cbxCliente.DataSource = ds.Tables["cliente"];
            con.Close();
        }

        public void CarregaCbxProduto()
        {
            string pro = "SELECT Id, nome FROM [Produto	]";
            SqlCommand cmd = new SqlCommand(pro, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(pro, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "produto");
            cbxProduto.ValueMember = "Id";
            cbxProduto.DisplayMember = "nome";
            cbxProduto.DataSource = ds.Tables["produto"];
            con.Close();
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            if (cbxCliente.DisplayMember == "")
            {
                cbxProduto.Enabled = false;
                txtIdProduto.Enabled = false;
                txtQuantidade.Enabled = false;
                txtValor.Enabled = false;
                dgvVenda.Enabled = false;
                btnNovoItem.Enabled = false;
                btnEditarItem.Enabled = false;
                btnExcluirItem.Enabled = false;
                txtTotal.Enabled = false;
                btnFinalizarVenda.Enabled = false;
            }
            CarregaCbxCliente();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            cbxProduto.Enabled = true;
            CarregaCbxProduto();
            txtIdProduto.Enabled = true;
            txtQuantidade.Enabled = true;
            txtValor.Enabled = true;
            dgvVenda.Enabled = true;
            btnNovoItem.Enabled = true;
            btnEditarItem.Enabled = true;
            btnExcluirItem.Enabled = true;
            txtTotal.Enabled = true;
            btnFinalizarVenda.Enabled = true;
            dgvVenda.Columns.Add("ID", "ID");
            dgvVenda.Columns.Add("Produto", "Produto");
            dgvVenda.Columns.Add("Quantidade", "Quantidade");
            dgvVenda.Columns.Add("Valor", "Valor");
            dgvVenda.Columns.Add("Total", "Total");
        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Produto	] WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", cbxProduto.SelectedValue);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtValor.Text = rd["valor"].ToString();
                txtIdProduto.Text = rd["Id"].ToString();
                txtQuantidade.Focus();
                rd.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {


            if (dgvVenda.RowCount == 0)
            {
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvVenda);

                float total, valor, quantidade;


                valor = float.Parse(txtValor.Text);
                quantidade = float.Parse(txtQuantidade.Text);
                total = valor * quantidade;

                item.Cells[0].Value = txtIdProduto.Text;
                item.Cells[1].Value = cbxProduto.Text;
                item.Cells[2].Value = txtQuantidade.Text;
                item.Cells[3].Value = txtValor.Text;
                item.Cells[4].Value = total.ToString();
                dgvVenda.Rows.Add(item);
            }

            else
            {
                int repetido = 0;
                foreach (DataGridViewRow dr in dgvVenda.Rows)
                {
                    if (txtIdProduto.Text == Convert.ToString(dr.Cells[0].Value))
                    {

                        MessageBox.Show("Esse item ja foi adicionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        repetido = 1;
                    }
                }
                if (repetido == 0)
                {
                    DataGridViewRow item = new DataGridViewRow();
                    item.CreateCells(dgvVenda);

                    float total, valor, quantidade;

                    valor = float.Parse(txtValor.Text);
                    quantidade = float.Parse(txtQuantidade.Text);
                    total = valor * quantidade;

                    item.Cells[0].Value = txtIdProduto.Text;
                    item.Cells[1].Value = cbxProduto.Text;
                    item.Cells[2].Value = txtQuantidade.Text;
                    item.Cells[3].Value = txtValor.Text;
                    item.Cells[4].Value = total.ToString();

                    dgvVenda.Rows.Add(item);
                }

            }

            double conta;
            conta = 0;
            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {

                conta = conta + Convert.ToDouble(dr.Cells[4].Value);

                txtTotal.Text = Convert.ToString(conta);
            }

        }
    }
}
