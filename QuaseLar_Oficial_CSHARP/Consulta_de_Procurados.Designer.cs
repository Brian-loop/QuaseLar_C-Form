namespace QuaseLar_Oficial_CSHARP
{
    partial class Consulta_de_Procurados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRemoverImagens = new System.Windows.Forms.Button();
            this.btnAdicionarImagens = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPetsImg = new System.Windows.Forms.DataGridView();
            this.dgvPets = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetsImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoverImagens
            // 
            this.btnRemoverImagens.Location = new System.Drawing.Point(1751, 366);
            this.btnRemoverImagens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoverImagens.Name = "btnRemoverImagens";
            this.btnRemoverImagens.Size = new System.Drawing.Size(95, 65);
            this.btnRemoverImagens.TabIndex = 13;
            this.btnRemoverImagens.Text = "Remover imagens";
            this.btnRemoverImagens.UseVisualStyleBackColor = true;
            this.btnRemoverImagens.Click += new System.EventHandler(this.btnRemoverImagens_Click);
            // 
            // btnAdicionarImagens
            // 
            this.btnAdicionarImagens.Location = new System.Drawing.Point(1751, 299);
            this.btnAdicionarImagens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionarImagens.Name = "btnAdicionarImagens";
            this.btnAdicionarImagens.Size = new System.Drawing.Size(95, 62);
            this.btnAdicionarImagens.TabIndex = 12;
            this.btnAdicionarImagens.Text = "Adicionar Imagens";
            this.btnAdicionarImagens.UseVisualStyleBackColor = true;
            this.btnAdicionarImagens.Click += new System.EventHandler(this.btnAdicionarImagens_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1751, 233);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 62);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reabilitar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1751, 700);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 62);
            this.button3.TabIndex = 10;
            this.button3.Text = "Fechar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(1751, 164);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 62);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(1751, 96);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 62);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvPetsImg);
            this.panel1.Controls.Add(this.dgvPets);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(36, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1695, 728);
            this.panel1.TabIndex = 7;
            // 
            // dgvPetsImg
            // 
            this.dgvPetsImg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPetsImg.Location = new System.Drawing.Point(949, 62);
            this.dgvPetsImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPetsImg.Name = "dgvPetsImg";
            this.dgvPetsImg.RowHeadersWidth = 51;
            this.dgvPetsImg.RowTemplate.Height = 24;
            this.dgvPetsImg.Size = new System.Drawing.Size(723, 647);
            this.dgvPetsImg.TabIndex = 2;
            // 
            // dgvPets
            // 
            this.dgvPets.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgvPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPets.Location = new System.Drawing.Point(23, 62);
            this.dgvPets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPets.Name = "dgvPets";
            this.dgvPets.RowHeadersWidth = 51;
            this.dgvPets.RowTemplate.Height = 24;
            this.dgvPets.Size = new System.Drawing.Size(895, 647);
            this.dgvPets.TabIndex = 1;
            this.dgvPets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPets_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de animais desaparecidos";
            // 
            // Consulta_de_Procurados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1885, 798);
            this.Controls.Add(this.btnRemoverImagens);
            this.Controls.Add(this.btnAdicionarImagens);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Consulta_de_Procurados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta_de_Procurados";
            this.Load += new System.EventHandler(this.Consulta_de_Procurados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetsImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemoverImagens;
        private System.Windows.Forms.Button btnAdicionarImagens;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPetsImg;
        private System.Windows.Forms.DataGridView dgvPets;
        private System.Windows.Forms.Label label1;
    }
}