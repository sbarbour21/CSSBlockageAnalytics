CREATE PROCEDURE dbo.spEntry_Insert
	@EngineerId int,
	@TimeStamp nvarchar(50),
	@ServiceRequest money,
	@Severity float,
	@id int = 0 output,
	@BlockStatus nvarchar(50),
	@BlockReason nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.EntryDB(EngineerId, ServiceRequest, Severity, [Block Reason], [Block Status])
	values (@EngineerId, @ServiceRequest, @Severity, @BlockReason, @BlockStatus);

	select @id = SCOPE_IDENTITY();

END