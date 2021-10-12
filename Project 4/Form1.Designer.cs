
namespace Project_4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.butShowCon = new System.Windows.Forms.Button();
            this.butAddCon = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(355, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "My simple Phone Book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butShowCon
            // 
            this.butShowCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butShowCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butShowCon.Location = new System.Drawing.Point(57, 111);
            this.butShowCon.Name = "butShowCon";
            this.butShowCon.Size = new System.Drawing.Size(292, 63);
            this.butShowCon.TabIndex = 1;
            this.butShowCon.Text = "Show Contacts";
            this.butShowCon.UseVisualStyleBackColor = true;
            this.butShowCon.Click += new System.EventHandler(this.butShowCon_Click);
            // 
            // butAddCon
            // 
            this.butAddCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAddCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddCon.Location = new System.Drawing.Point(57, 209);
            this.butAddCon.Name = "butAddCon";
            this.butAddCon.Size = new System.Drawing.Size(292, 63);
            this.butAddCon.TabIndex = 2;
            this.butAddCon.Text = "Add Contacts";
            this.butAddCon.UseVisualStyleBackColor = true;
            this.butAddCon.Click += new System.EventHandler(this.butAddCon_Click);
            // 
            // butExit
            // 
            this.butExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(57, 305);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(292, 63);
            this.butExit.TabIndex = 3;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label14.Location = new System.Drawing.Point(12, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "team: Coders";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(415, 407);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butAddCon);
            this.Controls.Add(this.butShowCon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butShowCon;
        private System.Windows.Forms.Button butAddCon;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label label14;
    }
}

