namespace MiniGameAPIBase.Model.Abstract
{
    /// <summary>
    /// Интерфейс для создания юнитов.
    /// </summary>
    public interface IUnitFactory
    {
        /// <summary>
        /// Создание юнита.
        /// </summary>
        /// <param name="name">Название юнита.</param>
        IUnit CreateUnit(string name);

        /// <summary>
        /// Создание юнита.
        /// </summary>
        /// <param name="name">Название юнита.</param>
        /// <param name="states">Состояния юнита.</param>
        /// <param name="commands">Команды юнита.</param>
        IUnit CreateUnit(string name, IState state, List<ICommand> commands);
    }
}
