using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuaseLar_Oficial_CSHARP
{
    public partial class Consulta_de_Procurados : Form
    {
        BancoDeDados bd = new BancoDeDados();
        string caminhoImagens = @"C:\\imagens\\d";
        int idProcuradoSelecionado = -1; ///

        //BancoDeDados bd = new BancoDeDados();
        //MySqlDataAdapter da;
        //DataTable dt;
        public Consulta_de_Procurados()
        {
            InitializeComponent();
        }

        private void Consulta_de_Procurados_Load(object sender, EventArgs e)
        {
            CarregarPets();
        }
        private void CarregarPets()
        {
            try
            {
                string sql = "SELECT * FROM tb_procurados";
                MySqlCommand cmd = new MySqlCommand(sql, bd.AbrirConexao());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPets.DataSource = dt;
                bd.FecharConexao();
                dgvPets.Columns["id_procurados"].HeaderText = "ID";
                dgvPets.Columns["id_usuario"].HeaderText = "ID USER";
                dgvPets.Columns["nome_p"].HeaderText = "Nome do Pet";
                dgvPets.Columns["raca_p"].HeaderText = "Raça";
                dgvPets.Columns["status_p"].HeaderText = "Status";

                dgvPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                // 🔹 AQUI ESTÁ O NOVO CÓDIGO:
                foreach (DataGridViewRow linha in dgvPets.Rows)
                {
                    if (linha.Cells["status_p"].Value != null)
                    {
                        string status = linha.Cells["status_p"].Value.ToString();

                        if (status == "DESATIVADO")
                        {
                            linha.DefaultCellStyle.BackColor = Color.LightGray;
                            linha.DefaultCellStyle.ForeColor = Color.DarkGray;
                            linha.ReadOnly = true;
                        }
                        else if (status == "ATIVO")
                        {
                            linha.DefaultCellStyle.BackColor = Color.White;
                            linha.DefaultCellStyle.ForeColor = Color.Black;
                            linha.ReadOnly = false;
                        }
                    }
                }
            }



            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar pets: " + ex.Message);
            }
        }

        private void CarregarImagens(int idAdocao)
        {
            try
            {
                string sql = "SELECT * FROM tb_img_procurados WHERE id_procurados = @id";
                MySqlCommand cmd = new MySqlCommand(sql, bd.AbrirConexao());
                cmd.Parameters.AddWithValue("@id", idAdocao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                bd.FecharConexao();

                dgvPetsImg.Rows.Clear();
                dgvPetsImg.Columns.Clear();

                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.HeaderText = "Imagens";
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvPetsImg.Columns.Add(imgCol);

                foreach (DataRow row in dt.Rows)
                {
                    string caminho = row["localizacao"].ToString();
                    if (File.Exists(caminho))
                    {
                        Image img = Image.FromFile(caminho);
                        dgvPetsImg.Rows.Add(img);
                    }
                }

                dgvPetsImg.RowTemplate.Height = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar imagens: " + ex.Message);
            }
        }

        private void dgvPets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idProcuradoSelecionado = Convert.ToInt32(dgvPets.Rows[e.RowIndex].Cells["id_procurados"].Value);
                CarregarImagens(idProcuradoSelecionado);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dgvPets.DataSource;
                foreach (DataRow row in dt.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        string sql = @"UPDATE tb_procurados SET 
                                       nome_pet=@nome_pet, raca=@raca, idade=@idade, 
                                       status_cad_pet=@status WHERE id_procurados=@id";
                        MySqlCommand cmd = new MySqlCommand(sql, bd.AbrirConexao());
                        cmd.Parameters.AddWithValue("@nome_pet", row["nome_pet"]);
                        cmd.Parameters.AddWithValue("@raca", row["raca"]);
                        cmd.Parameters.AddWithValue("@idade", row["idade"]);
                        cmd.Parameters.AddWithValue("@status", row["status_cad_pet"]);
                        cmd.Parameters.AddWithValue("@id", row["id_procurados"]);
                        cmd.Parameters.AddWithValue("@id_usuario", row["id_usuario"]);
                        cmd.ExecuteNonQuery();
                        bd.FecharConexao();
                    }
                }

                MessageBox.Show("Atualização concluída com sucesso!");
                CarregarPets();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvPets.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvPets.SelectedRows[0].Cells["id_procurados"].Value);

                string sql = "UPDATE tb_procurados SET status_cad_pet='DESATIVADO' WHERE id_procurados=@id";
                MySqlCommand cmd = new MySqlCommand(sql, bd.AbrirConexao());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                bd.FecharConexao();

                // Desabilita linha visualmente
                DataGridViewRow linha = dgvPets.SelectedRows[0];
                linha.DefaultCellStyle.BackColor = Color.LightGray;
                linha.DefaultCellStyle.ForeColor = Color.DarkGray;
                linha.ReadOnly = true;

                MessageBox.Show("Cadastro desativado com sucesso!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvPets.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvPets.SelectedRows[0].Cells["id_procurados"].Value);

                string sql = "UPDATE tb_procurados SET status_cad_pet='ATIVO' WHERE id_procurados=@id";
                MySqlCommand cmd = new MySqlCommand(sql, bd.AbrirConexao());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                bd.FecharConexao();

                DataGridViewRow linha = dgvPets.SelectedRows[0];
                linha.DefaultCellStyle.BackColor = Color.White;
                linha.DefaultCellStyle.ForeColor = Color.Black;
                linha.ReadOnly = false;

                MessageBox.Show("Cadastro reabilitado com sucesso!");
            }
        }

        private void btnAdicionarImagens_Click(object sender, EventArgs e)
        {
            if (idProcuradoSelecionado == -1)
            {
                MessageBox.Show("Selecione um pet antes de adicionar imagens.");
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string arquivo in ofd.FileNames)
                {
                    string nomeArquivo = Path.GetFileName(arquivo);
                    string destino = Path.Combine(caminhoImagens, nomeArquivo);
                    File.Copy(arquivo, destino, true);

                    string sql = "INSERT INTO tb_img_procurados (id_procurados , nome_arquivo, localizacao) VALUES (@id, @nome, @local)";
                    MySqlCommand cmd = new MySqlCommand(sql, bd.AbrirConexao());
                    cmd.Parameters.AddWithValue("@id", idProcuradoSelecionado);
                    cmd.Parameters.AddWithValue("@nome", nomeArquivo);
                    cmd.Parameters.AddWithValue("@local", destino);
                    cmd.ExecuteNonQuery();
                    bd.FecharConexao();
                }

                CarregarImagens(idProcuradoSelecionado);
                MessageBox.Show("Imagens adicionadas com sucesso!");
            }
        }

        private void btnRemoverImagens_Click(object sender, EventArgs e)
        {
            if (dgvPetsImg.SelectedRows.Count > 0 && idProcuradoSelecionado != -1)
            {
                int index = dgvPetsImg.SelectedRows[0].Index;

                string sql = "SELECT * FROM tb_img_procurados WHERE id_procurados=@id";
                MySqlCommand cmd = new MySqlCommand(sql, bd.AbrirConexao());
                cmd.Parameters.AddWithValue("@id", idProcuradoSelecionado);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                bd.FecharConexao();

                if (index < dt.Rows.Count)
                {
                    string caminho = dt.Rows[index]["localizacao"].ToString();
                    int idImg = Convert.ToInt32(dt.Rows[index]["id_img_procurados "]);

                    if (index < dgvPetsImg.Rows.Count)
                    {
                        var cell = dgvPetsImg.Rows[index].Cells[0];
                        if (cell.Value is Image img)
                        {
                            cell.Value = null;
                            img.Dispose();
                        }
                    }

                    if (File.Exists(caminho))
                        File.Delete(caminho);

                    string deleteSql = "DELETE FROM tb_img_procurados WHERE id_img_procurados =@idImg";
                    MySqlCommand delCmd = new MySqlCommand(deleteSql, bd.AbrirConexao());
                    delCmd.Parameters.AddWithValue("@idImg", idImg);
                    delCmd.ExecuteNonQuery();
                    bd.FecharConexao();

                    CarregarImagens(idProcuradoSelecionado);
                    MessageBox.Show("Imagem removida com sucesso!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
