using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncStreams
{
    public class Order
    {
        public int Id { get; set; }
    }
    
    public class OrderFactory
    {
        public async IAsyncEnumerable<Order> MakeOrdersAsync(int count)
        {
            for (var i = 0; i < count; i++)
            {
                await Task.Delay(1000);
                yield return new Order { Id = i + 1 };
            }
        }
    }
}
