USE [todolistdb]
GO

/****** Object:  StoredProcedure [dbo].[UpdateItem]    Script Date: 9/9/2017 4:37:48 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateItem]
     @id int,
     @description varchar(500)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[Items]
		SET [Description] = @description
		WHERE [ID] = @id
END

GO

