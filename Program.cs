string[] ishodni = { "2023", "go", "hello", "to", "20", "23" };
int skoka = 3;

Console.WriteLine("Исходный массив: " + string.Join(", ", ishodni));

string[] poluchilos = Newarray(ishodni, skoka);

string[] Newarray (string[] array, int n)
{
    int x = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= n) 
        {
            x++;
        }
    }

    string [] newarray = new string[x];
    int j = 0;

    for (int i = 0; i < array.Length; i++) 
    {
        if(array[i].Length <= n) 
        {
            newarray[j] = array[i];
            j++;
        }
    }

    return newarray;
}

Console.WriteLine("Новый массив: " + string.Join(", ", poluchilos));