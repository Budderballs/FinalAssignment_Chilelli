USE [CustomerData]
GO

/****** Object:  StoredProcedure [dbo].[updateCusts]    Script Date: 3/13/2021 1:16:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[updateCusts]
@firstName nvarchar(30),
@id int
as
begin
update Customers set Firstname = @firstName where CustomerID = @id
end
GO