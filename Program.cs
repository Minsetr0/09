Random random = new Random();
int minRandomNumber = 1;
int maxRandomNumber = 28;
int multiplicity = 0;
int beginningThreeDigitNumber = 100;
int endThreeDigitNumber = 999;
int number = random.Next(minRandomNumber, maxRandomNumber);
int numberToWork = number;

while (numberToWork < endThreeDigitNumber)
{
    if (numberToWork < beginningThreeDigitNumber)
    {
        numberToWork += number;
    }
    else if (numberToWork >= beginningThreeDigitNumber)
    { 
        multiplicity++;
        numberToWork += number;
    }
}

Console.WriteLine("Количество трёхзначных чисел, кратных " + number + ", равно " + multiplicity + ".");