 //Задача 38: Задайте массив вещественных чисел. Найдите разницу между
 // максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76 

double[] arrayNumbers = new double[8];
  for (int i = 0; i < arrayNumbers.Length; i++ )
  {
    arrayNumbers[i] = new Random().Next(1, 100);
    Console.Write(arrayNumbers[i] + " ");
    
  }
System.Console.WriteLine();
double maxNumber = arrayNumbers[0];
double minNumber = arrayNumbers[0];

  for (int i = 1; i < arrayNumbers.Length; i++)
  {
    if (maxNumber < arrayNumbers[i])
    {
      maxNumber = arrayNumbers[i];
    }
        if (minNumber > arrayNumbers[i])
    {
      minNumber = arrayNumbers[i];
    }
  }

  double sum = maxNumber - minNumber;

  Console.Write($"разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {sum}");