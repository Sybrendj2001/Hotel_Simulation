namespace Hotel
{
    partial class ChooseFloor
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
            this.btnSelectFloor = new System.Windows.Forms.Button();
            this.txtSelectFloor = new System.Windows.Forms.TextBox();
            this.lblSelectFloor = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectFloor
            // 
            this.btnSelectFloor.Location = new System.Drawing.Point(101, 173);
            this.btnSelectFloor.Name = "btnSelectFloor";
            this.btnSelectFloor.Size = new System.Drawing.Size(75, 46);
            this.btnSelectFloor.TabIndex = 5;
            this.btnSelectFloor.Text = "Enter";
            this.btnSelectFloor.UseVisualStyleBackColor = true;
            this.btnSelectFloor.Click += new System.EventHandler(this.btnSelectFloor_Click);
            // 
            // txtSelectFloor
            // 
            this.txtSelectFloor.Location = new System.Drawing.Point(39, 109);
            this.txtSelectFloor.Name = "txtSelectFloor";
            this.txtSelectFloor.Size = new System.Drawing.Size(205, 20);
            this.txtSelectFloor.TabIndex = 4;
            // 
            // lblSelectFloor
            // 
            this.lblSelectFloor.AutoSize = true;
            this.lblSelectFloor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectFloor.Location = new System.Drawing.Point(35, 26);
            this.lblSelectFloor.Name = "lblSelectFloor";
            this.lblSelectFloor.Size = new System.Drawing.Size(219, 22);
            this.lblSelectFloor.TabIndex = 3;
            this.lblSelectFloor.Text = "Please Enter Floornumber";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(75, 245);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 6;
            // 
            // ChooseFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 312);
            this.ControlBox = false;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSelectFloor);
            this.Controls.Add(this.txtSelectFloor);
            this.Controls.Add(this.lblSelectFloor);
            this.Name = "ChooseFloor";
            this.Text = "ChooseFloor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFloor;
        public System.Windows.Forms.TextBox txtSelectFloor;
        private System.Windows.Forms.Label lblSelectFloor;
        private System.Windows.Forms.Label lblError;
    }
}