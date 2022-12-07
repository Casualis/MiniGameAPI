using MiniGameAPIBase.Model.Concrete.Properties;

namespace MiniGameAPIBase.Debugger.DemoPositions
{
    public class AmmoProperty : PropertyBase
    {
        public AmmoProperty()
        {
            Name = "Зпас патронов";
            Type = Model.Enums.PropertyType.AmmoSupply;
        }
    }
}
