CREATE PROCEDURE [dbo].[UpdateItem]
     @id INT,
     @description VARCHAR(500)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[Items]
		SET [Description] = @description
		WHERE [ID] = @id
END
