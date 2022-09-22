using CAdatetime;

int x = 10;
int y = x;
y -= 5;
Console.WriteLine($"x = {x}");
Console.WriteLine($"y = {y}");

int[] v = { 10 };
int[] w = v;
w[0] -= 5;
Console.WriteLine($"v[0] = {v[0]}");
Console.WriteLine($"w[0] = {w[0]}");

//másolás tétele
int[] tomb_1 = { 1, 3, 4, 5, 6 };
int[] tomb_2 = new int[tomb_1.Length];



for (int i = 0; i < tomb_1.Length; i++)
    tomb_2[i] = tomb_1[i];

tomb_2[2] = 100;

Console.Write("t1: ");
foreach (var e in tomb_1) Console.Write(e + ", ");
Console.Write("\nt2: ");
foreach (var e in tomb_2) Console.Write(e + ", ");

//value type == érték típus
//MINDEN struct a C#ban value

//reference type = referencia típus
//MINDEN class a C#ban ref.

Console.WriteLine("\n--------------");

DateTime datum = new DateTime(2001, 09, 11, 13, 12, 00);

Console.WriteLine(datum.ToLongDateString() + " " + datum.ToShortTimeString());
Console.WriteLine(datum.ToString("yyyy-MMM-dd, tt hh:mm"));

var szul = new DateTime(1990, 07, 11);
Console.WriteLine(szul);

var szazNappalKesobb = szul.AddDays(100);
Console.WriteLine(szazNappalKesobb);

bool szokiove = DateTime.IsLeapYear(2004);
Console.WriteLine(szokiove);


