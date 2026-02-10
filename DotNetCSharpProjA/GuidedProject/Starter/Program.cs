using System;
// Student names
string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];
// initialize variables - graded assignments 
int examAssignments = 5;
int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];

int[] studentScores = new int[10];

string studentLetterGrade = "";

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

    int studentSum = 0;
    decimal studentGrade;
    int gradedAssignments = 0;

    foreach (var score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            studentSum += score;
        else
            studentSum += score / 10;
    }

    studentGrade = (decimal)studentSum / examAssignments;

    if (studentGrade >= 97)
        studentLetterGrade = "A+";

    else if (studentGrade >= 93)
        studentLetterGrade = "A";

    else if (studentGrade >= 90)
        studentLetterGrade = "A-";

    else if (studentGrade >= 87)
        studentLetterGrade = "B+";

    else if (studentGrade >= 83)
        studentLetterGrade = "B";

    else if (studentGrade >= 80)
        studentLetterGrade = "B-";

    else if (studentGrade >= 77)
        studentLetterGrade = "C+";

    else if (studentGrade >= 73)
        studentLetterGrade = "C";

    else if (studentGrade >= 70)
        studentLetterGrade = "C-";

    else if (studentGrade >= 67)
        studentLetterGrade = "D+";

    else if (studentGrade >= 63)
        studentLetterGrade = "D";

    else if (studentGrade >= 60)
        studentLetterGrade = "D-";

    else
        studentLetterGrade = "F";

    Console.WriteLine($"{student}:\t\t{studentGrade}\t{studentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
