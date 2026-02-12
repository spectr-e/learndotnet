// int[] times = { 800, 1200, 1600, 2000 };
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");

// /* Format and display medicine times */
// DisplayTimes();


// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     Console.WriteLine("Invalid GMT");
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     AdjustTimes();
// }
// else
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");

// /* Format and display medicine times */
// DisplayTimes();

// void DisplayTimes()
// {
//     /* Format and display medicine times */
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//             time = time.Insert(len - 2, ":");
//         else if (len == 2)
//             time = time.Insert(0, "0:");
//         else
//             time = time.Insert(0, "0:0");

//         Console.Write($"{time} ");
//     }
//     Console.WriteLine();
// }

// void AdjustTimes()
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++)
//         times[i] = times[i] + diff % 2400;
// }

/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255
then ipAddress is valid
else ipAddress is invalid
*/

string[] ipCollection = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };

foreach (var ipv4Input in ipCollection)
{
    if (ValidateLength(ipv4Input) && ValidateZeroes(ipv4Input) && ValidateRange(ipv4Input))
        Console.WriteLine($"{ipv4Input} is a valid IPv4 address");
    else
        Console.WriteLine($"{ipv4Input} is an invalid IPv4 address");
}

bool ValidateLength(string ip)
{
    if (ip.Split(".", StringSplitOptions.RemoveEmptyEntries).Length == 4)
        return true;
    else
        return false;
}

bool ValidateZeroes(string ip)
{
    foreach (var item in ip.Split(".", StringSplitOptions.RemoveEmptyEntries))
    {
        if (item.StartsWith("0"))
            return false;
    }
    return true;
}

bool ValidateRange(string ip)
{
    int[] range = Array.ConvertAll(ip.Split(".", StringSplitOptions.RemoveEmptyEntries), int.Parse);

    foreach (var item in range)
    {
        if (item <= 0 || item > 255)
            return false;
    }

    return true;
}