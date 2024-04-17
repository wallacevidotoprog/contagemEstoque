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
	public partial class Form_CadastroRapido : Form
	{
		public Form_CadastroRapido()
		{
			InitializeComponent();
		}
		public string PROD { get; set; }
		
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((Keys)e.KeyChar == Keys.Enter)
			{
				this.estoqueTableAdapter.INSERT(PROD, textBox1.Text);
				this.Close();
			}
			if ((Keys)e.KeyChar == Keys.Escape)
			{
				this.Close();
			}
		}
	}
}
