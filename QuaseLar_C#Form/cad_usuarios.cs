using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;       //conexao com o banco de dados


namespace QuaseLar_C_Form
{
    public partial class cad_usuarios : Form
    {
        public cad_usuarios()
        {
            InitializeComponent();
        }

        private void cad_usuarios_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                labelDeMensagemDeErro.Text = "O campo Nome é obrigatório.";
            }
            else
            {
            }
        }





































        private void buttonCadastrarSe_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string email = textBoxEmail.Text;
            string telefone = textBoxTelefone.Text;
            string cpf = textBoxCpf.Text;
            string endereco = textBoxEndereco.Text;
            string cep = textBoxCep.Text;
            string senha = textBoxSenha.Text;
            string confirmarSenha = textBoxConfirmeSenha.Text;

            if (senha == confirmarSenha)
            {
                string mensagem = "Senhas conferem!";
                labelDeMensagemDeErro.Text = mensagem;
            }
            else
            {
                string mensagem = "Senhas não conferem!";
                labelDeMensagemDeErro.Text = mensagem;
                return; // Sai do método se as senhas não conferirem
            }

            //Abrindo meu banco de dados
            BancoDeDados conexao = new BancoDeDados();

            try
            {
                using (MySqlConnection conn = conexao.AbrirConexao())
                {
                    string scriptSql = "INSERT INTO tb_usuario (nome, email, telefone, cpf, endereco, cep, senha) " +
                                       "VALUES (@Nome, @Email, @Telefone, @Cpf, @Endereco, @Cep, @Senha)";
                    using (MySqlCommand cmd = new MySqlCommand(scriptSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Telefone", telefone);
                        cmd.Parameters.AddWithValue("@Cpf", cpf);
                        cmd.Parameters.AddWithValue("@Endereco", endereco);
                        cmd.Parameters.AddWithValue("@Cep", cep);
                        cmd.Parameters.AddWithValue("@Senha", senha);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cadastro Realizado com sucesso!!");

                        textBoxNome.Clear();
                        textBoxEmail.Clear();
                        textBoxTelefone.Clear();
                        textBoxCpf.Clear();
                        textBoxEndereco.Clear();
                        textBoxCep.Clear();
                        textBoxLoginSenha.Clear();
                        textBoxConfirmeSenha.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
            }



        }

        
    }
}
