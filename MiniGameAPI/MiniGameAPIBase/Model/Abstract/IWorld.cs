namespace MiniGameAPIBase.Model.Abstract
{
    /// <summary>
    /// Интерфейс игрового мира.
    /// </summary>
    public interface IWorld
    {
        /// <summary>
        /// Название игрового мира.
        /// </summary>
        string WorldName { get; set; }

        /// <summary>
        /// Добавление юнита.
        /// </summary>
        /// <param name="unit"></param>
        void AddUnit(IUnit unit);

        /// <summary>
        /// Добавление юнита.
        /// </summary>
        /// <param name="unit"></param>
        void AddUnits(List<IUnit> units);

        /// <summary>
        /// Создани нового юнита.
        /// </summary>
        void CreateUnit(string unitName);

        /// <summary>
        /// Список юнитов игрового мира.
        /// </summary>
        List<IUnit> GetUnits();

        /// <summary>
        /// Поиск юнита.
        /// </summary>
        IUnit GetUnit(int id);

        /// <summary>
        /// Поиск юнита.
        /// </summary>
        IUnit GetUnit(string unitName);

        /// <summary>
        /// Удаление юнита.
        /// </summary>
        void DeleteUnit(int id);

        /// <summary>
        /// Удаление юнита.
        /// </summary>
        void DeleteUnit(string unitName);
    }
}
