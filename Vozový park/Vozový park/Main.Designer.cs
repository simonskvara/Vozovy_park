
namespace Vozový_park
{
    partial class Main
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
            this.buttonAddCars = new System.Windows.Forms.Button();
            this.buttonAddCustom = new System.Windows.Forms.Button();
            this.buttonRent = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddCars
            // 
            this.buttonAddCars.Location = new System.Drawing.Point(193, 38);
            this.buttonAddCars.Name = "buttonAddCars";
            this.buttonAddCars.Size = new System.Drawing.Size(208, 61);
            this.buttonAddCars.TabIndex = 0;
            this.buttonAddCars.Text = "Add cars";
            this.buttonAddCars.UseVisualStyleBackColor = true;
            this.buttonAddCars.Click += new System.EventHandler(this.buttonAddCars_Click);
            // 
            // buttonAddCustom
            // 
            this.buttonAddCustom.Location = new System.Drawing.Point(193, 105);
            this.buttonAddCustom.Name = "buttonAddCustom";
            this.buttonAddCustom.Size = new System.Drawing.Size(208, 61);
            this.buttonAddCustom.TabIndex = 1;
            this.buttonAddCustom.Text = "Add customers";
            this.buttonAddCustom.UseVisualStyleBackColor = true;
            this.buttonAddCustom.Click += new System.EventHandler(this.buttonAddCustom_Click);
            // 
            // buttonRent
            // 
            this.buttonRent.Location = new System.Drawing.Point(193, 172);
            this.buttonRent.Name = "buttonRent";
            this.buttonRent.Size = new System.Drawing.Size(208, 61);
            this.buttonRent.TabIndex = 2;
            this.buttonRent.Text = "Rent a car";
            this.buttonRent.UseVisualStyleBackColor = true;
            this.buttonRent.Click += new System.EventHandler(this.buttonRent_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(193, 239);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(208, 61);
            this.buttonReturn.TabIndex = 3;
            this.buttonReturn.Text = "Return a car";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(193, 306);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(208, 61);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 425);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonRent);
            this.Controls.Add(this.buttonAddCustom);
            this.Controls.Add(this.buttonAddCars);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCars;
        private System.Windows.Forms.Button buttonAddCustom;
        private System.Windows.Forms.Button buttonRent;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonLogout;
    }
}