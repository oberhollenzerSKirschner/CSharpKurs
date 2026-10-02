namespace InterfaceWinFormsApp
{
    partial class EventHandlerForm
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
            OutputLabel = new Label();
            SuspendLayout();
            // 
            // OutputLabel
            // 
            OutputLabel.AutoSize = true;
            OutputLabel.Location = new Point(18, 25);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(53, 15);
            OutputLabel.TabIndex = 0;
            OutputLabel.Text = "Ausgabe";
            // 
            // EventHandlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OutputLabel);
            Name = "EventHandlerForm";
            Text = "EventHandlerForm";
            Load += EventHandlerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OutputLabel;
    }
}