using MiniGameAPIBase.Debugger;
using MiniGameAPIBase.Extensions;
using MiniGameAPIBase.Model.Abstract;
using MiniGameAPIBase.Model.Concrete.Factories;

namespace MiniGameAPI
{
    class Program
    {
        /// <summary>
        /// Тестовое приложение для работы по ТЗ. Это не Unit test.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            // Старт игры
            string worldName = StartGame();

            // Создадим новый игровой мир
            var worldFactory = new WorldFactory();
            IWorld world = worldFactory.CreateWorld(worldName);

            try
            {
                #region Test for Game World

                // теперь немного процедурного программирования для теста, добавляем свойства и поведение для юнитов
                // проверим API с помощью случайного заполнения свойст юнитов
                Console.WriteLine("Fill the World ...");
                WorldDebbuger.FillTheWorldForTest(world);

                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Demo Game ...");
                WorldDebbuger.DemoGame(world);

                #endregion // Test for Game World
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                EndGame();
            }
        }

        /// <summary>
        /// Старт игры.
        /// </summary>
        private static string StartGame()
        {
            // Старт игры
            Console.WriteLine("Start the Game! ... Enter New World Name.");
            string worldName = String.Empty;

            while (worldName.IsEmpty())
            {
                worldName = Console.ReadLine();

                if (worldName.IsEmpty())
                    Console.WriteLine("Enter New World Name!");
            }

            return worldName;
        }

        /// <summary>
        /// Окончание игры.
        /// </summary>
        private static void EndGame()
        {
            Console.WriteLine("Done");
            Console.Read();
        }
    }
}



