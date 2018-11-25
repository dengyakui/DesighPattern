namespace CommandPattern
{
    public class GarageDoorOpenCommand : ICommand
    {
        private readonly GarageDoor door;

        public GarageDoorOpenCommand(GarageDoor door)
        {
            this.door = door;
        }

        public void Execute()
        {
            door.Up();

        }

        public void Undo()
        {
            door.Down();
        }
    }
}
