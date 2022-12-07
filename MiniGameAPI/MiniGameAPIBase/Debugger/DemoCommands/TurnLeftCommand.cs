using MiniGameAPIBase.Model.Concrete.Commands;

namespace MiniGameAPIBase.Debugger.DemoCommands
{
    /// <summary>
    /// Класс поворот налево.
    /// </summary>
    public class TurnLeftCommand : CommandBase
    {
        public TurnLeftCommand()
        {
            Name = "Поворот налево";
            ExecAction = new Action(() => Console.WriteLine(Name));
            Enabled = true;
        }
    }
}
