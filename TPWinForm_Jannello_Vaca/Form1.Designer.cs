
namespace TPWinForm_Jannello_Vaca
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSesion = new System.Windows.Forms.Button();
            this.BtnConfiguracion = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.logoImg = new System.Windows.Forms.PictureBox();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PanelMenu.Controls.Add(this.BtnEliminar);
            this.PanelMenu.Controls.Add(this.BtnSesion);
            this.PanelMenu.Controls.Add(this.BtnConfiguracion);
            this.PanelMenu.Controls.Add(this.BtnModificar);
            this.PanelMenu.Controls.Add(this.BtnListar);
            this.PanelMenu.Controls.Add(this.logoImg);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(137, 408);
            this.PanelMenu.TabIndex = 0;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnEliminar.Location = new System.Drawing.Point(1, 235);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(135, 35);
            this.BtnEliminar.TabIndex = 5;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnSesion
            // 
            this.BtnSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSesion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSesion.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSesion.Location = new System.Drawing.Point(1, 365);
            this.BtnSesion.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSesion.Name = "BtnSesion";
            this.BtnSesion.Size = new System.Drawing.Size(135, 35);
            this.BtnSesion.TabIndex = 4;
            this.BtnSesion.Text = "Cerrar sesión";
            this.BtnSesion.UseVisualStyleBackColor = false;
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnConfiguracion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfiguracion.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnConfiguracion.Location = new System.Drawing.Point(1, 330);
            this.BtnConfiguracion.Margin = new System.Windows.Forms.Padding(0);
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.Size = new System.Drawing.Size(135, 35);
            this.BtnConfiguracion.TabIndex = 3;
            this.BtnConfiguracion.Text = "Configuración";
            this.BtnConfiguracion.UseVisualStyleBackColor = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModificar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnModificar.Location = new System.Drawing.Point(1, 200);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(135, 35);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnListar
            // 
            this.BtnListar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnListar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnListar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnListar.Location = new System.Drawing.Point(1, 165);
            this.BtnListar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(135, 35);
            this.BtnListar.TabIndex = 1;
            this.BtnListar.Text = "Ver lista de artículos";
            this.BtnListar.UseVisualStyleBackColor = false;
            // 
            // logoImg
            // 
            this.logoImg.Image = ((System.Drawing.Image)(resources.GetObject("logoImg.Image")));
            this.logoImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoImg.InitialImage")));
            this.logoImg.Location = new System.Drawing.Point(0, 0);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(137, 123);
            this.logoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImg.TabIndex = 0;
            this.logoImg.TabStop = false;
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(137, 122);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(754, 286);
            this.dgvTabla.TabIndex = 1;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 408);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.PanelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppForm";
            this.Text = "Trabajo Práctico WinForms";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnConfiguracion;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSesion;
        private System.Windows.Forms.DataGridView dgvTabla;
    }
}

