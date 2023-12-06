// MIS 3033
// December 6, 2023
// Braden Fisher. 113492081

using MIS3033_LC_1206_BradenFisher.Data;
using MIS3033_LC_1206_BradenFisher.Models;

StuDB2 db = new StuDB2();

foreach (Student student in db.Students)
{
    Console.WriteLine(student.Name);
}

string t_txt = File.ReadAllText("Trump.txt");
string b_txt = File.ReadAllText("Biden.txt");

Console.WriteLine(t_txt);
Console.WriteLine(b_txt);