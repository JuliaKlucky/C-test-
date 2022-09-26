int[] array = {18, 22, 34, 68, 15, 6, 97, 68};

int n = array.Length;
int find = 68;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}