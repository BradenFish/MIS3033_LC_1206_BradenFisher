// MIS 3033
// December 6, 2023
// Braden Fisher. 113492081

using MIS3033_LC_1206_BradenFisher.Data;
using MIS3033_LC_1206_BradenFisher.Models;
using System.Text.RegularExpressions;

//StuDB2 db = new StuDB2();

//foreach (Student student in db.Students)
//{
//    Console.WriteLine(student.Name);
//}

string t_txt = File.ReadAllText("Trump.txt");
string b_txt = File.ReadAllText("Biden.txt");

//Console.WriteLine(t_txt);
//Console.WriteLine(b_txt);

string authors = "Mike, 23, michael, macy, tom, aiden, rose, david, dave";
//string str1 = @"\n\n";
//Console.WriteLine(str1);
//Console.WriteLine(str1.Length);

Regex pattern1;// Regex, complex
//pattern1 = new Regex(@"\bm[a-z] {0,}|aiden", RegexOptions.IgnoreCase);
pattern1 = new Regex(@"what", RegexOptions.IgnoreCase);

//var matches = pattern1.Matches(authors);// collection
var matches = pattern1.Matches(b_txt);

for (int i = 0; i < matches.Count; i++)
{
    var match = matches[i]; 
    Console.WriteLine($"V: {match.Value} I: {match.Index}");
}

Console.WriteLine(matches.Count);