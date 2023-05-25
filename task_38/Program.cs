//  Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

double[] FillArrayWithRandomNumber(int size)
{

double [] arr = new double[size];  

Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
  {

  arr[i] = (double) rnd.Next(0,1000)/10;

  }

  return arr;

}

System.Console.Write("Введите размер массива: ");

int length = Convert.ToInt32(Console.ReadLine());

double[] array = FillArrayWithRandomNumber(length);

System.Console.WriteLine(string.Join("/ ", array));

for (int i = 0; i< array.Length - 1; i++  )
{  
   int minPosition = i;

    for (int j = i + 1; j < array.Length; j++)
    
    {

       if (array[j] < array[minPosition]) minPosition = j;

    }
  double temporary = array[i];

    array[i] = array[minPosition];

    array[minPosition] = temporary;

    Console.WriteLine($"array[i] {array[i]}");
    Console.WriteLine($"array[m] {array[minPosition]}");
    Console.WriteLine($"temporar {temporary}");
    Console.WriteLine(i);
}

for (int i = 0; i< array.Length; i++  )
{ 
  System.Console.WriteLine(array[i]);
}

System.Console.Write($"Разница между максимальным и минимальным элементом массива равна: {array[array.Length - 1] - array[0]} ");