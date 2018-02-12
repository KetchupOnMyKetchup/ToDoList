USE [todolistdb]
GO

/****** Object:  StoredProcedure [dbo].[DeleteItemById]    Script Date: 9/9/2017 4:36:58 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteItemById]
	@id int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM [dbo].[Items]
	WHERE ID = @id
END

GO

