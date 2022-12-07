using MiniGameAPIBase.Debugger.DemoPositions;
using MiniGameAPIBase.Model.Concrete.States;

namespace MiniGameAPIBase.Debugger.DemoStates
{
    public class PositionState : StateBase
    {
        public PositionState()
        {
            StateName = "Позиция";
            Properties.Add(new PositionProperty());
        }
    }
}
