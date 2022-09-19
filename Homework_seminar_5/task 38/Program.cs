// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

double[] NewArr(double[] array)
{
    double[] res = new double[10];

    for(int i =0; i < array.Length; i++)
    {
        res[i] = array[i]/10;
    }
    return res;
}

double min(double[] array)
{
    double res = array[0];

    for(int i =0; i < array.Length; i++)
    {
        if(array[i] < res)
        res = array[i];
    }
    return res;
}

double max(double[] array)
{
    double res = array[0];

    for(int i =0; i < array.Length; i++)
    {
        if(array[i] > res)
        res = array[i];
    }
    return res;
}

double[] myArray = GetArray(10, 0, 100);
double[] newArray = NewArr(myArray);
Console.WriteLine(String.Join(" ", newArray));
double res1 = max(newArray);
double res2 = min(newArray);

double dif = res1 - res2;

Console.WriteLine($"{dif}");