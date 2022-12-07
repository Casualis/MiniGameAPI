using MiniGameAPIBase.Model.Concrete.Commands;

namespace MiniGameAPIBase.Debugger.DemoCommands
{
    /// <summary>
    /// Класс поворот направо.
    /// </summary>
    public class TurnRightCommand : CommandBase
    {
        public TurnRightCommand()
        {
            Name = "Поворот направо";
            ExecAction = new Action(() => Console.WriteLine(Name));
            Enabled = true;
        }
    }
}
