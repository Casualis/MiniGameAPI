using MiniGameAPIBase.Model.Abstract;
using System.Collections.Generic;

namespace MiniGameAPIBase.Model.Concrete.Factories
{
    /// <summary>
    /// Фабрика для создания юнитов.
    /// </summary>
    public class UnitFactory : IUnitFactory
    {
        /// <summary>
        /// Счётчик идентификаторов юнитов.
        /// </summary>
        public static int UnitId = 1;

        /// <summary>
        /// Создание юнита.
        /// </summary>
        /// <param name="name">Название юнита.</param>
        public IUnit CreateUnit(IState state, List<ICommand> commands)
        {
            // здесь по идее надо создать юнит, который просит пользователь.
            // просто делаем новую сущность.
            return new Unit(state, commands);
        }

        /// <summary>
        /// Создание юнита.
        /// </summary>
        /// <param name="name">Название юнита.</param>
        /// <param name="states">Состояния юнита.</param>
        /// <param name="commands">Команды юнита.</param>
        public IUnit CreateUnit(string name, IState state, List<ICommand> commands)
        {
            // здесь по идее надо создать юнит, который просит пользователь.
            // просто делаем новую сущность.
            // но если у нас будет конечное число типов юнитов, то будем разбирать через switch-case.
            return new Unit(name, state, commands);
        }

        public IUnit CreateUnit(string name)
        {
            // здесь по идее надо создать юнит, который просит пользователь.
            // просто делаем новую сущность.
            // но если у нас будет конечное число типов юнитов, то будем разбирать через switch-case.
            return new Unit(name);
        }
    }
}
