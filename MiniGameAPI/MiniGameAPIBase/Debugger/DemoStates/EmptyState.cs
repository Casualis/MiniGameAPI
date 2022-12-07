using MiniGameAPIBase.Debugger.DemoPositions;
using MiniGameAPIBase.Model.Concrete.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameAPIBase.Debugger.DemoStates
{
    internal class EmptyState : StateBase
    {
        public EmptyState()
        {
            StateName = "Состояние отсутстувет";
        }
    }
}
