using System;

namespace CommandPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var simpleRemoteControl = new SimpleRemoteControl();
            simpleRemoteControl.SetCommand(new LightOnCommand(new Light()));
            simpleRemoteControl.ButtonPressed();

            simpleRemoteControl.SetCommand(new GarageDoorOpenCommand(new GarageDoor()));
            simpleRemoteControl.ButtonPressed();


            var advancedRemoteControl = new AdvancedRemoteControl();
            var livingRoomLight = new Light();
            advancedRemoteControl.SetCommand(0, new LightOnCommand(livingRoomLight), new LightOffCommand(livingRoomLight));

            advancedRemoteControl.OnButtonPressed(0);
            advancedRemoteControl.Undo();
            advancedRemoteControl.OffButtonPressed(0);
            advancedRemoteControl.Undo();

        }
    }

}
