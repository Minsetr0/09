Random random = new Random();
int minRandomNumber = 1;
int maxRandomNumber = 28;
int multiplicity = 0;
int beginningThreeDigitNumber = 100;
int endThreeDigitNumber = 999;
int number = random.Next(minRandomNumber, maxRandomNumber);

for (int i = number; i <= endThreeDigitNumber; i += number)
{
    if (i >= beginningThreeDigitNumber)
    {
        multiplicity++;
    }
}

Console.WriteLine("Количество трёхзначных чисел, кратных " + number + ", равно " + multiplicity + ".");