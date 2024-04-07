string[] array = Character_array();
string[] result_array = Generate_new_array(array);
string first_array = Print_array(array);
string second_array = Print_array(result_array);
Console.WriteLine(first_array + " -> " + second_array);
string[] Character_array()
{
    Console.WriteLine("Enter the data separated by a space: ");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null) { enterSymbols = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] array = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return array;
}

string Print_array(string[] array)
{
    string stringArray = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            stringArray += $"\"{array[i]}\"";
            break;
        }
        stringArray += ($"\"{array[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}

int Count_symbols(string[] array)
{
    int counter = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}

string[] Generate_new_array(string[] array)
{
    int resultLength = Count_symbols(array);
    string[] result_array = new string[resultLength];
    int i = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            result_array[i] = item;
            i++;
        }
    }
    return result_array;
}


