using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio;

namespace Taller.App.Persistencia
{
    public class RepositorioVehiculo
    {
        private readonly ContextDb contextDb;
        public RepositorioVehiculo(ContextDb contextDb)
        {
            this.contextDb = contextDb;
        }

        public Vehiculo AgregarVehiculo(Vehiculo vehiculo)
        {
            var vehiculoNuevo = this.contextDb.Vehiculos.Add(vehiculo);
            this.contextDb.SaveChanges();
            return vehiculoNuevo.Entity;
        }

        public IEnumerable<Vehiculo> ObtenerVehiculos()
        {
            return this.contextDb.Vehiculos;
        }

        public Vehiculo BuscarVehiculo(string id)
        {
            return this.contextDb.Vehiculos.FirstOrDefault(p => p.Id == id);
        }

        public void EliminarVehiculo(string id)
        {
            var vehiculo = this.contextDb.Vehiculos.FirstOrDefault(p => p.Id == id);
            if (vehiculo != null)
            {
                this.contextDb.Vehiculos.Remove(vehiculo);
                this.contextDb.SaveChanges();
            }
        }
         public void EditarVehiculo(Vehiculo vehiculonuevo){
             var vehiculoActual = this.contextDb.Vehiculos.FirstOrDefault(p => p.Id == vehiculonuevo.Id);
            if (vehiculoActual != null)
            { 
                vehiculoActual.Placa = vehiculonuevo.Placa;
                vehiculoActual.Marca = vehiculonuevo.Marca;
                vehiculoActual.Modelo = vehiculonuevo.Modelo;
                vehiculoActual.Kilometraje = vehiculonuevo.Kilometraje;        
            } 
        }

    }
}