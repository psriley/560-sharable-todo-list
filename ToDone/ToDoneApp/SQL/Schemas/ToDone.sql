IF NOT EXISTS
(
	SELECT *
	FROM sys.schemas s
	WHERE s.[name] = N'ToDone'
)
BEGIN
	EXEC(N'CREATE SCHEMA [ToDone] AUTHORIZATION [dbo]');
END;