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

namespace Peluqueria
{
    public partial class RadFormAdelantoInsentivo : Telerik.WinControls.UI.RadForm
    {
        DataSet dts = new DataSet();
        DataTable dttAdelantoInsentivo = new DataTable();
        Negocio Consulta = new Negocio();

        int RowIndex = -1;
        public RadFormAdelantoInsentivo()
        {
            InitializeComponent(); ThemeResolutionService.ApplyThemeToControlTree(this, Program.NombreTema);
            RadMessageBox.ThemeName = this.ThemeName;

            TablaAdelantoInsentivo();
            RadMenuItemGuardar.Enabled = false;
        }

        protected void TablaAdelantoInsentivo()
        {
            dts = Consulta.ConsultaAdelantoInsentivo("","");

            if (dts.Tables[0].Rows[0]["Resultado"].ToString() == "1")
            {
                RadDrpUsuario.DataSource = dts.Tables[2];
                RadDrpUsuario.DisplayMember = "CodigoUsuario";
                RadDrpUsuario.ValueMember = "UsuarioID";
                RadDrpUsuario.SelectedIndex = -1;

                var Adelanto = from prod in dts.Tables[1].Copy().AsEnumerable()
                              where prod.Field<bool>("Activo") == (Program.User.RolID == 1 ? prod.Field<bool>("Activo") : true)
                              select prod;

                if (Adelanto.Count() > 0)
                {
                    dttAdelantoInsentivo = Adelanto.CopyToDataTable();
                    ConfiguraGrilla();

                }
                else
                {
                    RadGridViewAdelantoInsentivos.DataSource = new DataTable();
                    RadGridViewAdelantoInsentivos.Columns.Clear();
                }


                Habilita(false);
            }

        }

        private void ConfiguraGrilla()
        {
            RadGridViewAdelantoInsentivos.CurrentRowChanged -= new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewAdelantoInsentivos_CurrentRowChanged);

            RadGridViewAdelantoInsentivos.DataSource = new DataTable();
            RadGridViewAdelantoInsentivos.Columns.Clear();

            RadGridViewAdelantoInsentivos.EnableFiltering = true;
            RadGridViewAdelantoInsentivos.AutoGenerateColumns = false;
            RadGridViewAdelantoInsentivos.AllowAddNewRow = false;
            RadGridViewAdelantoInsentivos.MasterTemplate.ShowHeaderCellButtons = true;
            RadGridViewAdelantoInsentivos.MasterTemplate.ShowFilteringRow = false;
            RadGridViewAdelantoInsentivos.TableElement.EndUpdate();
            RadGridViewAdelantoInsentivos.AllowDeleteRow = false;
            RadGridViewAdelantoInsentivos.AllowRowResize = false;
            RadGridViewAdelantoInsentivos.AllowEditRow = true;
            RadGridViewAdelantoInsentivos.ShowRowHeaderColumn = false;
            RadGridViewAdelantoInsentivos.Select();
            RadGridViewAdelantoInsentivos.EnableSorting = true;

            List<int> data = dttAdelantoInsentivo.AsEnumerable().Select(CodigoUsuario => CodigoUsuario.Field<string>("CodigoUsuario").Length).ToList();
            int WidthText = data.Max();
            var col = from dat in dttAdelantoInsentivo.AsEnumerable()
                      where dat.Field<string>("CodigoUsuario").Length == WidthText
                      select dat;

            GridViewTextBoxColumn colCodigoUsuario = new GridViewTextBoxColumn();
            colCodigoUsuario.FieldName = "CodigoUsuario";
            colCodigoUsuario.HeaderText = "CodigoUsuario";
            colCodigoUsuario.MinWidth = Consulta.AnchoTexto(WidthText > colCodigoUsuario.HeaderText.Length
                                            ? col.First().Field<string>("CodigoUsuario").ToString()
                                            : colCodigoUsuario.HeaderText, RadGridViewAdelantoInsentivos.Font);
            colCodigoUsuario.Name = "colCodigoUsuario";
            colCodigoUsuario.ReadOnly = true;
            RadGridViewAdelantoInsentivos.Columns.Add(colCodigoUsuario);

            GridViewTextBoxColumn colValorAdelantoInsentivo = new GridViewTextBoxColumn();
            colValorAdelantoInsentivo.DataType = typeof(decimal);
            colValorAdelantoInsentivo.FieldName = "ValorAdelantoInsentivo";
            colValorAdelantoInsentivo.FormatString = "{0:C}";
            colValorAdelantoInsentivo.HeaderText = "Valor de Compra";
            colValorAdelantoInsentivo.MinWidth = Consulta.AnchoTexto(WidthText > colValorAdelantoInsentivo.HeaderText.Length
                                            ? col.First().Field<int>("ValorAdelantoInsentivo").ToString()
                                            : colValorAdelantoInsentivo.HeaderText, RadGridViewAdelantoInsentivos.Font);
            colValorAdelantoInsentivo.Name = "colValorAdelantoInsentivo";
            colValorAdelantoInsentivo.ReadOnly = true;
            RadGridViewAdelantoInsentivos.Columns.Add(colValorAdelantoInsentivo);

            GridViewCheckBoxColumn colInsumo = new GridViewCheckBoxColumn();
            colInsumo.FieldName = "Insumo";
            colInsumo.HeaderText = "Insumo";
            colInsumo.MinWidth = Consulta.AnchoTexto("Insumo", RadGridViewAdelantoInsentivos.Font);
            colInsumo.Name = "colInsumo";
            colInsumo.ReadOnly = true;
            RadGridViewAdelantoInsentivos.Columns.Add(colInsumo);

