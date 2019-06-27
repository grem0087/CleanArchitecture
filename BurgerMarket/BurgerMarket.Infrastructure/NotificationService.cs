using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using BurgerMarket.Application.Interfaces;
using BurgerMarket.Application.Notifications.Models;
using System.Threading.Tasks;
using Confluent.Kafka;
using Confluent.Kafka.Serialization;
using Message = BurgerMarket.Application.Notifications.Models.Message;

namespace BurgerMarket.Infrastructure
{
    public class NotificationService : INotificationService
    {
        private readonly Producer<Null, string> _producer;
        private Consumer<Null, string> _consumer;

        private readonly IDictionary<string, object> _producerConfig;

        public NotificationService(string host)
        {
            _producerConfig = new Dictionary<string, object> {{"bootstrap.servers", host}};

            _producer = new Producer<Null, string>(_producerConfig, null, new StringSerializer(Encoding.UTF8));
        }

        public async Task SendAsync(Message message)
        {
            await _producer.ProduceAsync(message.To, null, message.Body);
        }
    }
}