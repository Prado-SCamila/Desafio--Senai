using System;

namespace Desafio__Senai
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("Olá, nadador! Qual é a sua idade?");
            i = int.Parse(Console.ReadLine());

            if(i>=5 && i<=7){
                Console.WriteLine("CATEGORIA : Infantil A");
            } else if(i>=8 && i<=10){
                Console.WriteLine("CATEGORIA: Infantil B");
            } else if( i>=11 && i<=13){
                Console.WriteLine("CATEGORIA: Juvenil A");
            }else if( i>=14 && i<=17){
                Console.WriteLine("CATEGORIA: Juvenil B");
            }else if( i> 18){
                Console.WriteLine("CATEGORIA: Sênior");
            }
        }
    }
}
