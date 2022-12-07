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
    /// Демо-юнит "Трактор".
    /// </summary>
    public class TractorUnit : Unit
    {
        public TractorUnit(IState state, List<ICommand> commands) : base("Tractor", state, commands)
        {
        }
    }
}
