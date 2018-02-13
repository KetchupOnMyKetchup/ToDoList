CREATE PROCEDURE [dbo].[InsertItem]
    @id INT,
    @description VARCHAR(500)
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
