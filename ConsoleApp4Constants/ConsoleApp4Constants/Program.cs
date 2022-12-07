// See https://aka.ms/new-console-template for more information


//contants are immutuble values which are known at compile time
//and do not change for the life of the program

const double pi = 3.14;

double p1 = 3;

p1 = 4;

//pi = 4;you cannot change because it is a const value

///type casting


double a = 3.14;

int b = Convert.ToInt32(a);

Console.WriteLine(b);
Console.WriteLine(a);

Console.WriteLine(a.GetType());//it tells us the type of the variables

Console.WriteLine(b.GetType());

int c = 123;

double d = Convert.ToDouble(c);

Console.WriteLine(d);

Console.WriteLine(d.GetType());

int e = 321;
String f = Convert.ToString(e);
Console.WriteLine(f.GetType());

String g = "$";

char h = Convert.ToChar(g);

Console.WriteLine(h.GetType());

String i = "true";

bool j = Convert.ToBoolean(i);

Console.WriteLine(j);
Console.WriteLine(j.GetType());






















