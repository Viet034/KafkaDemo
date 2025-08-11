using Confluent.Kafka;
namespace Kafka_demo;

public class ProducerApp
{
    public static async Task Main(string[] args)
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };

        using var producer = new ProducerBuilder<string, string>(config).Build();

        while (true)
        {
            try 
            {
                Console.WriteLine("Enter key: ");
                var key = Console.ReadLine();
                
                Console.WriteLine("Enter message (exit to out): ");
                var messageValue = Console.ReadLine();
               
                if (key == "exit") break;

                var message = new Message<string, string> {Key = key, Value = messageValue };
                var result = await producer.ProduceAsync("demo-topic", message);
                Console.WriteLine($"Message belongs to Partition: {result.Partition}, Index Offset :{result.Offset}");
            }
            catch (Exception ex)
            {
                throw new Exception("Error");
            }
            
        }
    }
}
