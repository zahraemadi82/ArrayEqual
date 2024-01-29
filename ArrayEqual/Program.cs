// See https://aka.ms/new-console-template for more information
using System;

int[] myArray = new int[100];
int n = 0;
while (true)
{
    Console.Write("Enter number(If it exits, enter the word e) : ");
    string result = Console.ReadLine();
    if (result == "e")
    {
        break;
    }
    myArray[n] = Convert.ToInt32(result);
    n++;
}

int count = 0;

for (int i = 0; i < myArray.Length; i++)
{
    for (int j = i + 1; j < myArray.Length; j++)
    {
        if (myArray[i] == myArray[j])
        {
            count++;
            break;
        }
    }
}

Console.WriteLine(count);