﻿using System;

class Program
{
    static void Main()
    {
        double saldo = 1000.0; 
        double limiteSaque = 500.0; 
        string tipoConta = "corrente"; 
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n--- Caixa Eletrônico ---");
            Console.WriteLine("1. Saque");
            Console.WriteLine("2. Fazer um depósito");
            Console.WriteLine("3. Ver saldo");
            Console.WriteLine("4. Fazer uma transferência");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    
                    Console.Write("Digite o valor do saque: ");
                    double valorSaque = Convert.ToDouble(Console.ReadLine());
                    if (valorSaque > limiteSaque)
                    {
                        Console.WriteLine("Erro: Valor do saque excede o limite permitido.");
                    }
                    else if (valorSaque > saldo)
                    {
                        Console.WriteLine("Erro: Saldo insuficiente.");
                    }
                    else
                    {
                        saldo -= valorSaque;
                        Console.WriteLine($"Saque de R${valorSaque} realizado com sucesso. Saldo atual: R${saldo}");
                    }
                    break;

                case "2":
                    
                    Console.Write("Digite o valor do depósito: ");
                    double valorDeposito = Convert.ToDouble(Console.ReadLine());
                    saldo += valorDeposito;
                    Console.WriteLine($"Depósito de R${valorDeposito} realizado com sucesso. Saldo atual: R${saldo}");
                    break;

                case "3":
                    
                    Console.WriteLine($"Saldo atual: R${saldo}");
                    break;

                case "4":
                    
                    Console.Write("Digite o valor da transferência: ");
                    double valorTransferencia = Convert.ToDouble(Console.ReadLine());
                    if (valorTransferencia > saldo)
                    {
                        Console.WriteLine("Erro: Saldo insuficiente para transferência.");
                    }
                    else
                    {
                        saldo -= valorTransferencia;
                        Console.WriteLine($"Transferência de R${valorTransferencia} realizada com sucesso. Saldo atual: R${saldo}");
                    }
                    break;

                case "5":
                    
                    continuar = false;
                    Console.WriteLine("Saindo do caixa eletrônico. Até mais!");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
