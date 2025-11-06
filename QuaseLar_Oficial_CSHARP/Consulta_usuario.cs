using MySql.Data.MySqlClient;
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

namespace QuaseLar_Oficial_CSHARP
{
    public partial class Consulta_usuario : Form
    {
        BancoDeDados bd = new BancoDeDados();
        MySqlDataAdapter da;
        DataTable dt;
        public Consulta_usuario()
        {
            InitializeComponent();
        }

        private void Consulta_usuario_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }
        //private void CarregarDados()
        //{
        //    try
        //    {
        //        MySqlConnection conexao = bd.AbrirConexao();
        //        string query = "SELECT * FROM tb_usuario";
        //        da = new MySqlDataAdapter(query, conexao);

        //        MySqlCommandBuilder builder = new MySqlCommandBuilder(da);

        //        dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridView1.DataSource = dt;

        //        dataGridView1.ReadOnly = false;
        //        dataGridView1.AllowUserToAddRows = false;
        //        dataGridView1.AllowUserToDeleteRows = false;

        //        AtualizarEstiloLinhas();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao carregar dados: " + ex.Message);
        //    }
        //    finally
        //    {
        //        bd.FecharConexao();
        //    }
        //}

        //// ✅ DESABILITAR (btnExcluir)
        //private void btnExcluir_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView1.CurrentRow == null)
        //    {
        //        MessageBox.Show("Selecione um usuário para desabilitar.");
        //        return;
        //    }

        //    int idUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_usuario"].Value);

        //    DialogResult confirm = MessageBox.Show(
        //        "Deseja realmente DESABILITAR este usuário?",
        //        "Confirmação",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Question
        //    );

        //    if (confirm == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            MySqlConnection conexao = bd.AbrirConexao();
        //            string query = "UPDATE tb_usuario SET status = 'DESABILITADO' WHERE id_usuario = @id";
        //            MySqlCommand cmd = new MySqlCommand(query, conexao);
        //            cmd.Parameters.AddWithValue("@id", idUsuario);
        //            cmd.ExecuteNonQuery();

        //            dataGridView1.CurrentRow.Cells["status"].Value = "DESABILITADO";
        //            AtualizarEstiloLinhas();

        //            MessageBox.Show("Usuário desabilitado com sucesso!");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Erro ao desabilitar usuário: " + ex.Message);
        //        }
        //        finally
        //        {
        //            bd.FecharConexao();
        //        }
        //    }
        //}

        //// ✅ REABILITAR (btnReabilitar)
        //private void btnReabilitar_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView1.CurrentRow == null)
        //    {
        //        MessageBox.Show("Selecione um usuário para reabilitar.");
        //        return;
        //    }

        //    int idUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_usuario"].Value);

        //    DialogResult confirm = MessageBox.Show(
        //        "Deseja reabilitar este usuário?",
        //        "Confirmação",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Question
        //    );

        //    if (confirm == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            MySqlConnection conexao = bd.AbrirConexao();
        //            string query = "UPDATE tb_usuario SET status = 'HABILITADO' WHERE id_usuario = @id";
        //            MySqlCommand cmd = new MySqlCommand(query, conexao);
        //            cmd.Parameters.AddWithValue("@id", idUsuario);
        //            cmd.ExecuteNonQuery();

        //            dataGridView1.CurrentRow.Cells["status"].Value = "HABILITADO";
        //            AtualizarEstiloLinhas();

        //            MessageBox.Show("Usuário reabilitado com sucesso!");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Erro ao reabilitar usuário: " + ex.Message);
        //        }
        //        finally
        //        {
        //            bd.FecharConexao();
        //        }
        //    }
        //}

