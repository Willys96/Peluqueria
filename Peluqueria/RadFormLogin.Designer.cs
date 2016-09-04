namespace Peluqueria
{
    partial class RadFormLogin
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
            this.RadTxtUser = new Telerik.WinControls.UI.RadTextBox();
            this.RadLblUser = new Telerik.WinControls.UI.RadLabel();
            this.RadLblPassword = new Telerik.WinControls.UI.RadLabel();
            this.RadBtnLogin = new Telerik.WinControls.UI.RadButton();
            this.RadTxtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.RadLblError = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.RadTxtUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadLblUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadLblPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadBtnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadTxtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadLblError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // RadTxtUser
            // 
            this.RadTxtUser.Location = new System.Drawing.Point(93, 9);
            this.RadTxtUser.Name = "RadTxtUser";
            this.RadTxtUser.Size = new System.Drawing.Size(187, 20);
            this.RadTxtUser.TabIndex = 0;
            // 
            // RadLblUser
            // 
            this.RadLblUser.Location = new System.Drawing.Point(12, 10);
            this.RadLblUser.Name = "RadLblUser";
            this.RadLblUser.Size = new System.Drawing.Size(44, 18);
            this.RadLblUser.TabIndex = 2;
            this.RadLblUser.Text = "Usuario";
            // 
            // RadLblPassword
            // 
            this.RadLblPassword.Location = new System.Drawing.Point(12, 36);
            this.RadLblPassword.Name = "RadLblPassword";
            this.RadLblPassword.Size = new System.Drawing.Size(33, 18);
            this.RadLblPassword.TabIndex = 3;
            this.RadLblPassword.Text = "Clave";
            // 
            // RadBtnLogin
            // 
            this.RadBtnLogin.Location = new System.Drawing.Point(93, 91);
            this.RadBtnLogin.Name = "RadBtnLogin";
            this.RadBtnLogin.Size = new System.Drawing.Size(110, 24);
            this.RadBtnLogin.TabIndex = 4;
            this.RadBtnLogin.Text = "Ingresar";
            this.RadBtnLogin.Click += new System.EventHandler(this.RadBtnLogin_Click);
            // 
            // RadTxtPassword
            // 
            this.RadTxtPassword.Location = new System.Drawing.Point(93, 37);
            this.RadTxtPassword.Name = "RadTxtPassword";
            this.RadTxtPassword.PasswordChar = '*';
            this.RadTxtPassword.Size = new System.Drawing.Size(187, 20);
            this.RadTxtPassword.TabIndex = 1;
            // 
            // RadLblError
            // 
            this.RadLblError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadLblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadLblError.Location = new System.Drawing.Point(93, 67);
            this.RadLblError.Name = "RadLblError";
            this.RadLblError.Size = new System.Drawing.Size(33, 18);
            this.RadLblError.TabIndex = 4;
            this.RadLblError.Text = "Error";
            this.RadLblError.Visible = false;
            // 
            // RadFormLogin
            // 
            this.AcceptButton = this.RadBtnLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(292, 138);
            this.Controls.Add(this.RadLblError);
            this.Controls.Add(this.RadTxtPassword);
            this.Controls.Add(this.RadBtnLogin);
            this.Controls.Add(this.RadLblPassword);
            this.Controls.Add(this.RadLblUser);
            this.Controls.Add(this.RadTxtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RadFormLogin";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RadFormLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.RadTxtUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadLblUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadLblPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadBtnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadTxtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadLblError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox RadTxtUser;
        private Telerik.WinControls.UI.RadLabel RadLblUser;
        private Telerik.WinControls.UI.RadLabel RadLblPassword;
        private Telerik.WinControls.UI.RadButton RadBtnLogin;
        private Telerik.WinControls.UI.RadTextBox RadTxtPassword;
        private Telerik.WinControls.UI.RadLabel RadLblError;
    }
}
