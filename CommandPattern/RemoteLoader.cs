using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class RemoteLoader
    {
        public static void Test()
        {
            var ceilingFan = new CeilingFan("living room");

            var highCommand = new CeilingFanHighCommand(ceilingFan);
            var mediumCommand = new CeilingFanMediumCommand(ceilingFan);
            var lowCommand = new CeilingFanLowCommand(ceilingFan);
            var offCommand = new CeilingFanOffCommand(ceilingFan);


            var control = new AdvancedRemoteControl();
            control.SetCommand(0, mediumCommand, offCommand);
            control.SetCommand(1, highCommand, offCommand);

            control.OnButtonPressed(0);
            control.OffButtonPressed(0);
            control.Undo();


            control.OnButtonPressed(1);
            control.OffButtonPressed(1);
            control.Undo();
        }

    }
}
