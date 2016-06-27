CREATE PROCEDURE [dbo].[TransUIDSproc]
	@TransactionUid VARCHAR(MAX)
AS
BEGIN
SELECT T.TransactionId, TransactionTypeId, TransactionUID, T.UserId AS TUserId, Total, ProcessingFee, AdditionalFee, T.Created, Completed, Request, Response, AcctNumber, ProcessorType, Custom, CardType, CCExpirationDate, Success, DisputeData, U.UserId, AssociationId, UserKey, CompanyName, FirstName, LastName, Street, City, CountryCode, State, Zip, Phone, Email, Internal, Temporary, U.Created AS UserCreated, ErrorId, ErrorKey, E.TransactionId AS ETransactionId, LongErrorMessage, Errorcode, ShortErrorMessage, Error, StackTrace 
FROM Transactions T 
INNER JOIN Users U ON U.UserId = T.UserId 
LEFT JOIN Errors E ON T.TransactionId = E.TransactionId 
WHERE T.TransactionUID = @TransactionUid
END
GO