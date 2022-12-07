using MiniGameAPIBase.Model.Concrete.Commands;

namespace MiniGameAPIBase.Debugger.DemoCommands
{
    /// <summary>
    /// Класс выстрел.
    /// </summary>
    public class FireCommand : CommandBase
    {
        public FireCommand()
        {
            Name = "Выстрел";
            ExecAction = new Action(() => Console.WriteLine(Name));
            Enabled = true;
        }
    }
}
