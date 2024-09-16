using DesafioPOO.Models;

Console.WriteLine("----- Nokia -----");
Nokia nokia = new Nokia("01234","Modelo 09", "333333", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Kanji Study");

Console.WriteLine("----------------------");

Console.WriteLine("----- IPhone -----");
Iphone iphone = new Iphone("56789","Modelo 18", "666666", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");