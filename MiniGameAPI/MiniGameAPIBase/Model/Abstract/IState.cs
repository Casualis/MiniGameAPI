namespace MiniGameAPIBase.Model.Abstract
{
    /// <summary>
    /// Состояние юнита.
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// Название состояния.
        /// </summary>
        string StateName { get; set; }

        /// <summary>
        /// Набор свойств.
        /// </summary>
        List<IProperty> Properties { get; set; }

        /// <summary>
        /// Список свойств состояния.
        /// </summary>
        string GetPropertiesNames();

        /// <summary>
        /// Признаки выполнения команд. Состояние может не выполнять команд.
        /// </summary>
        bool ApplyCommands { get; set; }
    }
}
