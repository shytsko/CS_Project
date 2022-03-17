int[] a = new int[] {1, 2, 3}, b = new int[] {1, 2};

int[] c = ArrayDiff(a, b);
foreach(int v in c) Console.Write($"{v} ");


  static int[] ArrayDiff(int[] a, int[] b)
  {
      List<int> res = new List<int>();

      foreach (int item in a)
        if(!b.Contains(item))
            res.Add(item);

    return res.ToArray();
    // Your brilliant solution goes here
    // It's possible to pass random tests in about a second ;)
  }