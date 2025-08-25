using Confluent.Kafka;

namespace connectOracleDBTest.Services;

public interface IProducerService
{
    Task<DeliveryResult<int, string>> ProducerKafka<T>(string topic, int key, T message);
}
