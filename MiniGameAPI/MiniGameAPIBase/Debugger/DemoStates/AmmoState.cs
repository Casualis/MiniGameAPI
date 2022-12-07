using MiniGameAPIBase.Debugger.DemoPositions;
using MiniGameAPIBase.Model.Concrete.States;

namespace MiniGameAPIBase.Debugger.DemoStates
{
    public class AmmoState : StateBase
    {
        public AmmoState()
        {
            StateName = "Запас патронов";
            Properties.Add(new AmmoProperty());
        }
    }
}
