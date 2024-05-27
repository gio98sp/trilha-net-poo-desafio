using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("3121313123", "N1", "1234", 64);
Iphone iphone = new Iphone("987643321", "10", "1234", 64);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Pou");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
