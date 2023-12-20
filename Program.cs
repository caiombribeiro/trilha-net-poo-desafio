using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo1", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.especificacoes();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "987654", modelo: "Modelo2", imei: "2222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Jogo do Tigrinho");
iphone.especificacoes();