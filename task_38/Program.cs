//  Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

// double [] arr = {3.1, 7.2, 22.3, 2.4, 78.5};


Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine()); 

double [] arr = new double[size];  



for (int i = 0; i < arr.Length; i++)

  {

  Console.WriteLine($"Введите {i+1}-е число: ");
  
 arr[i] = Double.Parse(Console.ReadLine());

  }

void SelectionSort(double[] array)

{
for (int i = 0; i< array.Length - 1; i++)
  {  
   int minPosition = i;

    for (int j = i + 1; j<array.Length; j++)
    
    {
        if (array[j] < array[minPosition]) minPosition = j;
    }
    double temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;

  
   }

  System.Console.Write($"Разница между максимальным и минимальным элементом массива равна: {array[array.Length - 1] - array[0]} ");
  
}
  

SelectionSort(arr);

    



