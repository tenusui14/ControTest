string[] someArgs = { "12345", "ads", "Portal", "+++", "md", "3", "a", "fffff", "00", "fdsgads", "kek" };

Console.WriteLine($"[{string.Join(", ", someArgs)}]");
string[] outputArray = Array.Empty<string>();
int j = 0;
Array.Resize(ref outputArray, outputArray.Length + 1);
for (int i = 0; i < someArgs.Length; i++)
{

    if (someArgs[i].Length <= 3)
    {
        outputArray[j] = someArgs[i];
        j++;
        Array.Resize(ref outputArray, outputArray.Length + 1);
    }
}
Array.Resize(ref outputArray, outputArray.Length - 1);
Console.WriteLine($"[{string.Join(", ", outputArray)}]");