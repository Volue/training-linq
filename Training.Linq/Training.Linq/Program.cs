// See https://aka.ms/new-console-template for more information

using Training.Linq;

var dataRepository = new DataRepository();
var dataProcessor = new DataProcessor();

Console.WriteLine($"Numbers: {dataRepository.TenNumbers.ToSingleString()}");
Console.WriteLine($"Words{dataRepository.TenWords.ToSingleString()}");

var result = dataProcessor.GetNumbersFromRange(dataRepository.TenNumbers, 1, 100);
Console.WriteLine($"Result: {result.ToSingleString()}");

Console.WriteLine($"Press any key to exit");
Console.ReadKey();