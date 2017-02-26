using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AzureServiceBusQueuesDemo
{
    class Program
    {        
        public static void Main(string[] args)
        {
            string connectionString = ConfigurationSettings.AppSettings.Get("ServiceBusConnectionString");
            string queueName = ConfigurationSettings.AppSettings.Get("QueueName");
            var client = QueueClient.CreateFromConnectionString(connectionString, queueName);
            var message = "This is a test message 1!";
            //Send(message, client);
            Receive(client);
        }

        private static void Send(string message, QueueClient client)
        {                        
            var brokeredMessage = new BrokeredMessage(message);
            client.Send(brokeredMessage);
            Console.WriteLine("Message is successfully sent!");
        }

        private static void Receive(QueueClient client)
        {
            client.OnMessage(message =>
            {
                Console.WriteLine(String.Format("Message body: {0}", message.GetBody<String>()));
                Console.WriteLine(String.Format("Message id: {0}", message.MessageId));
            });

            Console.ReadLine();
        }
    }
}
