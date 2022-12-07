using MiniGameAPIBase.Model.Concrete.Properties;

namespace MiniGameAPIBase.Debugger.DemoPositions
{
    internal class DirectionProperty : PropertyBase
    {
        public DirectionProperty()
        {
            Name = "Направление";
            Type = Model.Enums.PropertyType.Direction;
        }
    }
}
