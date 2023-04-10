using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Behavioral.Observer
{
    public class Suspicion
    {
        public string Action { get; }

        public Suspicion(string action)
        {
            Action = action;
        }
    }

    public class Hitman : IObservable<Suspicion>
    {
        public List<IObserver<Suspicion>> Observers { get; set; }

        public Hitman()
        {
            Observers = new List<IObserver<Suspicion>>();
        }

        public IDisposable Subscribe(IObserver<Suspicion> observer)
        {
            if(!Observers.Contains(observer))
            {
                Observers.Add(observer);
            }

            return new Unsubscriber(observer, Observers);
        }

        public void ActSuspicious(string action)
        {
            foreach(IObserver<Suspicion> observer in Observers)
            {
                observer.OnNext(new Suspicion(action));
            }
        }
    }

    public class Unsubscriber : IDisposable
    {
        private readonly IObserver<Suspicion> observer;
        private readonly List<IObserver<Suspicion>> observers;

        public Unsubscriber(IObserver<Suspicion> observer, List<IObserver<Suspicion>> observers)
        {
            this.observer = observer;
            this.observers = observers;
        }

        public void Dispose()
        {
            if(observer is not null && observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }
    }

    public class Guard : IObserver<Suspicion>
    {
        public string ObservedAction { get; private set; } = "";

        public void OnCompleted() { }

        public void OnError(Exception error) { }

        public void OnNext(Suspicion value)
        {
            ObservedAction = value.Action;
        }

        public IDisposable Register(Hitman hitman)
        {
            return hitman.Subscribe(this);
        }
    }
}
