namespace Rhcodepi
{
    public delegate void MyEventHandler(decimal value);
    internal class EventPublisher
    {
        private decimal deposit;
        public event MyEventHandler? changedEvent;

        public decimal Balence{
            set {
                this.deposit += value;
                this.changedEvent(deposit);
            }
        }
    }
}