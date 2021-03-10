CREATE PROCEDURE [dbo].[spUserLookup]
	@Id nvarchar(128)
AS
Begin
    set nocount on;

	SELECT  ID,FirstName,LastName,EmailAddress,CreatedDate

	FROM [dbo].[User]
	where ID =@Id;
End
