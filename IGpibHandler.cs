namespace Bev.IO.Gpib
{
    public interface IGpibHandler
    {
        void Remote(int address);

        void Local(int address);

        void Trigger(int address);

        void Output(int address, string command);

        string Enter(int address);
    }
}
