namespace Hotel
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public static int ScreenWidth;
        public static int ScreenHeight;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.pbxBackground = new System.Windows.Forms.PictureBox();
            this.PanelPictureboxHotel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackground)).BeginInit();
            this.PanelPictureboxHotel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxBackground
            // 
            this.pbxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxBackground.Location = new System.Drawing.Point(0, 0);
            this.pbxBackground.Margin = new System.Windows.Forms.Padding(2);
            this.pbxBackground.Name = "pbxBackground";
            this.pbxBackground.Size = new System.Drawing.Size(993, 700);
            this.pbxBackground.TabIndex = 0;
            this.pbxBackground.TabStop = false;
            // 
            // PanelPictureboxHotel
            // 
            this.PanelPictureboxHotel.BackColor = System.Drawing.Color.Transparent;
            this.PanelPictureboxHotel.Controls.Add(this.pbxBackground);
            this.PanelPictureboxHotel.Location = new System.Drawing.Point(451, 286);
            this.PanelPictureboxHotel.Name = "PanelPictureboxHotel";
            this.PanelPictureboxHotel.Size = new System.Drawing.Size(993, 700);
            this.PanelPictureboxHotel.TabIndex = 6;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel.Properties.Resources.pixel_landscape_background_wallpaper_3;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.PanelPictureboxHotel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HotelSimulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackground)).EndInit();
            this.PanelPictureboxHotel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBackground;
        private System.Windows.Forms.Panel PanelPictureboxHotel;
    }
}