using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuaseLar_C_Form
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cad_usuarios form2 = new cad_usuarios();
            form2.Show();
        }

        private void adoçãoDeAnimaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cad_adocao_de_animais form = new cad_adocao_de_animais();
            form.Show();
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

}
