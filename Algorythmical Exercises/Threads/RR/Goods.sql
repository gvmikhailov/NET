use Test
go

create table dbo.Good (
	 [GoodBarCode]		bigint					not null
	,[ShopId]					varchar(256)		not null
	,[GoodName]				varchar(8000)		not null
	,primary key clustered([GoodBarCode], [ShopId])
)
go