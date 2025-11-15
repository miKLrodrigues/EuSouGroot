 string pergunta, resposta, saida;

saida = "tchau";
 Console.WriteLine("---Groot Chatbot---\n");

while (true)
{
    PerguntaUsuario();
    
    if (pergunta == saida){
        resposta = "Eu sou o Groot!";
        Console.WriteLine($"                       Resposta: {resposta}");
        break;
    }

    resposta = "Eu sou o Groot.";
    Console.WriteLine($"                       Resposta: {resposta}");

}


void PerguntaUsuario() {
    Console.Write("Pergunta: ");

    //variavel só funciona aqui
    pergunta = Console.ReadLine()!.ToLower().Trim();

} 


