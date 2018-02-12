USE [todolistdb]
GO

/****** Object:  StoredProcedure [dbo].[GetItemById]    Script Date: 9/9/2017 4:37:20 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetItemById]
	@id int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM [dbo].[Items]
	WHERE ID = @id
END

GO

