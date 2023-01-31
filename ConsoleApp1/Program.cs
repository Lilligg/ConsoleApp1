// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

string[] names = { "Пенси", "Драко", "Тео", "Блейз", "Гермиона" };
Random rand = new Random();
User U = new User();
U.name = names[0];
U.age = rand.Next(1, 100);
U.print();

User U1 = new User();
U1.name = names[1];
U1.age = rand.Next(1, 100);
U1.print();

User U2 = new User();
U2.name = names[2];
U2.age = rand.Next(1, 100);
U2.print();

User U3 = new User();
U3.name = names[3];
U3.age = rand.Next(1, 100);
U3.print();

User U4 = new User();
U4.name = names[4];
U4.age = rand.Next(1, 100);
U4.print();