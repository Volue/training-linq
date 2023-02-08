// See https://aka.ms/new-console-template for more information

using Training.Linq;

var dataRepository = new DataRepository();
var dataProcessor = new DataProcessor();

Console.WriteLine($"Numbers: {dataRepository.TenNumbers.ToSingleString()}");
Console.WriteLine($"Words{dataRepository.TenWords.ToSingleString()}");

var result = dataProcessor.GetNumbersFromRange(dataRepository.TenNumbers, 1, 100);
Console.WriteLine($"Result: {result.ToSingleString()}");

var result2 = dataProcessor.GetWordsLongerThan(dataRepository.TenWords, 4);
Console.WriteLine($"Result: {result2.ToSingleString()}");

var result3 = dataProcessor.GetSquaresAbove(dataRepository.TenNumbers, 20);
Console.WriteLine($"Result: {result3.ToSingleString()}");

var result4 = dataProcessor.GetUniequeWords(dataRepository.TenWords);
Console.WriteLine($"Result: {result4.ToSingleString()}");

var result5 = dataProcessor.GetContainingLetter(dataRepository.TenWords, 'e');
Console.WriteLine($"Result: {result5.ToSingleString()}");

var result6 = dataProcessor.ChangeLetterToLetter(dataRepository.TenWords, 't', 'x');
Console.WriteLine($"Result: {result6.ToSingleString()}");

Console.WriteLine($"Press any key to exit");
Console.ReadKey();

ABC x = new A();

switch (x)
{
    case A:
        break;
    case B:
        break;
}