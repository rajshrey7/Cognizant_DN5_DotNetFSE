BEGIN TRY

    DECLARE @A INT = 100;
    DECLARE @B INT = 0;

    SELECT @A / @B AS Result;

END TRY

BEGIN CATCH

    SELECT
        ERROR_NUMBER() AS ErrorNumber,
        ERROR_SEVERITY() AS ErrorSeverity,
        ERROR_MESSAGE() AS ErrorMessage;

END CATCH;
GO