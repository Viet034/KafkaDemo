using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confluent.Kafka;

namespace Kafka_demo_1;

class ConsumerApp
{
    public static async Task Main(string[] args)
    {
        try
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "demo-topic",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };
            using var consumer = new ConsumerBuilder<string, string>(config).Build();
            consumer.Subscribe("demo-topic");
            Console.WriteLine("Consumer is listening......");
            while (true)
            {
                var consumerResult = consumer.Consume(CancellationToken.None);
                Console.WriteLine($"Consumer: {consumerResult.Partition}, Offset: {consumerResult.Offset} ");
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error: ", ex);
        }


    }
}
