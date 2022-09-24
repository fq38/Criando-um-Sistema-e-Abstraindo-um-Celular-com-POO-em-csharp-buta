
using net_poo_desafio_buta.Models;

Console.WriteLine("SmartPhone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "<odelo 1", imei: "1111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");
Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone:");
Smartphone iphone = new Iphone(numero: "5453", modelo: "modelo2", imei: "2222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegtarm");


// TODO: Realizar os  estes com as classes Nokia e Iphone