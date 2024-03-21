namespace TransportInterfaces
{
    public interface ServerConnection
    {

        public void SendCommand(Command command);
        public void Close();
        public void Start(Device device);
        public void SendData(byte[] data);
        public void SendString(string data);
    }

    public class Command
    {
        public Command(CommandType Command, int Value)
        {
            this.Value = Value;
            this.Type = Command;
        }
        public enum CommandType
        {
            Move = 1,
            Rotate,
            GetDevice
        }

        public CommandType Type { get; set; }
        public int Value { get; set; }
    }
}
