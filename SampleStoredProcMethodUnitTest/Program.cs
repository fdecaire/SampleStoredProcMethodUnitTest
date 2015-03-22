using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;
using System.Data;

namespace MainConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var personSelector = new PersonSelector();
			DataSet data= personSelector.ReadNames();

			foreach (DataRow row in data.Tables[0].Rows)
			{
				Console.WriteLine(row["first"].ToString() + " " + row["last"].ToString());
			}

			Console.ReadKey();
		}
	}

	public class PersonSelector
	{
		public DataSet ReadNames()
		{
			using (var db = new ADODatabaseContext("Server=FRANK-PC\\FRANK;Initial Catalog=sampledata;Integrated Security=True"))
			{
				return db.StoredProcedureSelect("sampledata.dbo.ReadPersonNames");
			}
		}
	}
}
