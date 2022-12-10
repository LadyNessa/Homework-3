void CubeArray (int [] arr, int len )
{
    for (int i = 0; i < len; i++)
    {
        arr[i] = i + 1;
        int cube = arr[i] * arr[i] * arr[i];
        Console.WriteLine(cube);
    }
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];

CubeArray(array, N);