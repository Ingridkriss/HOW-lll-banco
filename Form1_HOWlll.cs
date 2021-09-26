using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HOW_lll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "livraria";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM livro WHERE ativoLivro = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dtgrid.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dtgrid.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//codigo
                    row.Cells[1].Value = reader.GetString(1);//genero
                    row.Cells[2].Value = reader.GetString(2);//titulo
                    row.Cells[3].Value = reader.GetString(3);//autor
                    row.Cells[4].Value = reader.GetInt32(4);//ANO
                    row.Cells[5].Value = reader.GetString(5);//editora               
                    row.Cells[6].Value = reader.GetString(6);//descricao
                    dtgrid.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void botao_cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();

        }

        private void limparCampos()

        {
            tb_codigo.Clear();
            tb_genero.Text = "";
            tb_titulo.Clear();
            tb_autor.Clear();
            tb_ano.Clear();
            tb_editora.Clear();
            tb_descricao.Clear();
        }

        private void botao_salvar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();


                comandoMySql.CommandText = "INSERT INTO livro (generoLivro,tituloLivro,autorLivro,anolivro,editoraLivro,descricaoLivro) " +
                      "VALUES('" + tb_genero.Text + "', '" + tb_titulo.Text + "','" + tb_autor.Text + "', " + Convert.ToInt16(tb_ano.Text) + ",'" + tb_editora.Text + "','" + tb_descricao.Text + "')";


                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Inserido com sucesso");
                atualizarGrid();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

        
   
        
        
      


















    