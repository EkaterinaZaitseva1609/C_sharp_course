//Работа с файлами и строками 

string word = "Hello";
word += "!";



//System.Console.WriteLine(word.Length);
//word = String.Concat(word, "!!");
//System.Console.WriteLine(String.Compare(word, "Heoo!!!!"));

string people = "Alex, Bob, John"; 
string[] names = people.Split(new char[]{','});
foreach(string el in names)
System.Console.WriteLine(el);