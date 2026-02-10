using System;
// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// initialize variables - graded assignments 
int currentAssignments = 5;
int[] sophiaScores = [90, 86, 87, 98, 100];
int[] andrewScores = [92, 89, 81, 96, 90];
int[] emmaScores = [90, 85, 87, 98, 68];
int[] loganScores = [90, 95, 87, 88, 96];

int[] studentScores = new int[10];
int studentSum = 0;
decimal studentGrade;

Console.WriteLine("Student\t\tGrade\n");
foreach (var student in studentNames)
{
    if (student == "Sophia")
        studentScores = sophiaScores;
    else if (student == "Andrew")
        studentScores = andrewScores;
    else if (student == "Emma")
        studentScores = emmaScores;
    else if (student == "Logan")
        studentScores = loganScores;
    foreach (var score in studentScores)
    {
        studentSum += score;
    }
    studentGrade = (decimal)studentSum / currentAssignments;
    Console.WriteLine($"{student}:\t\t{studentGrade}\t?");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
