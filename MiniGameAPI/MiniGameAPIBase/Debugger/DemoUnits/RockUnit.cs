using MiniGameAPIBase.Model.Abstract;
using MiniGameAPIBase.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameAPIBase.Debugger.DemoUnits
{
    /// <summary>
    /// Демо-юнит "Камень".
    /// </summary>
    public class RockUnit : Unit
    {
        public RockUnit(IState state, List<ICommand> commands) : base("Rock", state, commands)
        {
        }
    }
}
