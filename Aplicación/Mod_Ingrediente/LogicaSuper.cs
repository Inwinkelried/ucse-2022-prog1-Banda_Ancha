using System;
using System.Collections.Generic;
using System.Linq;
using Aplicacion;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion {

    public class LogicaSuper
    {
        public List<Ingrediente> ListaFiltrada = new List<Ingrediente>();
        public List<Ingrediente> ListaSuper = new List<Ingrediente>();
        //Aca solo voy a hacer un calculo
        public LogicaSuper()
        {
            LogicaIngrediente ingrediente = new LogicaIngrediente();
            ListaSuper = ingrediente.getListaSuper();
        }

        public void añadirIngrediente(Ingrediente ingrediente)
        {
            ListaSuper.Add(ingrediente);
        }

        public decimal CalcularTotalCompra()
        {
            decimal total = 0;
            foreach (Ingrediente ingrediente in ListaSuper)
            {
                LogicaIngrediente IngredTemp = new LogicaIngrediente();
                total += IngredTemp.CostoDelIngrediente(ingrediente);
            }
            return total;
        }
        public List<Ingrediente> FiltrarPorTipo(Ingrediente ingrediente)
        {
            ListaFiltrada = ListaSuper.FindAll(x => x.GetType() == ingrediente.GetType()).ToList(); ;
            return ListaFiltrada;
        }
        //Filtro por precio
        public List<Ingrediente> FiltrarPorPrecio(decimal precio)
        {
            return ListaFiltrada = ListaSuper.FindAll(x => x.Precio <= precio).ToList();
        }
        //Filtro para Verduleria
        public List<Ingrediente> FiltrarPorVerduleria()
        {
            return ListaFiltrada = ListaSuper.FindAll(x => (x is HortalizaYVerdura) || (x is Fruta)).ToList();
        }
        //Filtro para Carne
        public List<Ingrediente> FiltrarPorCarniceria()
        {
            return ListaFiltrada = ListaSuper.FindAll(x => (x is Carnes) || (x is Pescados )).ToList();
        }
        // Filtro Lacteos
        public List<Ingrediente> FiltrarPorLacteos()
        {
            return ListaFiltrada = ListaSuper.FindAll(x => (x is Queso) || (x is Lacteo)).ToList();
        }
        // Filtro Bebidas
        public List<Bebida> TipoDeBebida(Tipo_Bebida tipo)
        {
            List<Bebida> bebidafiltrada = ListaSuper.Where((x => x is Bebida)).Select(x => x as Bebida).ToList();
            return bebidafiltrada.Where(x => x.Tipo == tipo).Select(x => x as Bebida).ToList();
        }



    }
}
