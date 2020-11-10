using System;

namespace FunzioniMatematiche
{
    public class Matematica
    {
        /// <summary>
        /// Questa funzione fa la somma tra due numeri interi 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int SommaInt(int a, int b)
        {

            return a + b;
        }
        /// <summary>
        /// Questa funzione fa la somma tra due numeri decimali
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double SommaDouble(double a, double b)
        {

            return a + b;
        }
        /// <summary>
        /// Questa funzione fa la sottrazione tra due numeri decimali
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Differenza(double a, double b)
        {

            return a - b;

        }
        /// <summary>
        /// Questa fnzione fra la moltiplicazione tra due numeri
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Moltiplicazione(double a, double b)
        {
            return a * b;

        }
        /// <summary>
        /// Questa funzione fa la divisione tra due numeri
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Divisione(double a, double b)
        {
            return a / b;

        }
        /// <summary>
        /// Questa funzione fa la potenza di un numero 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static long Potenza(int a, int b)
        {
            long p = 1;
            int cont = 0;
            for (; cont < b; cont++)
            {
                p = p * a;
            }
            return p;
        }
        /// <summary>
        /// Questa funzione fa il calcolo fattoriale di un mumero 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static long CalcoloFattoriale(int a)
        {
            long f = 1;
            int cont = 1;
            for (; cont <= a; cont++)
            {
                f = f * cont;
            }
            return f;
        }
        /// <summary>
        /// Questa funzione trova il minote tra tre numeri
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int MinoreTra(int a, int b, int c)
        {
            int min;
            if (a < b && a < c)
            {
                min = a;
            }
            else if (b < a && b < c)
            {
                min = b;
            }
            else
            {
                min = c;
            }
            return min;
        }
        /// <summary>
        /// Questa funzione trova il maggiore tra tre numeri
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int MaggioreTra(int a, int b, int c)
        {
            int max;
            if (a > b && a > c)
            {
                max = a;
            }
            else if (b > a && b > c)
            {
                max = b;
            }
            else
            {
                max = c;
            }
            return max;
        }
        /// <summary>
        /// Questa funzione inverte un numero da negativo a positivo o viceversa
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Inverso(int a)
        {
            return a = a * -1;
        }
        /// <summary>
        /// Questa funzione dice se un numero é pari
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool IsPari(int a)
        {
            bool IsPari;
            if (a % 2 == 0)
            {
                IsPari = true;
            }
            else
            {
                IsPari = false;
            }

            return IsPari;
        }
        /// <summary>
        /// Questa funzione dice se un numero é dispari
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool IsDispari(int a)
        {
            bool IsDispari;
            if (a % 2 == 0)
            {
                IsDispari = false;
            }
            else
            {
                IsDispari = true;
            }
            return IsDispari;
        }
        /// <summary>
        /// Questa funzione dice se un numero é positivo
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool IsPositivo(int a)
        {
            bool IsPositivo;
            if (a > 0)
            {
                IsPositivo = true;
            }
            else
            {
                IsPositivo = false;
            }
            return IsPositivo;
        }
        /// <summary>
        /// Questa funzione dice se un numero é negativo
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool IsNegativo(int a)
        {
            bool IsNegativo;
            if (a < 0)
            {
                IsNegativo = true;
            }
            else
            {
                IsNegativo = false;
            }
            return IsNegativo;
        }
    }
}
