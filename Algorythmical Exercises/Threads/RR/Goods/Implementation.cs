using System;
using System.Data.SqlClient;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace Goods
{
    partial class Program
    {
        public static async void MainMethodAsync (string command, string shopId, string url)
        {
            if (command == "save")
                await SetDataToDbAsync(shopId, url);
            else if (command == "print")
                PrintDataAsCSVFromDbAsync(shopId);            
        }

        public static async Task SetDataToDbAsync (string shopId, string url)
        {
            var content = new HttpResponseMessage();
            using (HttpClient client = new HttpClient())
            {
                content = await client.GetAsync(url);                
            }
            
            string xml = content.Content.ToString();

            RunProcedure(xml, shopId);
        }

        public static void PrintDataAsCSVFromDbAsync(string shopId)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var goods = db.Goods.ToList();
                StringBuilder csvDoc = new StringBuilder();
                string delimiter = ",";
                csvDoc.Append("GoodBarCode,ShopId,GoodName \r\n");
                foreach (Goods u in goods.Where(i=> i.ShopId == null || i.ShopId == shopId))
                {
                    csvDoc.Append(u.GoodBarCode + delimiter +
                                  u.ShopId + delimiter +
                                  u.GoodName + "\r\n");
                }

                Console.WriteLine(csvDoc.ToString());
            }
        }

        public static void RunProcedure (string xml, string shopId)
        {
            string connectionString = @"ConnectionString";
            string sqlExpression = "dbo.AddGoods";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter xmlParam = new SqlParameter
                    {
                        ParameterName = "@XML",
                        Value = xml
                    };
                    command.Parameters.Add(xmlParam);
                    SqlParameter shopID = new SqlParameter
                    {
                        ParameterName = "@ShopID",
                        Value = shopId
                    };
                    command.Parameters.Add(shopID);
                    command.ExecuteReaderAsync();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
