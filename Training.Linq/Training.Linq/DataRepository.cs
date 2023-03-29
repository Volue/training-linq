namespace Training.Linq;

public class DataRepository
{
    public List<int> TenConsecutiveNumbers = new() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    public List<int> TenNumbers = new() { 15, 62, 305, 11, 99, -2, 0, 62, 33, 71 };
    public List<string> TenWords = new() { "the", "bike", "this", "it", "tenth", "mathematics", "a", "mathematics", "mathematics!", "mathematics" };
    public List<string> TwoLetterWords = new() {"fa", "fi", "fe", "fo", "fu"};
    public List<string> NumbersAndWordsMixed = new() {"bike", "11", "999", "-0.1", "tenth", "the", "404", "3.333"};
    
    public List<string> BuildingNumber = new() {"A5", "A2", "A1" };
    public List<int> FlatNumber = new() {104, 109, 25, 200 };
    public List<string> StreetName = new() {"Baker Street", "Cross Street", "Hu Street" };
    
    public int[,] MultiDimensionalArray = new [,]
    {
        { 1, 2 },
        { 3, 4 },
        { 5, 6 }
    };
}