using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peluqueria.Clases
{
    class Objetos
    {
    }

    class Usuario
    {
        public Usuario()
        { }

        public Usuario(string Nombre, string Apellido, string Documento, string Telefono, string NombreUsuario, string Clave, string Direccion)
        {
            nombre = Nombre;
            apellido = Apellido;
            documento = Documento;
            telefono = Telefono;
            nombreUsuario = NombreUsuario;
            clave = Clave;
            direccion = Direccion;
        }

        int usuarioId;
        public int UsuarioID
        {
            get
            {
                return usuarioId;
            }

            set
            {
                usuarioId = value;
            }
        }

        string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        string apellido;
        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        string codigoUsuario;
        public string CodigoUsuario
        {
            get
            {
                return codigoUsuario;
            }

            set
            {
                codigoUsuario = value;
            }
        }

        string documento;
        public string Documento
        {
            get
            {
                return documento;
            }

            set
            {
                documento = value;
            }
        }

        string telefono;
        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        string nombreUsuario;
        public string NombreUsuario
        {
            get
            {
                return nombreUsuario;
            }

            set
            {
                nombreUsuario = value;
            }
        }

        string clave;
        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }

        string direccion;
        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        int rolID;
        public int RolID
        {
            get
            {
                return rolID;
            }

            set
            {
                rolID = value;
            }
        }

        bool activo;
        public bool Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }


        Rol UsuarioRol = new Rol();


    }

    class Rol
    {
        int rolID;
        public int RolID
        {
            get
            {
                return rolID;
            }

            set
            {
                rolID = value;
            }
        }

        string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

    }

    class Producto
    {
        public Producto() { }

        public Producto(int ProductoID, string Nombre, int UnidadxProducto, int ValorCompra, int ValorVentaXUnidad, int PorcentajeVentaPublico,
            int DescuentoVentaInterna, bool Insumo, string CodigoProducto, bool Activo)
        {
            productoID = ProductoID;
            nombre = Nombre;
            unidadxProducto = UnidadxProducto;
            valorCompra = ValorCompra;
            valorVentaXUnidad = ValorVentaXUnidad;
            porcentajeVentaPublico = PorcentajeVentaPublico;
            descuentoVentaInterna = DescuentoVentaInterna;
            insumo = Insumo;
            codigoProducto = CodigoProducto;
            activo = Activo;
        }

        int productoID;
        public int ProductoID
        {
            get
            {
                return productoID;
            }

            set
            {
                productoID = value;
            }
        }

        string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        int unidadxProducto;
        public int UnidadxProducto
        {
            get
            {
                return unidadxProducto;
            }

            set
            {
                unidadxProducto = value;
            }
        }

        int valorCompra;
        public int ValorCompra
        {
            get
            {
                return valorCompra;
            }

            set
            {
                valorCompra = value;
            }
        }

        int valorVentaXUnidad;
        public int ValorVentaXUnidad
        {
            get
            {
                return valorVentaXUnidad;
            }

            set
            {
                valorVentaXUnidad = value;
            }
        }

        int porcentajeVentaPublico;
        public int PorcentajeVentaPublico
        {
            get
            {
                return porcentajeVentaPublico;
            }

            set
            {
                porcentajeVentaPublico = value;
            }
        }

        int descuentoVentaInterna;
        public int DescuentoVentaInterna
        {
            get
            {
                return descuentoVentaInterna;
            }

            set
            {
                descuentoVentaInterna = value;
            }
        }

        bool insumo;
        public bool Insumo
        {
            get
            {
                return insumo;
            }

            set
            {
                insumo = value;
            }
        }

        string codigoProducto;
        public string CodigoProducto
        {
            get
            {
                return codigoProducto;
            }

            set
            {
                codigoProducto = value;
            }
        }

        bool activo;
        public bool Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }

        int proveedorID;
        public int ProveedorID
        {
            get
            {
                return proveedorID;
            }

            set
            {
                proveedorID = value;
            }
        }

        string proveedor;
        public string Proveedor
        {
            get
            {
                return proveedor;
            }

            set
            {
                proveedor = value;
            }
        }

    }

    class Servicio
    {
        public Servicio() { }

        public Servicio(int servicioID, string nombre, int valorVenta, int porcentajeEstilista, string CodigoServicio, bool variable, bool activo)
        {
            servicioID = ServicioID;
            nombre = Nombre;
            valorVenta = ValorVenta;
            porcentajeEstilista = PorcentajeEstilista;
            codigoServicio = CodigoServicio;
            variable = Variable;
            activo = Activo;
        }

        int servicioID;
        public int ServicioID
        {
            get
            {
                return servicioID;
            }

            set
            {
                servicioID = value;
            }
        }

        string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        int valorVenta;
        public int ValorVenta
        {
            get
            {
                return valorVenta;
            }

            set
            {
                valorVenta = value;
            }
        }

        int porcentajeEstilista;
        public int PorcentajeEstilista
        {
            get
            {
                return porcentajeEstilista;
            }

            set
            {
                porcentajeEstilista = value;
            }
        }

        bool variable;
        public bool Variable
        {
            get
            {
                return variable;
            }

            set
            {
                variable = value;
            }
        }

        string codigoServicio;
        public string CodigoServicio
        {
            get
            {
                return codigoServicio;
            }

            set
            {
                codigoServicio = value;
            }
        }

        bool activo;
        public bool Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }


        public List<Producto> Productos = new List<Producto>();
    }

    class AdelantoInsentivo
    {
        public AdelantoInsentivo() { }

        int adelantoInsentivoID;
        public int AdelantoInsentivoID
        {
            get
            {
                return adelantoInsentivoID;
            }

            set
            {
                adelantoInsentivoID = value;
            }
        }

        int usuarioAdelantoInsentivoID;
        public int UsuarioAdelantoInsentivoID
        {
            get
            {
                return usuarioAdelantoInsentivoID;
            }

            set
            {
                usuarioAdelantoInsentivoID = value;
            }
        }

        int valorAdelantoInsentivo;
        public int ValorAdelantoInsentivo
        {
            get
            {
                return valorAdelantoInsentivo;
            }

            set
            {
                valorAdelantoInsentivo = value;
            }
        }

        bool adelanto;
        public bool Adelanto
        {
            get
            {
                return adelanto;
            }

            set
            {
                adelanto = value;
            }
        }

        bool activo;
        public bool Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }


    }

    class Deposito
    {
        public Deposito() { }

        int depositoID;
        public int DepositoID
        {
            get
            {
                return depositoID;
            }

            set
            {
                depositoID = value;
            }
        }

        int valorDeposito;
        public int ValorDeposito
        {
            get
            {
                return valorDeposito;
            }

            set
            {
                valorDeposito = value;
            }
        }

        bool activo;
        public bool Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }

    }

    class Gasto
    {
        public Gasto() { }

        int gastoID;
        public int GastoID
        {
            get
            {
                return gastoID;
            }

            set
            {
                gastoID = value;
            }
        }

        string detalle;
        public string Detalle
        {
            get
            {
                return detalle;
            }

            set
            {
                detalle = value;
            }
        }

        int valorGasto;
        public int ValorGasto
        {
            get
            {
                return valorGasto;
            }

            set
            {
                valorGasto = value;
            }
        }

        bool activo;
        public bool Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }


    }

    class PagoFactura
    {
        public PagoFactura() { }

        int pagoFacturaID;
        public int PagoFacturaID
        {
            get
            {
                return pagoFacturaID;
            }

            set
            {
                pagoFacturaID = value;
            }
        }

        int proveedorID;
        public int ProveedorID
        {
            get
            {
                return proveedorID;
            }

            set
            {
                proveedorID = value;
            }
        }

        string numeroFactura;
        public string NumeroFactura
        {
            get
            {
                return numeroFactura;
            }

            set
            {
                numeroFactura = value;
            }
        }

        int valorPagoFactura;
        public int ValorPagoFactura
        {
            get
            {
                return valorPagoFactura;
            }

            set
            {
                valorPagoFactura = value;
            }
        }

        bool activo;
        public bool Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }

    }
}
