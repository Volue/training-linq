// See https://aka.ms/new-console-template for more information

using Training.Linq;

var dataRepository = new DataRepository();
var dataProcessor = new DataProcessor();

Console.WriteLine($"Consecutive Numbers: {dataRepository.TenConsecutiveNumbers.ToSingleString()}");
Console.WriteLine($"Numbers: {dataRepository.TenNumbers.ToSingleString()}");
Console.WriteLine($"Words: {dataRepository.TenWords.ToSingleString()}");
Console.WriteLine($"Two Letter Words: {dataRepository.TwoLetterWords.ToSingleString()}");
Console.WriteLine($"Mixed Words and Numbers: {dataRepository.NumbersAndWordsMixed.ToSingleString()}");
Console.WriteLine();

var result = dataProcessor.GetNumbersFromRange(dataRepository.TenNumbers, 1, 100);
Console.WriteLine($"{nameof(dataProcessor.GetNumbersFromRange)} Result: {result.ToSingleString()}");

var result2 = dataProcessor.GetWordsLongerThan(dataRepository.TenWords, 4);
Console.WriteLine($"{nameof(dataProcessor.GetWordsLongerThan)} Result: {result2.ToSingleString()}");

var result3 = dataProcessor.GetSquaresAbove(dataRepository.TenNumbers, 20);
Console.WriteLine($"{nameof(dataProcessor.GetSquaresAbove)} Result: {result3.ToSingleString()}");

var result4 = dataProcessor.GetUniequeWords(dataRepository.TenWords);
Console.WriteLine($"{nameof(dataProcessor.GetUniequeWords)} Result: {result4.ToSingleString()}");

var result5 = dataProcessor.GetContainingLetter(dataRepository.TenWords, 'e');
Console.WriteLine($"{nameof(dataProcessor.GetContainingLetter)} Result: {result5.ToSingleString()}");

var result6 = dataProcessor.ChangeLetterToLetter(dataRepository.TenWords, 't', 'x');
Console.WriteLine($"{nameof(dataProcessor.ChangeLetterToLetter)} Result: {result6.ToSingleString()}");

var result7 = dataProcessor.ShuffleNumbers(dataRepository.TenConsecutiveNumbers);
Console.WriteLine($"{nameof(dataProcessor.ShuffleNumbers)} Result: {result7.ToSingleString()}");

var result8 = dataProcessor.GetCharacterFrequency(dataRepository.TenWords);
Console.WriteLine($"{nameof(dataProcessor.GetCharacterFrequency)} Result: {result8.ToSingleString()}");

var result9 = dataProcessor.GetMostFrequentCharacter(dataRepository.TenWords);
Console.WriteLine($"{nameof(dataProcessor.GetMostFrequentCharacter)} Result: {result9}");

var result10 = dataProcessor.GetUniqueValues(dataRepository.TenWords);
Console.WriteLine($"{nameof(dataProcessor.GetUniqueValues)} Result: {result10.ToSingleString()}");

var result11 = dataProcessor.GetAllWordCombinations(dataRepository.TwoLetterWords);
Console.WriteLine($"{nameof(dataProcessor.GetAllWordCombinations)} Result: {result11.ToSingleString()}");

var result12 = dataProcessor.ExtractStringNumbers(dataRepository.NumbersAndWordsMixed);
Console.WriteLine($"{nameof(dataProcessor.ExtractStringNumbers)} Result: {result12.ToSingleString()}");

var result13 = dataProcessor.CombineCollections(dataRepository.TenWords, dataRepository.TwoLetterWords);
Console.WriteLine($"{nameof(dataProcessor.CombineCollections)} Result: {result13.ToSingleString()}");

var result14 = dataProcessor.CombineWordsAndNumbers(dataRepository.TenWords, dataRepository.TenNumbers);
Console.WriteLine($"{nameof(dataProcessor.CombineCollections)} Result: {result14.ToSingleString()}");

Console.WriteLine();
Console.WriteLine($"Press any key to exit");
Console.ReadKey();