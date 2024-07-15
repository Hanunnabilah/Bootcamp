// Implicit Upcasting
int x = 4;
double y = x;
Console.WriteLine(y);

// explicit downcasting
// double x = 12;
// int y = x;
// Console.WriteLine(y); //error, from bigges to smalles can be fit

// big to small
double c = 3.99999;
int d = (int)c; // convert double c menjadi int c
Console.WriteLine(d); // d = 3, int hanya mengambil bilangan bulat sehingga bilangan dibelakang koma tidak dibaca

// explicit upcasting
int a = 1;
double b = (double)a;
Console.WriteLine(b);

// pembulatan keatas
double ac = 3.99;
double ad = Math.Ceiling(ac);
int result = (int)ad;
Console.WriteLine(result);

//pembulatan kebawah
double q = 3.99;
double z = Math.Floor(q);
int resultfloor = (int) z;
Console.WriteLine(resultfloor);

// penggunaan double menggunakan ==
double aq = 1.1;
double aw = 1.9;
Console.WriteLine((aq + aw) == 3.0);