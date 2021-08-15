using System;
using System.Collections;

namespace Listas001
{
    public class Lista:IEnumerable
    {
        private Nodo list;
        private EnumLista enu;
        public Lista()
        {
            list = null;
            this.enu= new EnumLista(this);
        }

        public int Count
        {
            get
            {
                int con = 0;
                for (Nodo aux = this.list; aux != null; aux=aux.siguiente)
                {
                    con++;
                }
                
                return con;
            }
        }

        public void Agregar(int pItem)
        {
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.item = pItem;
            nuevoNodo.siguiente = null;
            if (this.list == null)
            {
                list = nuevoNodo;
            }
            else
            {
                Nodo aux = this.list;
                while (aux.siguiente!=null)
                {
                    aux = aux.siguiente;
                }

                aux.siguiente = nuevoNodo;
            }
        }

        public void InserAt(int index, int pItem)
        {
            if (index < 0 || index >= Count)
            {
                
            }
            else
            {
                Nodo nuevoNodo = new Nodo();
                nuevoNodo.item = pItem;
                nuevoNodo.siguiente = null;
                if (index == 0)
                {
                    nuevoNodo.siguiente = this.list;
                    this.list = nuevoNodo;
                }
                else
                {
                    Nodo aux1 = list;
                    Nodo aux=this.list;
                    Nodo anterior = null;

                    
                    for (int i = 0; i <= index; i++)
                    {
                        anterior = aux;
                        aux = aux.siguiente;
                    }


                    anterior.siguiente = nuevoNodo;
                    nuevoNodo.siguiente = aux;
                    
                }
                
                
                
            }
        }

        public void Eliminar(int pItem)
        {
            if (this.list != null)
            {
                Nodo aux = list;
                Nodo anterior = null;

                while (aux.item.Equals(pItem)==false)
                {
                    anterior = aux;
                    aux = aux.siguiente;
                }


                if (aux == null)
                {
                    
                }else if (anterior == null)
                {
                    this.list = aux;
                }
                else
                {
                    anterior.siguiente = aux.siguiente;
                }

            }
        }

        public void DeleteAt(int index)
        {
            if (index < 0 || index >= Count)
            {

            }
            else
            {
                if (index == 0)
                {
                    list = list.siguiente;
                }
                else
                {
                    Nodo aux1 = list;
                    Nodo aux = this.list;
                    Nodo anterior = null;


                    for (int i = 0; i < index; i++)
                    {
                        anterior = aux;
                        aux = aux.siguiente;
                    }


                    anterior.siguiente = aux.siguiente;

                }
            }
        }

        public Nodo ObtenerPorIndice(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("indices fuera de la matriz");
            }
            else
            {
                Nodo aux = list;
                for (int i = 0; i < index; i++)
                {
                    aux = aux.siguiente;
                }

                return aux;
            }
        }
        
        public int this[int index]
        {
            get
            {

                Nodo aux =ObtenerPorIndice(index);
                return aux.item;
            }
            set
            {
                Nodo aux =ObtenerPorIndice(index);
                aux.item = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return GetEnumLista();
        }

        public EnumLista GetEnumLista()
        {
            return new EnumLista(this);
        }
    }

    public class EnumLista : IEnumerator
    {

        private Lista _lista;
        private int index = -1;
        public EnumLista(Lista pLista)
        {
            this._lista = pLista;
        }

        public bool MoveNext()
        {
            index++;
            return index < _lista.Count;
        }

        public void Reset()
        {
            this.index = -1;
        }

        public object Current => _lista[index];
    }

    public class Nodo
    {
        public int item { get; set; }
        public Nodo siguiente { get; set; }
    }
}