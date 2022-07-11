


string CurSteps = (Console.ReadLine());
int Total = int.Parse(CurSteps);
while (Total < 10000)
{    
    CurSteps = (Console.ReadLine());   
    if(CurSteps == "Going Home")
    {
        Total +=  int.Parse(Console.ReadLine());
        break;
    }
    Total += int.Parse(CurSteps);
}
if (Total > 10000)
{
    Console.WriteLine("Goal reached, Good job!");
    Console.WriteLine((Total - 10000) + " steps over the goal!");
}
else
{
    Console.WriteLine((10000 - Total) + " more steps to reach goal!");
}