Console.WriteLine("Insira seu num");
string?  entrada1 = Console.ReadLine(); 
float num1 = float.Parse(entrada1);

Console.WriteLine("Insira seu segundo num");
string?  entrada2 = Console.ReadLine();
float num2 = float.Parse(entrada2);

Console.WriteLine(num2 + num1); 
Console.WriteLine(num2 - num1); 
Console.WriteLine(num2 / num1); 
Console.WriteLine(num2 * num1); 

//método de interpolação
string mensagem = $"Seu resultado da some é, {num2 + num1}!";
Console.WriteLine(mensagem);

//metodo de concatenacao
string mensagem2 = "Seu resultado da divisão é, " + num1 / num2 + "!";
Console.WriteLine(mensagem2);

//Placeholder 1
string mensagem3 = string.Format("Sua multiplicacao resulta em: {0}!", num1 * num2);
Console.WriteLine(mensagem3);

//Placeholder 2
string mensagem4 = string.Format("Sua subtracao resulta em: {0}!", num1 - num2);
Console.WriteLine(mensagem4);