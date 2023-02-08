namespace Training.Linq;

public class DataProcessor
{
    public IEnumerable<int> GetNumbersFromRange(IEnumerable<int> collection, int start, int end)
    {
        return Enumerable.Empty<int>();
    }
    
    public IEnumerable<int> GetSquaresAbove(IEnumerable<int> collection, int limit)
    {
        return Enumerable.Empty<int>();
    }
    
    public IEnumerable<string> GetWordsLongerThan(IEnumerable<string> collection, int minLength)
    {
        return Enumerable.Empty<string>();
    }
    
    public IEnumerable<string> GetUniequeWords(IEnumerable<string> collection)
    {
        return Enumerable.Empty<string>();
    }
    
    public IEnumerable<string> GetContainingLetter(IEnumerable<string> collection, char letter)
    {
        return Enumerable.Empty<string>();
    }
    
    public IEnumerable<string> ChangeLetterToLetter(IEnumerable<string> collection, char oldValue, char newValue)
    {
        return Enumerable.Empty<string>();
    }
    
    public IEnumerable<int> ShuffleNumbers(IEnumerable<int> collection)
    {
        return Enumerable.Empty<int>();
    }
    
    public IEnumerable<(char, int)> GetCharacterFrequency(IEnumerable<string> collection)
    {
        return Enumerable.Empty<(char, int)>();
    }
    
    public char GetMostFrequentCharacter(IEnumerable<string> collection)
    {
        return default;
    }
    
    public IEnumerable<string> GetUniqueValues(IEnumerable<string> collection)
    {
        return default;
    }
}