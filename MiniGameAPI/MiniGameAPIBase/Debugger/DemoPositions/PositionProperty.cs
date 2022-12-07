using MiniGameAPIBase.Model.Concrete.Properties;

namespace MiniGameAPIBase.Debugger.DemoPositions
{
    internal class PositionProperty : PropertyBase
    {
        public PositionProperty()
        {
            Name = "Позиция";
            Type = Model.Enums.PropertyType.Position;
        }
    }
}
