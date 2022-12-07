using MiniGameAPIBase.Model.Abstract;
using System.Security.Cryptography.X509Certificates;

namespace MiniGameAPIBase.Model.Concrete.States
{
    /// <summary>
    /// Базовый класс состояния юнита.
    /// </summary>
    public class StateBase : IState
    {
        /// <summary>
        /// Имя состояния.
        /// </summary>
        public string StateName { get; set; }

        /// <summary>
        /// Набор свойств для состояния.
        /// </summary>
        public virtual List<IProperty> Properties { get; set; } = new List<IProperty>();

        /// <summary>
        /// Признаки выполнения команд. Состояние может не выполнять команд.
        /// </summary>
        public bool ApplyCommands { get; set; }

        public StateBase()
        {
            StateName = "<Имя состояния не задано>";
            Properties = new List<IProperty>();
            ApplyCommands = true;
        }

        public StateBase(string stateName, List<IProperty> properties, bool applyCommands)
        {
            StateName = stateName;
            Properties = properties;
            ApplyCommands = applyCommands;
        }

        /// <summary>
        /// Список свойств состояния.
        /// </summary>
        public virtual string GetPropertiesNames()
        {
            return String.Join(",", Properties.Select(p => p.Name));
        }
    }
}
