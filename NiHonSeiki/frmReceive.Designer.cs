namespace NiHonSeiki
{
    partial class frmReceive
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
            this.dgList = new System.Windows.Forms.DataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLotNo = new System.Windows.Forms.TextBox();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGood = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dgList
            // 
            this.dgList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgList.Location = new System.Drawing.Point(3, 124);
            this.dgList.Name = "dgList";
            this.dgList.Size = new System.Drawing.Size(234, 167);
            this.dgList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.Text = "LotNo";
            // 
            // txtLotNo
            // 
            this.txtLotNo.Location = new System.Drawing.Point(55, 26);
            this.txtLotNo.Name = "txtLotNo";
            this.txtLotNo.Size = new System.Drawing.Size(182, 21);
            this.txtLotNo.TabIndex = 1;
            this.txtLotNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLotNo_KeyPress);
            // 
            // txtProcess
            // 
            this.txtProcess.Location = new System.Drawing.Point(55, 50);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(182, 21);
            this.txtProcess.TabIndex = 3;
            this.txtProcess.TextChanged += new System.EventHandler(this.txtProcess_TextChanged);
            this.txtProcess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcess_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.Text = "Process";
            // 
            // txtGood
            // 
            this.txtGood.Location = new System.Drawing.Point(55, 74);
            this.txtGood.Name = "txtGood";
            this.txtGood.Size = new System.Drawing.Size(50, 21);
            this.txtGood.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.Text = "Good";
            // 
            // txtNG
            // 
            this.txtNG.Location = new System.Drawing.Point(187, 74);
            this.txtNG.Name = "txtNG";
            this.txtNG.Size = new System.Drawing.Size(50, 21);
            this.txtNG.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(148, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.Text = "NG";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(3, 100);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 20);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(84, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 20);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(165, 100);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 20);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.Text = "Section";
            // 
            // lblSection
            // 
            this.lblSection.Location = new System.Drawing.Point(55, 6);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(182, 17);
            this.lblSection.Text = "PURCHASE";
            // 
            // frmReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLotNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgList);
            this.KeyPreview = true;
            this.Name = "frmReceive";
            this.Text = "Receive";
            this.Load += new System.EventHandler(this.frmReceive_Load);
            this.ResumeLayout(false);

        }

      

       

        #endregion

        private System.Windows.Forms.DataGrid dgList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLotNo;
        private System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSection;
      
     

    }
}