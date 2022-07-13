using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultilistaCircular
{
    class TListaJ : TLista
    {
        public TListaJ() { }

        public void crearLista(int Brigada, int ID, string Nombre)
        {
            Insertar(new TNodoJ(Brigada, ID, Nombre));
        }
        public bool BuscarBrigada(int nB)
        {
            TNodoJ p;
            bool aux = false;
            p = (TNodoJ)getPrimero();
            while (p != null)
            {
                if (p.getNBrigada() == nB)
                {
                    aux = true;
                    Cursor = p;
                    break;
                    // salir de cualquier estructura de control
                }
                p = (TNodoJ)p.PENodo;
            }
            return aux;
        }


        public TNodoJ getAnterior(int nB)
        {
            if (BuscarBrigada(nB))
                return (TNodoJ)getAntCursor();
            else
                return null;
        }


        public TNodoJ getPosterior(int nB)
        {

            if (BuscarBrigada(nB))
                return (TNodoJ)getProxCursor();
            else
                return null;
                
        }

        public void InsertarTrab(int nB, int i, string n, string o)
        {
            TNodoJ p = new TNodoJ();

            if (BuscarBrigada(nB))
                p = (TNodoJ)getCursor();
            p.TListaTrabajador.Insertar(new TNodoTrabajador(i, n, o));
        }


        public void EliminarTrab(int nB, int NId)
        {
            TNodoJ p;
            TNodoTrabajador q;
            BuscarBrigada(nB);
            p = (TNodoJ)getCursor();
            q = (TNodoTrabajador)p.TListaTrabajador.getPrimero();
            while (true)
            {
                if (q.ID == NId)
                {
                    p.TListaTrabajador.Cursor = q;
                    break;
                }
                else
                    q = (TNodoTrabajador)q.PENodo;
            }
            p.TListaTrabajador.Eliminar();
        }

        //Cambios: inicializar i en 1 
        // Agregamos while y cambiamos el valor de N
        // RowCount - 1; (antes)
        public void MostrarTrab(int nB, DataGridView dgv)
        {
            TNodoJ p;
            TNodoTrabajador q;

            int n, i;
            //n = dgv.RowCount - 1;
            n = 0;
        
            BuscarBrigada(nB);
            p = (TNodoJ)getCursor();
            q = (TNodoTrabajador)p.TListaTrabajador.getPrimero();

            //Mientras el primer trabajador sea diferente del último
            while (q != p.TListaTrabajador.Ultimo)
            {
                // el primer nodo trabajador toma el valor del siguiente hasta que
                // se cumpla la condición
                q = (TNodoTrabajador)q.PENodo;
                n++;
            }
            
            dgv.Rows.Clear();
            //MessageBox.Show("Cantidad de trabajadores: " + n, "Brigada " + (nB));
            for (i = 0; i <= n; i++)
            {
                if (q == null)
                    break;
                else
                {
                    dgv.Rows.Add();
                    dgv.Rows[i].Cells[0].Value = q.getID();
                    dgv.Rows[i].Cells[1].Value = q.getNombre();
                    dgv.Rows[i].Cells[2].Value = q.getOficio();
                    q = (TNodoTrabajador)q.PENodo;
                }
            }  
        }


        public bool EliminarLista()
        {
            if (getCursor() != null)
            {
                Eliminar();
                return true;
        }
            else return false;
        }
    }
}
