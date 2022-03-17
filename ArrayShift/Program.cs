int[] a = new int[]{0,1,2,3,4,5,6,7};

foreach(int v in a) Console.Write($"{v} ");
Console.WriteLine();
ArrayShift(a, 3);
foreach(int v in a) Console.Write($"{v} ");
Console.WriteLine();

void ArrayShift(int[] array, int k)
{
    if(k != 0)
    {
        k = (k > 0) ? (k % array.Length) : ((k % array.Length) + array.Length);
        int[] temp = new int[k];
        Array.Copy(array, array.Length-k, temp, 0, k);
        Array.Copy(array, 0, array, k, array.Length-k);
        Array.Copy(temp, array, k);
    }
}