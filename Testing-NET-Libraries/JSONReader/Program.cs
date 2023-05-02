
using System.Text.Json;
using Testing_NET_Libraries.JSONReader.car;
using Testing_NET_Libraries.JSONReader.utils;


List<Car> cars = JSONReader<Car>.readJson(@"../../../JSONReader/datafiles/cars.json");

CarPrinter.printCars(cars);