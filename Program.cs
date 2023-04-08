Random rand = new Random();
int minRandomNumber = 1;
int maxRandomNumber = 28;
int multiplicity = 0;
int beginningThreeDigitNumber = 100;
int endThreeDigitNumber = 999;
int number = rand.Next(minRandomNumber, maxRandomNumber);

for (int i = beginningThreeDigitNumber; i <= endThreeDigitNumber; i++)
{
	int multiplicityCheckNumber = i; 

	while (multiplicityCheckNumber > 0)
	{
        multiplicityCheckNumber = multiplicityCheckNumber - number;
	}

	if (multiplicityCheckNumber == 0)
	{
		multiplicity++;
    }
}

Console.WriteLine("Количество трёхзначных чисел, кратных " + number + ", равно " + multiplicity + ".");