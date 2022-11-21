Console.Write("Números pares entre 0 e ? ");

int numeroInformado = Convert.ToInt32(Console.ReadLine());


if (numeroInformado >= 1)


{int numeroPar = 0;


while (numeroPar <= numeroInformado)

{ Console.WriteLine($"{numeroPar} ");

numeroPar += 2;}}


else


{Console.Write($"O número {numeroInformado} não é inteiro positivo.");}
