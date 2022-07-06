using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.ObserverIdioma
{
    public abstract class SubjectIdioma
    {
        private static List<IObserverIdioma> _observerIdiomas = new List<IObserverIdioma>();

        public static void AddObserverIdioma(IObserverIdioma observerIdioma)
        {
            if (!_observerIdiomas.Contains(observerIdioma))
            {
                _observerIdiomas.Add(observerIdioma);
            }
        }
        public static void RemoveObserverIdioma(IObserverIdioma observerIdioma)
        {
            if (!_observerIdiomas.Contains(observerIdioma))
            {
                _observerIdiomas.Remove(observerIdioma);
            }
        }
        public static void Notify()
        {
            foreach (IObserverIdioma observer in _observerIdiomas)
                observer.Update();
        }
    }
}
