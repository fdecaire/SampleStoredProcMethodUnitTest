using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helpers;
using MainConsoleApp;
using System.Data;
using Data;

namespace UnitTestPersonSelector
{
	[TestClass]
	public class UnitTest1
	{
		[TestCleanup]
		public void Cleanup()
		{
			UnitTestHelpers.TruncateData();
		}

		[TestMethod]
		public void TestMethod1()
		{
			// moved this to here so the fake stored procedures don't break this unit test
			ReadPersonNames.Instance.CreateStoredProcedure(UnitTestHelpers.InstanceName);

			using (var db = new ADODatabaseContext("TEST","sampledata"))
			{
				db.ExecuteNonQuery("INSERT INTO person (first,last) VALUES ('Mary','Jane')");
				db.ExecuteNonQuery("INSERT INTO person (first,last) VALUES ('Joe','Cool')");
			}

			var personSelector = new PersonSelector();
			DataSet data = personSelector.ReadNames();

			Assert.AreEqual(2, data.Tables[0].Rows.Count);
		}

		[TestMethod]
		public void TestFakeSproc1()
		{
			UnitTestHelpers.ExecuteSQLCode("UnitTestPersonSelector.TestData.TestFakeSproc1.sql");

			var personSelector = new PersonSelector();
			DataSet data = personSelector.ReadNames();

			Assert.AreEqual(1, data.Tables[0].Rows.Count);
			Assert.AreEqual("Lisa", data.Tables[0].Rows[0]["first"].ToString());
		}

		[TestMethod]
		public void TestFakeSproc2()
		{
			UnitTestHelpers.ExecuteSQLCode("UnitTestPersonSelector.TestData.TestFakeSproc2.sql");

			var personSelector = new PersonSelector();
			DataSet data = personSelector.ReadNames();

			Assert.AreEqual(3, data.Tables[0].Rows.Count);
		}
	}
}
