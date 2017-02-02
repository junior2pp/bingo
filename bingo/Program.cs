using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Collections;
using System.Media;
using System.Speech.Synthesis;

namespace bingo
{
    class Program
    {


        static void mostrar(int[,] matriz1, Stack pila1)
        {

            for (int i = 0; i < 9; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    Console.SetCursorPosition((i * 4) + 1, (j * 1) + 3);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila1)
                    {
                        if (matriz1[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }
                    Console.Write(matriz1[i, j]);
                }
            }
        }
        static int[,] matriz1; 
        static int[,] matriz2;
        static int[,] matriz3;
        static int[,] matriz4;
        static int[,] matriz5;
        static int[,] matriz6;
        static int[,] matriz7;
        static int[,] matriz8; 
        static int[,] matriz9; 
        static int[,] matriz10;
        static int[,] matriz11;
        static int[,] matriz12;
        static int[,] matriz13; 
        static int[,] matriz14;
        static int[,] matriz15;
        static int[,] matriz16;
        static int[,] matriz17;
        static int[,] matriz18;

        static List<int> lista1 = new List<int>();
        static List<int> lista2 = new List<int>();
        static List<int> lista3 = new List<int>();
        static List<int> lista4 = new List<int>();
        static List<int> lista5 = new List<int>();
        static List<int> lista6 = new List<int>();
        static List<int> lista7 = new List<int>();
        static List<int> lista8 = new List<int>();
        static List<int> lista9 = new List<int>();
        static List<int> lista10 = new List<int>();
        static List<int> lista11 = new List<int>();
        static List<int> lista12 = new List<int>();
        static List<int> lista13 = new List<int>();
        static List<int> lista14 = new List<int>();
        static List<int> lista15 = new List<int>();
        static List<int> lista16 = new List<int>();
        static List<int> lista17 = new List<int>();
        static List<int> lista18 = new List<int>();


        static void limpiarlistas()
        {
            lista1.Clear();
            lista2.Clear();
            lista3.Clear();
            lista4.Clear();
            lista5.Clear();
            lista6.Clear();
            lista7.Clear();
            lista8.Clear();
            lista9.Clear();
            lista10.Clear();
            lista11.Clear();
            lista12.Clear();
            lista13.Clear();
            lista14.Clear();
            lista15.Clear();
            lista16.Clear();
            lista17.Clear();
            lista18.Clear();





        }
        static void marcarjugadores(Stack pila2)
        {

            foreach (int item in pila2)
            {
                lista1.Remove(item);
                lista2.Remove(item);
                lista3.Remove(item);
                lista4.Remove(item);
                lista5.Remove(item);
                lista6.Remove(item);
                lista7.Remove(item);
                lista8.Remove(item);
                lista9.Remove(item);
                lista10.Remove(item);
                lista11.Remove(item);
                lista12.Remove(item);
                lista13.Remove(item);
                lista14.Remove(item);
                lista15.Remove(item);
                lista16.Remove(item);
                lista17.Remove(item);
                lista18.Remove(item);

            }
            Console.SetCursorPosition(46, 0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("JUGADOR 1");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((i * 4) + 42, (j * 1) + 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila2)
                    {
                        
                        if (matriz1[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            
                        }

                    }
                    Console.Write(matriz1[i, j]);
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(46, 6);
            Console.Write("JUGADOR 2");
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((i * 4) + 42, (j * 1) + 8);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila2)
                    {
                        
                        if (matriz2[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }
                    Console.Write(matriz2[i, j]);
                }
            }



            Console.SetCursorPosition(46, 12);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("JUGADOR 3");
            Console.SetCursorPosition(2, 21);
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((i * 4) + 42, (j * 1) + 14);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila2)
                    {
                        
                        if (matriz3[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            
                        }

                    }
                    Console.Write(matriz3[i, j]);
                }
            }




            Console.SetCursorPosition(46, 18);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("JUGADOR 4");
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((i * 4) + 42, (j * 1) + 20);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila2)
                    {
                        
                        if (matriz4[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }
                    Console.Write(matriz4[i, j]);
                }
            }




