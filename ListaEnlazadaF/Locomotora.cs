using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazadaF
{
    class Locomotora
    {
        Vagon Primero {  get; set; }
       
        public  void AgregarPrimero(int valor)
        {
           
            Vagon nuevo = new Vagon(valor);
            if(this.Primero == null)
            {
                this.Primero = nuevo;
            }
            else 
            {
                nuevo.Sig = this.Primero;
                this.Primero = nuevo;
            }
        }
        public void AgregaFinal(int valor)
        {
            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null)//caso 1
            {
                this.Primero = nuevo;
            }
            else
            {
                Vagon tmp = this.Primero;
                while (tmp.Sig != null)
                {
                    tmp = tmp.Sig;
                }
                 
                tmp.Sig = nuevo;
            }
        }
        public string VerVagones()
        {
            string listaVag = "";
            Vagon tmp = this.Primero;
            while (tmp != null)
            {
                listaVag += tmp.Dato + ", ";
                tmp = tmp.Sig;
            }
            return listaVag;
        }
    }
}
