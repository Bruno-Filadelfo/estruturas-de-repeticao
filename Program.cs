int numero = 5;
int contador = 1;

while (contador <= 10) {
    Console.WriteLine($"{contador}° execução: {numero} x {contador} = {numero * contador}");
    contador++;

    if (contador == 6) {
        break;
    }
}
