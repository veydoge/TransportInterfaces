using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportInterfaces
{
    public class Device : IDeviceCommands
    {
        public int Position { get; set; }
        public int Rotation { get; set; }

        public void Move(int x)
        {
            Position += x;
        }

        public void Rotate(int x)
        {
            Rotation += x;
        }


    }

    public interface IDeviceCommands
    {
        public void Move(int x);
        public void Rotate(int x);

        public int Position { get; set; }
        public int Rotation { get; set; }
    }
}
