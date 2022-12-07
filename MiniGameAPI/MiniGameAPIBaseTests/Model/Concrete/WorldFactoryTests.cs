using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniGameAPIBase.Model.Abstract;

namespace MiniGameAPIBase.Model.Concrete.Tests
{
    /// <summary>
    /// Тест для создания игрового мира.
    /// </summary>
    [TestClass()]
    public class WorldFactoryTests
    {
        /// <summary>
        /// Это просто заготовка для тестов. Полноценные тесты по ТЗ пока не делаем.
        /// </summary>
        [TestMethod()]
        public void CreateWorldTest()
        {
            string worldName = "Стражи Галактики";

            IWorld world = new World(worldName);

            Assert.AreEqual(world.WorldName, worldName);
        }
    }
}