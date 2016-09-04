using Peluqueria.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Xml;

namespace Peluqueria
{
    public partial class RadFormVentas : Telerik.WinControls.UI.RadForm
    {
        Negocio Consulta = new Negocio();
        DataSet DTS = new DataSet();
        DataTable dttVenta = new DataTable();
        DataTable dttVentaPro = new DataTable();
        DataTable dttVentaDia = new DataTable();
        DataTable dttInsumo = new DataTable();
        bool Interna = false;

        int total = 0;

        public RadFormVentas()
        {
            InitializeComponent();
            ThemeResolutionService.ApplyThemeToControlTree(this, Program.NombreTema);
            RadMessageBox.ThemeName = ThemeName;

            Inicio();

            ConsultaVentaDia();

            ValidaVenta();
        }

        protected void Inicio()
        {
            RadDrpServicios.Focus();

            dttVenta = new DataTable();
            dttVenta.Columns.Add("ID", typeof(int));
            dttVenta.Columns.Add("CodigoTrabajo", typeof(string));
            dttVenta.Columns.Add("ServicioID", typeof(int));
            dttVenta.Columns.Add("Servicio", typeof(string));
            dttVenta.Columns.Add("ProductoID", typeof(int));
            dttVenta.Columns.Add("Producto", typeof(string));
            dttVenta.Columns.Add("UsuarioID", typeof(int));
            dttVenta.Columns.Add("Estilista", typeof(string));
            dttVenta.Columns.Add("Cantidad", typeof(int));
            dttVenta.Columns.Add("ValorVenta", typeof(int));

            dttVentaPro = new DataTable();
            dttVentaPro.Columns.Add("ID", typeof(int));
            dttVentaPro.Columns.Add("ServicioID", typeof(int));
            dttVentaPro.Columns.Add("ProductoID", typeof(int));
            dttVentaPro.Columns.Add("Cantidad", typeof(int));

            DTS = Consulta.ConsultaProductosServicios();

            if (DTS.Tables[0].Rows[0]["Resultado"].ToString() == "1")
            {
                RadDrpServicios.SelectedIndexChanged -= new Telerik.WinControls.UI.Data.PositionChangedEventHandler(RadDrpServicios_SelectedIndexChanged);
                RadDrpProductos.SelectedIndexChanged -= new Telerik.WinControls.UI.Data.PositionChangedEventHandler(RadDrpProductos_SelectedIndexChanged);

                RadDrpUsuarios.DataSource = DTS.Tables[1];
                RadDrpUsuarios.DisplayMember = "CodigoUsuario";
                RadDrpUsuarios.ValueMember = "UsuarioID";
                RadDrpUsuarios.SelectedIndex = -1;

                RadDrpServicios.DataSource = DTS.Tables[2];
                RadDrpServicios.DisplayMember = "CodigoServicio";
                RadDrpServicios.ValueMember = "ServicioID";
                RadDrpServicios.SelectedIndex = -1;

                var ProdVenta = from prod in DTS.Tables[3].AsEnumerable()
                                where prod.Field<bool>("Insumo") == false
                                select prod;

                if (ProdVenta.Count()>0)
                {
                    RadDrpProductos.DataSource = ProdVenta.CopyToDataTable().Copy();
                    RadDrpProductos.DisplayMember = "Nombre";
                    RadDrpProductos.ValueMember = "ProductoID";
                    RadDrpProductos.SelectedIndex = -1; 
                }

                ProdVenta = from prod in DTS.Tables[3].AsEnumerable()
                            where prod.Field<bool>("Insumo") == true
                            select prod;

                if (ProdVenta.Count() > 0)
                {
                    dttInsumo = new DataTable();
                    dttInsumo = ProdVenta.CopyToDataTable().Copy();
                    dttInsumo.Columns.Add("Cantidad",typeof(int));
                    //dttInsumo.Columns.Add("ID", typeof(int));
                    //dttInsumo.Columns.Add("ServicioID", typeof(int));

                    foreach (DataRow dtr in dttInsumo.Rows)
                    {
                        //dtr["ID"] = 0;
                        dtr["Cantidad"] = 0;
                        //dtr["ServicioID"] = 0;
                    }

                    RadGridViewProductoInsumo.DataSource = new DataTable();
                    RadGridViewProductoInsumo.Columns.Clear();

                    RadGridViewProductoInsumo.EnableFiltering = false;
                    RadGridViewProductoInsumo.AutoGenerateColumns = false;
                    RadGridViewProductoInsumo.AllowAddNewRow = false;
                    RadGridViewProductoInsumo.MasterTemplate.ShowHeaderCellButtons = true;
                    RadGridViewProductoInsumo.MasterTemplate.ShowFilteringRow = false;
                    RadGridViewProductoInsumo.TableElement.EndUpdate();
                    RadGridViewProductoInsumo.AllowDeleteRow = false;
                    RadGridViewProductoInsumo.AllowRowResize = false;
                    RadGridViewProductoInsumo.AllowEditRow = true;
                    RadGridViewProductoInsumo.ShowRowHeaderColumn = false;
                    RadGridViewProductoInsumo.Select();
                    RadGridViewProductoInsumo.EnableSorting = true;
                    RadGridViewProductoInsumo.AllowDragToGroup = false;
                    RadGridViewProductoInsumo.ShowGroupPanel = false;

                    List<int> data = dttInsumo.AsEnumerable().Select(CodigoProducto => CodigoProducto.Field<string>("CodigoProducto").Length).ToList();
                    int WidthText = data.Max();
                    var col = from dat in dttInsumo.AsEnumerable()
                              where dat.Field<string>("CodigoProducto").Length == WidthText
                              select dat;

                    GridViewTextBoxColumn colCodigoProducto = new GridViewTextBoxColumn();
                    colCodigoProducto.FieldName = "CodigoProducto";
                    colCodigoProducto.HeaderText = "CodigoProducto";
                    colCodigoProducto.MinWidth = Consulta.AnchoTexto(col.First().Field<string>("CodigoProducto").ToString(), colCodigoProducto.HeaderText, RadGridViewProductoInsumo.Font);
                    colCodigoProducto.Name = "colCodigoProducto";
                    colCodigoProducto.ReadOnly = true;
                    RadGridViewProductoInsumo.Columns.Add(colCodigoProducto);

                    data = dttInsumo.AsEnumerable().Select(Cantidad => Cantidad.Field<int>("Cantidad").ToString().Length).ToList();
                    WidthText = data.Max();
                    col = from dat in dttInsumo.AsEnumerable()
                              where dat.Field<int>("Cantidad").ToString().Length == WidthText
                              select dat;

                    GridViewDecimalColumn colCantidad = new GridViewDecimalColumn();
                    colCantidad.FieldName = "Cantidad";
                    colCantidad.HeaderText = "Cantidad";
                    colCantidad.MinWidth = Consulta.AnchoTexto(col.First().Field<int>("Cantidad").ToString(), colCantidad.HeaderText, RadGridViewProductoInsumo.Font);
                    colCantidad.Name = "colCantidad";
                    colCantidad.Minimum = 0;
                    colCantidad.DecimalPlaces = 0;
                    colCantidad.ReadOnly = false;
                    RadGridViewProductoInsumo.Columns.Add(colCantidad);

                    RadGridViewProductoInsumo.DataSource = dttInsumo;
                }

                RadDrpServicios.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(RadDrpServicios_SelectedIndexChanged);
                RadDrpProductos.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(RadDrpProductos_SelectedIndexChanged);
            }
        }

