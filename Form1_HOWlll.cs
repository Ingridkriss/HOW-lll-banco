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
private void botao_editar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco
                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE livro SET generoLivro = '" + tb_genero.Text + "', " +
                    "tituloLivro = '" + tb_titulo.Text + "', " +
                    "autorLivro = '" + tb_autor.Text + "', " +
                     "editoraLivro = '" + tb_editora.Text + "', " +
                    "descicaoLivro = '" + tb_descricao.Text + "', " +
                    "anoLivro = " + Convert.ToInt16(tb_ano.Text) +
                    " WHERE codigoLivro = " + tb_codigo.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }

            }

        private void botao_excluir_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco
                
                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                // "DELETE FROM filme WHERE idFilme = "+ textBoxId.Text +""
                //comandoMySql.CommandText = "DELETE FROM filme WHERE idFilme = " + tbID.Text + "";
                comandoMySql.CommandText = "DELETE FROM livro WHERE codigoLivro = " + tb_codigo.Text + "";
                
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Deletado com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void dtgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dtgrid.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                tb_codigo.Text = dtgrid.Rows[e.RowIndex].Cells["Coluna_codigo"].FormattedValue.ToString();
                tb_genero.Text = dtgrid.Rows[e.RowIndex].Cells["Coluna_genero"].FormattedValue.ToString();
                tb_titulo.Text = dtgrid.Rows[e.RowIndex].Cells["Coluna_titulo"].FormattedValue.ToString();
                tb_autor.Text = dtgrid.Rows[e.RowIndex].Cells["Coluna_autor"].FormattedValue.ToString();
                tb_ano.Text = dtgrid.Rows[e.RowIndex].Cells["Coluna_ano"].FormattedValue.ToString();
                tb_editora.Text = dtgrid.Rows[e.RowIndex].Cells["Coluna_editora"].FormattedValue.ToString();
                tb_descricao.Text = dtgrid.Rows[e.RowIndex].Cells["Coluna_descricao"].FormattedValue.ToString();

            }
        }

        private void botao_novo_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
    }
        
   
        
        
      


















    