            GridViewCheckBoxColumn colActivo = new GridViewCheckBoxColumn();
            colActivo.FieldName = "Activo";
            colActivo.HeaderText = "Activo";
            colActivo.MinWidth = Consulta.AnchoTexto("Activo", RadGridViewAdelantoInsentivos.Font);
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            RadGridViewAdelantoInsentivos.Columns.Add(colActivo);

            RadGridViewAdelantoInsentivos.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.RadGridViewAdelantoInsentivos_CurrentRowChanged);

            RadGridViewAdelantoInsentivos.DataSource = dttAdelantoInsentivo;
        }

        private void RadGridViewAdelantoInsentivos_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow == null ? false : e.CurrentRow.Index > -1)
            {
                RowIndex = e.CurrentRow.Index;
                cargaControles();
            }
        }

        private void cargaControles()
        {
            //Program.User.AdelantoInsentivoID = int.Parse(dtsAdelantoInsentivo.Rows[RowIndex]["AdelantoInsentivoID"].ToString());
            RadChkAdelanto.Checked = bool.Parse(dttAdelantoInsentivo.Rows[RowIndex]["Adelanto"].ToString());
            RadMskValorCompra.Text = dttAdelantoInsentivo.Rows[RowIndex]["ValorAdelantoInsentivo"].ToString();
            RadChkActivo.Checked = bool.Parse(dttAdelantoInsentivo.Rows[RowIndex]["Activo"].ToString());
            RadDrpUsuario.SelectedValue = int.Parse(dttAdelantoInsentivo.Rows[RowIndex]["UsuarioAdelantoInsentivoID"].ToString());
        }

        private void Habilita(bool estado)
        {
            RadMskValorCompra.Enabled = estado;
            RadChkActivo.Enabled = estado;
            RadChkAdelanto.Enabled = estado;
            RadDrpUsuario.Enabled = estado;
        }

        private void RadMenuItemAdicionar_Click(object sender, EventArgs e)
        {
            RowIndex = -1;
            Limpia();
            Habilita(true);
            RadChkActivo.Enabled = false;
            RadMenuItemEditar.Enabled = false;
            RadMenuItemAdicionar.Enabled = false;
            RadMenuItemGuardar.Enabled = true;
            RadGridViewAdelantoInsentivos.Enabled = false;
            RadDrpUsuario.Focus();
        }

        private void Limpia()
        {
            RadMskValorCompra.Value = "";
            RadChkActivo.Checked = true;
            RadChkAdelanto.Checked = false;
            RadDrpUsuario.SelectedIndex = -1;
        }

        private void RadMenuItemEditar_Click(object sender, EventArgs e)
        {
            Habilita(true);
            RadMenuItemAdicionar.Enabled = false;
            RadMenuItemEditar.Enabled = false;
            RadMenuItemGuardar.Enabled = true;
            RadGridViewAdelantoInsentivos.Enabled = false;
            RadDrpUsuario.Focus();
        }

        private void RadMenuItemGuardar_Click(object sender, EventArgs e)
        {
            bool modifica = RowIndex > -1;

            if (ValidaCambios(modifica))
            {
                RadMessageBox.Show("No se han realizado cambios.", "ALERTA");
                return;
            }

            AdelantoInsentivo Product = new AdelantoInsentivo();
            Product.AdelantoInsentivoID = modifica ? int.Parse(dttAdelantoInsentivo.Rows[RowIndex]["AdelantoInsentivoID"].ToString()) : 0;
            Product.ValorAdelantoInsentivo= Convert.ToInt32(float.Parse(RadMskValorCompra.Value.ToString()));
            Product.Adelanto = RadChkAdelanto.Checked;
            Product.Activo = RadChkActivo.Checked;
            Product.UsuarioAdelantoInsentivoID = RadDrpUsuario.SelectedIndex > -1 ? int.Parse(RadDrpUsuario.SelectedValue.ToString()) : 0;

            DataSet dtsSave = Consulta.GuardaAdelantoInsentivo(modifica, Product);

            RadMessageBox.Show(dtsSave.Tables[0].Rows[0]["Mensaje"].ToString(), "Respuesta");

            TablaAdelantoInsentivo();

            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewAdelantoInsentivos.Enabled = true;
        }

        private void RadMenuItemCancelar_Click(object sender, EventArgs e)
        {
            TablaAdelantoInsentivo();
            RadMenuItemEditar.Enabled = true;
            RadMenuItemAdicionar.Enabled = true;
            RadMenuItemGuardar.Enabled = false;
            RadGridViewAdelantoInsentivos.Enabled = true;
        }

        private bool ValidaCambios(bool modifica)
        {
            int cont = 0;

            if (modifica)
            {

                cont = float.Parse(RadMskValorCompra.Value.ToString()) != float.Parse(dttAdelantoInsentivo.Rows[RowIndex]["ValorAdelantoInsentivo"].ToString()) ? (cont + 1) : cont;

                cont = RadChkAdelanto.Checked != bool.Parse(dttAdelantoInsentivo.Rows[RowIndex]["Adelanto"].ToString()) ? (cont + 1) : cont;

                cont = RadChkActivo.Checked != bool.Parse(dttAdelantoInsentivo.Rows[RowIndex]["Activo"].ToString()) ? (cont + 1) : cont;

                cont = RadDrpUsuario.SelectedIndex > -1 ? int.Parse(RadDrpUsuario.SelectedValue.ToString()) : 0
                    != int.Parse(dttAdelantoInsentivo.Rows[RowIndex]["UsuarioAdelantoInsentivoID"].ToString()) ? (cont + 1) : cont;
            }

            return modifica ? cont == 0 : modifica;
        }

        
    }
}