// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

// Use ToString() to convert a number to a string
// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// Convert a string to an int using the Parse() helper method
// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// Convert a string to a int using the Convert class
// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// Compare casting and converting a decimal into an int
// int value1 = (int)1.5m; // casting truncates
// Console.WriteLine(value1);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

// string[] values = ["12.3", "45", "ABC", "11", "DEF"];
// decimal sum = 0;
// string message = "";
// foreach (var value in values)
// {
//     if (decimal.TryParse(value, out decimal output))
//         sum += output;
//     else
//         message += value;
// }
// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {sum}");

// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// // Your code here to set result1
// int result1 = value1 / Convert.ToInt32(value2);
// // Hint: You need to round the result to nearest integer (don't just truncate)
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// // Your code here to set result2
// decimal result2 = value2 / Convert.ToDecimal(value3);
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// // Your code here to set result3
// float result3 = value3 / value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

string pangram = "The quick brown fox jumps over the lazy dog";
string[] message = pangram.Split(" ");
string[] newMessage = new string[message.Length];
for (var i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}
string output = string.Join(" ", newMessage);
Console.WriteLine(output);