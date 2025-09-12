using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;
using MySql.Data.MySqlClient;       //conexao com o banco de dados
using Mysqlx;


namespace QuaseLar_C_Form
{
    public partial class formulario : Form
    {
        public formulario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text.Trim();
            string email = textBoxEmail.Text.Trim();

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Por favor, informe o nome.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNome.Focus();
                return;
            }
            // Validação do email com regex simples
            //if (!IsValidEmail(email))
            //{
            //    MessageBox.Show("Por favor, informe um email válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    textBoxEmail.Focus();
            //    return;
            //}

            // Se passou nas validações
            MessageBox.Show("Dados enviados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string telefone = textBoxTelefone.Text;
            string senha = textBoxSenha.Text;
            int cpf = textBoxCpf.Text.Length;
            int cep = textBoxCep.Text.Length;
            string dataNasc = textBoxDataNasc.Text;
            string endereco = textBoxEndereco.Text;
            string confrimarSenha = textBoxConfirmeSenha.Text;

            string conexaoBanco = "server=localhost;user id=root;passaword=;database=db_quaselar_oficial";      //conexxao local

            using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
            {
                try
                {
                    conexao.Open();
                    string query = "INSERT INTO tb_usuario (nome, email, telefone, endereco, cep, cpf, senha, confirmar_senha, data_nasc) VALUES (@nome, @email, @telefone, @endereco, @cep, @cpf, @senha, @confirmar_senha, @data_nasc)";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);    //variavel declarada encima
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@data_nasc", dataNasc);
                    cmd.Parameters.AddWithValue("@cep", cep);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@confirmar_senha", confrimarSenha);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente cadastrado com sucesso");      //mensagem de sucesso
                    textBoxNome.Clear();    //limpa os 'textBox' preenchidos
                    textBoxEmail.Clear();
                    textBoxTelefone.Clear();
                    textBoxDataNasc.Clear();
                    textBoxCep.Clear();
                    textBoxCpf.Clear();
                    textBoxEndereco.Clear();
                    textBoxConfirmeSenha.Clear();
                    textBoxSenha.Clear();

                    textBoxNome.Focus();    //Aponta o cursor para ele depois de limpar tudo

                    conexao.Close();    //fecha o banco de dados
                }
                //messagem de erro (caso a conexao falhar)
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastar o cliente, erro de conexão de banco de dados" + ex.Message);
                }


            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string conexaoBanco = "server=localhost;user id=root;passaword=;database=db_quaselar_oficial";      //conexxao local

        }
    }
}

