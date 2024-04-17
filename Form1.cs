using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contagemEstoque
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Class_X X = new Class_X();
		DataTable DT = new DataTable();

		private void textBox_CODIGO_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((Keys)e.KeyChar == Keys.Enter)
			{
				if (textBox_CODIGO.Text != "")
				{
					textBox_DESCRICAO.Text = this.estoqueTableAdapter.BuscaNome(textBox_CODIGO.Text);

					if (textBox_DESCRICAO.Text == "")
					{
						Form_CadastroRapido FM = new Form_CadastroRapido();
						FM.PROD = textBox_CODIGO.Text;
						FM.ShowDialog();


						textBox_DESCRICAO.Text = this.estoqueTableAdapter.BuscaNome(textBox_CODIGO.Text);

						
						//textBox_DEFEITO.Focus();
					}
					else
					{
						//textBox_DEFEITO.Focus();
					}
				}

				if (checkBox_AUTO.Checked == true)
				{
					button1.Visible = false;
					ADD();

					dataGridView_CONTAGEM.ClearSelection();
					textBox_CODIGO.Focus();

					textBox_CODIGO.Clear();
					textBox_DESCRICAO.Clear();
					tbQuantidade.Text = "1";
				}
				else
				{
					
						button1.Visible = true;
				}

			}
		}

		public void ADD()
		{
			//DT = X.TabelaTXT();
			string A1 = null; string A2 = null; string A3 = null; int I1; int I2;
			if (DT.Rows.Count == 0)
			{
				DataRow DR = DT.NewRow();

				DR["CODIGO"] = textBox_CODIGO.Text;
				DR["NOME"] = textBox_DESCRICAO.Text;
				DR["QUANTIDADE"] = tbQuantidade.Text;
				DT.Rows.Add(DR);
			}
			else
			{
				for (int i = 0; i <= DT.Rows.Count; i++)
				{
					A1 = Convert.ToString(DT.Rows[i]["CODIGO"]);
					A2 = Convert.ToString(textBox_CODIGO.Text);

					if (A1 == A2)
					{
						//DataRow DR = DT.Rows.();

						I1 = Convert.ToInt32(DT.Rows[i]["QUANTIDADE"]);
						I2 = Convert.ToInt32(tbQuantidade.Text);

						A3 = Convert.ToString(I1 + I2);

						DT.Rows[i]["QUANTIDADE"] = A3;

						//DR["QUANTIDADE"] = A3;
						//DT.Rows.InsertAt(DT, i);

						
						//DT.Rows.Add();
						 A1 = null;  A2 = null;  A3 = null;  I1=0;  I2=0;
						break;
					}
					else
					{
						DataRow DR = DT.NewRow();

						DR["CODIGO"] = textBox_CODIGO.Text;
						DR["NOME"] = textBox_DESCRICAO.Text;
						DR["QUANTIDADE"] = tbQuantidade.Text;
						DT.Rows.Add(DR);
					}

				}
			}
			
			dataGridView_CONTAGEM.DataSource = DT;


		}
		private void btnMenos_Click(object sender, EventArgs e)
		{
			string QT = "";
			QT = tbQuantidade.Text;
			int tbQu = 0;
			tbQu = Convert.ToInt32(QT);

			if (tbQu != 1)
			{

				int inc = 0;
				int total = 0;
				int soma = -1;
				string fx = "";

				inc = Convert.ToInt32(tbQuantidade.Text);

				total = inc + soma;

				fx = Convert.ToString(total);

				tbQuantidade.Text = fx;

			}
			else
			{

			}
		}

		private void btnMais_Click(object sender, EventArgs e)
		{
			int inc = 0;
			int total = 0;
			int soma = 1;
			string fx = "";

			inc = Convert.ToInt32(tbQuantidade.Text);
			total = inc + soma;
			fx = Convert.ToString(total);
			tbQuantidade.Text = fx;
		}

		private void estoqueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.estoqueBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.estoqueDataSet);

		}

		private void checkBox_AUTO_CheckedChanged(object sender, EventArgs e)
		{
			//if (checkBox_AUTO.Checked == true)
			//{
			//	button1.Visible = true;
			//}
			//else
			//{
			//	button1.Visible = false;
			//}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ADD();

			dataGridView_CONTAGEM.ClearSelection();
			textBox_CODIGO.Focus();

			textBox_CODIGO.Clear();
			textBox_DESCRICAO.Clear();
			tbQuantidade.Text = "1";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			DT = X.TabelaTXT();
			dataGridView_CONTAGEM.DataSource = DT;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DT = X.TabelaTXT();
			//DT.();
		}
	}
}
