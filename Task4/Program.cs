// Дано N гирь с разным весом в случайном
// порядке. Определить вес самой тяжелой
// гири.

// int n = 5;
int[] array = {1,3,6,8,5,4,10,15,9};
int i = 0;
int max = array[0];

while(i < array.Length)
{
    if(array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.Write(max);

max = array[0];
for(int j = 0; j < array.Length; j++)
{
    if(array[j] > max)
    {
        max = array[j];
    }
}
Console.Write(max);

max = array[0];
foreach(int e in array)
{
    if(e > max)
    {
        max = e;
    }
}
Console.Write(max);