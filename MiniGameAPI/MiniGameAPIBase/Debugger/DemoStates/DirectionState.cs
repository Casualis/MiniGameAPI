using MiniGameAPIBase.Debugger.DemoPositions;
using MiniGameAPIBase.Model.Concrete.States;

namespace MiniGameAPIBase.Debugger.DemoStates
{
    public class DirectionState : StateBase
    {
        public DirectionState()
        {
            StateName = "Направление";
            Properties.Add(new DirectionProperty());
        }
    }
}
