string[] array = new string[] {"Hello", "2", "world", ":-)"};
int len_array = array.Length;
Console.Write("Массив из 3 и менее символов: ");

for(int i = 0; i < len_array; i++)
{
    string Str = array[i];
    if(Str.Length <= 3)
    {
        Console.Write(Str + ", ");
    }
}
