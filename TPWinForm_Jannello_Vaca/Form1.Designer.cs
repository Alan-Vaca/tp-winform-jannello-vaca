
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
            this.articulosListButton = new System.Windows.Forms.Button();
            this.logoImg = new System.Windows.Forms.PictureBox();
            this.allArticulosPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            this.allArticulosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PanelMenu.Controls.Add(this.articulosListButton);
            this.PanelMenu.Controls.Add(this.logoImg);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(137, 338);
            this.PanelMenu.TabIndex = 0;
            // 
            // articulosListButton
            // 
            this.articulosListButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.articulosListButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.articulosListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.articulosListButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.articulosListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.articulosListButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.articulosListButton.Location = new System.Drawing.Point(0, 118);
            this.articulosListButton.Margin = new System.Windows.Forms.Padding(0);
            this.articulosListButton.Name = "articulosListButton";
            this.articulosListButton.Size = new System.Drawing.Size(137, 35);
            this.articulosListButton.TabIndex = 1;
            this.articulosListButton.Text = "Ver lista de artículos";
            this.articulosListButton.UseVisualStyleBackColor = false;
            this.articulosListButton.Click += new System.EventHandler(this.articulosListButton_Click);
            // 
            // logoImg
            // 
            this.logoImg.Image = ((System.Drawing.Image)(resources.GetObject("logoImg.Image")));
            this.logoImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoImg.InitialImage")));
            this.logoImg.Location = new System.Drawing.Point(22, 12);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(87, 78);
            this.logoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImg.TabIndex = 0;
            this.logoImg.TabStop = false;
            this.logoImg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // allArticulosPanel
            // 
            this.allArticulosPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.allArticulosPanel.Controls.Add(this.dataGridView1);
            this.allArticulosPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allArticulosPanel.Location = new System.Drawing.Point(137, 0);
            this.allArticulosPanel.Name = "allArticulosPanel";
            this.allArticulosPanel.Size = new System.Drawing.Size(607, 338);
            this.allArticulosPanel.TabIndex = 1;
            this.allArticulosPanel.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 252);
            this.dataGridView1.TabIndex = 0;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 338);
            this.Controls.Add(this.allArticulosPanel);
            this.Controls.Add(this.PanelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppForm";
            this.Text = "Trabajo Práctico WinForms";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.allArticulosPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.Button articulosListButton;
        private System.Windows.Forms.Panel allArticulosPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

