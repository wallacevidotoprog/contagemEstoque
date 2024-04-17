namespace contagemEstoque
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox_AUTO = new System.Windows.Forms.CheckBox();
			this.tbQuantidade = new System.Windows.Forms.TextBox();
			this.btnMenos = new System.Windows.Forms.Button();
			this.btnMais = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_DESCRICAO = new System.Windows.Forms.TextBox();
			this.textBox_CODIGO = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView_CONTAGEM = new System.Windows.Forms.DataGridView();
			this.estoqueDataSet = new contagemEstoque.estoqueDataSet();
			this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.estoqueTableAdapter = new contagemEstoque.estoqueDataSetTableAdapters.estoqueTableAdapter();
			this.tableAdapterManager = new contagemEstoque.estoqueDataSetTableAdapters.TableAdapterManager();
			this.contagemfullBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.contagem_fullTableAdapter = new contagemEstoque.estoqueDataSetTableAdapters.contagem_fullTableAdapter();
			this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button2 = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_CONTAGEM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contagemfullBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(986, 43);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
			this.panel2.Controls.Add(this.groupBox2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 43);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(986, 264);
			this.panel2.TabIndex = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.checkBox_AUTO);
			this.groupBox2.Controls.Add(this.tbQuantidade);
			this.groupBox2.Controls.Add(this.btnMenos);
			this.groupBox2.Controls.Add(this.btnMais);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.textBox_DESCRICAO);
			this.groupBox2.Controls.Add(this.textBox_CODIGO);
			this.groupBox2.Location = new System.Drawing.Point(12, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(962, 254);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(776, 195);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(180, 53);
			this.button1.TabIndex = 10;
			this.button1.Text = "LANÇAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox_AUTO
			// 
			this.checkBox_AUTO.AutoSize = true;
			this.checkBox_AUTO.Checked = true;
			this.checkBox_AUTO.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_AUTO.Font = new System.Drawing.Font("Nirmala UI", 25F);
			this.checkBox_AUTO.Location = new System.Drawing.Point(325, 184);
			this.checkBox_AUTO.Name = "checkBox_AUTO";
			this.checkBox_AUTO.Size = new System.Drawing.Size(251, 50);
			this.checkBox_AUTO.TabIndex = 9;
			this.checkBox_AUTO.Text = "AUTOMÁTICO";
			this.checkBox_AUTO.UseVisualStyleBackColor = true;
			this.checkBox_AUTO.CheckedChanged += new System.EventHandler(this.checkBox_AUTO_CheckedChanged);
			// 
			// tbQuantidade
			// 
			this.tbQuantidade.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tbQuantidade.Enabled = false;
			this.tbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.tbQuantidade.Location = new System.Drawing.Point(132, 183);
			this.tbQuantidade.Multiline = true;
			this.tbQuantidade.Name = "tbQuantidade";
			this.tbQuantidade.Size = new System.Drawing.Size(75, 52);
			this.tbQuantidade.TabIndex = 2;
			this.tbQuantidade.Text = "1";
			this.tbQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnMenos
			// 
			this.btnMenos.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenos.Location = new System.Drawing.Point(23, 185);
			this.btnMenos.Name = "btnMenos";
			this.btnMenos.Size = new System.Drawing.Size(97, 54);
			this.btnMenos.TabIndex = 6;
			this.btnMenos.Text = "<<";
			this.btnMenos.UseVisualStyleBackColor = true;
			this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
			// 
			// btnMais
			// 
			this.btnMais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnMais.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMais.Location = new System.Drawing.Point(213, 184);
			this.btnMais.Name = "btnMais";
			this.btnMais.Size = new System.Drawing.Size(97, 54);
			this.btnMais.TabIndex = 8;
			this.btnMais.Text = ">>";
			this.btnMais.UseVisualStyleBackColor = true;
			this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Nirmala UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(334, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(205, 46);
			this.label3.TabIndex = 4;
			this.label3.Text = "DESCRIÇÃO:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Nirmala UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(15, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(235, 46);
			this.label4.TabIndex = 4;
			this.label4.Text = "QUANTIDADE:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Nirmala UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(155, 46);
			this.label2.TabIndex = 4;
			this.label2.Text = "CÓDIGO:";
			// 
			// textBox_DESCRICAO
			// 
			this.textBox_DESCRICAO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_DESCRICAO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBox_DESCRICAO.Enabled = false;
			this.textBox_DESCRICAO.Font = new System.Drawing.Font("Nirmala UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_DESCRICAO.Location = new System.Drawing.Point(334, 66);
			this.textBox_DESCRICAO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox_DESCRICAO.Name = "textBox_DESCRICAO";
			this.textBox_DESCRICAO.Size = new System.Drawing.Size(622, 52);
			this.textBox_DESCRICAO.TabIndex = 1;
			this.textBox_DESCRICAO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_CODIGO
			// 
			this.textBox_CODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBox_CODIGO.Font = new System.Drawing.Font("Nirmala UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_CODIGO.Location = new System.Drawing.Point(14, 66);
			this.textBox_CODIGO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox_CODIGO.Name = "textBox_CODIGO";
			this.textBox_CODIGO.Size = new System.Drawing.Size(314, 52);
			this.textBox_CODIGO.TabIndex = 0;
			this.textBox_CODIGO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox_CODIGO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CODIGO_KeyPress);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
			this.groupBox1.Controls.Add(this.dataGridView_CONTAGEM);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 307);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(986, 220);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// dataGridView_CONTAGEM
			// 
			this.dataGridView_CONTAGEM.AllowDrop = true;
			this.dataGridView_CONTAGEM.AllowUserToAddRows = false;
			this.dataGridView_CONTAGEM.AllowUserToDeleteRows = false;
			this.dataGridView_CONTAGEM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_CONTAGEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_CONTAGEM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOME,
            this.QUANTIDADE});
			this.dataGridView_CONTAGEM.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_CONTAGEM.Location = new System.Drawing.Point(3, 16);
			this.dataGridView_CONTAGEM.MultiSelect = false;
			this.dataGridView_CONTAGEM.Name = "dataGridView_CONTAGEM";
			this.dataGridView_CONTAGEM.RowHeadersVisible = false;
			this.dataGridView_CONTAGEM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_CONTAGEM.Size = new System.Drawing.Size(980, 201);
			this.dataGridView_CONTAGEM.TabIndex = 0;
			// 
			// estoqueDataSet
			// 
			this.estoqueDataSet.DataSetName = "estoqueDataSet";
			this.estoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// estoqueBindingSource
			// 
			this.estoqueBindingSource.DataMember = "estoque";
			this.estoqueBindingSource.DataSource = this.estoqueDataSet;
			// 
			// estoqueTableAdapter
			// 
			this.estoqueTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.contagem_fullTableAdapter = null;
			this.tableAdapterManager.contagem_shortTableAdapter = null;
			this.tableAdapterManager.estoqueTableAdapter = this.estoqueTableAdapter;
			this.tableAdapterManager.UpdateOrder = contagemEstoque.estoqueDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// contagemfullBindingSource
			// 
			this.contagemfullBindingSource.DataMember = "contagem_full";
			this.contagemfullBindingSource.DataSource = this.estoqueDataSet;
			// 
			// contagem_fullTableAdapter
			// 
			this.contagem_fullTableAdapter.ClearBeforeFill = true;
			// 
			// CODIGO
			// 
			this.CODIGO.DataPropertyName = "CODIGO";
			this.CODIGO.HeaderText = "CÓDIGO";
			this.CODIGO.Name = "CODIGO";
			// 
			// NOME
			// 
			this.NOME.DataPropertyName = "NOME";
			this.NOME.HeaderText = "NOME";
			this.NOME.Name = "NOME";
			// 
			// QUANTIDADE
			// 
			this.QUANTIDADE.DataPropertyName = "QUANTIDADE";
			this.QUANTIDADE.HeaderText = "QUANTIDADE";
			this.QUANTIDADE.Name = "QUANTIDADE";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(656, 158);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(986, 527);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_CONTAGEM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contagemfullBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView_CONTAGEM;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBox_AUTO;
		private System.Windows.Forms.TextBox tbQuantidade;
		private System.Windows.Forms.Button btnMenos;
		private System.Windows.Forms.Button btnMais;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_DESCRICAO;
		private System.Windows.Forms.TextBox textBox_CODIGO;
		private estoqueDataSet estoqueDataSet;
		private System.Windows.Forms.BindingSource estoqueBindingSource;
		private estoqueDataSetTableAdapters.estoqueTableAdapter estoqueTableAdapter;
		private estoqueDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.BindingSource contagemfullBindingSource;
		private estoqueDataSetTableAdapters.contagem_fullTableAdapter contagem_fullTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
		private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
		private System.Windows.Forms.Button button2;
	}
}

