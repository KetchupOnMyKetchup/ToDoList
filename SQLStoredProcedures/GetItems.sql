USE [todolistdb]
GO

/****** Object:  StoredProcedure [dbo].[GetItems]    Script Date: 9/9/2017 4:37:29 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetItems]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM [dbo].[Items]
END

GO

