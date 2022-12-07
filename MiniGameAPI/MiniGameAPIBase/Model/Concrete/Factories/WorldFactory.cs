using MiniGameAPIBase.Model.Abstract;

namespace MiniGameAPIBase.Model.Concrete.Factories
{
    public class WorldFactory
    {
        /// <summary>
        /// СОздаёт новый игровой мир.
        /// </summary>
        /// <param name="Name"></param>
        public IWorld CreateWorld(string Name)
        {
            return new World(Name); ;
        }
    }
}