        private void ConsultaVentaDia()
        {
            DataSet dtsventa = Consulta.ConsultaVentas(0, "", "");
            if (dtsventa.Tables[0].Rows[0]["Resultado"].ToString()=="1")
            {
                dttVentaDia = dtsventa.Tables[1];
                CargaGrillaVenta();
            }
        }

        protected void CargaGrillaVenta()
        {
            RadGridViewVentaDiaria.DataSource = new DataTable();
            RadGridViewVentaDiaria.Columns.Clear();

            if (dttVentaDia.Rows.Count > 0)
            {
                RadGridViewVentaDiaria.EnableFiltering = true;
                RadGridViewVentaDiaria.AutoGenerateColumns = false;
                RadGridViewVentaDiaria.AllowAddNewRow = false;
                RadGridViewVentaDiaria.MasterTemplate.ShowHeaderCellButtons = true;
                RadGridViewVentaDiaria.MasterTemplate.ShowFilteringRow = false;
                RadGridViewVentaDiaria.TableElement.EndUpdate();
                RadGridViewVentaDiaria.AllowDeleteRow = false;
                RadGridViewVentaDiaria.AllowRowResize = false;
                RadGridViewVentaDiaria.AllowEditRow = true;
                RadGridViewVentaDiaria.ShowRowHeaderColumn = false;
                RadGridViewVentaDiaria.Select();
                RadGridViewVentaDiaria.EnableSorting = true;

                List<int> data = dttVentaDia.AsEnumerable().Select(Nombre => Nombre.Field<int>("NumeroVentaDia").ToString().Length).ToList();
                int WidthText = data.Max();
                var col = from dat in dttVentaDia.AsEnumerable()
                          where dat.Field<int>("NumeroVentaDia").ToString().Length == WidthText
                          select dat;

                GridViewTextBoxColumn colNumeroVentaDia = new GridViewTextBoxColumn();
                colNumeroVentaDia.DataType = typeof(decimal);
                colNumeroVentaDia.FieldName = "NumeroVentaDia";
                colNumeroVentaDia.FormatString = "{0:G}";
                colNumeroVentaDia.HeaderText = "Numero de Venta";
                colNumeroVentaDia.MinWidth = Consulta.AnchoTexto(col.First().Field<int>("NumeroVentaDia").ToString(), colNumeroVentaDia.HeaderText, RadGridViewVentas.Font);
                colNumeroVentaDia.Name = "colNumeroVentaDia";
                colNumeroVentaDia.ReadOnly = true;
                RadGridViewVentaDiaria.Columns.Add(colNumeroVentaDia);

                data = dttVentaDia.AsEnumerable().Select(Servicio => Servicio.Field<int>("ValorVenta").ToString().Length).ToList();
                WidthText = data.Max();
                col = from dat in dttVentaDia.AsEnumerable()
                          where dat.Field<int>("ValorVenta").ToString().Length == WidthText
                          select dat;

                GridViewTextBoxColumn colValorVenta = new GridViewTextBoxColumn();
                colValorVenta.DataType = typeof(decimal);
                colValorVenta.FieldName = "ValorVenta";
                colValorVenta.FormatString = "{0:C}";
                colValorVenta.HeaderText = "Valor de Factura";
                colValorVenta.MinWidth = Consulta.AnchoTexto(col.First().Field<int>("ValorVenta").ToString(), colValorVenta.HeaderText, RadGridViewVentas.Font);
                colValorVenta.Name = "colValorVenta";
                colValorVenta.ReadOnly = true;
                RadGridViewVentaDiaria.Columns.Add(colValorVenta);

                data = dttVentaDia.AsEnumerable().Select(Servicio => Servicio.Field<string>("Fecha").ToString().Length).ToList();
                WidthText = data.Max();
                col = from dat in dttVentaDia.AsEnumerable()
                          where dat.Field<string>("Fecha").ToString().Length == WidthText
                          select dat;


                GridViewDateTimeColumn colFecha = new GridViewDateTimeColumn();
                colFecha.FieldName = "Fecha";
                colFecha.HeaderText = "Fecha";
                colFecha.MinWidth = Consulta.AnchoTexto(col.First().Field<string>("Fecha").ToString(), colFecha.HeaderText, RadGridViewVentaDiaria.Font);
                colFecha.Name = "colFecha";
                colFecha.ReadOnly = true;
                RadGridViewVentaDiaria.Columns.Add(colFecha);

                GridViewImageColumn colEliminar = new GridViewImageColumn();
                colEliminar.HeaderText = "Eliminar";
                colEliminar.MinWidth = 50;
                colEliminar.Name = "colEliminar";
                colEliminar.ReadOnly = true;
                RadGridViewVentaDiaria.Columns.Add(colEliminar);

                RadGridViewVentaDiaria.DataSource = dttVentaDia;

                for (int l = 0; l < RadGridViewVentaDiaria.Rows.Count; l++)
                {
                    Bitmap eliminar = new Bitmap(@"Imagenes\shopping-cart-remove-icon (1).png");
                    RadGridViewVentaDiaria.Rows[l].Cells["colEliminar"].Value = eliminar;
                }
            }

        }

