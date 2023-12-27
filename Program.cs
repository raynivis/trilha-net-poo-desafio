using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone:");

Iphone i = new Iphone(numero: "18991335474", modelo: "Iphone 8", imei:"5555555555555", memoria:"128gb");
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("Instagram");


Console.WriteLine("Smartphone Nokia:");

Nokia no = new Nokia(numero: "18991369854", modelo: " Nokia Lumia 1320", imei:"777777777777", memoria:"32gb");
no.Ligar();
no.ReceberLigacao();
no.InstalarAplicativo("Reddit");