
using System.Collections;
using System.Text.Json;
using Testing_NET_Libraries.JSON.utils;
using Testing_NET_Libraries.JSONReader.car;
using Testing_NET_Libraries.JSONReader.utils;

// JSON

List<Car> cars = JSONReader<Car>.readJson(@"../../../JSON/datafiles/cars.json");

//JSONWriter<Car>.writeJSONToFile(@"../../../JSON/datafiles/cars.json", new(5, "Corolla", "Toyota"));

CarPrinter.printCars(cars);

// LINQ

List<int> scores = new List<int>() { 22, 58, 56, 50, 100, 86, 33 };
List<int> secondScores = new List<int>() { 58, 25, 100 };

IEnumerable<int> scoresGreaterThanFifty =
    from score in scores
     where score > 50
     select score;

scoresGreaterThanFifty.ToList().ForEach(score => Console.WriteLine(score));

IEnumerable<int> compareSameNumbers =
    from score in scores
    join secondScore in secondScores
    on score equals secondScore
    select score;

compareSameNumbers.ToList().ForEach((score) => Console.WriteLine(score + "\n"));

IEnumerable<int> orderScoresAsc =
    from score in scores
    orderby score ascending
    select score;


orderScoresAsc.ToList().ForEach(score => Console.WriteLine(score));

IEnumerable<int> orderScoresDesc =
    from score in scores
    orderby score descending
    select score;

orderScoresDesc.ToList().ForEach(score => Console.WriteLine(score));