        private void ValidaVenta()
        {
            RadMenuItemGuardar.Enabled = dttVenta.Rows.Count > 0;
        }

        protected void CargaGrilla()
        {
            RadGridViewVentas.DataSource = new DataTable();
            RadGridViewVentas.Columns.Clear();

            if (dttVenta.Rows.Count>0)
            {
                RadGridViewVentas.EnableFiltering = true;
                RadGridViewVentas.AutoGenerateColumns = false;
                RadGridViewVentas.AllowAddNewRow = false;
                RadGridViewVentas.MasterTemplate.ShowHeaderCellButtons = true;
                RadGridViewVentas.MasterTemplate.ShowFilteringRow = false;
                RadGridViewVentas.TableElement.EndUpdate();
                RadGridViewVentas.AllowDeleteRow = false;
                RadGridViewVentas.AllowRowResize = false;
                RadGridViewVentas.AllowEditRow = true;
                RadGridViewVentas.ShowRowHeaderColumn = false;
                RadGridViewVentas.Select();
                RadGridViewVentas.EnableSorting = true;

                List<int>  data = dttVenta.AsEnumerable().Select(Servicio => Servicio.Field<string>("Servicio").Length).ToList();
                int WidthText = data.Max();
                var col = from dat in dttVenta.AsEnumerable()
                          where dat.Field<string>("Servicio").Length == WidthText
                          select dat;

                GridViewTextBoxColumn colServicio = new GridViewTextBoxColumn();
                colServicio.FieldName = "Servicio";
                colServicio.HeaderText = "Servicio";
                colServicio.MinWidth = Consulta.AnchoTexto( col.First().Field<string>("Servicio").ToString(),colServicio.HeaderText, RadGridViewVentas.Font);
                colServicio.Name = "colServicio";
                colServicio.ReadOnly = true;
                RadGridViewVentas.Columns.Add(colServicio);

                data = dttVenta.AsEnumerable().Select(Producto => Producto.Field<string>("Producto").Length).ToList();
                WidthText = data.Max();
                col = from dat in dttVenta.AsEnumerable()
                      where dat.Field<string>("Producto").Length == WidthText
                      select dat;

                GridViewTextBoxColumn colProducto = new GridViewTextBoxColumn();
                colProducto.FieldName = "Producto";
                colProducto.HeaderText = "Producto";
                colProducto.MinWidth = Consulta.AnchoTexto( col.First().Field<string>("Producto").ToString(),colProducto.HeaderText, RadGridViewVentas.Font);
                colProducto.Name = "colProducto";
                colProducto.ReadOnly = true;
                RadGridViewVentas.Columns.Add(colProducto);

                data = dttVenta.AsEnumerable().Select(Estilista => Estilista.Field<string>("Estilista").Length).ToList();
                WidthText = data.Max();
                col = from dat in dttVenta.AsEnumerable()
                      where dat.Field<string>("Estilista").Length == WidthText
                      select dat;

                GridViewTextBoxColumn colEstilista = new GridViewTextBoxColumn();
                colEstilista.FieldName = "Estilista";
                colEstilista.HeaderText = "Estilista";
                colEstilista.MinWidth = Consulta.AnchoTexto(col.First().Field<string>("Estilista").ToString(),colEstilista.HeaderText, RadGridViewVentas.Font);
                colEstilista.Name = "colEstilista";
                colEstilista.ReadOnly = true;
                RadGridViewVentas.Columns.Add(colEstilista);

                data = dttVenta.AsEnumerable().Select(CodigoTrabajo => CodigoTrabajo.Field<string>("CodigoTrabajo").Length).ToList();
                WidthText = data.Max();
                col = from dat in dttVenta.AsEnumerable()
                      where dat.Field<string>("CodigoTrabajo").Length == WidthText
                      select dat;

                GridViewTextBoxColumn colCodigoTrabajo = new GridViewTextBoxColumn();
                colCodigoTrabajo.FieldName = "CodigoTrabajo";
                colCodigoTrabajo.HeaderText = "Baucher";
                colCodigoTrabajo.MinWidth = Consulta.AnchoTexto(col.First().Field<string>("CodigoTrabajo").ToString(), colCodigoTrabajo.HeaderText, RadGridViewVentas.Font);
                colCodigoTrabajo.Name = "colCodigoTrabajo";
                colCodigoTrabajo.ReadOnly = true;
                RadGridViewVentas.Columns.Add(colCodigoTrabajo);

                data = dttVenta.AsEnumerable().Select(Nombre => Nombre.Field<int>("Cantidad").ToString().Length).ToList();
                WidthText = data.Max();
                col = from dat in dttVenta.AsEnumerable()
                      where dat.Field<int>("Cantidad").ToString().Length == WidthText
                      select dat;

                GridViewTextBoxColumn colCantidad = new GridViewTextBoxColumn();
                colCantidad.DataType = typeof(decimal);
                colCantidad.FieldName = "Cantidad";
                colCantidad.FormatString = "{0:G}";
                colCantidad.HeaderText = "Cantidad";
                colCantidad.MinWidth = Consulta.AnchoTexto( col.First().Field<int>("Cantidad").ToString(),colCantidad.HeaderText, RadGridViewVentas.Font);
                colCantidad.Name = "colCantidad";
                colCantidad.ReadOnly = true;
                RadGridViewVentas.Columns.Add(colCantidad);

                data = dttVenta.AsEnumerable().Select(Nombre => Nombre.Field<int>("ValorVenta").ToString().Length).ToList();
                WidthText = data.Max();
                col = from dat in dttVenta.AsEnumerable()
                      where dat.Field<int>("ValorVenta").ToString().Length == WidthText
                      select dat;

                GridViewTextBoxColumn colValorVenta = new GridViewTextBoxColumn();
                colValorVenta.DataType = typeof(decimal);
                colValorVenta.FieldName = "ValorVenta";
                colValorVenta.FormatString = "{0:C}";
                colValorVenta.HeaderText = "Valor de Compra";
                colValorVenta.MinWidth = Consulta.AnchoTexto( col.First().Field<int>("ValorVenta").ToString(),colValorVenta.HeaderText, RadGridViewVentas.Font);
                colValorVenta.Name = "colValorVenta";
                colValorVenta.ReadOnly = true;
                RadGridViewVentas.Columns.Add(colValorVenta);

                GridViewImageColumn colEliminar = new GridViewImageColumn();
                colEliminar.HeaderText = "Eliminar";
                colEliminar.MinWidth = 50;
                colEliminar.Name = "colEliminar";
                colEliminar.ReadOnly = true;
                RadGridViewVentas.Columns.Add(colEliminar);

                RadGridViewVentas.DataSource = dttVenta; 
            }

            total = 0;

            foreach(DataRow dtr in dttVenta.Rows)
            {
                total += (int.Parse(dtr["Cantidad"].ToString()) * int.Parse(dtr["ValorVenta"].ToString()));
            }

            for (int l = 0; l < RadGridViewVentas.Rows.Count; l++)
            {
                Bitmap eliminar = new Bitmap(@"Imagenes\shopping-cart-remove-icon (1).png");
                RadGridViewVentas.Rows[l].Cells["colEliminar"].Value = eliminar;
            }

            RadMskValorTotal.Value = total;

            Limpiar();
            ValidaVenta();
        }

