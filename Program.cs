using DesafioPOO.Models;

Nokia nokia = new Nokia("1234-5678", "SF-898", "000001" , 7);
Iphone iphone = new Iphone("8765-4321", "IP03", "0302011", 10);

Console.WriteLine("\nSmarthphone Nokia: \n ");
    nokia.Ligar();
    nokia.ReceberLigacao();
    nokia.InstalarAplicativo("Whatssap");
Console.WriteLine("\nSmartphone Iphone: \n");
    iphone.Ligar();
    iphone.ReceberLigacao();
    iphone.InstalarAplicativo("Instagram");
