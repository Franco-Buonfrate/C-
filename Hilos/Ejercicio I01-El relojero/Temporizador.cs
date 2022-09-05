using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_I01_El_relojero
{
    public class Temporizador
    {
        public delegate void DelegadoTemporizador();
        public event DelegadoTemporizador TiempoCumplido;

        private Task hilo;
        private int intervalo;
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;

        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
        }
        public bool EstaActivo
        {
            get
            {
                return hilo is not null && hilo.Status == TaskStatus.Running;
            }
        }
        public Temporizador(int intervalo)
        {
            this.intervalo = intervalo;
        }

        public void DetenerTemporizador()
        {
            if (EstaActivo)
            {
                cancellationTokenSource.Cancel();
            }
        }

        public void IniciarTemporizador()
        {
            if (!EstaActivo)
            {
                cancellationTokenSource = new CancellationTokenSource();
                cancellationToken = cancellationTokenSource.Token;
                hilo = new Task(CorrerTiempo);
                hilo.Start();
            }
        }
        private void CorrerTiempo()
        {
            while (TiempoCumplido is not null && !cancellationToken.IsCancellationRequested)
            {
                TiempoCumplido();
                Thread.Sleep(intervalo);
            }
        }
        
    }
}
