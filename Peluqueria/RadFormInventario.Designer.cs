namespace Peluqueria
{
    partial class RadFormInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadFormInventario));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.RadMenuItemGuardar = new Telerik.WinControls.UI.RadMenuItem();
            this.RadMenuItemAdicionar = new Telerik.WinControls.UI.RadMenuItem();
            this.RadMenu = new Telerik.WinControls.UI.RadMenu();
            this.RadMenuItemEditar = new Telerik.WinControls.UI.RadMenuItem();
            this.RadMenuItemCancelar = new Telerik.WinControls.UI.RadMenuItem();
            this.RadMskCantidadUnidad = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.RadLblUnidadProducto = new Telerik.WinControls.UI.RadLabel();
            this.splitPanel3 = new Telerik.WinControls.UI.SplitPanel();
            this.RadSplitContainerConfProductos = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel4 = new Telerik.WinControls.UI.SplitPanel();
            this.RadDrpProducto = new Telerik.WinControls.UI.RadDropDownList();
            this.RadLblNombre = new Telerik.WinControls.UI.RadLabel();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.RadSplitContainerProductos = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.RadGridViewInventarios = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RadMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadMskCantidadUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadLblUnidadProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel3)).BeginInit();
            this.splitPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadSplitContainerConfProductos)).BeginInit();
            this.RadSplitContainerConfProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel4)).BeginInit();
            this.splitPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadDrpProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadLblNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadSplitContainerProductos)).BeginInit();
            this.RadSplitContainerProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadGridViewInventarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadGridViewInventarios.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // RadMenuItemGuardar
            // 
            this.RadMenuItemGuardar.Image = ((System.Drawing.Image)(resources.GetObject("RadMenuItemGuardar.Image")));
            this.RadMenuItemGuardar.Name = "RadMenuItemGuardar";
            this.RadMenuItemGuardar.Text = "Guardar";
            this.RadMenuItemGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RadMenuItemGuardar.Click += new System.EventHandler(this.RadMenuItemGuardar_Click);
            // 
            // RadMenuItemAdicionar
            // 
            this.RadMenuItemAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("RadMenuItemAdicionar.Image")));
            this.RadMenuItemAdicionar.Name = "RadMenuItemAdicionar";
            this.RadMenuItemAdicionar.Text = "Adicionar";
            this.RadMenuItemAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RadMenuItemAdicionar.Click += new System.EventHandler(this.RadMenuItemAdicionar_Click);
            // 
            // RadMenu
            // 
            this.RadMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.RadMenuItemAdicionar,
            this.RadMenuItemEditar,
            this.RadMenuItemGuardar,
            this.RadMenuItemCancelar});
            this.RadMenu.Location = new System.Drawing.Point(0, 0);
            this.RadMenu.Name = "RadMenu";
            this.RadMenu.Size = new System.Drawing.Size(400, 84);
            this.RadMenu.TabIndex = 0;
            this.RadMenu.Text = "radMenu1";
            // 
            // RadMenuItemEditar
            // 
            this.RadMenuItemEditar.Image = ((System.Drawing.Image)(resources.GetObject("RadMenuItemEditar.Image")));
            this.RadMenuItemEditar.Name = "RadMenuItemEditar";
            this.RadMenuItemEditar.Text = "Retirar";
            this.RadMenuItemEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RadMenuItemEditar.Click += new System.EventHandler(this.RadMenuItemEditar_Click);
            // 
            // RadMenuItemCancelar
            // 
            this.RadMenuItemCancelar.Image = ((System.Drawing.Image)(resources.GetObject("RadMenuItemCancelar.Image")));
            this.RadMenuItemCancelar.Name = "RadMenuItemCancelar";
            this.RadMenuItemCancelar.Text = "Cancelar";
            this.RadMenuItemCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RadMenuItemCancelar.Click += new System.EventHandler(this.RadMenuItemCancelar_Click);
            // 
            // RadMskCantidadUnidad
            // 
            this.RadMskCantidadUnidad.Location = new System.Drawing.Point(159, 40);
            this.RadMskCantidadUnidad.Mask = "G";
            this.RadMskCantidadUnidad.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.RadMskCantidadUnidad.Name = "RadMskCantidadUnidad";
            this.RadMskCantidadUnidad.Size = new System.Drawing.Size(223, 20);
            this.RadMskCantidadUnidad.TabIndex = 2;
            this.RadMskCantidadUnidad.TabStop = false;
            this.RadMskCantidadUnidad.Tag = "";
            this.RadMskCantidadUnidad.Text = "0";
            this.RadMskCantidadUnidad.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // RadLblUnidadProducto
            // 
            this.RadLblUnidadProducto.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.RadLblUnidadProducto.Location = new System.Drawing.Point(12, 41);
            this.RadLblUnidadProducto.Name = "RadLblUnidadProducto";
            this.RadLblUnidadProducto.Size = new System.Drawing.Size(117, 18);
            this.RadLblUnidadProducto.TabIndex = 2;
            this.RadLblUnidadProducto.Text = "Unidades de Producto";
            // 
            // splitPanel3
            // 
            this.splitPanel3.Controls.Add(this.RadMenu);
            this.splitPanel3.Location = new System.Drawing.Point(0, 0);
            this.splitPanel3.Name = "splitPanel3";
            // 
            // 
            // 
            this.splitPanel3.RootElement.MaxSize = new System.Drawing.Size(0, 88);
            this.splitPanel3.RootElement.MinSize = new System.Drawing.Size(0, 88);
            this.splitPanel3.Size = new System.Drawing.Size(400, 88);
            this.splitPanel3.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.3092643F);
            this.splitPanel3.SizeInfo.MaximumSize = new System.Drawing.Size(0, 88);
            this.splitPanel3.SizeInfo.MinimumSize = new System.Drawing.Size(0, 88);
            this.splitPanel3.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -114);
            this.splitPanel3.TabIndex = 0;
            this.splitPanel3.TabStop = false;
            this.splitPanel3.Text = "splitPanel3";
            // 
            // RadSplitContainerConfProductos
            // 
            this.RadSplitContainerConfProductos.Controls.Add(this.splitPanel3);
            this.RadSplitContainerConfProductos.Controls.Add(this.splitPanel4);
            this.RadSplitContainerConfProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadSplitContainerConfProductos.Location = new System.Drawing.Point(0, 0);
            this.RadSplitContainerConfProductos.Name = "RadSplitContainerConfProductos";
            this.RadSplitContainerConfProductos.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.RadSplitContainerConfProductos.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.RadSplitContainerConfProductos.Size = new System.Drawing.Size(400, 470);
            this.RadSplitContainerConfProductos.TabIndex = 0;
            this.RadSplitContainerConfProductos.TabStop = false;
            this.RadSplitContainerConfProductos.Text = "radSplitContainer1";
            // 
            // splitPanel4
            // 
            this.splitPanel4.Controls.Add(this.RadDrpProducto);
            this.splitPanel4.Controls.Add(this.RadMskCantidadUnidad);
            this.splitPanel4.Controls.Add(this.RadLblUnidadProducto);
            this.splitPanel4.Controls.Add(this.RadLblNombre);
            this.splitPanel4.Location = new System.Drawing.Point(0, 92);
            this.splitPanel4.Name = "splitPanel4";
            // 
            // 
            // 
            this.splitPanel4.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.splitPanel4.Size = new System.Drawing.Size(400, 378);
            this.splitPanel4.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.3092643F);
            this.splitPanel4.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 114);
            this.splitPanel4.TabIndex = 1;
            this.splitPanel4.TabStop = false;
            this.splitPanel4.Text = "splitPanel4";
            // 
            // RadDrpProducto
            // 
            this.RadDrpProducto.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.RadDrpProducto.Location = new System.Drawing.Point(159, 14);
            this.RadDrpProducto.Name = "RadDrpProducto";
            this.RadDrpProducto.Size = new System.Drawing.Size(223, 20);
            this.RadDrpProducto.TabIndex = 1;
            // 
            // RadLblNombre
            // 
            this.RadLblNombre.Location = new System.Drawing.Point(12, 15);
            this.RadLblNombre.Name = "RadLblNombre";
            this.RadLblNombre.Size = new System.Drawing.Size(52, 18);
            this.RadLblNombre.TabIndex = 0;
            this.RadLblNombre.Text = "Producto";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.RadSplitContainerConfProductos);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MaxSize = new System.Drawing.Size(400, 0);
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(400, 0);
            this.splitPanel1.Size = new System.Drawing.Size(400, 470);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.1182213F, 0F);
            this.splitPanel1.SizeInfo.MaximumSize = new System.Drawing.Size(400, 0);
            this.splitPanel1.SizeInfo.MinimumSize = new System.Drawing.Size(400, 0);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-109, 0);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // RadSplitContainerProductos
            // 
            this.RadSplitContainerProductos.Controls.Add(this.splitPanel1);
            this.RadSplitContainerProductos.Controls.Add(this.splitPanel2);
            this.RadSplitContainerProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadSplitContainerProductos.Location = new System.Drawing.Point(0, 0);
            this.RadSplitContainerProductos.Name = "RadSplitContainerProductos";
            // 
            // 
            // 
            this.RadSplitContainerProductos.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.RadSplitContainerProductos.Size = new System.Drawing.Size(892, 470);
            this.RadSplitContainerProductos.TabIndex = 2;
            this.RadSplitContainerProductos.TabStop = false;
            this.RadSplitContainerProductos.Text = "radSplitContainer1";
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.RadGridViewInventarios);
            this.splitPanel2.Location = new System.Drawing.Point(404, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.splitPanel2.Size = new System.Drawing.Size(488, 470);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.1182213F, 0F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(109, 0);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // RadGridViewInventarios
            // 
            this.RadGridViewInventarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadGridViewInventarios.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.RadGridViewInventarios.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.RadGridViewInventarios.Name = "RadGridViewInventarios";
            this.RadGridViewInventarios.Size = new System.Drawing.Size(488, 470);
            this.RadGridViewInventarios.TabIndex = 0;
            this.RadGridViewInventarios.Text = "``";
            // 
            // RadFormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 470);
            this.Controls.Add(this.RadSplitContainerProductos);
            this.Name = "RadFormInventario";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "GESTIÓN DE INVENTARIO";
            ((System.ComponentModel.ISupportInitialize)(this.RadMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadMskCantidadUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadLblUnidadProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel3)).EndInit();
            this.splitPanel3.ResumeLayout(false);
            this.splitPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadSplitContainerConfProductos)).EndInit();
            this.RadSplitContainerConfProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel4)).EndInit();
            this.splitPanel4.ResumeLayout(false);
            this.splitPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadDrpProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadLblNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RadSplitContainerProductos)).EndInit();
            this.RadSplitContainerProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RadGridViewInventarios.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadGridViewInventarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadMenuItem RadMenuItemGuardar;
        private Telerik.WinControls.UI.RadMenuItem RadMenuItemAdicionar;
        private Telerik.WinControls.UI.RadMenu RadMenu;
        private Telerik.WinControls.UI.RadMenuItem RadMenuItemEditar;
        private Telerik.WinControls.UI.RadMenuItem RadMenuItemCancelar;
        private Telerik.WinControls.UI.RadMaskedEditBox RadMskCantidadUnidad;
        private Telerik.WinControls.UI.RadLabel RadLblUnidadProducto;
        private Telerik.WinControls.UI.SplitPanel splitPanel3;
        private Telerik.WinControls.UI.RadSplitContainer RadSplitContainerConfProductos;
        private Telerik.WinControls.UI.SplitPanel splitPanel4;
        private Telerik.WinControls.UI.RadLabel RadLblNombre;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.RadSplitContainer RadSplitContainerProductos;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadGridView RadGridViewInventarios;
        private Telerik.WinControls.UI.RadDropDownList RadDrpProducto;
    }
}
