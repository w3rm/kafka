using Confluent.Kafka;

namespace Services.Kadka 
{

public static class KafkaProducer
{

    public static async Task Produce(string topic, string message)
    {
        Console.WriteLine("producing message {0}", message);
        try
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092",

            };

            using (var producer = new ProducerBuilder<Null, string>(config).Build())
            {
                var result = await producer.ProduceAsync(topic, new Message<Null, string> { Value = message });

            }

        }
        catch (Exception e)
        {
            Console.WriteLine("error {0}", e.Message);
        }

    }

}

}
