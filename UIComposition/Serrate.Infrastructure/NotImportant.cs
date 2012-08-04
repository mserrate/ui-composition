using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serrate.Infrastructure
{
    public interface IMessage {}
    public interface ICommand : IMessage {}
    public interface IEvent : IMessage {}

    public interface IBus
    {
        void Send(ICommand cmd);
        void Publish(IEvent evt);
    }

    public interface IHandle<T>
        where T : IMessage
    {
        void Handle(T msg);
    }

    public static class TheSession
    {
        public static readonly Guid OrderId = new Guid("76F680B6-7488-4C81-93BD-221FD384F2C4");
    }
}
