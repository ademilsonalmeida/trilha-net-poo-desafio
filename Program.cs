using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 1", iMEI: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "67890", modelo: "Modelo 14", iMEI: "22222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");