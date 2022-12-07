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
    /// Демо-юнит "Ветер".
    /// </summary>
    public class WindUnit : Unit
    {
        public WindUnit(IState state, List<ICommand> commands) : base("Wind", state, commands)
        {
        }
    }
}
