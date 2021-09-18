
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
            this.BtnVerDetalle = new System.Windows.Forms.Button();
            this.logoImg = new System.Windows.Forms.PictureBox();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.ordenarPor = new System.Windows.Forms.Label();
            this.cbOrdernarPor = new System.Windows.Forms.ComboBox();
            this.listaCategoria = new System.Windows.Forms.ComboBox();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.textLabelBuscador = new System.Windows.Forms.Label();
            this.columnaRangoPrecio = new System.Windows.Forms.Label();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.listaMarca = new System.Windows.Forms.ComboBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonCancelBusqueda = new System.Windows.Forms.Button();
            this.labelFiltrar = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PanelMenu.Controls.Add(this.buttonAgregar);
            this.PanelMenu.Controls.Add(this.BtnEliminar);
            this.PanelMenu.Controls.Add(this.BtnSesion);
            this.PanelMenu.Controls.Add(this.BtnVerDetalle);
            this.PanelMenu.Controls.Add(this.logoImg);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4);
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
            this.buttonAgregar.Size = new System.Drawing.Size(135, 35);
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
            this.BtnEliminar.Size = new System.Drawing.Size(136, 35);
            this.BtnEliminar.TabIndex = 5;
            this.BtnEliminar.Text = "Eliminar artículo por ID";
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
            // BtnVerDetalle
            // 
            this.BtnVerDetalle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnVerDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerDetalle.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnVerDetalle.FlatAppearance.BorderSize = 0;
            this.BtnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerDetalle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnVerDetalle.Location = new System.Drawing.Point(2, 188);
            this.BtnVerDetalle.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVerDetalle.Name = "BtnVerDetalle";
            this.BtnVerDetalle.Size = new System.Drawing.Size(134, 35);
            this.BtnVerDetalle.TabIndex = 2;
            this.BtnVerDetalle.Text = "Ver Detalle";
            this.BtnVerDetalle.UseVisualStyleBackColor = false;
            this.BtnVerDetalle.Click += new System.EventHandler(this.BtnVerDetalle_Click);
            // 
            // logoImg
            // 
            this.logoImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoImg.Image = ((System.Drawing.Image)(resources.GetObject("logoImg.Image")));
            this.logoImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoImg.InitialImage")));
            this.logoImg.Location = new System.Drawing.Point(0, 0);
            this.logoImg.Margin = new System.Windows.Forms.Padding(4);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(137, 118);
            this.logoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImg.TabIndex = 0;
            this.logoImg.TabStop = false;
            // 
            // dgvTabla
            // 
            this.dgvTabla.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTabla.Location = new System.Drawing.Point(153, 165);
            this.dgvTabla.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTabla.MultiSelect = false;
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersVisible = false;
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabla.Size = new System.Drawing.Size(769, 195);
            this.dgvTabla.TabIndex = 1;
            this.dgvTabla.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTabla_CellMouseDoubleClick);
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
            // cbOrdernarPor
            // 
            this.cbOrdernarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrdernarPor.FormattingEnabled = true;
            this.cbOrdernarPor.Location = new System.Drawing.Point(254, 53);
            this.cbOrdernarPor.Margin = new System.Windows.Forms.Padding(2);
            this.cbOrdernarPor.Name = "cbOrdernarPor";
            this.cbOrdernarPor.Size = new System.Drawing.Size(119, 21);
            this.cbOrdernarPor.TabIndex = 3;
            this.cbOrdernarPor.SelectionChangeCommitted += new System.EventHandler(this.cbOrdernarPor_SelectionChangeCommitted);
            // 
            // listaCategoria
            // 
            this.listaCategoria.FormattingEnabled = true;
            this.listaCategoria.Location = new System.Drawing.Point(680, 112);
            this.listaCategoria.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.listaCategoria.Name = "listaCategoria";
            this.listaCategoria.Size = new System.Drawing.Size(89, 21);
            this.listaCategoria.TabIndex = 9;
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxBuscador.Location = new System.Drawing.Point(153, 112);
            this.textBoxBuscador.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.textBoxBuscador.Multiline = true;
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(163, 20);
            this.textBoxBuscador.TabIndex = 14;
            // 
            // textLabelBuscador
            // 
            this.textLabelBuscador.Location = new System.Drawing.Point(150, 87);
            this.textLabelBuscador.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textLabelBuscador.Name = "textLabelBuscador";
            this.textLabelBuscador.Size = new System.Drawing.Size(313, 23);
            this.textLabelBuscador.TabIndex = 15;
            this.textLabelBuscador.Text = "BUSCAR POR CODIGO, NOMBRE O DESCRIPCIÓN:";
            // 
            // columnaRangoPrecio
            // 
            this.columnaRangoPrecio.Location = new System.Drawing.Point(604, 58);
            this.columnaRangoPrecio.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.columnaRangoPrecio.Name = "columnaRangoPrecio";
            this.columnaRangoPrecio.Size = new System.Drawing.Size(83, 18);
            this.columnaRangoPrecio.TabIndex = 17;
            this.columnaRangoPrecio.Text = "Rango precio";
            // 
            // nudMin
            // 
            this.nudMin.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMin.Location = new System.Drawing.Point(709, 56);
            this.nudMin.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(102, 20);
            this.nudMin.TabIndex = 18;
            this.nudMin.ValueChanged += new System.EventHandler(this.nudMin_ValueChanged);
            // 
            // nudMax
            // 
            this.nudMax.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMax.Location = new System.Drawing.Point(865, 58);
            this.nudMax.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(96, 20);
            this.nudMax.TabIndex = 19;
            this.nudMax.ValueChanged += new System.EventHandler(this.nudMax_ValueChanged);
            // 
            // listaMarca
            // 
            this.listaMarca.FormattingEnabled = true;
            this.listaMarca.Location = new System.Drawing.Point(562, 112);
            this.listaMarca.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.listaMarca.Name = "listaMarca";
            this.listaMarca.Size = new System.Drawing.Size(96, 21);
            this.listaMarca.TabIndex = 8;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.BackgroundImage")));
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBuscar.Location = new System.Drawing.Point(319, 111);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(24, 24);
            this.buttonBuscar.TabIndex = 20;
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonCancelBusqueda
            // 
            this.buttonCancelBusqueda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelBusqueda.BackgroundImage")));
            this.buttonCancelBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancelBusqueda.Location = new System.Drawing.Point(349, 111);
            this.buttonCancelBusqueda.Name = "buttonCancelBusqueda";
            this.buttonCancelBusqueda.Size = new System.Drawing.Size(24, 24);
            this.buttonCancelBusqueda.TabIndex = 21;
            this.buttonCancelBusqueda.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonCancelBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelBusqueda.UseVisualStyleBackColor = true;
            this.buttonCancelBusqueda.Visible = false;
            this.buttonCancelBusqueda.Click += new System.EventHandler(this.buttonCancelBusqueda_Click);
            // 
            // labelFiltrar
            // 
            this.labelFiltrar.AutoSize = true;
            this.labelFiltrar.Location = new System.Drawing.Point(462, 115);
            this.labelFiltrar.Name = "labelFiltrar";
            this.labelFiltrar.Size = new System.Drawing.Size(84, 13);
            this.labelFiltrar.TabIndex = 22;
            this.labelFiltrar.Text = "FILTRAR POR: ";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 408);
            this.Controls.Add(this.labelFiltrar);
            this.Controls.Add(this.buttonCancelBusqueda);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.columnaRangoPrecio);
            this.Controls.Add(this.textLabelBuscador);
            this.Controls.Add(this.textBoxBuscador);
            this.Controls.Add(this.listaCategoria);
            this.Controls.Add(this.listaMarca);
            this.Controls.Add(this.cbOrdernarPor);
            this.Controls.Add(this.ordenarPor);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.PanelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AppForm";
            this.Text = "Trabajo Práctico WinForms";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.Button BtnVerDetalle;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSesion;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Label ordenarPor;
        private System.Windows.Forms.ComboBox cbOrdernarPor;
        private System.Windows.Forms.ComboBox listaCategoria;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.Label textLabelBuscador;
        private System.Windows.Forms.Label columnaRangoPrecio;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.ComboBox listaMarca;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonCancelBusqueda;
        private System.Windows.Forms.Label labelFiltrar;
    }
}

