USE [art]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[PutChain]
		@idU = 1,
		@kStep = 10,
		@kAct = 5

SELECT	'Return Value' = @return_value

GO
