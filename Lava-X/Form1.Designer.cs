namespace Lava_X
{
    partial class CreateTable
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CadastrarBtn = new System.Windows.Forms.Button();
            this.nomeTbx = new System.Windows.Forms.TextBox();
            this.sobrenomeTbx = new System.Windows.Forms.TextBox();
            this.cpfTbx = new System.Windows.Forms.TextBox();
            this.numeroTbx = new System.Windows.Forms.TextBox();
            this.telefoneTbx = new System.Windows.Forms.TextBox();
            this.enderecoTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Logradouro,
            this.Column5,
            this.Column6,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1110, 440);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sobrenome";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Identidade";
            this.Column3.Name = "Column3";
            // 
            // Logradouro
            // 
            this.Logradouro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Logradouro.HeaderText = "Logradouro";
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.Width = 127;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Número";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Telefone";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cadastro em";
            this.Column4.Name = "Column4";
            // 
            // CadastrarBtn
            // 
            this.CadastrarBtn.Location = new System.Drawing.Point(805, 95);
            this.CadastrarBtn.Name = "CadastrarBtn";
            this.CadastrarBtn.Size = new System.Drawing.Size(90, 32);
            this.CadastrarBtn.TabIndex = 6;
            this.CadastrarBtn.Text = "Cadastrar";
            this.CadastrarBtn.UseVisualStyleBackColor = true;
            this.CadastrarBtn.Click += new System.EventHandler(this.CadastrarBtn_Click);
            // 
            // nomeTbx
            // 
            this.nomeTbx.Location = new System.Drawing.Point(103, 33);
            this.nomeTbx.Name = "nomeTbx";
            this.nomeTbx.Size = new System.Drawing.Size(173, 26);
            this.nomeTbx.TabIndex = 0;
            // 
            // sobrenomeTbx
            // 
            this.sobrenomeTbx.Location = new System.Drawing.Point(400, 35);
            this.sobrenomeTbx.Name = "sobrenomeTbx";
            this.sobrenomeTbx.Size = new System.Drawing.Size(272, 26);
            this.sobrenomeTbx.TabIndex = 1;
            // 
            // cpfTbx
            // 
            this.cpfTbx.Location = new System.Drawing.Point(743, 38);
            this.cpfTbx.Name = "cpfTbx";
            this.cpfTbx.Size = new System.Drawing.Size(152, 26);
            this.cpfTbx.TabIndex = 2;
            // 
            // numeroTbx
            // 
            this.numeroTbx.Location = new System.Drawing.Point(400, 98);
            this.numeroTbx.Name = "numeroTbx";
            this.numeroTbx.Size = new System.Drawing.Size(100, 26);
            this.numeroTbx.TabIndex = 4;
            // 
            // telefoneTbx
            // 
            this.telefoneTbx.Location = new System.Drawing.Point(605, 101);
            this.telefoneTbx.Name = "telefoneTbx";
            this.telefoneTbx.Size = new System.Drawing.Size(139, 26);
            this.telefoneTbx.TabIndex = 5;
            // 
            // enderecoTbx
            // 
            this.enderecoTbx.Location = new System.Drawing.Point(97, 90);
            this.enderecoTbx.Multiline = true;
            this.enderecoTbx.Name = "enderecoTbx";
            this.enderecoTbx.Size = new System.Drawing.Size(179, 56);
            this.enderecoTbx.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefone";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(944, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(1128, 152);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(306, 164);
            this.listBox1.TabIndex = 16;
            // 
            // CreateTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1593, 604);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enderecoTbx);
            this.Controls.Add(this.telefoneTbx);
            this.Controls.Add(this.numeroTbx);
            this.Controls.Add(this.cpfTbx);
            this.Controls.Add(this.sobrenomeTbx);
            this.Controls.Add(this.nomeTbx);
            this.Controls.Add(this.CadastrarBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CreateTable";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CreateTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CadastrarBtn;
        private System.Windows.Forms.TextBox nomeTbx;
        private System.Windows.Forms.TextBox sobrenomeTbx;
        private System.Windows.Forms.TextBox cpfTbx;
        private System.Windows.Forms.TextBox numeroTbx;
        private System.Windows.Forms.TextBox telefoneTbx;
        private System.Windows.Forms.TextBox enderecoTbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

