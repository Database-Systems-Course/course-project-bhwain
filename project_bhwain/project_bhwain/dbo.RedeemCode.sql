CREATE PROCEDURE [dbo].[RedeemCode]
	@Code varchar,
	@idCustomer int
AS
	Update Users set Balance = Balance + (SELECT Amount from Codes where Code = @Code) where idCustomers = @idCustomers
	delete from Codes where Code = @Code;
RETURN 0