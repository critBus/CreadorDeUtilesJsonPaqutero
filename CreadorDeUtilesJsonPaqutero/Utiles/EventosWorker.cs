using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReneUtiles;
using ReneUtiles.Clases;

namespace CreadorDeUtilesJsonPaqutero.Utiles
{
    public class EventosWorker<T>:ConsolaBasica
    {
        // Events
        private event Action<T> Starting;
        private event Action<T,double> Progress;
        private event Action<T,TimeSpan> Completed;
        private event Action<T,Exception> Error;
        private event Action<T,TimeSpan> StoppedByUser;

        public void addStarting(Action<T> Starting)
        {
            this.Starting += Starting;
        }
        public void addProgress(Action<T, double> Progress)
        {
            this.Progress += Progress;
        }
        public void addCompleted(Action<T, TimeSpan> Completed)
        {
            this.Completed += Completed;
        }
        public void addError(Action<T, Exception> Error)
        {
            this.Error += Error;
        }
        public void addStoppedByUser(Action<T, TimeSpan> StoppedByUser)
        {
            this.StoppedByUser += StoppedByUser;
        }


        public virtual void OnStarting(T input)
        {

            Starting?.Invoke(input);
        }


        public virtual void OnProgress(T input, double progress)
        {
            Progress?.Invoke(input, progress);
        }

        public virtual void OnCompleted(T input, TimeSpan elapsed)
        {
            Completed?.Invoke(input, elapsed);
        }

        public virtual void OnError(T input, Exception ex)
        {
            Error?.Invoke(input, ex);
        }

        public virtual void OnStoppedByUser(T input, TimeSpan elapsed)
        {
            StoppedByUser?.Invoke(input, elapsed);
        }
    }
}