        private void RadDrpServicios_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if(RadDrpServicios.SelectedIndex>-1)
            {
                RadTxtCodigoTrabajo.Enabled = true;
                RadGridViewProductoInsumo.Enabled = true;
                RadDrpUsuarios.SelectedIndex = -1;

                RadDrpProductos.SelectedIndex = -1;

                var service = from serv in DTS.Tables[2].AsEnumerable()
                              where serv.Field<int>("ServicioID") == int.Parse(RadDrpServicios.SelectedValue.ToString())
                              select serv;

                if(!service.First().Field<bool>("Variable"))
                {
                    RadMskValorVenta.Value = service.First().Field<int>("ValorVenta");
                }
                else
                {
                    RadMskValorVenta.Value = 0;
                }
            }
        }

        private void RadDrpProductos_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (RadDrpProductos.SelectedIndex > -1)
            {
                //RadTxtCodigoTrabajo.Enabled = false;
                RadGridViewProductoInsumo.Enabled = false;

                foreach (DataRow dtr in dttInsumo.Rows)
                {
                    dtr["Cantidad"] = 0;
                }

                RadDrpUsuarios.SelectedIndex = -1;

                RadDrpServicios.SelectedIndex = -1;

                var product = from prod in DTS.Tables[3].AsEnumerable()
                              where prod.Field<int>("ProductoID") == int.Parse(RadDrpProductos.SelectedValue.ToString())
                              select prod;

                RadMskValorVenta.Value = product.First().Field<int>("ValorVentaXUnidad");
            }
        }

        private void RadMenuItemAdicionar_Click(object sender, EventArgs e)
        {

            if (RadDrpServicios.SelectedIndex == -1 && RadDrpProductos.SelectedIndex == -1)
            {
                RadMessageBox.Show("No ha seleccionado ningun Servicio o Producto.", "ALERTA");
                return;
            } 

            if (RadDrpServicios.SelectedIndex>-1)
            {
                if (RadDrpUsuarios.SelectedIndex == -1)
                {
                    RadMessageBox.Show("Se debe asociar el estilista que realiza el servicio.", "ALERTA");
                    return;
                }
                else
                {
                    if (RadTxtCodigoTrabajo.Text == "")
                    {
                        RadMessageBox.Show("Se debe ingresar el Código del Baucher.", "ALERTA");
                        return;
                    }
                }
            }

            if (RadDrpUsuarios.SelectedIndex > -1 && RadDrpProductos.SelectedIndex>-1)
            {
                if (RadTxtCodigoTrabajo.Text == "")
                {
                    if (RadMessageBox.Show("No ha Ingresado el Código del Baucher, recuerde que si es una Venta a Público\n y desea aplicar una bonificación a un estilista debe ser ingresado.\nDesea continuar?", "ALERTA", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }


            if (Convert.ToInt16(float.Parse(RadMskValorVenta.Value.ToString())) == 0)
            {
                RadMessageBox.Show("El Valor de Venta debe ser mayor a 0.", "ALERTA");
                return;
            }

            if (Convert.ToInt16(float.Parse(RadMskCantidad.Value.ToString())) == 0)
            {
                RadMessageBox.Show("La Cantidad de Productos o Servicios debe ser mayor a 0.", "ALERTA");
                return;
            }


            DataRow dtr = dttVenta.NewRow();
            dtr["ID"] = dttVenta.Rows.Count+1;
            dtr["CodigoTrabajo"] = RadTxtCodigoTrabajo.Text;
            dtr["ServicioID"] = RadDrpServicios.SelectedIndex > -1 ? int.Parse(RadDrpServicios.SelectedValue.ToString()) : 0;
            dtr["Servicio"] = RadDrpServicios.Text;
            dtr["ProductoID"] = RadDrpProductos.SelectedIndex > -1 ? int.Parse(RadDrpProductos.SelectedValue.ToString()) : 0;
            dtr["Producto"] = RadDrpProductos.Text;
            dtr["UsuarioID"] = RadDrpProductos.SelectedIndex > -1 && RadDrpUsuarios.SelectedIndex > -1 && RadTxtCodigoTrabajo.Text == "" 
                                ? 0
                                :RadDrpUsuarios.SelectedIndex > -1 ? int.Parse(RadDrpUsuarios.SelectedValue.ToString()) : 0;
            dtr["Estilista"] = RadDrpProductos.SelectedIndex>-1 && RadDrpUsuarios.SelectedIndex>-1 && RadTxtCodigoTrabajo.Text==""?"": RadDrpUsuarios.Text;
            dtr["Cantidad"] = Convert.ToInt16(float.Parse(RadMskCantidad.Value.ToString()));
            dtr["ValorVenta"] = Convert.ToInt16(float.Parse(RadMskValorVenta.Value.ToString()));

            if (RadDrpServicios.SelectedIndex > -1)
            {
                var prod = from pr in dttInsumo.AsEnumerable()
                           where pr.Field<int>("Cantidad") > 0
                           select pr;


                if (prod.Count() > 0)
                {
                    foreach (DataRow dtr1 in prod.CopyToDataTable().Copy().Rows)
                    {
                        DataRow dtr2 = dttVentaPro.NewRow();
                        dtr2["ID"] = dttVenta.Rows.Count + 1;
                        dtr2["ServicioID"] = RadDrpServicios.SelectedIndex > -1 ? int.Parse(RadDrpServicios.SelectedValue.ToString()) : 0;
                        dtr2["ProductoID"] = dtr1["ProductoID"];
                        dtr2["Cantidad"] = dtr1["Cantidad"];

                        dttVentaPro.Rows.Add(dtr2);
                    }

                }
                else
                {
                    if (RadMessageBox.Show("Seguro desea adicionar el servicio sin Productos Insumo?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }

                foreach (DataRow dtr1 in dttInsumo.Rows)
                {
                    dtr1["Cantidad"] = 0;
                }

            }

            dttVenta.Rows.Add(dtr);

            CargaGrilla();
        }

        private void RadMenuItemCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void Limpiar()
        {
            RadDrpServicios.SelectedIndex = -1;
            RadDrpProductos.SelectedIndex = -1;
            RadMskValorVenta.Value = 0;
            RadMskCantidad.Value = 0;
            RadDrpUsuarios.SelectedIndex = -1;
            RadDrpUsuarios.Enabled = true;
            RadTxtCodigoTrabajo.Text = "";
        }

        private void RadMenuItemGuardar_Click(object sender, EventArgs e)
        {
            if(RadMessageBox.Show("Seguro desea guardar la factura","ALERTA",MessageBoxButtons.OKCancel)==DialogResult.Cancel)
            {
                return;
            }

            if (RadMessageBox.Show("La factura es de Venta al Público?", "ALERTA", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                Interna = true;
            }

            dttVenta.TableName = "row";
            dttVentaPro.TableName = "row2";

            DataSet dtsVenta = new DataSet();
            dtsVenta.Tables.Add(dttVenta);
            dtsVenta.Tables.Add(dttVentaPro);

            string xml = dtsVenta.GetXml().Replace("</NewDataSet>","").Replace("<NewDataSet>", "");
            int venta = Convert.ToInt32(float.Parse(RadMskValorTotal.Value.ToString()));

            DTS = Consulta.CreaVenta(xml, venta,Interna);

            RadMessageBox.Show(DTS.Tables[0].Rows[0]["Mensaje"].ToString(), "ALERTA");


            if (DTS.Tables[0].Rows[0]["Resultado"].ToString()=="1")
            {
                dttVenta.Rows.Clear();
                ValidaVenta(); 
                Limpiar();
                RadMskValorTotal.Value = 0;
                Interna = false;
            }
            Inicio();
            ConsultaVentaDia();
            CargaGrilla();
        }

        private void RadGridViewVentas_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex>=0 && e.ColumnIndex==RadGridViewVentas.Columns.Count-1)
            {
                if(RadMessageBox.Show("Seguro desea eliminar este registro.","ALERTA",MessageBoxButtons.OKCancel)==DialogResult.OK)
                {
                    dttVenta.Rows.RemoveAt(e.RowIndex);

                    CargaGrilla();
                }
            }
        }

        private void RadGridViewVentaDiaria_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == RadGridViewVentaDiaria.Columns.Count - 1)
            {
                if (RadMessageBox.Show("Seguro desea eliminar esta Venta.", "ALERTA", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DataSet dttel = Consulta.EliminaVenta(int.Parse(dttVentaDia.Rows[e.RowIndex]["VentaID"].ToString()));
                    RadMessageBox.Show(dttel.Tables[0].Rows[0]["Mensaje"].ToString(), "ALERTA");

                    ConsultaVentaDia();
                }
            }
        }
    }
}
