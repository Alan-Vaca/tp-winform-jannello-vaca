
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.listaMarca = new System.Windows.Forms.ComboBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonCancelBusqueda = new System.Windows.Forms.Button();
            this.labelFiltrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.columnaRangoPrecio = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.PanelMenu.Controls.Add(this.buttonAgregar);
            this.PanelMenu.Controls.Add(this.BtnEliminar);
            this.PanelMenu.Controls.Add(this.BtnSesion);
            this.PanelMenu.Controls.Add(this.BtnVerDetalle);
            this.PanelMenu.Controls.Add(this.logoImg);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(5);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(183, 464);
            this.PanelMenu.TabIndex = 0;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.Transparent;
            this.buttonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAgregar.FlatAppearance.BorderSize = 0;
            this.buttonAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAgregar.Location = new System.Drawing.Point(1, 188);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(180, 43);
            this.buttonAgregar.TabIndex = 6;
            this.buttonAgregar.Text = "Agregar artículo";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnEliminar.Location = new System.Drawing.Point(0, 274);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(181, 43);
            this.BtnEliminar.TabIndex = 5;
            this.BtnEliminar.Text = "Eliminar artículo por ID";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnSesion
            // 
            this.BtnSesion.BackColor = System.Drawing.Color.Transparent;
            this.BtnSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSesion.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnSesion.FlatAppearance.BorderSize = 0;
            this.BtnSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSesion.Location = new System.Drawing.Point(2, 400);
            this.BtnSesion.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSesion.Name = "BtnSesion";
            this.BtnSesion.Size = new System.Drawing.Size(180, 43);
            this.BtnSesion.TabIndex = 4;
            this.BtnSesion.Text = "Cerrar";
            this.BtnSesion.UseVisualStyleBackColor = false;
            this.BtnSesion.Click += new System.EventHandler(this.BtnSesion_Click);
            // 
            // BtnVerDetalle
            // 
            this.BtnVerDetalle.BackColor = System.Drawing.Color.Transparent;
            this.BtnVerDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerDetalle.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnVerDetalle.FlatAppearance.BorderSize = 0;
            this.BtnVerDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnVerDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerDetalle.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnVerDetalle.Location = new System.Drawing.Point(3, 231);
            this.BtnVerDetalle.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVerDetalle.Name = "BtnVerDetalle";
            this.BtnVerDetalle.Size = new System.Drawing.Size(179, 43);
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
            this.logoImg.Margin = new System.Windows.Forms.Padding(5);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(183, 145);
            this.logoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImg.TabIndex = 0;
            this.logoImg.TabStop = false;
            // 
            // dgvTabla
            // 
            this.dgvTabla.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dgvTabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTabla.Location = new System.Drawing.Point(204, 203);
            this.dgvTabla.Margin = new System.Windows.Forms.Padding(5);
            this.dgvTabla.MultiSelect = false;
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersVisible = false;
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabla.Size = new System.Drawing.Size(1077, 240);
            this.dgvTabla.TabIndex = 1;
            this.dgvTabla.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTabla_CellMouseDoubleClick);
            // 
            // ordenarPor
            // 
            this.ordenarPor.BackColor = System.Drawing.Color.Transparent;
            this.ordenarPor.Location = new System.Drawing.Point(200, 68);
            this.ordenarPor.Name = "ordenarPor";
            this.ordenarPor.Size = new System.Drawing.Size(147, 26);
            this.ordenarPor.TabIndex = 2;
            this.ordenarPor.Text = "ORDERNAR POR :";
            // 
            // cbOrdernarPor
            // 
            this.cbOrdernarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrdernarPor.FormattingEnabled = true;
            this.cbOrdernarPor.Location = new System.Drawing.Point(339, 65);
            this.cbOrdernarPor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrdernarPor.Name = "cbOrdernarPor";
            this.cbOrdernarPor.Size = new System.Drawing.Size(194, 24);
            this.cbOrdernarPor.TabIndex = 3;
            this.cbOrdernarPor.SelectionChangeCommitted += new System.EventHandler(this.cbOrdernarPor_SelectionChangeCommitted);
            // 
            // listaCategoria
            // 
            this.listaCategoria.FormattingEnabled = true;
            this.listaCategoria.Location = new System.Drawing.Point(345, 38);
            this.listaCategoria.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.listaCategoria.Name = "listaCategoria";
            this.listaCategoria.Size = new System.Drawing.Size(128, 24);
            this.listaCategoria.TabIndex = 9;
            this.listaCategoria.SelectedIndexChanged += new System.EventHandler(this.filtrarPorMarcaYCategoria);
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxBuscador.BackColor = System.Drawing.Color.White;
            this.textBoxBuscador.Location = new System.Drawing.Point(204, 143);
            this.textBoxBuscador.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.textBoxBuscador.Multiline = true;
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(253, 29);
            this.textBoxBuscador.TabIndex = 14;
            // 
            // textLabelBuscador
            // 
            this.textLabelBuscador.BackColor = System.Drawing.Color.Transparent;
            this.textLabelBuscador.Location = new System.Drawing.Point(200, 119);
            this.textLabelBuscador.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textLabelBuscador.Name = "textLabelBuscador";
            this.textLabelBuscador.Size = new System.Drawing.Size(417, 22);
            this.textLabelBuscador.TabIndex = 15;
            this.textLabelBuscador.Text = "BUSCAR POR CODIGO, NOMBRE O DESCRIPCIÓN:";
            // 
            // listaMarca
            // 
            this.listaMarca.FormattingEnabled = true;
            this.listaMarca.Location = new System.Drawing.Point(137, 38);
            this.listaMarca.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.listaMarca.Name = "listaMarca";
            this.listaMarca.Size = new System.Drawing.Size(136, 24);
            this.listaMarca.TabIndex = 8;
            this.listaMarca.SelectedIndexChanged += new System.EventHandler(this.filtrarPorMarcaYCategoria);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.BackgroundImage")));
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBuscar.Location = new System.Drawing.Point(461, 141);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(32, 30);
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
            this.buttonCancelBusqueda.Location = new System.Drawing.Point(501, 141);
            this.buttonCancelBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelBusqueda.Name = "buttonCancelBusqueda";
            this.buttonCancelBusqueda.Size = new System.Drawing.Size(32, 30);
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
            this.labelFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.labelFiltrar.Location = new System.Drawing.Point(7, 42);
            this.labelFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFiltrar.Name = "labelFiltrar";
            this.labelFiltrar.Size = new System.Drawing.Size(107, 17);
            this.labelFiltrar.TabIndex = 22;
            this.labelFiltrar.Text = "FILTRAR POR: ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(134, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "MARCA";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(342, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "CATEGORIA";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudMax);
            this.groupBox1.Controls.Add(this.nudMin);
            this.groupBox1.Controls.Add(this.columnaRangoPrecio);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(784, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 86);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(134, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "DESDE";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(342, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "HASTA";
            // 
            // nudMax
            // 
            this.nudMax.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMax.Location = new System.Drawing.Point(345, 39);
            this.nudMax.Margin = new System.Windows.Forms.Padding(4);
            this.nudMax.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(128, 22);
            this.nudMax.TabIndex = 19;
            this.nudMax.ValueChanged += new System.EventHandler(this.nudMax_ValueChanged);
            // 
            // nudMin
            // 
            this.nudMin.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMin.Location = new System.Drawing.Point(137, 39);
            this.nudMin.Margin = new System.Windows.Forms.Padding(4);
            this.nudMin.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(136, 22);
            this.nudMin.TabIndex = 18;
            this.nudMin.ValueChanged += new System.EventHandler(this.nudMin_ValueChanged);
            // 
            // columnaRangoPrecio
            // 
            this.columnaRangoPrecio.Location = new System.Drawing.Point(11, 41);
            this.columnaRangoPrecio.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.columnaRangoPrecio.Name = "columnaRangoPrecio";
            this.columnaRangoPrecio.Size = new System.Drawing.Size(107, 22);
            this.columnaRangoPrecio.TabIndex = 17;
            this.columnaRangoPrecio.Text = "PRECIO";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.groupBox2.Controls.Add(this.labelFiltrar);
            this.groupBox2.Controls.Add(this.listaMarca);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listaCategoria);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(784, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 86);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1303, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancelBusqueda);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textLabelBuscador);
            this.Controls.Add(this.textBoxBuscador);
            this.Controls.Add(this.cbOrdernarPor);
            this.Controls.Add(this.ordenarPor);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.PanelMenu);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AppForm";
            this.Text = "Trabajo Práctico WinForms";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.ComboBox listaMarca;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonCancelBusqueda;
        private System.Windows.Forms.Label labelFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label columnaRangoPrecio;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

