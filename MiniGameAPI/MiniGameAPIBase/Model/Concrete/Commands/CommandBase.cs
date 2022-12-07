using MiniGameAPIBase.Model.Abstract;

namespace MiniGameAPIBase.Model.Concrete.Commands
{
    /// <summary>
    /// Базовый класс Команда.
    /// </summary>
    public abstract class CommandBase : ICommand
    {
        /// <summary>
        /// Событие изменени сосстояния (доступность/недоступность) команды.
        /// </summary>
        public virtual event EventHandler? EnabledChanged;

        public virtual string Name { get; set; }

        /// <summary>
        /// То что нужно делать этой команде.
        /// </summary>
        public virtual Action ExecAction { get; set; } = default;

        /// <summary>
        /// Признак доступности команды.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Параметры команды. Добавили, но не используем пока.
        /// </summary>
        public IEnumerable<object> Params { get; set; }

        public CommandBase()
        {
        }

        public CommandBase(string name, Action execAction, bool enabled) : this()
        {
            Name = name;
            Enabled = enabled;
            ExecAction = execAction;
        }

        /// <summary>
        /// Исполнение команды.
        /// </summary>
        public virtual void Exec()
        {
            if (ExecAction is null)
                throw new Exception($"Empty Command! Use ExecAction property for initialization me. Name - {Name}");

            try
            {
                // если команда доступна - выполняем.
                if (Enabled)
                {
                    ExecAction.Invoke();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
