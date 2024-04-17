namespace contagemEstoque
{
	partial class Form_CadastroRapido
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
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.estoqueDataSet = new contagemEstoque.estoqueDataSet();
			this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.estoqueTableAdapter = new contagemEstoque.estoqueDataSetTableAdapters.estoqueTableAdapter();
			this.tableAdapterManager = new contagemEstoque.estoqueDataSetTableAdapters.TableAdapterManager();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(742, 85);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "CADASTRO RÁPIDO";
			// 
			// textBox1
			// 
			this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(6, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(730, 53);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
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
			this.tableAdapterManager.estoqueTableAdapter = this.estoqueTableAdapter;
			this.tableAdapterManager.UpdateOrder = contagemEstoque.estoqueDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// Form_CadastroRapido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(774, 108);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form_CadastroRapido";
			this.Text = "Form_CadastroRapido";
			
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private estoqueDataSet estoqueDataSet;
		private System.Windows.Forms.BindingSource estoqueBindingSource;
		private estoqueDataSetTableAdapters.estoqueTableAdapter estoqueTableAdapter;
		private estoqueDataSetTableAdapters.TableAdapterManager tableAdapterManager;
	}
}