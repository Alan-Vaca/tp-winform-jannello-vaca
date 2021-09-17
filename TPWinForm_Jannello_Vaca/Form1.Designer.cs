
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
            this.PanelMenu.Controls.Add(this.BtnEliminar);
            this.PanelMenu.Controls.Add(this.BtnSesion);
            this.PanelMenu.Controls.Add(this.BtnConfiguracion);
            this.PanelMenu.Controls.Add(this.BtnModificar);
            this.PanelMenu.Controls.Add(this.BtnListar);
            this.PanelMenu.Controls.Add(this.logoImg);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(183, 502);
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
            this.BtnEliminar.Location = new System.Drawing.Point(3, 263);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(180, 43);
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
            this.BtnSesion.Location = new System.Drawing.Point(1, 449);
            this.BtnSesion.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSesion.Name = "BtnSesion";
            this.BtnSesion.Size = new System.Drawing.Size(180, 43);
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
            this.BtnConfiguracion.Location = new System.Drawing.Point(1, 406);
            this.BtnConfiguracion.Margin = new System.Windows.Forms.Padding(0);
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.Size = new System.Drawing.Size(180, 43);
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
            this.BtnModificar.Location = new System.Drawing.Point(1, 220);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(180, 43);
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
            this.BtnListar.Location = new System.Drawing.Point(1, 177);
            this.BtnListar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(180, 43);
            this.BtnListar.TabIndex = 1;
            this.BtnListar.Text = "Ver lista de artículos";
            this.BtnListar.UseVisualStyleBackColor = false;
            // 
            // logoImg
            // 
            this.logoImg.Image = ((System.Drawing.Image)(resources.GetObject("logoImg.Image")));
            this.logoImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoImg.InitialImage")));
            this.logoImg.Location = new System.Drawing.Point(0, 0);
            this.logoImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(183, 151);
            this.logoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImg.TabIndex = 0;
            this.logoImg.TabStop = false;
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(183, 177);
            this.dgvTabla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.Size = new System.Drawing.Size(1139, 325);
            this.dgvTabla.TabIndex = 1;
            // 
            // ordenarPor
            // 
            this.ordenarPor.Location = new System.Drawing.Point(200, 68);
            this.ordenarPor.Name = "ordenarPor";
            this.ordenarPor.Size = new System.Drawing.Size(146, 26);
            this.ordenarPor.TabIndex = 2;
            this.ordenarPor.Text = "ORDERNAR POR :";
            this.ordenarPor.Click += new System.EventHandler(this.label1_Click);
            // 
            // listaOrdernarPor
            // 
            this.listaOrdernarPor.FormattingEnabled = true;
            this.listaOrdernarPor.Location = new System.Drawing.Point(338, 65);
            this.listaOrdernarPor.Name = "listaOrdernarPor";
            this.listaOrdernarPor.Size = new System.Drawing.Size(157, 24);
            this.listaOrdernarPor.TabIndex = 3;
            this.listaOrdernarPor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listaMarca
            // 
            this.listaMarca.FormattingEnabled = true;
            this.listaMarca.Location = new System.Drawing.Point(782, 151);
            this.listaMarca.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.listaMarca.Name = "listaMarca";
            this.listaMarca.Size = new System.Drawing.Size(133, 24);
            this.listaMarca.TabIndex = 8;
            // 
            // listaCategoria
            // 
            this.listaCategoria.FormattingEnabled = true;
            this.listaCategoria.Location = new System.Drawing.Point(915, 151);
            this.listaCategoria.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.listaCategoria.Name = "listaCategoria";
            this.listaCategoria.Size = new System.Drawing.Size(133, 24);
            this.listaCategoria.TabIndex = 9;
            // 
            // columnaDescripcion
            // 
            this.columnaDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.columnaDescripcion.Location = new System.Drawing.Point(649, 151);
            this.columnaDescripcion.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.columnaDescripcion.Multiline = true;
            this.columnaDescripcion.Name = "columnaDescripcion";
            this.columnaDescripcion.Size = new System.Drawing.Size(133, 24);
            this.columnaDescripcion.TabIndex = 10;
            // 
            // columnaNombre
            // 
            this.columnaNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.columnaNombre.Location = new System.Drawing.Point(516, 151);
            this.columnaNombre.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.columnaNombre.Multiline = true;
            this.columnaNombre.Name = "columnaNombre";
            this.columnaNombre.Size = new System.Drawing.Size(133, 24);
            this.columnaNombre.TabIndex = 11;
            // 
            // columnaCodigoArticulo
            // 
            this.columnaCodigoArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.columnaCodigoArticulo.Location = new System.Drawing.Point(383, 151);
            this.columnaCodigoArticulo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.columnaCodigoArticulo.Multiline = true;
            this.columnaCodigoArticulo.Name = "columnaCodigoArticulo";
            this.columnaCodigoArticulo.Size = new System.Drawing.Size(133, 24);
            this.columnaCodigoArticulo.TabIndex = 12;
            // 
            // columnaHasta
            // 
            this.columnaHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.columnaHasta.Location = new System.Drawing.Point(1243, 151);
            this.columnaHasta.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.columnaHasta.Multiline = true;
            this.columnaHasta.Name = "columnaHasta";
            this.columnaHasta.Size = new System.Drawing.Size(79, 24);
            this.columnaHasta.TabIndex = 13;
            // 
            // columnaID
            // 
            this.columnaID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.columnaID.Location = new System.Drawing.Point(250, 151);
            this.columnaID.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.columnaID.Multiline = true;
            this.columnaID.Name = "columnaID";
            this.columnaID.Size = new System.Drawing.Size(133, 24);
            this.columnaID.TabIndex = 14;
            // 
            // columnaFiltrar
            // 
            this.columnaFiltrar.Location = new System.Drawing.Point(183, 151);
            this.columnaFiltrar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.columnaFiltrar.Name = "columnaFiltrar";
            this.columnaFiltrar.Size = new System.Drawing.Size(67, 22);
            this.columnaFiltrar.TabIndex = 15;
            this.columnaFiltrar.Text = "Filtrar";
            this.columnaFiltrar.Click += new System.EventHandler(this.label2_Click);
            // 
            // columnaDesde
            // 
            this.columnaDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.columnaDesde.Location = new System.Drawing.Point(1164, 151);
            this.columnaDesde.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.columnaDesde.Multiline = true;
            this.columnaDesde.Name = "columnaDesde";
            this.columnaDesde.Size = new System.Drawing.Size(79, 24);
            this.columnaDesde.TabIndex = 16;
            // 
            // columnaRangoPrecio
            // 
            this.columnaRangoPrecio.Location = new System.Drawing.Point(1048, 151);
            this.columnaRangoPrecio.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.columnaRangoPrecio.Name = "columnaRangoPrecio";
            this.columnaRangoPrecio.Size = new System.Drawing.Size(116, 22);
            this.columnaRangoPrecio.TabIndex = 17;
            this.columnaRangoPrecio.Text = "Rango precio";
            this.columnaRangoPrecio.Click += new System.EventHandler(this.label3_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1324, 502);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnConfiguracion;
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
    }
}

