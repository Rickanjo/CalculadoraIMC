// Calcule o Índice de Massa Corporal (IMC) do usuário.
Console.WriteLine("--- Calculado IMC ---");

double imc;

Console.Write("Digite o quanto você pesa (Kg)..........:");
double peso = double.Parse(Console.ReadLine()!);

Console.Write("Digite sua altura (m)...................:");
double altura = double.Parse(Console.ReadLine()!);

imc = peso / (altura * altura) ;

Console.WriteLine($"\nO seu IMC é.............................: {imc:N2} kg/m²");

if (imc < 17){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Situação................................: Muito abaixo do peso");

}else if (imc >= 17 && imc < 25) {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Situção.................................: Abaixo do peso");

} else if (imc >= 25 && imc < 25){
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Situação................................: Peso normal");

}else if (imc >= 25 && imc < 30) {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Situação................................: Acima do peso");

} else if (imc >= 30 && imc < 35) {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Situação................................: Obesidade I");

} else if (imc >= 35 && imc < 40) {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Situação................................: Obesidade II (severa)");

} else {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Situação................................: Obesidade III (mórbida)");
}
Console.ResetColor();
