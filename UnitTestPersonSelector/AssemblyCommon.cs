using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helpers;
using Data;

namespace UnitTestPersonSelector
{
	[TestClass]
	public class AssemblyCommon
	{
		[AssemblyInitialize]
		public static void ClassStartInitialize(TestContext testContext)
		{
			UnitTestHelpers.Start("storedprocinstance", new string[] { Data.sampledataTables.DatabaseName });

			// create tables
			UnitTestHelpers.CreateAllTables(Data.sampledataTables.TableList, Data.sampledataTables.DatabaseName);
			ReadPersonNames.Instance.CreateStoredProcedure(UnitTestHelpers.InstanceName);
		}

		[AssemblyCleanup]
		public static void ClassEndCleanup()
		{
			UnitTestHelpers.End();
		}
	}
}
