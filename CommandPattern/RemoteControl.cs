namespace CommandPattern
{
    public class SimpleRemoteControl
    {
        private ICommand _slot;

        public void SetCommand(ICommand cmd)
        {
            _slot = cmd;
        }

        public void ButtonPressed()
        {
            _slot.Execute();
        }
    }

    public class AdvancedRemoteControl
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;

        private ICommand lastCommand;

        public AdvancedRemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            // 初始化on commands
            for (var i = 0; i < _onCommands.Length; i++)
            {
                _onCommands[i] = NoopComand.Instance;
            }

            // 初始化off commands
            for (var i = 0; i < _offCommands.Length; i++)
            {
                _onCommands[i] = NoopComand.Instance;
            }
            lastCommand = NoopComand.Instance;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            this._onCommands[slot] = onCommand;
            this._offCommands[slot] = offCommand;
        }

        public void OnButtonPressed(int slot)
        {
            this._onCommands[slot].Execute();
            lastCommand = this._onCommands[slot];

        }


        public void OffButtonPressed(int slot)
        {
            this._offCommands[slot].Execute();
            lastCommand = this._offCommands[slot];
        }

        public void Undo()
        {
            this.lastCommand.Undo();
        }
    }

    public class NoopComand : ICommand
    {
        private static NoopComand _instance = new NoopComand();
        public static NoopComand Instance => _instance;
        public void Execute()
        {
        }

        public void Undo()
        {
        }
    }
}
