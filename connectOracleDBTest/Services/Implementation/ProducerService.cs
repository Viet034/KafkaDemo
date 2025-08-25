using Confluent.Kafka;
namespace connectOracleDBTest.Services.Implementation;

public class ProducerService : IProducerService
{
    private readonly IProducer<int, string> _producer;

    public ProducerService(IProducer<int, string> producer)
    {
        _producer = producer;
    }

    public ProducerService(IConfiguration config)
    {
        var configs = new ProducerConfig
        {
            BootstrapServers = config["Kafka:BootstrapServers"]
        };
         _producer = new ProducerBuilder<int, string>(configs).Build();
    }
    public async Task<DeliveryResult<int, string>> ProducerKafka<T>(string topic, int key, T message)
    {
        try
        {
            var value = System.Text.Json.JsonSerializer.Serialize(message);
            var result = await _producer.ProduceAsync(topic, new Message<int, string>
            {
                Key = key,
                Value = value
            });

            Console.WriteLine(result.TopicPartitionOffset.Partition);
            Console.WriteLine(result.TopicPartitionOffset.Offset);
            
          
            return result;
        }
        catch (Exception ex)
        {
            throw new Exception("Error");
        }
        
    }

    
}

