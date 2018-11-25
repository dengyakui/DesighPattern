namespace CommandPattern
{
    public class GarageDoor
    {

        public void LightOn() { }
        public void LightOff() { }

        public void Up() { 
              System.Console.WriteLine("garagedoor is open now");
        }
        public void Down() { 
              System.Console.WriteLine("garagedoor is down now");
        }
        public void Stop() { 
              System.Console.WriteLine("garagedoor is stop now");
        }
    }
}
