using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultilistaCircular
{
    class TLista
    {
        public TNodo Primero;
        public TNodo Ultimo;
        public TNodo Cursor;


        public TLista() {           //Constructor
            Primero = null;
            Ultimo = null;
            Cursor = null;
        }

        public void inicializar()  //Inicializa los valores
        {
            Primero = null;
            Ultimo = null;
            Cursor = null;
        }

        public bool Vacia()
        {
            if (Primero == null)
                return true;
            else
                return false;
        }

        public void Insertar(TNodo nodo)
        {
            if (Vacia()){
                Primero = nodo;
                Ultimo = nodo;
                Cursor = nodo;
            }
            else{
                Ultimo.PENodo = nodo;
                Ultimo = nodo;
                Cursor = nodo;
            }
            nodo.PENodo = Primero;  // Enlazamos el enlance del último nodo creado
                                    // al primero nodo

        }
        public TNodo Eliminarprimero()
        {
            if (Vacia())
                return null;
            else
            {
                if (Primero == Ultimo)  //si cumple es que un solo elemento
                    inicializar();
                else
                {
                    if (Cursor == Primero)
                    {
                        Cursor = getProxCursor();
                        Primero = Primero.PENodo;

                    }

                }
                return Primero;
            }

        }

        public TNodo Eliminar()
        {
            TNodo VTemp;
            if (Cursor == null)
                return null;
            else
            {
                if (Cursor == Primero)
                    return Eliminarprimero();
                else
                {
                    VTemp = getAntCursor();
                    VTemp.PENodo = Cursor.PENodo;
                    if (Cursor == Ultimo)
                        Ultimo = VTemp;
                    Cursor = VTemp.PENodo;
                    return Cursor;
                }
            }
        }

        public TNodo getPrimero() {
            return Primero; }
        public TNodo getUltimo() {
            return Ultimo; }
        public TNodo getCursor() {
            return Cursor; }

        // 2
            public TNodo getProxCursor() {
                if (Cursor != null && Cursor != Ultimo)
                    return Cursor.PENodo;
                else {
                    //MessageBox.Show("No existe sucesor");
                    return Primero; }
            }

        // 3
        public TNodo getAntCursor()
        {
            TNodo VTemp;
            if ((Cursor != null) && (Cursor != Primero))
            {
                VTemp = Primero;
                while (VTemp.PENodo != Cursor)
                    VTemp = VTemp.PENodo;
                return VTemp;
            }
            else
            {
                //MessageBox.Show("No existe Antecesor");
                return Ultimo;
            }
        }

        public void setCursor(TNodo p)
        {
            Cursor = p;
        }
    }
}
