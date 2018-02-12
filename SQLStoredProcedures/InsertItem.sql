USE [todolistdb]
GO

/****** Object:  StoredProcedure [dbo].[InsertItem]    Script Date: 9/9/2017 4:37:41 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertItem]
    @id int,
    @description varchar(500)

AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[Items]
			   ([ID],
			    [Description])
		 VALUES
			   (@id,
			   @description)
END

GO

