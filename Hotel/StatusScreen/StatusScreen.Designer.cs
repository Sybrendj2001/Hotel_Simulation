using Hotel.StatusScreen.User_Controls;

namespace Hotel.StatusScreen
{
    partial class StatusScreen
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
            this.btnHTEconfig = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEvents = new System.Windows.Forms.Button();
            this.configureHTE1 = new Hotel.StatusScreen.User_Controls.ConfigureHTE();
            this.events1 = new Hotel.StatusScreen.UcEvents();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHTEconfig
            // 
            this.btnHTEconfig.Location = new System.Drawing.Point(12, 12);
            this.btnHTEconfig.Name = "btnHTEconfig";
            this.btnHTEconfig.Size = new System.Drawing.Size(127, 23);
            this.btnHTEconfig.TabIndex = 0;
            this.btnHTEconfig.Text = "Configure HTE";
            this.btnHTEconfig.UseVisualStyleBackColor = true;
            this.btnHTEconfig.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.events1);
            this.panel1.Controls.Add(this.configureHTE1);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 390);
            this.panel1.TabIndex = 2;
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(174, 12);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(155, 23);
            this.btnEvents.TabIndex = 3;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // configureHTE1
            // 
            this.configureHTE1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configureHTE1.Location = new System.Drawing.Point(0, 0);
            this.configureHTE1.Name = "configureHTE1";
            this.configureHTE1.Size = new System.Drawing.Size(776, 390);
            this.configureHTE1.TabIndex = 0;
            // 
            // events1
            // 
            this.events1.Location = new System.Drawing.Point(0, 12);
            this.events1.Name = "events1";
            this.events1.Size = new System.Drawing.Size(773, 378);
            this.events1.TabIndex = 1;
            // 
            // StatusScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHTEconfig);
            this.Name = "StatusScreen";
            this.Text = "Statusscherm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHTEconfig;
        private System.Windows.Forms.Panel panel1;
        private ConfigureHTE configureHTE1;
        private System.Windows.Forms.Button btnEvents;
        private Hotel.StatusScreen.UcEvents events1;
    }
}