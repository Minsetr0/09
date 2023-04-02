Random rand = new Random();
int number = rand.Next(1, 28);
int multiplicity = 0;

for (int i = 100; i <= 999; i++)
{
	int i2 = i; 

	while (i2 > 0)
	{
		i2 = i2 - number;
	}

	if (i2 == 0)
	{
		multiplicity++;
    }
}

Console.WriteLine("Количество трёхзначных чисел, кратных " + number + ", равно " + multiplicity + ".");