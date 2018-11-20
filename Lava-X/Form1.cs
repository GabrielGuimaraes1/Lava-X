using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Lava_X
{
    public partial class CreateTable : Form
    {
        private void CreateTable_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listBox1.Visible = false;
            try
            {
                //conectando à base de dados
                string connString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection conexao = new SqlConnection(connString);
                conexao.ConnectionString = @"Data Source=DESKTOP-U61K189\SQLEXPRESS;Initial Catalog=LAVAJATO;Integrated Security=True; User ID=sa; Password=sa;";
                conexao.Open();

                //Recebendo dados
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM PESSOA", conexao);
                DataTable cliente = new DataTable();

                adaptador.Fill(cliente);

                conexao.Close();

                //Mostrando dados no datagridview

                foreach (DataRow Drow in cliente.Rows)
                {
                    int num = dataGridView1.Rows.Add();
                    dataGridView1.Rows[num].Cells[0].Value = Drow["Nome"].ToString();
                    dataGridView1.Rows[num].Cells[1].Value = Drow["Sobrenome"].ToString();
                    dataGridView1.Rows[num].Cells[2].Value = Drow["cpf_cnpj"].ToString();
                    dataGridView1.Rows[num].Cells[3].Value = Drow["endereco"].ToString();
                    dataGridView1.Rows[num].Cells[4].Value = Drow["numero"].ToString();
                    dataGridView1.Rows[num].Cells[5].Value = Drow["Telefone"].ToString();
                    dataGridView1.Rows[num].Cells[6].Value = Drow["dataCadastro"].ToString();
                }
            }

            //Mensagem de erro (caso haja)
            catch
            {
                dataGridView1.Rows.Clear();
                MessageBox.Show("Houve algum erro ao carregar os dados.");
            }

        }
    
        public CreateTable()
        {
            InitializeComponent();
        }

        private void CadastrarBtn_Click(object sender, EventArgs e)
        {
            try
            {   //Abrindo conexão e inserindo dados no datagridview
                string connString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection conexao = new SqlConnection(connString);
                conexao.Open();

                string query = ("INSERT INTO pessoa (nome,sobrenome,cpf_cnpj,endereco,numero,telefone,dataCadastro,tipo) VALUES ('" +
                    nomeTbx.Text + "', '" + sobrenomeTbx.Text + "', " + " '" + cpfTbx.Text + "', " + " '" + enderecoTbx.Text + "', " +
                    " " + numeroTbx.Text + ", " + " '" + telefoneTbx.Text + "', " +
                    " GETDATE(),'F') DECLARE @ID int;set @ID = SCOPE_IDENTITY();Insert INTO cliente (pessoa_id) Values (@ID)");

                SqlCommand comando = new SqlCommand(query, conexao);
                comando.ExecuteNonQuery();

                //Recebendo dados atualizados
                DataTable cliente = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM PESSOA", conexao);
                adaptador.Fill(cliente);

                conexao.Close();
                //Mostrando nova linha no datagridview
                dataGridView1.Rows.Clear();
                foreach (DataRow Drow in cliente.Rows)
                {
                    int num = dataGridView1.Rows.Add();
                    dataGridView1.Rows[num].Cells[0].Value = Drow["Nome"].ToString();
                    dataGridView1.Rows[num].Cells[1].Value = Drow["Sobrenome"].ToString();
                    dataGridView1.Rows[num].Cells[2].Value = Drow["cpf_cnpj"].ToString();
                    dataGridView1.Rows[num].Cells[3].Value = Drow["endereco"].ToString();
                    dataGridView1.Rows[num].Cells[4].Value = Drow["numero"].ToString();
                    dataGridView1.Rows[num].Cells[5].Value = Drow["Telefone"].ToString();
                    dataGridView1.Rows[num].Cells[6].Value = Drow["dataCadastro"].ToString();
                }
                MessageBox.Show("Cadastro efetuado com sucesso.");
                DialogResult dr = MessageBox.Show("Deseja vincular esse cadastro a um serviço?", " ", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        listBox1.Visible = true;
                        //carregando dados na ListBox
                        conexao.Open();
                        SqlDataAdapter operario = new SqlDataAdapter("SELECT nome FROM servico",conexao);
                        DataTable servico = new DataTable();
                        adaptador.Fill(servico);
                        listBox1.DisplayMember = "servico.nome";
                        string servico_id = listBox1.ValueMember = "servico_id";
                        listBox1.DataSource = servico;
                        conexao.Close();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            //Mensagem de erro (caso haja)
            catch
            {
                MessageBox.Show("Houve algum erro na inserção de dados.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Abrindo conexão
                string connString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection conexao = new SqlConnection(connString);
                conexao.Open();

                //Deletando dados
                string nome = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string sobrenome = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string query = (
                                "DECLARE @del int; set @del = (SELECT pessoa_id FROM pessoa WHERE nome = '" + nome + "' AND sobrenome = '" + sobrenome + "')"+
                                "DELETE FROM cliente WHERE pessoa_id = @del" +
                                " DELETE FROM pessoa WHERE nome = '" + nome + "' AND sobrenome = '" + sobrenome + "'"
                                );
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.ExecuteNonQuery();

                //Mostrando tabela atualizada no datagridview
                DataTable cliente = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM PESSOA", conexao);
                adaptador.Fill(cliente);
                conexao.Close();

                dataGridView1.Rows.Clear();
                foreach (DataRow Drow in cliente.Rows)
                {
                    int num = dataGridView1.Rows.Add();
                    dataGridView1.Rows[num].Cells[0].Value = Drow["Nome"].ToString();
                    dataGridView1.Rows[num].Cells[1].Value = Drow["Sobrenome"].ToString();
                    dataGridView1.Rows[num].Cells[2].Value = Drow["cpf_cnpj"].ToString();
                    dataGridView1.Rows[num].Cells[3].Value = Drow["endereco"].ToString();
                    dataGridView1.Rows[num].Cells[4].Value = Drow["numero"].ToString();
                    dataGridView1.Rows[num].Cells[5].Value = Drow["Telefone"].ToString();
                    dataGridView1.Rows[num].Cells[6].Value = Drow["dataCadastro"].ToString();
                }
                MessageBox.Show("Cadastro removido com sucesso.");
            }
            catch
            {
                MessageBox.Show("Houve algum erro na remoção de dados.");
            }
        }
    }
}
