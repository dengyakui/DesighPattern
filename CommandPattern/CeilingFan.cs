using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public enum CeilingFanSpeed
    {
        OFF = 0,
        LOW = 1,
        MEDIUM = 2,
        HIGH = 3
    }
    public class CeilingFan
    {

        private readonly string _location;
        public CeilingFanSpeed Speed { get; set; }

        public CeilingFan(string location)
        {
            _location = location; //吊扇的位置
            Speed = CeilingFanSpeed.OFF; // 吊扇初始为关闭
        }

        /// <summary>
        /// 设置为高档转速
        /// </summary>
        public void High()
        {
            Speed = CeilingFanSpeed.HIGH;
            OnSpeedChange();
        }

        private void OnSpeedChange()
        {
            Console.WriteLine($"CeilingFan--{_location}'s current speed set to {Speed}");
        }


        /// <summary>
        /// 设置为中档转速
        /// </summary>
        public void Medium()
        {
            Speed = CeilingFanSpeed.MEDIUM;
            OnSpeedChange();

        }


        /// <summary>
        /// 设置为低档转速
        /// </summary>
        public void Low()
        {
            Speed = CeilingFanSpeed.LOW;
            OnSpeedChange();

        }


        /// <summary>
        /// 关闭
        /// </summary>
        public void Off()
        {
            Speed = CeilingFanSpeed.OFF;
            OnSpeedChange();
        }
    }


    /// <summary>
    /// 设置吊扇高速档
    /// </summary>
    public class CeilingFanHighCommand : ICommand
    {
        private readonly CeilingFan _ceilingFan;
        private CeilingFanSpeed _prevSpeed;
        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            _prevSpeed = _ceilingFan.Speed;
            _ceilingFan.High();
        }

        public void Undo()
        {
            if (_prevSpeed == CeilingFanSpeed.HIGH)
            {
                _ceilingFan.High();
            }
            else if (_prevSpeed == CeilingFanSpeed.MEDIUM)
            {
                _ceilingFan.Medium();
            }
            else if (_prevSpeed == CeilingFanSpeed.LOW)
            {
                _ceilingFan.Low();
            }
            else
            {
                _ceilingFan.Off();
            }
        }
    }


    /// <summary>
    /// 设置吊扇中速档
    /// </summary>
    public class CeilingFanMediumCommand : ICommand
    {
        private readonly CeilingFan _ceilingFan;
        private CeilingFanSpeed _prevSpeed;
        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            _prevSpeed = _ceilingFan.Speed;
            _ceilingFan.Medium();
        }

        public void Undo()
        {
            if (_prevSpeed == CeilingFanSpeed.HIGH)
            {
                _ceilingFan.High();
            }
            else if (_prevSpeed == CeilingFanSpeed.MEDIUM)
            {
                _ceilingFan.Medium();
            }
            else if (_prevSpeed == CeilingFanSpeed.LOW)
            {
                _ceilingFan.Low();
            }
            else
            {
                _ceilingFan.Off();
            }
        }
    }


    /// <summary>
    /// 设置吊扇低速档
    /// </summary>
    public class CeilingFanLowCommand : ICommand
    {
        private readonly CeilingFan _ceilingFan;
        private CeilingFanSpeed _prevSpeed;
        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            _prevSpeed = _ceilingFan.Speed;
            _ceilingFan.Low();
        }

        public void Undo()
        {
            if (_prevSpeed == CeilingFanSpeed.HIGH)
            {
                _ceilingFan.High();
            }
            else if (_prevSpeed == CeilingFanSpeed.MEDIUM)
            {
                _ceilingFan.Medium();
            }
            else if (_prevSpeed == CeilingFanSpeed.LOW)
            {
                _ceilingFan.Low();
            }
            else
            {
                _ceilingFan.Off();
            }
        }
    }


    /// <summary>
    /// 关闭吊扇
    /// </summary>
    public class CeilingFanOffCommand : ICommand
    {
        private readonly CeilingFan _ceilingFan;
        private CeilingFanSpeed _prevSpeed;
        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            _prevSpeed = _ceilingFan.Speed;
            _ceilingFan.Off();
        }

        public void Undo()
        {
            if (_prevSpeed == CeilingFanSpeed.HIGH)
            {
                _ceilingFan.High();
            }
            else if (_prevSpeed == CeilingFanSpeed.MEDIUM)
            {
                _ceilingFan.Medium();
            }
            else if (_prevSpeed == CeilingFanSpeed.LOW)
            {
                _ceilingFan.Low();
            }
            else
            {
                _ceilingFan.Off();
            }
        }
    }
}
