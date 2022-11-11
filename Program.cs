using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
 Console.WriteLine("Smartphone Nokia:");
 Smartphone nokia = new Nokia("123-456","Modelo 1","111111111",64);
 nokia.Ligar();
 nokia.InstalarAplicativo("whatsapp");

 Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone:");
 Smartphone iphone = new Iphone("456-789","Modelo 2","222222222",128);
 iphone.ReceberLigacao();
 iphone.InstalarAplicativo("Telegran");