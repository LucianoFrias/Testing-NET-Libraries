
using Microsoft.Extensions.Logging;
using Testing_NET_Libraries.Entity_Framework.Data;
using Testing_NET_Libraries.Entity_Framework.Models;
using Testing_NET_Libraries.Logger;
using Testing_NET_Libraries.Logger.Models;


// Entity Framework


// Instanciate our client context
var context = new ClientDBContext();

// Add Client
//context.Add(new Client()
//{
//    FirstName = "Diego",
//    LastName = "Maradona",
//    Age = 76
//});

//context.SaveChanges();

// Find Client by Id
Client? foundClient = context.Clients.First(client => client.Id == 12);
Console.WriteLine(foundClient.Id + " " + foundClient.FirstName);

// Delete Client

//context.Remove(foundClient);
//context.SaveChanges();

// Get All Clients

List<Client> clients = context.Clients.ToList();
clients.ForEach(client => Console.WriteLine(client.Id + " " + client.FirstName));

// Logger

ILoggerFactory loggerFactory = new LoggerFactory();
CustomerLogger customerLogger = new(loggerFactory.CreateLogger<CustomerLogger>());

customerLogger.logCustomerData(new Customer()
{
    Id = 50,
    FirstName = "Jose",
    LastName = "Hernandez"
});

