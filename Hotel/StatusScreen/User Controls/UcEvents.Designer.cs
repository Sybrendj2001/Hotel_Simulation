namespace Hotel.StatusScreen
{
    partial class UcEvents
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEmergency = new System.Windows.Forms.Button();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmergency
            // 
            this.btnEmergency.Location = new System.Drawing.Point(17, 19);
            this.btnEmergency.Name = "btnEmergency";
            this.btnEmergency.Size = new System.Drawing.Size(74, 47);
            this.btnEmergency.TabIndex = 106;
            this.btnEmergency.Text = "Emergency";
            this.btnEmergency.UseVisualStyleBackColor = true;
            this.btnEmergency.Click += new System.EventHandler(this.btnEmergency_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(16, 92);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(75, 47);
            this.btnCheckin.TabIndex = 107;
            this.btnCheckin.Text = "Checkin";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // UcEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.btnEmergency);
            this.Name = "UcEvents";
            this.Size = new System.Drawing.Size(581, 349);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmergency;
        private System.Windows.Forms.Button btnCheckin;
    }
}
