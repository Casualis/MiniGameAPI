namespace MiniGameAPIBase.Model.Abstract
{
    /// <summary>
    /// Интерфейс команды.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Событие изменения доступности команды для выполнения.
        /// </summary>
        event EventHandler? EnabledChanged;

        /// <summary>
        /// То что нужно делать этой команде.
        /// </summary>
        Action ExecAction { get; set; }

        /// <summary>
        /// Название команды.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Признак доступности команды.
        /// </summary>
        bool Enabled { get; set; }

        /// <summary>
        /// Исполнение команды.
        /// </summary>
        void Exec();
    }
}
