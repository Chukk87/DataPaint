--Gets the Data input details

CREATE PROCEDURE [App].[GetDataInputTable]

AS
BEGIN
    SELECT Id, InputName, OwnerGroupId, ExtractionTypeId, DataTypeId, [Location], SheetsId
    FROM App.DataInput
END;