            Console.SetCursorPosition(46,24);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("JUGADOR 5");
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((i * 4) + 42, (j * 1) + 26);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila2)
                    {
                        if (matriz5[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }
                    Console.Write(matriz5[i, j]);
                }
            }



            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(46, 30);
            Console.Write("JUGADOR 6");
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((i * 4) + 42, (j * 1) + 32);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila2)
                    {
                        if (matriz6[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }
                    Console.Write(matriz6[i, j]);
                }
            }

            Console.SetCursorPosition(73, 0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("JUGADOR 7");
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((i * 4) + 69, (j * 1) + 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila2)
                    {
                        if (matriz7[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }
                    Console.Write(matriz7[i, j]);
                }
            }

            Console.SetCursorPosition(73, 6);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("JUGADOR 8");
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((i * 4) + 69, (j * 1) + 8);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila2)
                    {
                        if (matriz8[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }
                    Console.Write(matriz8[i, j]);
                }
            }
            Console.SetCursorPosition(73, 12);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("JUGADOR 9");
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((i * 4) + 69, (j * 1) + 14);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila2)
                    {
                        if (matriz9[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }
                    Console.Write(matriz9[i, j]);
                }
            }
            Console.SetCursorPosition(73, 18);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("JUGADOR 10");
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((i * 4) + 69, (j * 1) + 20);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila2)
                    {
                        if (matriz10[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }
                    Console.Write(matriz10[i, j]);
                }
            }
            Console.SetCursorPosition(73, 24);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("JUGADOR 11");
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((i * 4) + 69, (j * 1) + 26);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila2)
                    {
                        if (matriz11[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }
                    Console.Write(matriz11[i, j]);
                }
            }
            Console.SetCursorPosition(73, 30);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("JUGADOR 12");
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((i * 4) + 69, (j * 1) + 32);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila2)
                    {
                        if (matriz12[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }
                    Console.Write(matriz12[i, j]);
                }
            }
            Console.SetCursorPosition(100, 0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("JUGADOR 13");
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((i * 4) + 96, (j * 1) + 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila2)
                    {
                        if (matriz13[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }
                    Console.Write(matriz13[i, j]);
                }
            }
            Console.SetCursorPosition(100, 6);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("JUGADOR 14");
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((i * 4) + 96, (j * 1) + 8);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila2)
                    {
                        if (matriz14[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }
                    Console.Write(matriz14[i, j]);
                }
            }
            Console.SetCursorPosition(100, 12);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("JUGADOR 15");
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((i * 4) + 96, (j * 1) + 14);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila2)
                    {
                        if (matriz15[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }
                    Console.Write(matriz15[i, j]);
                }
            }
            Console.SetCursorPosition(100, 18);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("JUGADOR 16");
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((i * 4) + 96, (j * 1) + 20);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila2)
                    {
                        if (matriz16[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }
                    Console.Write(matriz16[i, j]);
                }
            }
            Console.SetCursorPosition(100, 24);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("JUGADOR 17");
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((i * 4) + 96, (j * 1) + 26);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila2)
                    {
                        if (matriz17[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }
                    Console.Write(matriz17[i, j]);
                }
            }
            Console.SetCursorPosition(100, 30);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("JUGADOR 18");
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((i * 4) + 96, (j * 1) + 32);
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (int item in pila2)
                    {
                        if (matriz18[i, j] == item)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }
                    Console.Write(matriz18[i, j]);
                }
            }
        }
        static void jugadores()
        {

            matriz1 = new int[5,3];
            matriz1[0, 0] = 12;
            matriz1[0, 1] = 29;
            matriz1[0, 2] = 8;
            matriz1[1, 0] = 22;
            matriz1[1, 1] = 47;
            matriz1[1, 2] = 32;
            matriz1[2, 0] = 50;
            matriz1[2, 1] = 54;
            matriz1[2, 2] = 49;
            matriz1[3, 0] = 64;
            matriz1[3, 1] = 76;
            matriz1[3, 2] = 65;
            matriz1[4, 0] = 81;
            matriz1[4, 1] = 83;
            matriz1[4, 2] = 77;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lista1.Add(matriz1[i,j]);
                }
            }
            matriz2 = new int[5, 3];
            matriz2[0, 0] = 17;
            matriz2[0, 1] = 4;
            matriz2[0, 2] = 18;
            matriz2[1, 0] = 23;
            matriz2[1, 1] = 28;
            matriz2[1, 2] = 37;
            matriz2[2, 0] = 53;
            matriz2[2, 1] = 31;
            matriz2[2, 2] = 44;
            matriz2[3, 0] = 70;
            matriz2[3, 1] = 58;
            matriz2[3, 2] = 69;
            matriz2[4, 0] = 80;
            matriz2[4, 1] = 73;
            matriz2[4, 2] = 87;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lista2.Add(matriz2[i, j]);
                }
            }
            matriz3 = new int[5, 3];
            matriz3[0, 0] = 2;
            matriz3[0, 1] = 27;
            matriz3[0, 2] = 3;
            matriz3[1, 0] = 24;
            matriz3[1, 1] = 30;
            matriz3[1, 2] = 11;
            matriz3[2, 0] = 43;
            matriz3[2, 1] = 59;
            matriz3[2, 2] = 33;
            matriz3[3, 0] = 72;
            matriz3[3, 1] = 61;
            matriz3[3, 2] = 46;
            matriz3[4, 0] = 88;
            matriz3[4, 1] = 90;
            matriz3[4, 2] = 68;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lista3.Add(matriz3[i, j]);
                }
            }
            matriz4 = new int[5, 3];
            matriz4[0, 0] = 6;
            matriz4[0, 1] = 14;
            matriz4[0, 2] = 9;
            matriz4[1, 0] = 10;
            matriz4[1, 1] = 36;
            matriz4[1, 2] = 20;
            matriz4[2, 0] = 45;
            matriz4[2, 1] = 48;
            matriz4[2, 2] = 55;
            matriz4[3, 0] = 71;
            matriz4[3, 1] = 60;
            matriz4[3, 2] = 63;
            matriz4[4, 0] = 82;
            matriz4[4, 1] = 78;
            matriz4[4, 2] = 84;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lista4.Add(matriz4[i, j]);
                }
            }
            matriz5 = new int[5, 3];
            matriz5[0, 0] = 15;
            matriz5[0, 1] = 26;
            matriz5[0, 2] = 7;
            matriz5[1, 0] = 38;
            matriz5[1, 1] = 39;
            matriz5[1, 2] = 19;
            matriz5[2, 0] = 41;
            matriz5[2, 1] = 51;
            matriz5[2, 2] = 42;
            matriz5[3, 0] = 66;
            matriz5[3, 1] = 75;
            matriz5[3, 2] = 52;
            matriz5[4, 0] = 86;
            matriz5[4, 1] = 89;
            matriz5[4, 2] = 79;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lista5.Add(matriz5[i, j]);
                }
            }
            matriz6 = new int[5, 3];
            matriz6[0, 0] = 1;
            matriz6[0, 1] = 5;
            matriz6[0, 2] = 16;
            matriz6[1, 0] = 13;
            matriz6[1, 1] = 21;
            matriz6[1, 2] = 25;
            matriz6[2, 0] = 34;
            matriz6[2, 1] = 35;
            matriz6[2, 2] = 40;
            matriz6[3, 0] = 56;
            matriz6[3, 1] = 67;
            matriz6[3, 2] = 57;
            matriz6[4, 0] = 62;
            matriz6[4, 1] = 85;
            matriz6[4, 2] = 74;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lista6.Add(matriz6[i, j]);
                }
            }
            matriz7 = new int[5, 3];
            matriz7[0, 0] = 8;
            matriz7[0, 1] = 13;
            matriz7[0, 2] = 24;
            matriz7[1, 0] = 22;
            matriz7[1, 1] = 30;
            matriz7[1, 2] = 38;
            matriz7[2, 0] = 53;
            matriz7[2, 1] = 40;
            matriz7[2, 2] = 58;
            matriz7[3, 0] = 74;
            matriz7[3, 1] = 67;
            matriz7[3, 2] = 68;
            matriz7[4, 0] = 80;
            matriz7[4, 1] = 79;
            matriz7[4, 2] = 90;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lista7.Add(matriz7[i, j]);
                }
            }

            matriz8 = new int[5, 3];
            matriz8[0, 0] = 11;
            matriz8[0, 1] = 6;
            matriz8[0, 2] = 9;
            matriz8[1, 0] = 20;
            matriz8[1, 1] = 23;
            matriz8[1, 2] = 19;
            matriz8[2, 0] = 46;
            matriz8[2, 1] = 32;
            matriz8[2, 2] = 35;
            matriz8[3, 0] = 50;
            matriz8[3, 1] = 60;
            matriz8[3, 2] = 52;
            matriz8[4, 0] = 81;
            matriz8[4, 1] = 76;
            matriz8[4, 2] = 69;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lista8.Add(matriz8[i, j]);
                }
            }
            matriz9 = new int[5, 3];
            matriz9[0, 0] = 1;
            matriz9[0, 1] = 27;
            matriz9[0, 2] = 16;
            matriz9[1, 0] = 14;
            matriz9[1, 1] = 34;
            matriz9[1, 2] = 39;
            matriz9[2, 0] = 45;
            matriz9[2, 1] = 55;
            matriz9[2, 2] = 48;
            matriz9[3, 0] = 63;
            matriz9[3, 1] = 70;
            matriz9[3, 2] = 66;
            matriz9[4, 0] = 84;
            matriz9[4, 1] = 87;
            matriz9[4, 2] = 73;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lista9.Add(matriz9[i, j]);
                }
            }
            matriz10 = new int[5, 3];
            matriz10[0, 0] = 2;
            matriz10[0, 1] = 7;
            matriz10[0, 2] = 26;
            matriz10[1, 0] = 10;
            matriz10[1, 1] = 21;
            matriz10[1, 2] = 49;
            matriz10[2, 0] = 47;
            matriz10[2, 1] = 31;
            matriz10[2, 2] = 57;
            matriz10[3, 0] = 77;
            matriz10[3, 1] = 54;
            matriz10[3, 2] = 78;
            matriz10[4, 0] = 82;
            matriz10[4, 1] = 64;
            matriz10[4, 2] = 86;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lista10.Add(matriz10[i, j]);
                }
            }
            matriz11 = new int[5, 3];
            matriz11[0, 0] = 3;
            matriz11[0, 1] = 15;
            matriz11[0, 2] = 5;
            matriz11[1, 0] = 33;
            matriz11[1, 1] = 28;
            matriz11[1, 2] = 17;
            matriz11[2, 0] = 41;
            matriz11[2, 1] = 59;
            matriz11[2, 2] = 36;
            matriz11[3, 0] = 71;
            matriz11[3, 1] = 61;
            matriz11[3, 2] = 43;
            matriz11[4, 0] = 83;
            matriz11[4, 1] = 88;
            matriz11[4, 2] = 65;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lista11.Add(matriz11[i, j]);
                }
            }
            matriz12 = new int[5, 3];
            matriz12[0, 0] = 4;
            matriz12[0, 1] = 25;
            matriz12[0, 2] = 18;
            matriz12[1, 0] = 12;
            matriz12[1, 1] = 37;
            matriz12[1, 2] = 29;
            matriz12[2, 0] = 42;
            matriz12[2, 1] = 51;
            matriz12[2, 2] = 44;
            matriz12[3, 0] = 62;
            matriz12[3, 1] = 72;
            matriz12[3, 2] = 56;
            matriz12[4, 0] = 85;
            matriz12[4, 1] = 89;
            matriz12[4, 2] = 75;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lista12.Add(matriz12[i, j]);
                }
            }
            matriz13 = new int[5, 3];
            matriz13[0, 0] = 8;
            matriz13[0, 1] = 22;
            matriz13[0, 2] = 19;
            matriz13[1, 0] = 12;
            matriz13[1, 1] = 30;
            matriz13[1, 2] = 29;
            matriz13[2, 0] = 40;
            matriz13[2, 1] = 53;
            matriz13[2, 2] = 48;
            matriz13[3, 0] = 68;
            matriz13[3, 1] = 74;
            matriz13[3, 2] = 54;
            matriz13[4, 0] = 83;
            matriz13[4, 1] = 87;
            matriz13[4, 2] = 75;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lista13.Add(matriz13[i, j]);
                }
            }
            matriz14 = new int[5, 3];
            matriz14[0, 0] = 9;
            matriz14[0, 1] = 28;
            matriz14[0, 2] = 18;
            matriz14[1, 0] = 13;
            matriz14[1, 1] = 35;
            matriz14[1, 2] = 37;
            matriz14[2, 0] = 46;
            matriz14[2, 1] = 56;
            matriz14[2, 2] = 49;
            matriz14[3, 0] = 63;
            matriz14[3, 1] = 71;
            matriz14[3, 2] = 67;
            matriz14[4, 0] = 84;
            matriz14[4, 1] = 89;
            matriz14[4, 2] = 77;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lista14.Add(matriz14[i, j]);
                }
            }
            matriz15 = new int[5, 3];
            matriz15[0, 0] = 3;
            matriz15[0, 1] = 11;
            matriz15[0, 2] = 26;
            matriz15[1, 0] = 21;
            matriz15[1, 1] = 32;
            matriz15[1, 2] = 39;
            matriz15[2, 0] = 51;
            matriz15[2, 1] = 43;
            matriz15[2, 2] = 52;
            matriz15[3, 0] = 70;
            matriz15[3, 1] = 60;
            matriz15[3, 2] = 65;
            matriz15[4, 0] = 85;
            matriz15[4, 1] = 72;
            matriz15[4, 2] = 90;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lista15.Add(matriz15[i, j]);
                }
            }
            matriz16 = new int[5, 3];
            matriz16[0, 0] = 10;
            matriz16[0, 1] = 2;
            matriz16[0, 2] = 7;
            matriz16[1, 0] = 24;
            matriz16[1, 1] = 25;
            matriz16[1, 2] = 17;
            matriz16[2, 0] = 45;
            matriz16[2, 1] = 31;
            matriz16[2, 2] = 34;
            matriz16[3, 0] = 55;
            matriz16[3, 1] = 61;
            matriz16[3, 2] = 58;
            matriz16[4, 0] = 81;
            matriz16[4, 1] = 73;
            matriz16[4, 2] = 69;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lista16.Add(matriz16[i, j]);
                }
            }
            matriz17 = new int[5, 3];
            matriz17[0, 0] = 4;
            matriz17[0, 1] = 14;
            matriz17[0, 2] = 5;
            matriz17[1, 0] = 36;
            matriz17[1, 1] = 27;
            matriz17[1, 2] = 16;
            matriz17[2, 0] = 42;
            matriz17[2, 1] = 50;
            matriz17[2, 2] = 38;
            matriz17[3, 0] = 49;
            matriz17[3, 1] = 64;
            matriz17[3, 2] = 47;
            matriz17[4, 0] = 80;
            matriz17[4, 1] = 82;
            matriz17[4, 2] = 66;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lista17.Add(matriz17[i, j]);
                }
            }
            matriz18 = new int[5, 3];
            matriz18[0, 0] = 1;
            matriz18[0, 1] = 6;
            matriz18[0, 2] = 23;
            matriz18[1, 0] = 15;
            matriz18[1, 1] = 20;
            matriz18[1, 2] = 44;
            matriz18[2, 0] = 41;
            matriz18[2, 1] = 33;
            matriz18[2, 2] = 59;
            matriz18[3, 0] = 76;
            matriz18[3, 1] = 57;
            matriz18[3, 2] = 78;
            matriz18[4, 0] = 86;
            matriz18[4, 1] = 62;
            matriz18[4, 2] = 88;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lista18.Add(matriz18[i, j]);
                }
            }

        }

        static void menu()
        {
            jugadores();
            int[,] matriz;
            Random r = new Random();

            matriz = new int[9, 10];

            int h = 1;
            for (int i = 0; i < 9; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    matriz[i, k] = h;
                    h++;
                }
            }

            Stack pila = new Stack();

            int f = 90;
            int cont = 0;
            int aleatorio = 0;
            bool estado = true;
            mostrar(matriz, pila);
            string[] ganadores;
            ganadores = new string[18];
            while (f != cont && estado)
            {
                aleatorio = r.Next(1, 90);
                if (pila.Contains(aleatorio) == false)
                {

                    pila.Push(aleatorio);
                    mostrar(matriz, pila);
                    cont++;
                    Console.SetCursorPosition(10, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NÚMERO GENERADO");
                    Console.SetCursorPosition(15, 1);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(aleatorio);
                    SpeechSynthesizer synth = new SpeechSynthesizer();
                    synth.SetOutputToDefaultAudioDevice();
                    string voz = aleatorio.ToString();

                    if (voz.Length == 2)
                    {
                        mostrar(matriz, pila);
                        marcarjugadores(pila);
                        synth.Speak(voz);
                        string part1 = voz[0].ToString();
                        string part2 = voz[1].ToString();
                        
                        synth.Speak(part1);
                        Thread.Sleep(20);
                        synth.Speak("i");
                        synth.Speak(part2);
                           
                        
                    }
                    else
                    {
                        marcarjugadores(pila);
                        mostrar(matriz, pila);
                        synth.Speak(voz);
                        Thread.Sleep(20);
                        synth.Speak(voz);
                        
                    }                   
                    marcarjugadores(pila);
                    if (lista1.Count == 0)
                    {
                        ganadores[0] = "BINGO JUGADOR 1";
                        estado = false;
                        
                    }
                    if (lista2.Count == 0)
                    {
                        ganadores[1] = "BINGO JUGADOR 2";
                        estado = false;
                    }
                    if (lista3.Count == 0)
                    {
                        ganadores[2] = "BINGO JUGADOR 3";
                        estado = false;
                    }
                    if (lista4.Count == 0)
                    {
                        ganadores[3] = "BINGO JUGADOR 4";
                        estado = false;
                        
                    }
                    if (lista5.Count == 0)
                    {
                        ganadores[4] = "BINGO JUGADOR 5";
                        estado = false;
                    }
                    if (lista6.Count == 0)
                    {
                        ganadores[5] = "BINGO JUGADOR 6";
                        estado = false;
                    }
                    if (lista7.Count == 0)
                    {
                        ganadores[6] = "BINGO JUGADOR 7";
                        estado = false;
                    }
                    if (lista8.Count == 0)
                    {
                        ganadores[7] = "BINGO JUGADOR 8";
                        estado = false;
                    }
                    if (lista9.Count == 0)
                    {
                        ganadores[8] = "BINGO JUGADOR 9";
                        estado = false;
                    }
                    if (lista10.Count == 0)
                    {
                        ganadores[9] = "BINGO JUGADOR 10";
                        estado = false;
                    }
                    if (lista11.Count == 0)
                    {
                        ganadores[10] = "BINGO JUGADOR 11";
                        estado = false;
                    }
                    if (lista12.Count == 0)
                    {
                        ganadores[11] = "BINGO JUGADOR 12";
                        estado = false;
                    }
                    if (lista13.Count == 0)
                    {
                        ganadores[12] = "BINGO JUGADOR 13";
                        estado = false;
                    }
                    if (lista14.Count == 0)
                    {
                        ganadores[13] = "BINGO JUGADOR 14";
                        estado = false;
                    }
                    if (lista15.Count == 0)
                    {
                        ganadores[14] = "BINGO JUGADOR 15";
                        estado = false;
                    }
                    if (lista16.Count == 0)
                    {
                        ganadores[15] = "BINGO JUGADOR 16";
                        estado = false;
                    }
                    if (lista17.Count == 0)
                    {
                        ganadores[16] = "BINGO JUGADOR 17";
                        estado = false;
                    }
                    if (lista18.Count == 0)
                    {
                        ganadores[17] = "BINGO JUGADOR 18";
                        estado = false;
                    }
                   
                }
               
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(5, 17);
            Console.Write("LISTA DE GANADORES");
            ganador();
            int j = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var item in ganadores)
            {
                Console.SetCursorPosition(5 , (19 + j));
                Console.Write(item);
                j++;
            }
            Console.ReadKey();
        }

        static void ganador()
        {
            SoundPlayer player2 = new SoundPlayer();
            player2.SoundLocation = "snake1.wav";
            player2.Play();
        }
        static void intropozo()
        {
            /*SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "pozo.wav";
            player.Play();
            Console.SetCursorPosition(30, 17);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("SI DAS AMOR");
            Thread.Sleep(3000);
            Console.Clear();
            Console.SetCursorPosition(30, 7);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("MERECES AMOR");
            Thread.Sleep(3000);
            Console.Clear();
            Console.SetCursorPosition(60, 7);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("SI DAS LA VIDA POR TU PAIS");
            Thread.Sleep(3000);
            Console.Clear();
            Console.SetCursorPosition(60, 17);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("MERECES SER INMORTAL");
            Thread.Sleep(3000);
            Console.Clear();
            Console.SetCursorPosition(45, 10);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("SI DAS YAPA ");
            Thread.Sleep(4000);
            Console.Clear();
            Console.SetCursorPosition(17, 19);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("MERECES MÁS CLIENTES");
            Thread.Sleep(4000);
            Console.Clear();
            Console.SetCursorPosition(45, 10);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("SI DAS LA CLASIFICACIÓN AL MUNDIAL");
            Thread.Sleep(3000);
            Console.Clear();
            Console.SetCursorPosition(65, 26);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("MERECES LA GLORIA");
            Thread.Sleep(4000);
            Console.Clear();
            Console.SetCursorPosition(65, 8);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("PERO LOS QUE MÁS MERECEN");
            Thread.Sleep(4000);
            Console.Clear();
            Console.SetCursorPosition(25, 26);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("SON LOS QUE QUIEREN DARLE");
            Thread.Sleep(9000);
            Console.Clear();
            Console.SetCursorPosition(25, 15);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("TODO A SU FAMILIA");
            Thread.Sleep(10000);
            Console.Clear();*/
            Console.SetCursorPosition(50, 8);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("POZO MILLONARIO");
            Console.SetCursorPosition(51, 11);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("TE LO MERECES");
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("HOLA, MI NOMBRE ES SASHA GREY");
            Thread.Sleep(500);
            synth.Speak("BIENVENIDO AL JUEGO DEL BINGO, DESARROLLADO POR MI CREADOR LUIS SUAREZ , PRESIONA ENTER PARA COMENZAR");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(19, 17);
            SoundPlayer player1 = new SoundPlayer();
            player1.SoundLocation = "gona.wav";
            player1.Play();
            Console.Write("Aguantas mientras avanzas, hay que soportar sin dejar de avanzar, así es como se gana.".ToUpper());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(37, 24);
            Console.Write("PRESIONA ENTER PARA EMPEZAR CON EL JUEGO");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(42, 20);
            Console.Write("Cargando Tablas...........OK");
            Console.Beep();
            Thread.Sleep(2000);
            Console.SetCursorPosition(42, 21);
            Console.Write("Cargando Bolas............OK");
            Console.Beep();
            Thread.Sleep(2000);
            Console.SetCursorPosition(42, 22);
            Console.Write("Cargando Tablero..........OK");
            Console.Beep();
            Thread.Sleep(2000);
            Console.SetCursorPosition(42, 24);
            Console.Write("LISTO");
            Console.Beep();
            Thread.Sleep(1000);
            player1.Stop();
            player1.SoundLocation = "impacto.wav";
            player1.Play();
            Console.Clear();
        }
        static void Main(string[] args)
        {

            intropozo();
            Console.Clear();
            menu();
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(50, 8);
                Console.Write("DESEA VOLVER A JUGAR SI/NO ===>  ");
                Console.ForegroundColor = ConsoleColor.Red;
                string respuesta = Console.ReadLine();
                if (respuesta.ToUpper() == "SI")
                {
                    //player1.Play();
                    limpiarlistas();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    menu();

                }
                if (respuesta.ToUpper() == "NO")
                {
                    Environment.Exit(0);
                }
                
            }
            
            
        }
    }
}
