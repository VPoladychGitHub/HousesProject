using HousesProject;
using System;

/*Створити клас дім (House), який

- 65: Має адресу, яку обов'язково потрібно задати при створенні, можна читати, але не можна змінити

- +5: Має можливість змінити адресу за допомогою окремого методу. Метод має перевіряти, що адреса довше за 5 символів

- +5: Має ім'я (nickname), що можна читати та змінювати без обмежень

- +10: Якщо викликати на екземплярі класу ToString, якщо у дому є ім'я - повинно відображатися ім'я, якщо ні - то адреса

- +15: При порівнянні двох домів повинна враховуватися лише адреса*/
Console.WriteLine("===========   house1 =========================");
var house1 = new House
{
    Adress = "kharkiv prosp Nauki house 18"
};
Console.WriteLine(house1);
house1.Nickname = "nickname House";
Console.WriteLine(house1);
Console.WriteLine(house1.Adress + "   " + house1.Nickname);

Console.WriteLine("===========   house2 =========================");
var house2 = new House
{
    Adress = "kharkiv street Symska house 118"
};
house2.Nickname = "nickname House 2";
Console.WriteLine(house2.Adress + "   " + house2.Nickname);
Console.WriteLine(house2);

Console.WriteLine("===========   !Equals =========================");
Console.WriteLine(house1.Equals(house2));
Console.WriteLine(house1 == house2);
Console.WriteLine("===========   Equals =========================");
house2.setAdress("kharkiv prosp Nauki house 18");
Console.WriteLine(house1.Equals(house2));
Console.WriteLine(house1 == house2);
