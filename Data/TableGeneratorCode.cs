using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace Data
{
	public partial class sampledataTables
	{
		public static string DatabaseName
		{
			get
			{
				return "sampledata";
			}
		}

		public static List<TableDefinition> TableList = new List<TableDefinition> {
			new TableDefinition {Name="person", CreateScript="CREATE TABLE [dbo].[person]([id][int] IDENTITY(1,1) NOT NULL,[first][varchar](50),[last][varchar](50), CONSTRAINT [PK_person] PRIMARY KEY CLUSTERED ([id] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"},
		};
	}
}
