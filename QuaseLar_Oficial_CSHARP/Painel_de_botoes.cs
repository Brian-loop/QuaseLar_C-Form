using MySql.Data.MySqlClient;       //conexao com o banco de dados
using Newtonsoft.Json.Linq; // Para o funcionamento do API de cep ......Instalar via NuGet: Newtonsoft.Json
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;//
using System.Text;
using System.Threading.Tasks;//
using System.Windows.Forms;



namespace QuaseLar_Oficial_CSHARP
{
    public partial class Painel_de_botoes : Form
    {
        public Painel_de_botoes()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSairPainel_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_de_Usuarios cadUsuario = new Cadastro_de_Usuarios();
            cadUsuario.Show();
        }

        private void usuariosCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_usuario consulUser = new Consulta_usuario();
            consulUser.Show();
        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_de_Animais cadAnimais = new Cadastro_de_Animais();
            cadAnimais.Show(); 
        }

        private void animaisCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_de_Animais consulPets = new Consulta_de_Animais();
            consulPets.Show();
        }
    }

    //=============================================================================================================================
    //class de conexao com o banco de dados

    public class BancoDeDados
    {
        private static string servidor = "localhost";
        private static string banco = "db_quaselar_oficial";
        private static string usuario = "root";
        private static string senha = "";
        private static string stringConexao = $"SERVER={servidor}; DATABASE={banco}; UID={usuario}; PWD={senha};";

        private MySqlConnection conexao = new MySqlConnection(stringConexao);

        public MySqlConnection AbrirConexao()
        {
            try
            {
                if (conexao.State == System.Data.ConnectionState.Closed)
                {
                    conexao.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao abrir a conexão: " + ex.Message);
            }
            return conexao;
        }

        public void FecharConexao()
        {
            try
            {
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao fechar a conexão: " + ex.Message);
            }
        }
    }

    //=============================================================================================================================
    public class Endereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
    } 

}