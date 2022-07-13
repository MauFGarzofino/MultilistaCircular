using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilistaCircular
{
    class TNodo {
        public TNodo PENodo; //Enlace
        public TNodo() {
            PENodo = null; 
        } 
    }

    //Nodo jefe de brigada hereda de Nodo

    class TNodoJ : TNodo {
        private int ID;                  //Identificador
        private int NBrigada;            //Numero del jefe de brigada
        private string Nombre;           //Nombre del jefe de brigada
        public TLista TListaTrabajador;  //TListaTrabajador es de tipo TLista

        public TNodoJ() { }              //Constructor

        public TNodoJ(int nbrig, int id, string nombrigada) { //Constructor que recibe tres parametros
            NBrigada = nbrig;
            ID = id;
            Nombre = nombrigada;
            TListaTrabajador = new TLista(); }   //Crea una lista  

        public int getID() { //Devuelve el identificador de la brigada
            return ID; }

        public string getNombre() { //Devuelve el Nombre del jefe de brigada
            return Nombre; }

        public int getNBrigada() { //Devuelve el numero del jefe de brigada
            return NBrigada; }
    }
}
