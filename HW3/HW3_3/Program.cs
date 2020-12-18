using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1 корабль — ряд из 4 клеток
             * 2 корабля — ряд из 3 клеток
             * 3 корабля — ряд из 2 клеток
             * 4 корабля — 1 клетка
            */
            var rand = new Random();
            int[,] ships = { { 4, 3, 2, 1 }, { 1, 2, 3, 4 } };
            string[,] field = new string[12, 12];

            int x = 0;
            int y = 0;
            int drctn = 0;
            string tmp = " # ";
            string ok = " X ";
            string empty = "|_|";
            int allShips = 0;
            int oneShip = 0;

            bool check = false;

            //to do завернуть в цикл
            field[0, 0] = "   ";   field[11, 0] = "   ";
            field[0, 1] = " A ";   field[11, 1] = " A ";
            field[0, 2] = " B ";   field[11, 2] = " B ";
            field[0, 3] = " С ";   field[11, 3] = " С ";
            field[0, 4] = " D ";   field[11, 4] = " D ";
            field[0, 5] = " E ";   field[11, 5] = " E ";
            field[0, 6] = " F ";   field[11, 6] = " F ";
            field[0, 7] = " G ";   field[11, 7] = " G ";
            field[0, 8] = " H ";   field[11, 8] = " H ";
            field[0, 9] = " I ";   field[11, 9] = " I ";
            field[0, 10] = " F ";  field[11, 10] = " F ";

            field[1, 0] = " 1 ";  field[1, 11] = " 1 ";
            field[2, 0] = " 2 ";  field[2, 11] = " 2 ";
            field[3, 0] = " 3 ";  field[3, 11] = " 3 ";
            field[4, 0] = " 4 ";  field[4, 11] = " 4 ";
            field[5, 0] = " 5 ";  field[5, 11] = " 5 ";
            field[6, 0] = " 6 ";  field[6, 11] = " 6 ";
            field[7, 0] = " 7 ";  field[7, 11] = " 7 ";
            field[8, 0] = " 8 ";  field[8, 11] = " 8 ";
            field[9, 0] = " 9 ";  field[9, 11] = " 9 ";
            field[10, 0] = " 10"; field[10, 11] = " 10";

            //заполняем поле

            for (int i = 1; i < field.GetLength(0)-1; i++)
            {
                for (int j = 1; j < field.GetLength(1)-1; j++)
                {
                    field[i, j] = empty;
                }
            }


            //Проверяем в целом можем ли построить такой корабль
            //Если выпала горизонталь
            while(allShips <= 3 && oneShip <= ships[1, allShips])
            {
                check = false;
                while (!check) {
                    check = true;
                    x =  rand.Next(1, 11);
                    y =  rand.Next(1, 11);
                    drctn =  rand.Next(1, 3);

                    //Console.WriteLine($"Точка X {x}, Точка Y {y}, направление {drctn}, корабль {allShips} : кол-во {oneShip}");

                    if (drctn == 1)
                    {
                        if (x + ships[0, allShips] < 11)
                        { //поместились по горизонтали
                            for (int i = 0; i < ships[0, allShips]; i++)
                            {
                                if (field[y, x + i] == ok || field[y - 1, x + i] == ok || field[y + 1, x + i] == ok || field[y, x - 1 + i] == ok || field[y , x + 1 + i] == ok)
                                {
                                    check = false;
                                    break;
                                }

                                field[y, x + i] = tmp;

                            }
                        } else 
                            check = false;
                    }

                    if (drctn == 2)
                    {
                        if (y + ships[0, allShips] < 11 )
                        { //поместились по вертикали
                            for (int i = 0; i < ships[0, allShips]; i++)
                            {
                                if (field[y + i, x] == ok || field[y + i, x - 1] == ok || field[y + i, x + 1] == ok || field[y - 1 + i, x] == ok || field[y + 1 + i, x] == ok)
                                {
                                    check = false;
                                    break;
                                }

                                field[y + i, x] = tmp;

                            }
                        } else
                            check = false;
                    }

                    //  фиксируем результат
                    for (int i = 0; i < field.GetLength(0); i++)
                    {
                        for (int j = 0; j < field.GetLength(1); j++)
                        {
                            if (field[i, j] == tmp)
                                field[i, j] = check ? ok : empty;
                        }
                    }

                    if (check)
                    {
                        
                        oneShip++;
                        Console.WriteLine($"Точка X {x}, Точка Y {y}, направление {drctn} корабль {allShips} : кол-во {oneShip} из {ships[1, allShips]}");
                        if (oneShip == ships[1, allShips])
                        {
                            allShips++;
                            oneShip = 0;
                        }
                        
                    }
                }

                //oneShip <= ships[1, allShips]

            }
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
