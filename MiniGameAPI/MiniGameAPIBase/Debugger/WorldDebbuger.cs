using Microsoft.VisualBasic;
using MiniGameAPIBase.Debugger.DemoCommands;
using MiniGameAPIBase.Debugger.DemoPositions;
using MiniGameAPIBase.Debugger.DemoStates;
using MiniGameAPIBase.Debugger.DemoUnits;
using MiniGameAPIBase.Extensions;
using MiniGameAPIBase.Model.Abstract;
using MiniGameAPIBase.Model.Concrete.States;
using System.Dynamic;
using System.Runtime.ExceptionServices;

namespace MiniGameAPIBase.Debugger
{
    /// <summary>
    /// Класс отладки и демонстрации возможностей API.
    /// </summary>
    public class WorldDebbuger
    {
        /// <summary>
        /// Набор состояний для Demo версии API. Пример создания новых пользовательских состояний.
        /// </summary>
        public static List<IState> DemoStates { get; } = new List<IState>()
        {
            new AmmoState() { Properties = new List<IProperty>() { new AmmoProperty() } },
            new DirectionState() { Properties = new List<IProperty>() { new DirectionProperty() } },
            new PositionState() { Properties = new List<IProperty>() { new PositionProperty() } }
        };

        /// <summary>
        /// Набор команд для Demo версии API. Пример созданых пользовательских команд.
        /// </summary>
        public static List<ICommand> DemoCommands { get; } = new List<ICommand>()
        {
            new FireCommand(),
            new ForwardCommand(),
            new TurnLeftCommand(),
            new TurnRightCommand()
        };

        /// <summary>
        /// Наполняет игровой мир тестовыми юнитами. Метод для тестирования. Демонстрация исаользования API.
        /// </summary>
        public static void FillTheWorldForTest(IWorld world)
        {
            // TODO: Здесь, конечно, можно обернуть создание юнитов отдельным методом. Но так нагляднее.  

            // Трактор
            IState tractorState = new StateBase() 
            { 
                Properties = new List<IProperty>() { new PositionProperty(), new DirectionProperty() } 
            };
            List<ICommand> tractorCommands = new List<ICommand>()
            {
                new ForwardCommand(),
                new TurnLeftCommand(),
                new TurnRightCommand()
            };
            TractorUnit tractorUnit = new TractorUnit(tractorState, tractorCommands);

            // Камень
            IState rockState = new StateBase()
            {
                Properties = new List<IProperty>() { new PositionProperty() }
            };
            RockUnit rockUnit = new RockUnit(tractorState, null);

            // Ветер
            IState windState = new StateBase()
            {
                Properties = new List<IProperty>() { new DirectionProperty() }
            };
            List<ICommand> windCommands = new List<ICommand>()
            {
                new TurnLeftCommand(),
                new TurnRightCommand()
            };
            WindUnit windUnit = new WindUnit(windState, windCommands);

            // Сторожевая башня
            IState watchState = new StateBase()
            {
                Properties = new List<IProperty>() { new DirectionProperty(), new PositionProperty() , new AmmoProperty() }
            };
            List<ICommand> watchCommands = new List<ICommand>()
            {
                new TurnLeftCommand(),
                new TurnRightCommand(),
                new FireCommand()
            };
            WatchTower watchTower = new WatchTower(watchState, watchCommands);

            // Добавляем юниты в игровой мир
            world.AddUnits(new List<IUnit>() { tractorUnit, rockUnit, windUnit, watchTower });

            /* это комментируем - тестовый код
            // кол-во юнитов
            int countUnits = world.GetUnits().Count;

            // кол-во доступных состояний
            int countStates = DemoStates.Count;

            // кол-во доступных команд
            int countCommands = DemoCommands.Count;

            // объект для генерирования случайных последовательностей
            Random rnd = new Random(Int32.MaxValue);

            foreach (var unit in world.GetUnits())
            {
                // выбираем случайное состояние
                unit.State = GetRandom(DemoStates, rnd);

                // выбираем случайны набор команд
                (int first, int last) interval = rnd.GetRandomInterval(countStates);
                unit.Commands = GetInterval(DemoCommands, interval.first, interval.last).ToList();
            }
            */
        }

        /// <summary>
        /// Демо версия использования API.
        /// </summary>
        /// <param name="world"></param>
        public static void DemoGame(IWorld world)
        {
            CheckTheGame(world);

            foreach (var unit in world.GetUnits())
            {
                if(unit.State.ApplyCommands && unit.Commands is not null)
                {
                    foreach (var command in unit.Commands)
                        command.Exec();
                }
            }
        }

        /// <summary>
        /// Проверка валидности игрового мира. Игровой мир не может быть пустым.
        /// </summary>
        private static void CheckTheGame(IWorld world)
        {
            if (world is null || !world.GetUnits().Any())
            {
                throw new Exception("World is Empty!");
            }
        }

        /// <summary>
        /// Возвращает элемент из массива.
        /// </summary>
        private static T GetRandom<T>(List<T> array, Random rnd)
        {
            if (array is null || !array.Any())
                return default(T);

            int count = array.Count;

            return array[rnd.Next(0, count - 1)];
        }


        /// <summary>
        /// Возвращает набор элементов из массива.
        /// </summary>
        private static IEnumerable<T> GetInterval<T>(List<T> array, int first, int last)
        {
            for(int i = first; i <= last; i++)
            {
                yield return array[i];
            }
        }
    }
}
