
int N = int.Parse(Console.ReadLine());
for (int i = 1111; i < 9999; i++)
{
    int iFirstDigit = i / 1000;
    int iSecondDigit = i / 100 - iFirstDigit * 10;
    int iThirdDigit = i / 10 - iFirstDigit * 100 - iSecondDigit * 10;
    int iFourthDigit = i - iFirstDigit * 1000 - iSecondDigit * 100 - iThirdDigit * 10;
    if (iFirstDigit != 0 && iSecondDigit != 0 && iThirdDigit != 0 && iFourthDigit != 0)
    {
        if (N % iFirstDigit == 0 && N % iSecondDigit == 0 && N % iThirdDigit == 0 && N % iFourthDigit == 0)
        {
            Console.WriteLine(i);
        }
    }
}