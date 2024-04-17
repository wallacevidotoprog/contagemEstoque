using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contagemEstoque
{
	public class Class_X
	{
		public DataTable TabelaTXT()
		{
			DataTable DTTXT = new DataTable();
			DTTXT.Columns.Add("CODIGO", typeof(string));
			DTTXT.Columns.Add("NOME", typeof(string));
			DTTXT.Columns.Add("QUANTIDADE", typeof(string));

			//DTTXT.Columns["CODIGO"].Unique = true;
			//DTTXT.PrimaryKey = new DataColumn[] { DTTXT.Columns["CODIGO"] };
			return DTTXT;
		}
	}
}
