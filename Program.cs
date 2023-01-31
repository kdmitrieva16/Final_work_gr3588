string strFromUser = ReadStringData("Введите элементы массива через запятую");
string[] arrFromUser = ArrayFromUser(strFromUser);
Console.WriteLine("Исходный массив");
PrintArr(arrFromUser);
//int sizeNewArr = CountElement(arrFromUser);
string[] arrLessThenFour = ArrayLessThenFour(arrFromUser);
Console.WriteLine("Результат");
PrintArr(arrLessThenFour);

//Read data from user
string ReadStringData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

// Transform data from user to array

string[] ArrayFromUser(string str)
{
    string[] arr = str.Split(",");
    return arr;
}

// Print array 
void PrintArr(string[] arr)
{
    if (arr.Length != 0)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine(arr[arr.Length - 1] + "]");
    }
    else
        Console.Write("[]");
}

// Count element less than 4 
int CountElement(string[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            res++;
        }
    }
    return res;
}

// New array with elements less then 4

string[] ArrayLessThenFour(string[] arr)
{

    int size = 0;
    int j = 0;
    string[] outArr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i].Length < 4)
        {
            size++;
            string[] outArr1 = new string[size];
            outArr1[j] = arr[i];
            j++;
            for (int k = 0; k < outArr.Length; k++)
            {
                outArr1[k] = outArr[k];
            }
            outArr = outArr1;

        }


    }
    return outArr;
}


