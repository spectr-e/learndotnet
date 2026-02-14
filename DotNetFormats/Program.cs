string first = "Hello";
string second = "World";
//composite formatting
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

//template literals
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

decimal price = 123.45m;
int discount = 50;
//formatting currency
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

decimal measurement = 123456.78912m;
// formatting numbers
Console.WriteLine($"Measurement: {measurement:N} units");
Console.WriteLine($"Measurement: {measurement:N4} units");

decimal tax = .36785m;
// formatting percentages
Console.WriteLine($"Tax rate: {tax:P2}");