namespace InterfaceWinFormsApp
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
            lbl_Vorname = new Label();
            lbl_Nachname = new Label();
            label3 = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            greed_button = new Button();
            SuspendLayout();
            // 
            // lbl_Vorname
            // 
            lbl_Vorname.AutoSize = true;
            lbl_Vorname.Location = new Point(16, 11);
            lbl_Vorname.Name = "lbl_Vorname";
            lbl_Vorname.Size = new Size(57, 15);
            lbl_Vorname.TabIndex = 0;
            lbl_Vorname.Text = "Vorname:";
            // 
            // lbl_Nachname
            // 
            lbl_Nachname.AutoSize = true;
            lbl_Nachname.Location = new Point(13, 38);
            lbl_Nachname.Name = "lbl_Nachname";
            lbl_Nachname.Size = new Size(68, 15);
            lbl_Nachname.TabIndex = 1;
            lbl_Nachname.Text = "Nachname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 149);
            label3.Name = "label3";
            label3.Size = new Size(16, 15);
            label3.TabIndex = 2;
            label3.Text = "...";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(91, 9);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(100, 23);
            firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(91, 38);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(100, 23);
            lastNameTextBox.TabIndex = 4;
            // 
            // greed_button
            // 
            greed_button.Location = new Point(249, 12);
            greed_button.Name = "greed_button";
            greed_button.Size = new Size(75, 49);
            greed_button.TabIndex = 5;
            greed_button.Text = "&Grüßen";
            greed_button.UseVisualStyleBackColor = true;
            greed_button.Click += greed_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 264);
            Controls.Add(greed_button);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(label3);
            Controls.Add(lbl_Nachname);
            Controls.Add(lbl_Vorname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Vorname;
        private Label lbl_Nachname;
        private Label label3;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Button greed_button;
    }
}