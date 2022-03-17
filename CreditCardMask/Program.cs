// Usually when you buy something, you're asked whether your credit card number, phone number or answer to
// your most secret question is still correct. However, since someone could look over your shoulder,
// you don't want that shown on your screen. Instead, we mask it.

// Your task is to write a function maskify, which changes all but the last four characters into '#'.

using System;
using System.Text;

Console.WriteLine(Maskify("4556364607935616"));

static string Maskify(string cc)
{
    StringBuilder sb = new StringBuilder(cc);
    for(int i = 0; i < sb.Length-4; i++)
        sb[i] = '#';
    return sb.ToString();
}