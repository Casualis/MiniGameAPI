using MiniGameAPIBase.Debugger.DemoStates;
using MiniGameAPIBase.Extensions;
using MiniGameAPIBase.Model.Abstract;
using MiniGameAPIBase.Model.Concrete.Factories;
using System.Collections.Generic;

namespace MiniGameAPIBase.Model.Concrete
{
    /// <summary>
    /// Класс юнита в игровом мире.
    /// </summary>
    public class Unit : IUnit
    {
        /// <summary>
        /// Идентификатор юнита.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Название юнита.
        /// </summary>
        public string Name { get; set; }
        
        public IState State { get; set; }
        
        public List<ICommand> Commands { get; set; }

        /// <summary>
        /// Конструктор для пустого юнита.
        /// </summary>
        /// <param name="name"></param>
        public Unit(string name)
        {
            Id = UnitFactory.UnitId++;
            Name = "<Без имени>";
            State = new EmptyState();
        }

        public Unit(IState state, List<ICommand> commands)
        {
            Id = UnitFactory.UnitId++;
            State = state;
            Commands = commands;
        }

        public Unit(string name, IState state, List<ICommand> commands) : this(state, commands)
        {
            Name = name;
        }

        /// <summary>
        /// Исполнение команды.
        /// </summary>
        public virtual void ExecCommand(string commandName)
        {
            if (State.ApplyCommands && !commandName.IsEmpty() && Commands.Any(c => c.Name == commandName))
            {
                Commands.First().Exec();
            }
            else
                throw new Exception($"It's not command for me! {commandName}");
        }

        /// <summary>
        /// Исполнение команды.
        /// </summary>
        public virtual void ExecCommand(ICommand command)
        {
            if (State.ApplyCommands && command is not null && Commands.Any(c => c.Name == command.Name))
                command.Exec();
            else
                throw new Exception($"It's not command for me! {command?.Name}");
        }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
