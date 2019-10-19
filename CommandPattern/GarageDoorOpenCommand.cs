namespace CommandPattern
{
    public class GarageDoorOpenCommand : ICommand
    {
        private readonly GarageDoor _door;

        public GarageDoorOpenCommand(GarageDoor door)
        {
            this._door = door;
        }

        public void Execute()
        {
            _door.Up();

        }

        public void Undo()
        {
            _door.Down();
        }
    }
}
