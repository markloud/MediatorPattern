using MediatorPattern.Colleague;
using System.Collections.Generic;

namespace MediatorPattern.Mediator
{
    public interface IMediator<T>
    {
        List<IColleague<T>> ColleagueList { get; }

        void DistributeMessage(IColleague<T> sender, T message);

        void Register(IColleague<T> colleague);
    }
}