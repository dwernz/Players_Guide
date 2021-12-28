using System;

// Challenge: The Four Sisters and the Duckbear

Console.Write("How many chocolate eggs were gathered today? ");
string chocolateEggsString = Console.ReadLine();

int chocolateEggs = Convert.ToInt32(chocolateEggsString);

while (chocolateEggs < 0)
{
    Console.Write("Number must be positive.\nHow many chocolate eggs were gathered today? ");
    chocolateEggsString = Console.ReadLine();

    chocolateEggs = Convert.ToInt32(chocolateEggsString);
}

int sistersShare = chocolateEggs / 4;
int duckbearShare = chocolateEggs % 4;

if (sistersShare == 1)
{
    Console.WriteLine("Each sister should receive " + sistersShare + " chocolate egg.");
}
else
{
    Console.WriteLine("Each sister should receive " + sistersShare + " chocolate eggs.");
}

if (duckbearShare == 1)
{
    Console.WriteLine("The duckbear should receive " + duckbearShare + " chooclate egg.");
}
else
{
    Console.WriteLine("The duckbear should receive " + duckbearShare + " chooclate eggs.");
}
