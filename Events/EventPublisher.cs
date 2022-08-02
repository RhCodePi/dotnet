namespace Rhcodepi
{
    public delegate void MyEventHandler(int value);
    internal class EventPublisher
    {
        private int deposit;
        public event MyEventHandler? changedEvent;

        public int Balence{
            set {
                this.deposit += value;
                this.changedEvent(deposit);
            }
        }
    }
}