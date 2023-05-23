using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReneUtiles.Clases;

namespace CreadorDeUtilesJsonPaqutero.Utiles
{
    public abstract class Worker<T>:ConsolaBasica
    {
        protected T input;
        protected bool stopRequested = false;
        protected DateTime startTime;
        public EventosWorker<T> eventos;

        public Worker()
        {

        }
        public Worker(T input)
        {
            this.input = input;
        }

        public void addCompleted(Action<T, TimeSpan> Completed)
        {
            eventos.addCompleted(Completed);
        }
        protected abstract void accion();
        public  void Start()
        {
            

            try
            {
                startTime = DateTime.Now;
                accion();
                //OnStarting(input);

                //int progress = 0;
                //while (progress < 100 && !stopRequested)
                //{
                //    progress += 10;
                //    OnProgress(input, progress);

                //    System.Threading.Thread.Sleep(1000); // Simulate work
                //}

                //if (stopRequested)
                //{
                //    OnStoppedByUser(input, DateTime.Now - startTime);
                //}
                //else
                //{
                //    OnCompleted(input, DateTime.Now - startTime);
                //}
            }
            catch (Exception ex)
            {
                OnError(input, ex);
            }
        }

        public Worker<F> addSiguiente<F>(Worker<F> w) {
            this.eventos.addCompleted((v, t) => {
                cwl("al terminar");
                w.Start();
            });
            return w;
        }

        public void RequestStop()
        {
            stopRequested = true;
        }

        

        protected virtual void OnStarting(T input)
        {
            eventos.OnStarting(input);
            //Starting?.Invoke(input);
        }

        
        protected virtual void OnProgress(T input, double progress)
        {
            eventos.OnProgress(input,progress);
            //Progress?.Invoke(input, progress);
        }
        protected virtual void OnCompleted(T input)
        {
            OnCompleted(input, DateTime.Now - startTime);
            //Completed?.Invoke(input, elapsed);
        }
        protected virtual void OnCompleted(T input, TimeSpan elapsed)
        {
            eventos.OnCompleted(input, elapsed);
            //Completed?.Invoke(input, elapsed);
        }

        protected virtual void OnError(T input, Exception ex)
        {
            eventos.OnError(input,ex);
            //Error?.Invoke(input, ex);
        }

        protected virtual void OnStoppedByUser(T input) {
            OnStoppedByUser(input, DateTime.Now - startTime);
        }
        protected virtual void OnStoppedByUser(T input, TimeSpan elapsed)
        {
            eventos.OnStoppedByUser(input, elapsed);
            //StoppedByUser?.Invoke(input, elapsed);
        }
    }

}
