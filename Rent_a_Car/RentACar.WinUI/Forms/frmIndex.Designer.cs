namespace RentACar.WinUI
{
    partial class frmIndex
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledVozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoVoziloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newManufacturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poslovniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPoslovnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sveRezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recenzijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKomentaraKlijenataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledOcjenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.newVehicleModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.vozilaToolStripMenuItem,
            this.poslovniceToolStripMenuItem,
            this.rezervacijeToolStripMenuItem,
            this.recenzijeToolStripMenuItem,
            this.informacijeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKorisnikaToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.korisniciToolStripMenuItem.Text = "Customers";
            // 
            // pregledKorisnikaToolStripMenuItem
            // 
            this.pregledKorisnikaToolStripMenuItem.Name = "pregledKorisnikaToolStripMenuItem";
            this.pregledKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.pregledKorisnikaToolStripMenuItem.Text = "View all";
            this.pregledKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.pregledKorisnikaToolStripMenuItem_Click);
            // 
            // vozilaToolStripMenuItem
            // 
            this.vozilaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledVozilaToolStripMenuItem,
            this.newManufacturerToolStripMenuItem,
            this.newVehicleModelToolStripMenuItem,
            this.novoVoziloToolStripMenuItem});
            this.vozilaToolStripMenuItem.Name = "vozilaToolStripMenuItem";
            this.vozilaToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.vozilaToolStripMenuItem.Text = "Vehicles";
            // 
            // pregledVozilaToolStripMenuItem
            // 
            this.pregledVozilaToolStripMenuItem.Name = "pregledVozilaToolStripMenuItem";
            this.pregledVozilaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pregledVozilaToolStripMenuItem.Text = "View all vehicles";
            this.pregledVozilaToolStripMenuItem.Click += new System.EventHandler(this.pregledVozilaToolStripMenuItem_Click);
            // 
            // novoVoziloToolStripMenuItem
            // 
            this.novoVoziloToolStripMenuItem.Name = "novoVoziloToolStripMenuItem";
            this.novoVoziloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.novoVoziloToolStripMenuItem.Text = "New vehicle";
            this.novoVoziloToolStripMenuItem.Click += new System.EventHandler(this.novoVoziloToolStripMenuItem_Click);
            // 
            // newManufacturerToolStripMenuItem
            // 
            this.newManufacturerToolStripMenuItem.Name = "newManufacturerToolStripMenuItem";
            this.newManufacturerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newManufacturerToolStripMenuItem.Text = "New manufacturer";
            this.newManufacturerToolStripMenuItem.Click += new System.EventHandler(this.newManufacturerToolStripMenuItem_Click);
            // 
            // poslovniceToolStripMenuItem
            // 
            this.poslovniceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem,
            this.novaPoslovnicaToolStripMenuItem});
            this.poslovniceToolStripMenuItem.Name = "poslovniceToolStripMenuItem";
            this.poslovniceToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.poslovniceToolStripMenuItem.Text = "Branches";
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.pregledToolStripMenuItem.Text = "View all";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.pregledToolStripMenuItem_Click);
            // 
            // novaPoslovnicaToolStripMenuItem
            // 
            this.novaPoslovnicaToolStripMenuItem.Name = "novaPoslovnicaToolStripMenuItem";
            this.novaPoslovnicaToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.novaPoslovnicaToolStripMenuItem.Text = "New branch";
            this.novaPoslovnicaToolStripMenuItem.Click += new System.EventHandler(this.novaPoslovnicaToolStripMenuItem_Click);
            // 
            // rezervacijeToolStripMenuItem
            // 
            this.rezervacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sveRezervacijeToolStripMenuItem});
            this.rezervacijeToolStripMenuItem.Name = "rezervacijeToolStripMenuItem";
            this.rezervacijeToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.rezervacijeToolStripMenuItem.Text = "Reservations";
            // 
            // sveRezervacijeToolStripMenuItem
            // 
            this.sveRezervacijeToolStripMenuItem.Name = "sveRezervacijeToolStripMenuItem";
            this.sveRezervacijeToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.sveRezervacijeToolStripMenuItem.Text = "View all";
            this.sveRezervacijeToolStripMenuItem.Click += new System.EventHandler(this.sveRezervacijeToolStripMenuItem_Click);
            // 
            // recenzijeToolStripMenuItem
            // 
            this.recenzijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKomentaraKlijenataToolStripMenuItem,
            this.pregledOcjenaToolStripMenuItem});
            this.recenzijeToolStripMenuItem.Name = "recenzijeToolStripMenuItem";
            this.recenzijeToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.recenzijeToolStripMenuItem.Text = "Ratings and comments";
            // 
            // pregledKomentaraKlijenataToolStripMenuItem
            // 
            this.pregledKomentaraKlijenataToolStripMenuItem.Name = "pregledKomentaraKlijenataToolStripMenuItem";
            this.pregledKomentaraKlijenataToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.pregledKomentaraKlijenataToolStripMenuItem.Text = "View all comments";
            this.pregledKomentaraKlijenataToolStripMenuItem.Click += new System.EventHandler(this.pregledKomentaraKlijenataToolStripMenuItem_Click);
            // 
            // pregledOcjenaToolStripMenuItem
            // 
            this.pregledOcjenaToolStripMenuItem.Name = "pregledOcjenaToolStripMenuItem";
            this.pregledOcjenaToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.pregledOcjenaToolStripMenuItem.Text = "View all ratings";
            this.pregledOcjenaToolStripMenuItem.Click += new System.EventHandler(this.pregledOcjenaToolStripMenuItem_Click);
            // 
            // informacijeToolStripMenuItem
            // 
            this.informacijeToolStripMenuItem.Name = "informacijeToolStripMenuItem";
            this.informacijeToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.informacijeToolStripMenuItem.Text = "Informations";
            this.informacijeToolStripMenuItem.Click += new System.EventHandler(this.informacijeToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // newVehicleModelToolStripMenuItem
            // 
            this.newVehicleModelToolStripMenuItem.Name = "newVehicleModelToolStripMenuItem";
            this.newVehicleModelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newVehicleModelToolStripMenuItem.Text = "New vehicle model";
            this.newVehicleModelToolStripMenuItem.Click += new System.EventHandler(this.newVehicleModelToolStripMenuItem_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledVozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoVoziloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poslovniceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPoslovnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sveRezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recenzijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKomentaraKlijenataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledOcjenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newManufacturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVehicleModelToolStripMenuItem;
    }
}



