using DesafioPOO.Models;

Smartphone[] smartphones = new Smartphone[2];

smartphones[0] = new Nokia(
    "+55 (81) 91111-2222",
    "C-708",
    "1111111",
    128
);

smartphones[1] = new Iphone(
    "+55 (81) 93333-4444",
    "15 PRO",
    "2222222",
    128
);

Console.WriteLine("\nTestando os smartphones...\n");

foreach(Smartphone smartphone in smartphones) {
    Console.WriteLine(smartphone.ToString());
    smartphone.Ligar();
    smartphone.InstalarAplicativo("WhatsApp");
    smartphone.ReceberLigacao();
    Console.WriteLine();
}