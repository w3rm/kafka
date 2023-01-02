using Confluent.Kafka;

class Program
{
    public static async Task Main(string[] args)
    {
        //await Services.Kafka.Producer.Produce("quickstart", "mensagem 2");

        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "foo",
            AutoOffsetReset = AutoOffsetReset.Earliest,
            EnableAutoCommit = false,
            BrokerAddressFamily = BrokerAddressFamily.V4
        };

        const string topic = "quickstart";

        var consumer = new Services.Kafka.Consumer();
        consumer.Consume(
            config,
            topic
            );

    }
}
