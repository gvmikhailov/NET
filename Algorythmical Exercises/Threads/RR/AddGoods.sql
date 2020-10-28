use Test
go

create procedure dbo.AddGoods
   @XML     xml
  ,@ShopID  varchar(256)
as
begin
  declare @AllGoods	table (
     [GoodBarCode]  bigint        not null
    ,[ShopId]       varchar(256)  not null
    ,[GoodName]     varchar(8000) not null
  )

  insert into @AllGoods (
     [GoodBarCode]
    ,[ShopId]
    ,[GoodName]
  )
  select distinct
       f.value('@barcode','bigint')                                                 as [GoodBarCode]
      ,@ShopID                                                                      as [ShopId]
      ,concat(f.value('@author','varchar(512)'), f.value('@name','varchar(7424)'))  as [GoodName]
    from @XML.nodes('offers/offer') as t(f)

  -----------------------------
  begin tran Update_Data
  ----------------------------- 
    merge dbo.Good as trg
      using (
        select
             g.[GoodBarCode]
            ,g.[ShopId]
            ,g.[GoodName]
          from @AllGoods as g
        ) as src on src.[GoodBarCode] = trg.[GoodBarCode]
                and src.[ShopId] = trg.[ShopId]
   
    when matched and src.[GoodName] <> trg.[GoodName] then
      update set
          trg.[GoodName] = src.[GoodName]
    when not matched then 
      insert (
         [GoodBarCode]
        ,[ShopId]
        ,[GoodName]
      ) values (
         src.[GoodBarCode]
        ,src.[ShopId]
        ,src.[GoodName]
      )
    when not matched by source then
      delete
    ;
    
  -----------------------------
  commit tran Update_Data
  ----------------------------- 

end
go