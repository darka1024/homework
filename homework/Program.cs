Console.WriteLine("Enter budget:");
double budget = double.Parse(Console.ReadLine());
double travel = 2.50;
int count = 0;
if (budget > travel)
{
    while(budget >= travel)
   {
       budget = budget - travel;
       count++;
   }
}
else if (budget == travel)
{
    count = 1;
}
else Console.WriteLine("You cant afford to travel:");
Console.WriteLine($"number of travels done: {count}");
Console.WriteLine($"Leftover money: {budget}");
