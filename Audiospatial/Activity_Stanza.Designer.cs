namespace Audiospatial
{
    partial class Activity_Stanza
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
            this.labCenter = new System.Windows.Forms.Label();
            this.labTimeCounter = new System.Windows.Forms.Label();
            this.pbEast = new System.Windows.Forms.PictureBox();
            this.pbNorth = new System.Windows.Forms.PictureBox();
            this.pbWest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWest)).BeginInit();
            this.SuspendLayout();
            // 
            // labCenter
            // 
            this.labCenter.AutoSize = true;
            this.labCenter.BackColor = System.Drawing.Color.Transparent;
            this.labCenter.Font = new System.Drawing.Font("Comic Sans MS", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCenter.Location = new System.Drawing.Point(255, 299);
            this.labCenter.Name = "labCenter";
            this.labCenter.Size = new System.Drawing.Size(163, 223);
            this.labCenter.TabIndex = 23;
            this.labCenter.Text = ".";
            this.labCenter.Visible = false;
            this.labCenter.Click += new System.EventHandler(this.labCenter_Click);
            // 
            // labTimeCounter
            // 
            this.labTimeCounter.AutoSize = true;
            this.labTimeCounter.BackColor = System.Drawing.Color.Transparent;
            this.labTimeCounter.Font = new System.Drawing.Font("Comic Sans MS", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTimeCounter.Location = new System.Drawing.Point(544, -2);
            this.labTimeCounter.Name = "labTimeCounter";
            this.labTimeCounter.Size = new System.Drawing.Size(95, 130);
            this.labTimeCounter.TabIndex = 24;
            this.labTimeCounter.Text = ".";
            this.labTimeCounter.Visible = false;
            // 
            // pbEast
            // 
            this.pbEast.BackColor = System.Drawing.Color.Transparent;
            this.pbEast.Location = new System.Drawing.Point(594, 155);
            this.pbEast.Name = "pbEast";
            this.pbEast.Size = new System.Drawing.Size(125, 125);
            this.pbEast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEast.TabIndex = 22;
            this.pbEast.TabStop = false;
            this.pbEast.Visible = false;
            // 
            // pbNorth
            // 
            this.pbNorth.BackColor = System.Drawing.Color.Transparent;
            this.pbNorth.Location = new System.Drawing.Point(274, 3);
            this.pbNorth.Name = "pbNorth";
            this.pbNorth.Size = new System.Drawing.Size(125, 125);
            this.pbNorth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNorth.TabIndex = 21;
            this.pbNorth.TabStop = false;
            this.pbNorth.Visible = false;
            // 
            // pbWest
            // 
            this.pbWest.BackColor = System.Drawing.Color.Transparent;
            this.pbWest.Location = new System.Drawing.Point(3, 166);
            this.pbWest.Name = "pbWest";
            this.pbWest.Size = new System.Drawing.Size(125, 125);
            this.pbWest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWest.TabIndex = 20;
            this.pbWest.TabStop = false;
            this.pbWest.Visible = false;
            // 
            // Activity_Stanza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.labTimeCounter);
            this.Controls.Add(this.labCenter);
            this.Controls.Add(this.pbEast);
            this.Controls.Add(this.pbNorth);
            this.Controls.Add(this.pbWest);
            this.Name = "Activity_Stanza";
            this.Size = new System.Drawing.Size(758, 522);
            this.Load += new System.EventHandler(this.Activity_Stanza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWest;
        private System.Windows.Forms.PictureBox pbNorth;
        private System.Windows.Forms.PictureBox pbEast;
        private System.Windows.Forms.Label labCenter;
        private System.Windows.Forms.Label labTimeCounter;
    }
}
