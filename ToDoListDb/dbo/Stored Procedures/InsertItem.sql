CREATE PROCEDURE [dbo].[InsertItem]
    @description VARCHAR(500)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[Items]
			   ([Description])
		 VALUES
			   (@description)

    SELECT Id = SCOPE_IDENTITY()

END
