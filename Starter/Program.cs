int numberOfExamAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade;

Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumExamScores = 0;
    int sumExtraCreditScores = 0;
    int currentStudentNumberOfExtraCreditAssignments = 0;
    int currentStudentExtraCreditScore = 0;

    decimal currentStudentExamScore = 0;
    decimal currentStudentOverallScore = 0;
    decimal currentStudentExtraCreditPoints = 0;

    int gradedAssignments = 0;

    /* 
    the inner foreach loop sums assignment scores
    extra credit assignments are worth 10% of an exam score
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= numberOfExamAssignments)
            sumExamScores += score;

        else
        {
            sumExtraCreditScores += score;
            currentStudentNumberOfExtraCreditAssignments++;
        }
    }

    currentStudentExamScore = (decimal)sumExamScores / numberOfExamAssignments;
    currentStudentOverallScore = (sumExamScores + ((decimal)sumExtraCreditScores / 10)) / numberOfExamAssignments;
    currentStudentExtraCreditScore = sumExtraCreditScores / currentStudentNumberOfExtraCreditAssignments;
    currentStudentExtraCreditPoints = ((decimal)sumExtraCreditScores / 10) / numberOfExamAssignments;

    if (currentStudentOverallScore >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentOverallScore >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentOverallScore >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentOverallScore >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentOverallScore >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentOverallScore >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentOverallScore >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentOverallScore >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentOverallScore >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentOverallScore >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentOverallScore >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentOverallScore >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentOverallScore}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({currentStudentExtraCreditPoints} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
