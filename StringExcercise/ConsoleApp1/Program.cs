//=============== 1 
string text = "   Уча C# и програмирам на C#.   ";
Console.WriteLine(text);
text = text.Trim();
Console.WriteLine(text);
// ============== 2
Console.WriteLine(text.Length);
Console.WriteLine(text[5]);
Console.WriteLine(text[0] + " - " + text[text.Length-1]);

//=============== 3
Console.WriteLine(text.ToUpper());
Console.WriteLine(text.ToLower());

//=============== 4
Console.WriteLine(text.Contains("C#"));
Console.WriteLine(text.Contains("Python"));
Console.WriteLine(text.Contains("c#"));

//=============== 5
Console.WriteLine(text.StartsWith("Уча"));
Console.WriteLine(text.StartsWith("."));
Console.WriteLine(text.StartsWith("C#"));