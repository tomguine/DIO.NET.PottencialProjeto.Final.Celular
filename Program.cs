using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone i1 = new Iphone("(22)2773-4215", "14 Pro", "12345678", 128);
i1.InstalarAplicativo("DIO.me");
i1.Ligar();
i1.ReceberLigacao();
i1.Apresentar();

i1.Numero = "(55)2222-3333";
i1.Apresentar();


Nokia n1 = new Nokia("(22)99973-4251", "Tijolão", "0987654321", 256);
n1.InstalarAplicativo("Jogo da cobrinha");
n1.Ligar();
n1.ReceberLigacao();
n1.Apresentar();

n1.Numero = "(11)4444-5555";
n1.Apresentar();