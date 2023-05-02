
using System.Text.Json;
using Testing_NET_Libraries.JSON.utils;
using Testing_NET_Libraries.JSONReader.car;
using Testing_NET_Libraries.JSONReader.utils;


List<Car> cars = JSONReader<Car>.readJson(@"../../../JSON/datafiles/cars.json");

JSONWriter<Car>.writeJSONToFile(@"../../../JSON/datafiles/cars.json", new(5, "Corolla", "Toyota"));

CarPrinter.printCars(cars);