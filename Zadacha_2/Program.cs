
int Counter = 0;
double SborOcenki = 0;
String LastZadacha= "";
int BadGrades = 0;

int BadGradesLimit = int.Parse(Console.ReadLine());
if (BadGradesLimit < 1|| BadGradesLimit > 5)
{
    throw new ArgumentException("ot 1 do 5");
}
string Zadacha = Console.ReadLine();

while (Zadacha != "Enough")
{
    int CurGrade = int.Parse(Console.ReadLine());
    
    if (CurGrade < 2 || CurGrade > 6)
    {
        throw new ArgumentException("ot 2 do 6");
    }
    if (CurGrade < 5)
    {
        BadGradesLimit--;
        BadGrades++;
    }
    if (BadGradesLimit <= 0)
    {
        Console.WriteLine("You need a break, " + BadGrades + " poor grades!");
        break;
    }
    LastZadacha = Zadacha;
    SborOcenki = SborOcenki + CurGrade;
    Zadacha= Console.ReadLine();
    Counter++;
}
if (Zadacha == "Enough")
{
    Console.WriteLine("Average score:" + (SborOcenki / Counter));
    Console.WriteLine("Number of problems: " + Counter);
    Console.WriteLine("Last problem: " + LastZadacha);
}