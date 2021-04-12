
namespace Vozový_park
{
    partial class returnCar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDaysElapsed = new System.Windows.Forms.TextBox();
            this.txtCustomID = new System.Windows.Forms.TextBox();
            this.txtCarNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listBoxReturn = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDaysElapsed);
            this.groupBox1.Controls.Add(this.txtCustomID);
            this.groupBox1.Controls.Add(this.txtCarNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return";
            // 
            // txtDaysElapsed
            // 
            this.txtDaysElapsed.Location = new System.Drawing.Point(141, 147);
            this.txtDaysElapsed.Name = "txtDaysElapsed";
            this.txtDaysElapsed.Size = new System.Drawing.Size(194, 20);
            this.txtDaysElapsed.TabIndex = 6;
            // 
            // txtCustomID
            // 
            this.txtCustomID.Location = new System.Drawing.Point(141, 89);
            this.txtCustomID.Name = "txtCustomID";
            this.txtCustomID.Size = new System.Drawing.Size(194, 20);
            this.txtCustomID.TabIndex = 5;
            // 
            // txtCarNum
            // 
            this.txtCarNum.Location = new System.Drawing.Point(141, 29);
            this.txtCarNum.Name = "txtCarNum";
            this.txtCarNum.Size = new System.Drawing.Size(194, 20);
            this.txtCarNum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Days elapsed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car number:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(141, 266);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(114, 56);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(261, 266);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(114, 56);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // listBoxReturn
            // 
            this.listBoxReturn.FormattingEnabled = true;
            this.listBoxReturn.Location = new System.Drawing.Point(381, 31);
            this.listBoxReturn.Name = "listBoxReturn";
            this.listBoxReturn.Size = new System.Drawing.Size(368, 225);
            this.listBoxReturn.TabIndex = 9;
            // 
            // returnCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 374);
            this.Controls.Add(this.listBoxReturn);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "returnCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "returnCar";
            this.Load += new System.EventHandler(this.returnCar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDaysElapsed;
        private System.Windows.Forms.TextBox txtCustomID;
        private System.Windows.Forms.TextBox txtCarNum;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListBox listBoxReturn;
    }
}