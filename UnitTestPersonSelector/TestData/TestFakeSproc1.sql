USE [sampledata]
GO

IF exists (SELECT * FROM sys.objects WHERE name = N'ReadPersonNames' AND type = N'P') 
BEGIN
	DROP PROCEDURE ReadPersonNames
END
GO

CREATE PROCEDURE [dbo].[ReadPersonNames]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		'Lisa' AS first, 
		'Smith' AS last 
	WHERE
		1 = 1
END
GO
