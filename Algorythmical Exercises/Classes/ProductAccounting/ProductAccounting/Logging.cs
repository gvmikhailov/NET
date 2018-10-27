using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccounting
{
    class Logging
    {
        internal static List<Logging> log = new List<Logging>();

        public int OperationId { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public string Operation { get; set; }
        public string State { get; set; }
        public string Message { get; set; }

        internal Logging (int operationId, string product, int quantity, string operation, string state, string message)
        {
            OperationId = operationId;
            Product = product;
            Quantity = quantity;
            Operation = operation;
            State = state;
            Message = message;
        }

        internal Logging(int operationId, string operation, string state, string message)
        {
            OperationId = operationId;
            Operation = operation;
            State = state;
            Message = message;
        }

        internal static void ShowLogging()
        {
            foreach (Logging m in log)
            {
                Console.WriteLine(m.OperationId + " " + m.Product + " " + m.Quantity + " " + m.Operation + " " + m.State + " " + m.Message);
            }
        }
    }
}
