namespace Training.Linq;

public class DataProcessor
{
    public IEnumerable<int> GetNumbersFromRange(IEnumerable<int> collection, int start, int end)
    {
        return collection
            .Where(i => i < end)
            .Where(i => i > start);
    }
    
    public IEnumerable<int> GetSquaresAbove(IEnumerable<int> collection, int limit)
    {
        return collection
            .Select(i => i*i)
            .Where(i => i > limit);
    }
    
    public IEnumerable<string> GetWordsLongerThan(IEnumerable<string> collection, int minLength)
    {
        return collection.Where(i =>
        {
            return i.Length >= minLength;
        });
    }
    
    public IEnumerable<string> GetUniequeWords(IEnumerable<string> collection)
    {
        return collection.Distinct();
    }
    
    public IEnumerable<string> GetContainingLetter(IEnumerable<string> collection, char letter)
    {
        return collection.Where(i => i.Contains(letter)).Distinct();
    }
    
    public IEnumerable<string> ChangeLetterToLetter(IEnumerable<string> collection, char oldValue, char newValue)
    {
        return collection.Distinct().Select(s => s.Replace(oldValue, newValue));
    }
}