// Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter
// words reversed (Just like the name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be
// included only when more than one word is present.

// Examples:
// spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw"
// spinWords( "This is a test") => returns "This is a test"
// spinWords( "This is another test" )=> returns "This is rehtona test"
using System.Text;

Console.WriteLine(SpinWords( "Hey fellow warriors"));
Console.WriteLine(SpinWords( "This is a test"));
Console.WriteLine(SpinWords( "This is another test"));

static string SpinWords(string sentence)
{
    string[] words = sentence.Split(' ');

    for(int i = 0; i<words.Length; i++)
    {
        if(words[i].Length >=5)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in words[i])
                sb.Insert(0, c);
            words[i] = sb.ToString();
        }
    }

    return String.Join(" ", words);

}