        //// 🎨 Estilo das linhas com base no status
        //private void AtualizarEstiloLinhas()
        //{
        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {
        //        if (row.Cells["status"].Value != null)
        //        {
        //            string status = row.Cells["status"].Value.ToString();

        //            if (status == "DESABILITADO")
        //            {
        //                row.DefaultCellStyle.BackColor = Color.LightGray;
        //                row.ReadOnly = true;
        //            }
        //            else
        //            {
        //                row.DefaultCellStyle.BackColor = Color.White;
        //                row.ReadOnly = false;
        //            }
        //        }
        //    }
        //}

        //private void btnAtualizar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        bd.AbrirConexao();
        //        da.Update(dt);
        //        MessageBox.Show("Tabela atualizada com sucesso!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao atualizar dados: " + ex.Message);
        //    }
        //    finally
        //    {
        //        bd.FecharConexao();
        //    }
        //}
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //mudanças a partir daqui
        private void CarregarDados()
        {
            try
            {
                MySqlConnection conexao = bd.AbrirConexao();
                string query = "SELECT * FROM tb_usuario";
                da = new MySqlDataAdapter(query, conexao);

                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);

                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.ReadOnly = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;

                // 🔹 Configura seleção por linha
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;

                AtualizarEstiloLinhas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
            finally
            {
                bd.FecharConexao();
            }
        }

        // 🟥 Botão EXCLUIR (desabilitar)
        //private void btnExcluir_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView1.SelectedRows.Count == 0)
        //    {
        //        MessageBox.Show("Selecione uma linha para desabilitar.");
        //        return;
        //    }

        //    DataGridViewRow linha = dataGridView1.SelectedRows[0];
        //    int idUsuario = Convert.ToInt32(linha.Cells["id_usuario"].Value);

        //    if (linha.Cells["status"].Value.ToString() == "DESABILITADO")
        //    {
        //        MessageBox.Show("Este usuário já está desabilitado.");
        //        return;
        //    }

        //    DialogResult confirm = MessageBox.Show(
        //        "Deseja realmente DESABILITAR este usuário?",
        //        "Confirmação",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Question
        //    );

        //    if (confirm == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            MySqlConnection conexao = bd.AbrirConexao();
        //            string query = "UPDATE tb_usuario SET status = 'DESABILITADO' WHERE id_usuario = @id";
        //            MySqlCommand cmd = new MySqlCommand(query, conexao);
        //            cmd.Parameters.AddWithValue("@id", idUsuario);
        //            cmd.ExecuteNonQuery();

        //            linha.Cells["status"].Value = "DESABILITADO";
        //            AtualizarEstiloLinhas();

        //            MessageBox.Show("Usuário desabilitado com sucesso!");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Erro ao desabilitar usuário: " + ex.Message);
        //        }
        //        finally
        //        {
        //            bd.FecharConexao();
        //        }
        //    }
        //}

        // 🟩 Botão REABILITAR
        //private void btnReabilitar_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView1.SelectedRows.Count == 0)
        //    {
        //        MessageBox.Show("Selecione uma linha para reabilitar.");
        //        return;
        //    }

        //    DataGridViewRow linha = dataGridView1.SelectedRows[0];
        //    int idUsuario = Convert.ToInt32(linha.Cells["id_usuario"].Value);

        //    if (linha.Cells["status"].Value.ToString() == "HABILITADO")
        //    {
        //        MessageBox.Show("Este usuário já está habilitado.");
        //        return;
        //    }

        //    DialogResult confirm = MessageBox.Show(
        //        "Deseja reabilitar este usuário?",
        //        "Confirmação",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Question
        //    );

        //    if (confirm == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            MySqlConnection conexao = bd.AbrirConexao();
        //            string query = "UPDATE tb_usuario SET status = 'HABILITADO' WHERE id_usuario = @id";
        //            MySqlCommand cmd = new MySqlCommand(query, conexao);
        //            cmd.Parameters.AddWithValue("@id", idUsuario);
        //            cmd.ExecuteNonQuery();

        //            linha.Cells["status"].Value = "HABILITADO";
        //            AtualizarEstiloLinhas();

        //            MessageBox.Show("Usuário reabilitado com sucesso!");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Erro ao reabilitar usuário: " + ex.Message);
        //        }
        //        finally
        //        {
        //            bd.FecharConexao();
        //        }
        //    }
        //}

        // 🎨 Ajusta cores e bloqueia linhas desabilitadas
        private void AtualizarEstiloLinhas()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["status"].Value != null)
                {
                    string status = row.Cells["status"].Value.ToString();

                    if (status == "DESABILITADO")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                        row.DefaultCellStyle.ForeColor = Color.DarkGray;
                        row.DefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Italic);
                        row.ReadOnly = true;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Regular);
                        row.ReadOnly = false;
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
        //private void btnAtualizar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        bd.AbrirConexao();
        //        da.Update(dt);
        //        MessageBox.Show("Tabela atualizada com sucesso!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao atualizar dados: " + ex.Message);
        //    }
        //    finally
        //    {
        //        bd.FecharConexao();
        //    }
        //}
    }
}
