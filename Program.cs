using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia (numero: "123456789", modelo: "Nokia110", imei: "qaz123", memoria: 2000);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Waze");


Console.WriteLine("\n");

Console.WriteLine("Smartphoe Iphone:");
Smartphone iphone = new Iphone (numero: "987654321", modelo: "Iphone15", imei: "wsx123", memoria: 2000);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Waze");