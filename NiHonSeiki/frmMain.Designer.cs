namespace NiHonSeiki
{
    partial class frmMain
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
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnReceiveVender = new System.Windows.Forms.Button();
            this.btnSendVender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(49, 36);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(142, 54);
            this.btnReceive.TabIndex = 0;
            this.btnReceive.Text = "Receive";
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnReceiveVender
            // 
            this.btnReceiveVender.Location = new System.Drawing.Point(49, 103);
            this.btnReceiveVender.Name = "btnReceiveVender";
            this.btnReceiveVender.Size = new System.Drawing.Size(142, 54);
            this.btnReceiveVender.TabIndex = 1;
            this.btnReceiveVender.Text = "Receive from Vender";
            this.btnReceiveVender.Click += new System.EventHandler(this.btnReceiveVender_Click);
            // 
            // btnSendVender
            // 
            this.btnSendVender.Location = new System.Drawing.Point(49, 170);
            this.btnSendVender.Name = "btnSendVender";
            this.btnSendVender.Size = new System.Drawing.Size(142, 54);
            this.btnSendVender.TabIndex = 2;
            this.btnSendVender.Text = "Send to Vender";
            this.btnSendVender.Click += new System.EventHandler(this.btnSendVender_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.btnSendVender);
            this.Controls.Add(this.btnReceiveVender);
            this.Controls.Add(this.btnReceive);
            this.Name = "frmMain";
            this.Text = "Nihon Seiki Lot Travel Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnReceiveVender;
        private System.Windows.Forms.Button btnSendVender;
    }
}