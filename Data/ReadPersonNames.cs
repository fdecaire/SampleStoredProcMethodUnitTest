using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace Data
{
	public partial class ReadPersonNames : StoredProc
	{
		private static StoredProc _instance;
		public static StoredProc Instance
		{
			get { return _instance ?? (_instance = new ReadPersonNames()); }
		}
		override public string Name
		{
			get { return "ReadPersonNames"; }
		}
		override public string Database { get { return "sampledata"; } }
		override public string Code
		{
			get
			{
				return @"USE [sampledata]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO 
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE ReadPersonNames

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT first, last FROM person
END
";
			}
		}
	}
}
