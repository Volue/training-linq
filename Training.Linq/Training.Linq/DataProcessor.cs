namespace Training.Linq;

public class DataProcessor
{
    public IEnumerable<int> GetNumbersFromRange(IEnumerable<int> collection, int start, int end)
    {
        return collection
            .Where(n => n >= start)
            .Where(n => n <= end);
    }

    public IEnumerable<int> GetSquaresAbove(IEnumerable<int> collection, int limit)
    {
        return collection.Where(n => n * n > limit);
    }

    public IEnumerable<string> GetWordsLongerThan(IEnumerable<string> collection, int minLength)
    {
        return collection.Where(w => w.Length > minLength);
    }
    
    public IEnumerable<string> GetUniequeWords(IEnumerable<string> collection)
    {
        return collection
            .GroupBy(x => x)
            .Where(x => x.Count() == 1)
            .Select(x => x.Key)
            .ToList();
    }
    
    public IEnumerable<string> GetContainingLetter(IEnumerable<string> collection, char letter)
    {
        return collection.Where(x => x.Contains(letter));
    }
    
    public IEnumerable<string> ChangeLetterToLetter(IEnumerable<string> collection, char oldValue, char newValue)
    {
        return collection.Select(x => x.Replace(oldValue, newValue));
    }
    
    public IEnumerable<int> ShuffleNumbers(IEnumerable<int> collection)
    {
        var random = new Random();
        return collection.OrderBy(x => random.Next());
    }
    
    public IEnumerable<string> GetCharacterFrequency(IEnumerable<string> collection)
    {
        var characterFrequency = collection
            .Aggregate((acc, value) => $"{acc}{value}")
            .GroupBy(x => x)
            .Select(x => $"{x.Key}: {x.Count()}")
            .ToList();
        return characterFrequency;
    }
    
    
    public char GetMostFrequentCharacter(IEnumerable<string> collection)
    {
        return default;
    }
    
    public IEnumerable<string> GetUniqueValues(IEnumerable<string> collection)
    {
        return default;
    }

    public Task<int> ReturnNumber(int n)
    {
        return Task.FromResult(n);
    }
    
    public async Task Test(int n)
    {
        var dataRepository = new DataRepository();
        dataRepository.TenNumbers.Select(async n => await ReturnNumber(n));
    }
    
    public IEnumerable<string> GetAllWordCombinations(IEnumerable<string> collection)
    {
        return default;
    }
    
    public IEnumerable<decimal> ExtractStringNumbers(IEnumerable<string> collection)
    {
        return default;
    }
    
    public IEnumerable<decimal> CombineCollections(IEnumerable<string> collectionA, IEnumerable<string> collectionB)
    {
        return default;
    }
    
    public IEnumerable<decimal> CombineWordsAndNumbers(IEnumerable<string> collectionA, IEnumerable<int> collectionB)
    {
        return default;
    }
}