


// See https://aka.ms/new-console-template for more information
int[] arr = new int[5];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i + 1;
}

Console.WriteLine(string.Join(' ', arr));
Console.WriteLine("Hello, World! " + arr.Length);
