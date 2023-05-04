
using System;
using System.Collections;
using System.Text.Json;
using Testing_NET_Libraries.Entity_Framework.Data;
using Testing_NET_Libraries.Entity_Framework.Models;
using Testing_NET_Libraries.JSON.utils;
using Testing_NET_Libraries.JSONReader.car;
using Testing_NET_Libraries.JSONReader.utils;
using Testing_NET_Libraries.LINQ;

// JSON

List<Car> cars = JSONReader<Car>.readJson(@"../../../JSON/datafiles/cars.json");

//JSONWriter<Car>.writeJSONToFile(@"../../../JSON/datafiles/cars.json", new(5, "Corolla", "Toyota"));

CarPrinter.printCars(cars);

// LINQ

List<int> scores = new() { 22, 58, 56, 50, 100, 86, 33 };
List<int> secondScores = new() { 58, 25, 100 };

LINQScoresOperations linqScoresOperations = new()
{
    Scores = scores,
    SecondaryScores = secondScores
};

List<int>? scoresGreatherThanFifty = linqScoresOperations.getScoresGreatherThanFifty();
linqScoresOperations.checkListContents(scoresGreatherThanFifty);

List<int>? sameNumbers = linqScoresOperations.compareSameNumbers();
linqScoresOperations.checkListContents(sameNumbers);

List<int>? numbersAscending = linqScoresOperations.orderNumbersAsc();
linqScoresOperations.checkListContents(numbersAscending);

List<int>? numbersDescending = linqScoresOperations.orderNumbersDesc();
linqScoresOperations.checkListContents(numbersDescending);

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



