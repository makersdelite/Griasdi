namespace Griasdi.Mvvms.Views.NativeViews.PanelViewControls.COMPOSITES
{
    partial class ThreePanelNativeViewControl
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
            this.Panel0 = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Panel0
            // 
            this.Panel0.BackColor = System.Drawing.Color.LightGray;
            this.Panel0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel0.Location = new System.Drawing.Point(3, 3);
            this.Panel0.Name = "Panel0";
            this.Panel0.Size = new System.Drawing.Size(138, 37);
            this.Panel0.TabIndex = 0;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Yellow;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Location = new System.Drawing.Point(147, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(138, 37);
            this.Panel1.TabIndex = 1;
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel2.Location = new System.Drawing.Point(291, 3);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(138, 37);
            this.Panel2.TabIndex = 2;
            // 
            // ThreePanelNativeViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel0);
            this.Name = "ThreePanelNativeViewControl";
            this.Size = new System.Drawing.Size(435, 45);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel0;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
    }
}
