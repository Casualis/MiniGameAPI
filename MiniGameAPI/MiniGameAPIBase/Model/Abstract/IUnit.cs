namespace MiniGameAPIBase.Model.Abstract
{
    /// <summary>
    /// Интерфейс Юнита игрового мира.
    /// </summary>
    public interface IUnit
    {
        /// <summary>
        /// Идентификатор юнита.
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Название юнита.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Состояние юнита.
        /// </summary>
        IState State { get; set; }

        /// <summary>
        /// Команды юнита.
        /// </summary>
        List<ICommand> Commands { get; set; }

        /// <summary>
        /// Исполнение команды.
        /// </summary>
        void ExecCommand(string commandName);


        /// <summary>
        /// Исполнение команды.
        /// </summary>
        void ExecCommand(ICommand command);
    }
}
