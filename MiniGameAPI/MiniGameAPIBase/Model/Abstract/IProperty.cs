using MiniGameAPIBase.Model.Enums;

namespace MiniGameAPIBase.Model.Abstract
{
    /// <summary>
    /// Свойство юнита. Характеризует состояние.
    /// </summary>
    public interface IProperty
    {
        /// <summary>
        /// Имя свойства.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Тип свойства.
        /// </summary>
        PropertyType Type { get; set; }
    }
}
