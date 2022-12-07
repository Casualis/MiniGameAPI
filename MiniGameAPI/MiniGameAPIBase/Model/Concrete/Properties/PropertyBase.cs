using MiniGameAPIBase.Model.Abstract;
using MiniGameAPIBase.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameAPIBase.Model.Concrete.Properties
{
    /// <summary>
    /// Базовый класс Свойство.
    /// </summary>
    public abstract class PropertyBase : IProperty
    {
        /// <summary>
        /// Название свойства.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип свойства.
        /// </summary>
        public PropertyType Type { get; set; }

        public PropertyBase()
        {
            Name = "<Пустое свойство>";
            Type = PropertyType.None;
        }
    }
}
