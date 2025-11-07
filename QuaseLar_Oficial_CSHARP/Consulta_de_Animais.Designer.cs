namespace QuaseLar_Oficial_CSHARP
{
    partial class Consulta_de_Animais
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPetsImg = new System.Windows.Forms.DataGridView();
            this.dgvPets = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdicionarImagens = new System.Windows.Forms.Button();
            this.btnRemoverImagens = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetsImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvPetsImg);
            this.panel1.Controls.Add(this.dgvPets);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 592);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvPetsImg
            // 
            this.dgvPetsImg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPetsImg.Location = new System.Drawing.Point(712, 50);
            this.dgvPetsImg.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPetsImg.Name = "dgvPetsImg";
            this.dgvPetsImg.RowHeadersWidth = 51;
            this.dgvPetsImg.RowTemplate.Height = 24;
            this.dgvPetsImg.Size = new System.Drawing.Size(542, 526);
            this.dgvPetsImg.TabIndex = 2;
            // 
            // dgvPets
            // 
            this.dgvPets.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPets.Location = new System.Drawing.Point(17, 50);
            this.dgvPets.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPets.Name = "dgvPets";
            this.dgvPets.RowHeadersWidth = 51;
            this.dgvPets.RowTemplate.Height = 24;
            this.dgvPets.Size = new System.Drawing.Size(671, 526);
            this.dgvPets.TabIndex = 1;
            this.dgvPets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPets_CellClick);
            this.dgvPets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPets_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de cadastro de animais em adoção";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(1295, 60);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 50);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(1295, 115);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 50);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1295, 551);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Fechar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1295, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reabilitar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdicionarImagens
            // 
            this.btnAdicionarImagens.Location = new System.Drawing.Point(1295, 225);
            this.btnAdicionarImagens.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarImagens.Name = "btnAdicionarImagens";
            this.btnAdicionarImagens.Size = new System.Drawing.Size(71, 50);
            this.btnAdicionarImagens.TabIndex = 5;
            this.btnAdicionarImagens.Text = "Adicionar Imagens";
            this.btnAdicionarImagens.UseVisualStyleBackColor = true;
            this.btnAdicionarImagens.Click += new System.EventHandler(this.btnAdicionarImagens_Click);
            // 
            // btnRemoverImagens
            // 
            this.btnRemoverImagens.Location = new System.Drawing.Point(1295, 279);
            this.btnRemoverImagens.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoverImagens.Name = "btnRemoverImagens";
            this.btnRemoverImagens.Size = new System.Drawing.Size(71, 53);
            this.btnRemoverImagens.TabIndex = 6;
            this.btnRemoverImagens.Text = "Remover imagens";
            this.btnRemoverImagens.UseVisualStyleBackColor = true;
            this.btnRemoverImagens.Click += new System.EventHandler(this.btnRemoverImagens_Click);
            // 
            // Consulta_de_Animais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 609);
            this.Controls.Add(this.btnRemoverImagens);
            this.Controls.Add(this.btnAdicionarImagens);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Consulta_de_Animais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta_de_Animais";
            this.Load += new System.EventHandler(this.Consulta_de_Animais_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetsImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPetsImg;
        private System.Windows.Forms.Button btnAdicionarImagens;
        private System.Windows.Forms.Button btnRemoverImagens;
    }
}