using System;
using Taller.App.Dominio;
using Taller.App.Persistencia;

namespace Taller.App.Consola
{
    class Program
    {
        private static RepositorioMecanico repositorio = new RepositorioMecanico(
            new Persistencia.ContextDb()
        );
        private static RepositorioPropietario repositorioP = new RepositorioPropietario(
            new Persistencia.ContextDb()
        );
        private static RepositorioVehiculo repositorioV = new RepositorioVehiculo(
            new Persistencia.ContextDb()
        );
        static void Main(string[] args)
        {
            //AgregarMecanico();
            //ObtenerMecanicos();
            //BuscarMecanico("6");
            //EliminarMecanico("2");
            //EditarMecanico("4");

            //AgregarPropietario();
            //ObtenerPropietarios();
            //BuscarPropietario("3");
            //EliminarPropietario("4");
            //EditarPropietario("2")

            //AgregarVehiculo();
            //ObtenerVehiculo();
            //BuscarVehiculo("1");
            //EliminarVehiculo("2");
            //EditarVehiculo("")
        }
        static void AgregarMecanico()
        {
            var mecanicoNuevo = new Mecanico
            {
                Id = "1",
                Nombre = "Rogelio",
                Telefono = "5255456",
                Correo = "fulano@Rogelio",
                Contrasenia = "123698",
                FechaNacimiento = "02/02/1985",
                Ciudad = "Santa Fe",
            };

            repositorio.AgregarMecanico(mecanicoNuevo);
            Console.WriteLine("Mecanico Agregado");
        }
        static void ObtenerMecanicos()
        {
            foreach (var mecanico in repositorio.ObtenerMecanicos())
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Nombre: " + mecanico.Nombre + " \nTelefono: " + mecanico.Telefono);
            }
        }

        static void BuscarMecanico (string id){
            var mecanico = repositorio.BuscarMecanico(id);
            if(mecanico != null){
                Console.WriteLine("Se econtró el mecánico: "+  mecanico.Nombre);
                }
                else{
                    Console.WriteLine("NO SE HALLÓ");
            }
        }
        static void EliminarMecanico(string id){
            repositorio.EliminarMecanico(id);
        }

        static void EditarMecanico(){
            var mecanicoNuevo = new  Mecanico{
                Id = "2",
                Nombre = "Pancho",
                Telefono = "5255456",
                Correo = "fulano@pancho",
                Contrasenia = "123456",
                FechaNacimiento = "02/02/2000",
                Ciudad = "Santa Fe",
            };
            repositorio.EditarMecanico(mecanicoNuevo);
        }

        static void AgregarPropietario()
        {
            var propietarioNuevo = new Propietario
            {
                Id = "1",
                Nombre = "Antonio",
                Telefono = "24567899",
                Correo = "fulano@anotnio",
                Ciudad = "Santa Fe",
                Contrasenia = "123456",
                FechaNacimiento = "23/02/1990",
            };

            repositorioP.AgregarPropietario(propietarioNuevo);
            Console.WriteLine("Propietario Agregado");
        }
        static void ObtenerPropietarios()
        {
            foreach (var propietario in repositorioP.ObtenerPropietarios())
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Nombre: " + propietario.Nombre + " \nTelefono: " + propietario.Telefono);
            }
        }

        static void BuscarPropietario (string id){
            var propietario = repositorioP.BuscarPropietario(id);
            if(propietario != null){
                Console.WriteLine("Se econtró el propietario: " +  propietario.Nombre);
                }
                else{
                    Console.WriteLine("NO SE HALLÓ PROPIETARIO");
            }
        }
        static void EliminarPropietario(string id){
            repositorioP.EliminarPropietario(id);
        }

        static void EditarPropietario(){
            var propietarioNuevo = new  Propietario{
                Id = "2",
                Nombre = "Julian",
                Telefono = "24544567",
                Correo = "fulano@julian",
                Ciudad = "Santa Fe",
            };
            repositorioP.EditarPropietario(propietarioNuevo);
        }

        static void AgregarVehiculo()
        {
            var vehiculoNuevo = new Vehiculo
            {
                Id = "1",
                Placa = "ezt098",
                Marca = "kia",
                Modelo = "2001",
                Kilometraje = "45693",
            };

            repositorioV.AgregarVehiculo(vehiculoNuevo);
            Console.WriteLine("Vehiculo Agregado");
        }
        static void ObtenerVehiculos()
        {
            foreach (var vehiculo in repositorioV.ObtenerVehiculos())
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Placa: " + vehiculo.Placa + " \nMarca: " + vehiculo.Marca);
            }
        }

        static void BuscarVehiculo (string id){
            var vehiculo = repositorioV.BuscarVehiculo(id);
            if(vehiculo != null){
                Console.WriteLine("Se econtró el vehiculo: "+  vehiculo.Placa);
                }
                else{
                    Console.WriteLine("NO SE HALLÓ VEHICULO");
            }
        }
        static void EliminarVehiculo(string id){
            repositorioV.EliminarVehiculo(id);
        }

        static void EditarVehiculo(){
            var vehiculoNuevo = new  Vehiculo{
                Id = "3",
                Placa = "pit084",
                Marca = "Renault",
                Modelo = "2014",
                Kilometraje = "25984",
            };
            repositorioV.EditarVehiculo(vehiculoNuevo);
        }
    }
}
