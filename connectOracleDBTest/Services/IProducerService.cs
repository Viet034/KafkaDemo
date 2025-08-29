using Confluent.Kafka;

namespace connectOracleDBTest.Services;

public interface IProducerService
{
    Task<DeliveryResult<string, string>> ProducerKafka<T>(string topic, string key, T message);
}
