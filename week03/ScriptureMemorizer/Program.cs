using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{

    private string _book;
    private string _chapter;
    private string _verse;
    private string _text;
    static void Main(string[] args)

    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Program program = new Program();
        program.Book = "2 Nephi";
        program.Chapter = "2";  
        program.Verse = "25";
        program.Text = "Adam fell that men might be; and men are, that they might have joy.";
        Console.WriteLine(program.Scripture());
        program.HidenScripture();
    }


    public string Scripture()
    {
        return _book + " " + _chapter + ":" + _verse + "\n" + _text + "\n" + "Press enter to hide the words or quit to exit.";
    }

    public string Text
    {
         get { return _text; }
         set { _text = value; } 
    }

    public string Book
    {
         get { return _book; }
         set { _book = value; } 
    }
    public string Chapter
    {
         get { return _chapter; }
         set { _chapter = value; } 
    }
    public string Verse
    {
         get { return _verse; }
         set { _verse = value; } 
    }   

    public void HidenScripture()
    {

        string[] words = _text.Split(" ");

        List<string> ScriptureWords = new List<string>(words);
        
        List<string> RadonWords = new List<string>();

        int _wordsCount = ScriptureWords.Count;

        Random random = new Random();
        for (int i = ScriptureWords.Count - 1; i > 0; i--)
        {

            int j = random.Next(0, i + 1);
            string temp = ScriptureWords[i];
            ScriptureWords[i] = ScriptureWords[j];
            ScriptureWords[j] = temp;
            RadonWords.Add(ScriptureWords[i]);
        }
        Console.WriteLine(RadonWords[0]);
        while (_wordsCount  >= 0)
        {
            Console.Clear();
            Console.WriteLine(this.Scripture());
            string input = Console.ReadLine();

            if (input == "")
            {
                if(ScriptureWords.Count > 0)
                {
                    string wordToHide = ScriptureWords[0];
                    string changedWord = new string('_', wordToHide.Length);
                    int index = _text.IndexOf(wordToHide);
                    if (index != -1)
                    {
                        _text = _text.Remove(index, wordToHide.Length).Insert(index, changedWord);
                    }
                    this.Text = _text;
                    ScriptureWords.RemoveAt(0);
                }

            }
            else if (input == "quit")
            {
                Console.WriteLine("Goodbye!");

                break;
            }
            _wordsCount--;
        }
       
    }

}