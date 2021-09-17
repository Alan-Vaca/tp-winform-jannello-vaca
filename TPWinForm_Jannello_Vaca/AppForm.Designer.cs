
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
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSesion = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.logoImg = new System.Windows.Forms.PictureBox();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.ordenarPor = new System.Windows.Forms.Label();
            this.listaOrdernarPor = new System.Windows.Forms.ComboBox();
            this.listaMarca = new System.Windows.Forms.ComboBox();
            this.listaCategoria = new System.Windows.Forms.ComboBox();
            this.columnaDescripcion = new System.Windows.Forms.TextBox();
            this.columnaNombre = new System.Windows.Forms.TextBox();
            this.columnaCodigoArticulo = new System.Windows.Forms.TextBox();
            this.columnaHasta = new System.Windows.Forms.TextBox();
            this.columnaID = new System.Windows.Forms.TextBox();
            this.columnaFiltrar = new System.Windows.Forms.Label();
            this.columnaDesde = new System.Windows.Forms.TextBox();
            this.columnaRangoPrecio = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PanelMenu.Controls.Add(this.buttonAgregar);
            this.PanelMenu.Controls.Add(this.BtnEliminar);
            this.PanelMenu.Controls.Add(this.BtnSesion);
            this.PanelMenu.Controls.Add(this.BtnModificar);
            this.PanelMenu.Controls.Add(this.logoImg);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(137, 408);
            this.PanelMenu.TabIndex = 0;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAgregar.Location = new System.Drawing.Point(1, 153);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(136, 35);
            this.buttonAgregar.TabIndex = 6;
            this.buttonAgregar.Text = "Agregar artículo";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnEliminar.Location = new System.Drawing.Point(0, 223);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(137, 35);
            this.BtnEliminar.TabIndex = 5;
            this.BtnEliminar.Text = "Eliminar artículo";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnSesion
            // 
            this.BtnSesion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSesion.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSesion.Location = new System.Drawing.Point(1, 372);
            this.BtnSesion.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSesion.Name = "BtnSesion";
            this.BtnSesion.Size = new System.Drawing.Size(135, 35);
            this.BtnSesion.TabIndex = 4;
            this.BtnSesion.Text = "Cerrar";
            this.BtnSesion.UseVisualStyleBackColor = false;
            this.BtnSesion.Click += new System.EventHandler(this.BtnSesion_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnModificar.Location = new System.Drawing.Point(2, 188);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(135, 35);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // logoImg
            // 
            this.logoImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoImg.Image = ((System.Drawing.Image)(resources.GetObject("logoImg.Image")));
            this.logoImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoImg.InitialImage")));
            this.logoImg.Location = new System.Drawing.Point(0, 0);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(137, 118);
            this.logoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImg.TabIndex = 0;
            this.logoImg.TabStop = false;
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(137, 153);
            this.dgvTabla.MultiSelect = false;
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabla.Size = new System.Drawing.Size(854, 255);
            this.dgvTabla.TabIndex = 1;
            // 
            // ordenarPor
            // 
            this.ordenarPor.Location = new System.Drawing.Point(150, 55);
            this.ordenarPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ordenarPor.Name = "ordenarPor";
            this.ordenarPor.Size = new System.Drawing.Size(110, 21);
            this.ordenarPor.TabIndex = 2;
            this.ordenarPor.Text = "ORDERNAR POR :";
            // 
            // listaOrdernarPor
            // 
            this.listaOrdernarPor.FormattingEnabled = true;
            this.listaOrdernarPor.Location = new System.Drawing.Point(254, 53);
            this.listaOrdernarPor.Margin = new System.Windows.Forms.Padding(2);
            this.listaOrdernarPor.Name = "listaOrdernarPor";
            this.listaOrdernarPor.Size = new System.Drawing.Size(119, 21);
            this.listaOrdernarPor.TabIndex = 3;
            // 
            // listaMarca
            // 
            this.listaMarca.FormattingEnabled = true;
            this.listaMarca.Location = new System.Drawing.Point(586, 123);
            this.listaMarca.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.listaMarca.Name = "listaMarca";
            this.listaMarca.Size = new System.Drawing.Size(101, 21);
            this.listaMarca.TabIndex = 8;
            // 
            // listaCategoria
            // 
            this.listaCategoria.FormattingEnabled = true;
            this.listaCategoria.Location = new System.Drawing.Point(686, 123);
            this.listaCategoria.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.listaCategoria.Name = "listaCategoria";
            this.listaCategoria.Size = new System.Drawing.Size(89, 21);
            this.listaCategoria.TabIndex = 9;
            // 
            // columnaDescripcion
            // 
            this.columnaDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.columnaDescripcion.Location = new System.Drawing.Point(487, 123);
            this.columnaDescripcion.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.columnaDescripcion.Multiline = true;
            this.columnaDescripcion.Name = "columnaDescripcion";
            this.columnaDescripcion.Size = new System.Drawing.Size(101, 20);
            this.columnaDescripcion.TabIndex = 10;
            // 
            // columnaNombre
            // 
            this.columnaNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.columnaNombre.Location = new System.Drawing.Point(387, 123);
            this.columnaNombre.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.columnaNombre.Multiline = true;
            this.columnaNombre.Name = "columnaNombre";
            this.columnaNombre.Size = new System.Drawing.Size(101, 20);
            this.columnaNombre.TabIndex = 11;
            // 
            // columnaCodigoArticulo
            // 
            this.columnaCodigoArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.columnaCodigoArticulo.Location = new System.Drawing.Point(287, 123);
            this.columnaCodigoArticulo.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.columnaCodigoArticulo.Multiline = true;
            this.columnaCodigoArticulo.Name = "columnaCodigoArticulo";
            this.columnaCodigoArticulo.Size = new System.Drawing.Size(101, 20);
            this.columnaCodigoArticulo.TabIndex = 12;
            // 
            // columnaHasta
            // 
            this.columnaHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.columnaHasta.Location = new System.Drawing.Point(927, 123);
            this.columnaHasta.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.columnaHasta.Multiline = true;
            this.columnaHasta.Name = "columnaHasta";
            this.columnaHasta.Size = new System.Drawing.Size(60, 20);
            this.columnaHasta.TabIndex = 13;
            // 
            // columnaID
            // 
            this.columnaID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.columnaID.Location = new System.Drawing.Point(188, 123);
            this.columnaID.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.columnaID.Multiline = true;
            this.columnaID.Name = "columnaID";
            this.columnaID.Size = new System.Drawing.Size(101, 20);
            this.columnaID.TabIndex = 14;
            // 
            // columnaFiltrar
            // 
            this.columnaFiltrar.Location = new System.Drawing.Point(138, 124);
            this.columnaFiltrar.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.columnaFiltrar.Name = "columnaFiltrar";
            this.columnaFiltrar.Size = new System.Drawing.Size(50, 18);
            this.columnaFiltrar.TabIndex = 15;
            this.columnaFiltrar.Text = "Filtrar";
            // 
            // columnaDesde
            // 
            this.columnaDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.columnaDesde.Location = new System.Drawing.Point(867, 123);
            this.columnaDesde.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.columnaDesde.Multiline = true;
            this.columnaDesde.Name = "columnaDesde";
            this.columnaDesde.Size = new System.Drawing.Size(60, 20);
            this.columnaDesde.TabIndex = 16;
            // 
            // columnaRangoPrecio
            // 
            this.columnaRangoPrecio.Location = new System.Drawing.Point(784, 126);
            this.columnaRangoPrecio.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.columnaRangoPrecio.Name = "columnaRangoPrecio";
            this.columnaRangoPrecio.Size = new System.Drawing.Size(83, 18);
            this.columnaRangoPrecio.TabIndex = 17;
            this.columnaRangoPrecio.Text = "Rango precio";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 408);
            this.Controls.Add(this.columnaRangoPrecio);
            this.Controls.Add(this.columnaDesde);
            this.Controls.Add(this.columnaFiltrar);
            this.Controls.Add(this.columnaID);
            this.Controls.Add(this.columnaHasta);
            this.Controls.Add(this.columnaCodigoArticulo);
            this.Controls.Add(this.columnaNombre);
            this.Controls.Add(this.columnaDescripcion);
            this.Controls.Add(this.listaCategoria);
            this.Controls.Add(this.listaMarca);
            this.Controls.Add(this.listaOrdernarPor);
            this.Controls.Add(this.ordenarPor);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSesion;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Label ordenarPor;
        private System.Windows.Forms.ComboBox listaOrdernarPor;
        private System.Windows.Forms.ComboBox listaMarca;
        private System.Windows.Forms.ComboBox listaCategoria;
        private System.Windows.Forms.TextBox columnaDescripcion;
        private System.Windows.Forms.TextBox columnaNombre;
        private System.Windows.Forms.TextBox columnaCodigoArticulo;
        private System.Windows.Forms.TextBox columnaHasta;
        private System.Windows.Forms.TextBox columnaID;
        private System.Windows.Forms.Label columnaFiltrar;
        private System.Windows.Forms.TextBox columnaDesde;
        private System.Windows.Forms.Label columnaRangoPrecio;
        private System.Windows.Forms.Button buttonAgregar;
    }
}

