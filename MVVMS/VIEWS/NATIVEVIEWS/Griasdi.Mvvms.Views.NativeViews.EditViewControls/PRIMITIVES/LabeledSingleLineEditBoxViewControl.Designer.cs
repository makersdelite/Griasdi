using Griasdi.Mvvms.Views.NativeViews.PRIMITIVES;

namespace Griasdi.Mvvms.Views.NativeViews.EditViewControls.PRIMITIVES
{
    partial class LabeledSingleLineEditBoxViewControl
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
            this.LabelViewControl = new Griasdi.Mvvms.Views.NativeViews.PRIMITIVES.LabelViewControl();
            this.SingleLineEditBoxViewControl = new Griasdi.Mvvms.Views.NativeViews.EditViewControls.SingleLineEditBoxNativeViewControl();
            this.SuspendLayout();
            // 
            // LabelViewControl
            // 
            this.LabelViewControl.Location = new System.Drawing.Point(4, 4);
            this.LabelViewControl.Name = "LabelViewControl";
            this.LabelViewControl.Size = new System.Drawing.Size(176, 20);
            this.LabelViewControl.TabIndex = 0;
            // 
            // SingleLineEditBoxViewControl
            // 
            this.SingleLineEditBoxViewControl.Location = new System.Drawing.Point(146, 0);
            this.SingleLineEditBoxViewControl.Name = "SingleLineEditBoxViewControl";
            this.SingleLineEditBoxViewControl.Size = new System.Drawing.Size(327, 22);
            this.SingleLineEditBoxViewControl.TabIndex = 1;
            // 
            // LabeledSingleLineEditBoxViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SingleLineEditBoxViewControl);
            this.Controls.Add(this.LabelViewControl);
            this.Name = "LabeledSingleLineEditBoxViewControl";
            this.Size = new System.Drawing.Size(476, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelViewControl LabelViewControl;
        private SingleLineEditBoxNativeViewControl SingleLineEditBoxViewControl;
    }
}
