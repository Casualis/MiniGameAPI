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
    /// Демо-юнит "Сторожевая башня".
    /// </summary>
    internal class WatchTower : Unit
    {
        public WatchTower(IState state, List<ICommand> commands) : base("WatchTower", state, commands)
        {
        }
    }
}
