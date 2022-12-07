using MiniGameAPIBase.Model.Concrete.Commands;

namespace MiniGameAPIBase.Debugger.DemoCommands
{
    /// <summary>
    /// Класс движение вперёд.
    /// </summary>
    public class ForwardCommand : CommandBase
    {
        public ForwardCommand()
        {
            Name = "Движение вперёд";
            ExecAction = new Action(() => Console.WriteLine(Name));
            Enabled = true;
        }
    }
}
