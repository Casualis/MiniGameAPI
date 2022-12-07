using MiniGameAPIBase.Model.Abstract;
using MiniGameAPIBase.Model.Concrete.Factories;

namespace MiniGameAPIBase.Model.Concrete
{
    /// <summary>
    /// Игровой мир.
    /// </summary>
    public class World : IWorld
    {
        /// <summary>
        /// Название игрового мира.
        /// </summary>
        public string WorldName { get; set; }

        /// <summary>
        /// Фабрика для юнитов игрового мира. 
        /// </summary>
        protected IUnitFactory UnitFactory { get; set; }

        /// <summary>
        /// Список юнитов игрового мира.
        /// </summary>
        protected List<IUnit> Units { get; set; }

        public World(string worldName)
        {
            WorldName = worldName;
            Units = new List<IUnit>();
            UnitFactory = new UnitFactory();
        }

        public void AddUnit(IUnit unit)
        {
            Units.Add(unit);
        }

        public void CreateUnit(string unitName)
        {
           Units.Add(UnitFactory.CreateUnit(unitName));
        }

        public List<IUnit> GetUnits()
        {
            return Units;
        }

        public void AddUnits(List<IUnit> units)
        {
            Units.AddRange(units);
        }

        public IUnit GetUnit(int id)
        {
            IUnit unit = Units.FirstOrDefault(u => u.Id == id);

            if(unit is not null)
                return unit;

            throw new Exception($"Unit not found! Id - {id}");
        }

        public IUnit GetUnit(string unitName)
        {
            IUnit unit = Units.FirstOrDefault(u => u.Name == unitName);

            if (unit is not null)
                return unit;

            throw new Exception($"Unit not found! Name - {unitName}");
        }

        public void DeleteUnit(int id)
        {
            IUnit unit = Units.FirstOrDefault(u => u.Id == id);

            if (unit is not null)
                Units.Remove(unit);
        }

        public void DeleteUnit(string unitName)
        {
            var units = Units.Select(u => u.Name == unitName);

            if (units.Any())
            {

            }
        }
    }
}