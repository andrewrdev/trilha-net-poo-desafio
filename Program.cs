using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "11111111", memoria: 64);

nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");

Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "2222222", memoria: 128);

iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();