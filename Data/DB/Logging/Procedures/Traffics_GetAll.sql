/**
 * Copyright (C) moniüs, 2013.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

CREATE PROCEDURE [Logging].[Traffics_GetAll] 
	@ClientIP nvarchar(64), 
	@ClientOS nvarchar(64)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM [Logging].[Traffics] WHERE (([ClientIP] = @ClientIP) AND ([ClientOS] = @ClientOS))
END
GO