using MediatorPattern.Mediator;

namespace MediatorPattern.Colleague
{
    public interface IColleague<T>
    {
        void SendMessage(IMediator<T> mediator, T message);

        void ReceiveMessage(T message);
    }
}