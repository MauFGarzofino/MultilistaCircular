using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MultilistaCircular
{
    public partial class Form1 : Form
    {
        private int n = 0;
        TListaJ Lista = new TListaJ();
        int m = 0;

        public Form1()
        {
            InitializeComponent();
        }
  
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        private void InsertarBrigadas_Click(object sender, EventArgs e)
        {
            if (numBrigada.Text == "" || textIDBrigada.Text == "" || textNombreBrigada.Text == "")
            {
                MessageBox.Show("escriba los datos");
                return;
            }
            else
            {
                m++;
                Lista.crearLista(int.Parse(numBrigada.Text), int.Parse(textIDBrigada.Text), textNombreBrigada.Text);
                numeroDeBrigadas.Text = "Número de Brigadas:  " + m;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        private void InsertarTrabajadores_Click(object sender, EventArgs e)
        {
            //// Insertamos un nuevo renglon
            int n = DataGridView.Rows.Add(); // n = número de renglon
            Lista.InsertarTrab(int.Parse(numBrigada.Text), int.Parse(textIDTrabajador.Text), nombreTrab.Text, oficioTrab.Text);

            // Colocamos la información
            DataGridView.Rows[n].Cells[0].Value = textIDTrabajador.Text;
            DataGridView.Rows[n].Cells[1].Value = nombreTrab.Text;
            DataGridView.Rows[n].Cells[2].Value = oficioTrab.Text;

            // Limpiamos los txt
            textIDTrabajador.Text = "";
            nombreTrab.Text = "";
            oficioTrab.Text = "";
        }
            
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        private void eliminarBrigada_Click(object sender, EventArgs e)
        {
            if (Lista.Vacia())
            {
                DataGridView.Rows.Clear();
                numBrigada.Text = "";
                textIDBrigada.Text = "";
                textNombreBrigada.Text = "";
                MessageBox.Show("Lista Vacía");
            }
            else { 
            Lista.Eliminar();
            m--;
            numeroDeBrigadas.Text = "Número de Brigadas:  " + m;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        private void Limpiar_Click(object sender, EventArgs e)
        {
            //Eliminamos el texto de los textBoxs y el DataGridView
            textIDBrigada.Clear();
            textNombreBrigada.Clear();
            numBrigada.Clear();
            viewLabel.Text = "";

            DataGridView.Rows.Clear();
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        private void Sucesor_Click(object sender, EventArgs e)
        {
            if (!Lista.Vacia())
            {
                TNodoJ p;
                p = (TNodoJ)Lista.getCursor();
                p = (TNodoJ)Lista.getProxCursor();
                numBrigada.Text = Convert.ToString(p.getNBrigada());
                textIDBrigada.Text = Convert.ToString(p.getID());
                textNombreBrigada.Text = p.getNombre();

                Lista.MostrarTrab(int.Parse(numBrigada.Text), DataGridView);
                return;
            }
            else { MessageBox.Show("Lista Vacía"); }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        private void Antecesor_Click(object sender, EventArgs e)
        {
            if (!Lista.Vacia())
            {
                TNodoJ p;
                //p = (TNodoJ)Lista.getCursor();
                p = (TNodoJ)Lista.getAntCursor();
                numBrigada.Text = Convert.ToString(p.getNBrigada());
                textIDBrigada.Text = Convert.ToString(p.getID());
                textNombreBrigada.Text = p.getNombre();

                Lista.MostrarTrab(int.Parse(numBrigada.Text), DataGridView);
                return;
            }
            else{ MessageBox.Show("Lista Vacía");}
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        private void Primero_Click(object sender, EventArgs e)
        {
            if (!Lista.Vacia())
            {
                TNodoJ Primero;
                Primero = (TNodoJ)Lista.getPrimero();
                numBrigada.Text = Primero.getNBrigada().ToString();
                textIDBrigada.Text = Primero.getID().ToString();
                textNombreBrigada.Text = Primero.getNombre();
                viewLabel.Text = ("ID: " + (Primero).getID() + "   |  N_Brigada: " + (Primero).getNBrigada() + "   |  Nombre: " + (Primero).getNombre());

                Lista.MostrarTrab(int.Parse(numBrigada.Text), DataGridView);
                //Lista.setCursor((TNodoJ)Lista.getPrimero());
            }
            else { MessageBox.Show("Lista Vacía"); }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        private void Ultimo_Click(object sender, EventArgs e)
        {
            if (!Lista.Vacia())
            {
                TNodoJ Ultimo;
                Ultimo = (TNodoJ)Lista.getUltimo();
                numBrigada.Text = Ultimo.getNBrigada().ToString();
                textIDBrigada.Text = Ultimo.getID().ToString();
                textNombreBrigada.Text = Ultimo.getNombre();
                viewLabel.Text = ("ID: " + (Ultimo).getID() + "   |  N_Brigada: " + (Ultimo).getNBrigada() + "   |  Nombre: " + (Ultimo).getNombre());

                Lista.MostrarTrab(int.Parse(numBrigada.Text), DataGridView);
                //Lista.setCursor((TNodoJ)Lista.getUltimo());
            }
            else { MessageBox.Show("Lista Vacía"); }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        private void eliminarTrabajador_Click(object sender, EventArgs e)
        {
            TNodoJ p;

            int Posicion;
            Posicion = DataGridView.CurrentRow.Index;

            if (string.IsNullOrEmpty(Convert.ToString(DataGridView.Rows[Posicion].Cells[0].Value)))
            {
                MessageBox.Show("La brigada: " + textNombreBrigada.Text + " no tiene trabajadores", "Mensaje "); 
            }
            else
            {
                p = (TNodoJ)Lista.getCursor();
                Lista.EliminarTrab(int.Parse(numBrigada.Text), int.Parse(DataGridView.Rows[Posicion].Cells[0].Value.ToString()));
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Para obtener la información del índice del reglón
            n = e.RowIndex;  // Utilizando la información que recupera sobre el evento 
            // Si no se selecciona el encabezado
            if (n != -1)
            {
                // Para dar la informaciòn del nombre
                viewLabel.Text = (string)DataGridView.Rows[n].Cells[1].Value;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e){}
        private void primeroLabel_Click(object sender, EventArgs e){}
        private void Form1_Load(object sender, EventArgs e) {}

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
       
    }
}
