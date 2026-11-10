string text = "12 7 24 12 -6 15 8 24 -30 5";
List<string> texts = text.Split(" ").ToList();
List<int> nums = new List<int>();
foreach (string t in texts)
    nums.Add(int.Parse(t));
foreach (int n in nums)
    Console.WriteLine(n);
Console.WriteLine("Count of numbers: " + nums.Count);
List<int> positive = new List<int>();
foreach (int n in nums)
{   
    bool PositiveNum = n > 0;
    bool EvenNum = n % 2 == 0;
    if (PositiveNum && EvenNum)
    {
        if (!positive.Contains(n))
            positive.Add(n);
    }
}
Console.WriteLine(string.Join(", ", positive));
Console.WriteLine($"Count: {positive.Count} sum: {positive.Sum()}");
