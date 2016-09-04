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
using Peluqueria.Clases;

namespace Peluqueria
{
    public partial class RadFormReporte : Telerik.WinControls.UI.RadForm
    {
        Negocio consulta = new Negocio();
        DataSet DTS = new DataSet();

        public RadFormReporte()
        {
            InitializeComponent();
            ThemeResolutionService.ApplyThemeToControlTree(this, Program.NombreTema);
            RadMessageBox.ThemeName = this.ThemeName;

            RadDrpReporte.Items.Add(new RadListDataItem("Ventas",0));
            RadDrpReporte.Items.Add(new RadListDataItem("Nomina", 1));
            RadDrpReporte.Items.Add(new RadListDataItem("Inventario", 2));
            RadDrpReporte.SelectedIndex = 0;

        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            if(DateTimePickerInicio.Value.Date>DateTimePickerFinal.Value.Date && RadDrpReporte.SelectedValue.ToString()!="2")
            {
                RadMessageBox.Show("La Fecha Final no puede ser menor a la Fecha Inicial.", "ALERTA");
                return;
            }

            consultar();
        }

        private void consultar()
        {
            DataSet DtsReporte = new DataSet();

            switch (RadDrpReporte.SelectedValue.ToString())
            {
                case "2":

                    DTS = consulta.ConsultaInventario();

                    break;

                default:

                    DTS=consulta.ConsultaVentas(int.Parse(RadDrpReporte.SelectedValue.ToString()),DateTimePickerInicio.Value.ToString("yyyyMMdd"), DateTimePickerFinal.Value.ToString("yyyyMMdd"));

                    break;
            }

            if(DTS.Tables[0].Rows[0]["Resultado"].ToString()=="1")
            {

                consulta.FusionTablas(DtsReporte, DTS,RadDrpReporte.SelectedValue.ToString(),DateTimePickerInicio.Value.Date,DateTimePickerFinal.Value.Date);

                configuraGrilla(DtsReporte);

            }
            else
            {
                RadMessageBox.Show(DTS.Tables[0].Rows[0]["Resultado"].ToString(), "ALERTA");
            }
            
        }

        private void configuraGrilla(DataSet dtsReporte)
        {
            RadGridViewReporte.DataSource = new DataTable();
            RadGridViewReporte.Columns.Clear();

            RadGridViewReporte.EnableFiltering = true;
            RadGridViewReporte.AutoGenerateColumns = true;
            RadGridViewReporte.AllowAddNewRow = false;
            RadGridViewReporte.MasterTemplate.ShowHeaderCellButtons = true;
            RadGridViewReporte.MasterTemplate.ShowFilteringRow = false;
            RadGridViewReporte.TableElement.EndUpdate();
            RadGridViewReporte.AllowDeleteRow = false;
            RadGridViewReporte.AllowRowResize = false;
            RadGridViewReporte.AllowEditRow = true;
            RadGridViewReporte.ShowRowHeaderColumn = false;
            RadGridViewReporte.Select();
            RadGridViewReporte.EnableSorting = true;
            RadGridViewReporte.ReadOnly = true;

            RadGridViewReporte.DataSource = dtsReporte.Tables[0];


            for (int l = 0; l < RadGridViewReporte.Columns.Count; l++)
            {
                if (dtsReporte.Tables[0].Rows.Count > 0)
                {

                    List<int> data = dtsReporte.Tables[0].AsEnumerable().Select(Producto => Producto.Field<object>(dtsReporte.Tables[0].Columns[l].ColumnName).ToString().Length).ToList();
                    int WidthText = data.Max();
                    var col = from dat in dtsReporte.Tables[0].AsEnumerable()
                              where dat.Field<object>(dtsReporte.Tables[0].Columns[l].ColumnName).ToString().Length == WidthText
                              select dat;
                    RadGridViewReporte.Columns[l].MinWidth = consulta.AnchoTexto(WidthText > RadGridViewReporte.Columns[l].HeaderText.Length
                                                    ? col.First().Field<object>(dtsReporte.Tables[0].Columns[l].ColumnName).ToString()
                                                    : RadGridViewReporte.Columns[l].HeaderText, RadGridViewReporte.Font) + 10;
                }
                else
                {
                    RadGridViewReporte.Columns[l].MinWidth = consulta.AnchoTexto(RadGridViewReporte.Columns[l].HeaderText, RadGridViewReporte.Font) + 15;
                }

                RadGridViewReporte.Columns[l].HeaderText = RadGridViewReporte.Columns[l].HeaderText.Replace("X", " ");

            }
        }

        
    }
}
