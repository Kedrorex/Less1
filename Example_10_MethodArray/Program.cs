int [] array = {1, 5, 14, 15, 45, 756};

int n = array.Length;
int find = 45;

int i = 0;

while (i < n)
{
  if (array[i] == find)
  {
    Console.WriteLine(i);
    break;
  }
  i++;
}