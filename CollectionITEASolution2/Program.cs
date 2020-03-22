using System;
/*
 * Задание
1. Создать трехмерный массив (Int32)
2. Заполнить его рандомными данными
3. Размер вводим с консоли
4. Создать метод возвращающий самое большое значение из этого массива
5. Создать метод, который будет возвращать второе по величине значение из массива
6. Метод сортировки массива (любой который знаете/помните)
 */
namespace CollectionITEASolution2
{
    class Program
    {




        static void Main(string[] args)
        {
            try
            {
                int max = 0;
                int min = 0;
                Random random = new Random();

                Console.WriteLine("Dlina");
                int dlina = int.Parse(Console.ReadLine());
                Console.WriteLine("Shyrina");
                int shirina = int.Parse(Console.ReadLine());
                Console.WriteLine("Vysota");
                int vysota = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int[,,] thirdDimensionalArray = new int[dlina, shirina, vysota];


                for (int counter1 = 0; counter1 < thirdDimensionalArray.GetLength(dlina); counter1++)
                {
                    for (int counter2 = 0; counter2 < thirdDimensionalArray.GetLength(shirina - 1); counter2++)
                    {
                        for (int counter3 = 0; counter3 < thirdDimensionalArray.GetLength(vysota - 1); counter3++)
                        {
                            thirdDimensionalArray[dlina, shirina, vysota] = random.Next(100);
                            Console.WriteLine("Nash trehmernyi massiv", thirdDimensionalArray[counter1, counter2, counter3]);

                        }
                    }
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + "Глупости несешь");
            }
            //----------------------------------------------------------------------------------------------------------------------------------------------
            //tr
           // for (int counter1 = 0; counter1 < dlina - 1; counter1++)
//{
            //    for (int counter2 = 0; counter2 < shirina -  1; counter2++)
             //   {
                //    for (int counter3 = 0; counter3 < vysota - 1; counter3++)
                //    {
                 //       if(thirdDimensionalArray[dlina, shirina, vysota] > max)
                 //       {
                 //           max = thirdDimensionalArray[dlina, shirina, vysota];
                  //          Console.WriteLine(max);
                 //           Console.WriteLine();

                 //       }
               //     }
                   Console.ReadKey();
         //       }

        //    }
               // a[i] = rand.Next(-100, 100);
               // textBox1.Text += " " + a[i];
              //  if (a[i] > max)
               // {
               //     max = a[i];
               // }
                //---------------------------------------------------------------------------------------------------------------------------
              //  for (int i = 0; i < (size - 1); i++)
           // {
            //    if (max2 < mas2[i]) max2 = mas2[i];  // Находим второе по величине число
          //  }

        }
    }
}
