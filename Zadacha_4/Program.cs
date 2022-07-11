

int FirstNum = int.Parse(Console.ReadLine());
if (FirstNum <100000 || FirstNum > 300000)
{
    throw new ArgumentException("ot 100000 do 300000");
}
int SecondNum = int.Parse(Console.ReadLine());
if (SecondNum < 100000 || SecondNum > 300000 || SecondNum<FirstNum)
{
    throw new ArgumentException("ot 100000 do 300000 i po-malko ot purvo chislo!");
}
Console.WriteLine("");
for (int i = FirstNum; i <= SecondNum; i++)
{
    //the probably worst way to find the digits
    int iFirstDigit = i / 100000;
    int iSecondDigit = i / 10000 - iFirstDigit * 10;
    int iThirdDigit = i / 1000 - iFirstDigit * 100 - iSecondDigit * 10;
    int iFourthDigit = i / 100 - iFirstDigit * 1000 - iSecondDigit * 100 - iThirdDigit * 10;
    int iFifthDigit = i / 10 - iFirstDigit * 10000 - iSecondDigit * 1000 - iThirdDigit * 100 - iFourthDigit * 10;
    int iSixthDigit = i - iFirstDigit * 100000 - iSecondDigit * 10000 - iThirdDigit * 1000 - iFourthDigit * 100 - iFifthDigit * 10;
    if (iFirstDigit + iThirdDigit + iFifthDigit == iSecondDigit + iFourthDigit + iSixthDigit)
    {
        Console.Write(i+" ");
    }

}
//opa ne polzvah vlojen cikul tova problem li e?
