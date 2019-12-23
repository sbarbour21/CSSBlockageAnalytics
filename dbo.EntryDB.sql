CREATE TABLE [dbo].[EntryDB] (
    [id]             INT           IDENTITY (1, 1) NOT NULL,
    [EngineerId]     INT           NOT NULL,
    [TimeStamp]      ROWVERSION    NOT NULL,
    [ServiceRequest] NVARCHAR(50)          NOT NULL,
    [Severity]       NVARCHAR (50) NOT NULL,
    [Block Status]   NVARCHAR (50) NOT NULL,
    [Block Reason]   NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_EntryDB] PRIMARY KEY CLUSTERED ([id] ASC)
);

