namespace InterfaceWinFormsApp
{
    partial class EventsWinformsApp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            button1 = new Button();
            departmentsComboBox = new ComboBox();
            outputLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 0;
            label1.Text = "Vorname:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 50);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 1;
            label2.Text = "Nachname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 77);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 2;
            label3.Text = "Abteilung:";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(143, 17);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(312, 29);
            FirstNameTextBox.TabIndex = 3;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(143, 54);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(312, 29);
            LastNameTextBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(20, 127);
            button1.Name = "button1";
            button1.Size = new Size(220, 50);
            button1.TabIndex = 5;
            button1.Text = "Mittarbeiter anlegen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // departmentsComboBox
            // 
            departmentsComboBox.FormattingEnabled = true;
            departmentsComboBox.Location = new Point(142, 92);
            departmentsComboBox.Name = "departmentsComboBox";
            departmentsComboBox.Size = new Size(313, 29);
            departmentsComboBox.TabIndex = 6;
            departmentsComboBox.SelectedIndexChanged += departmentsComboBox_SelectedIndexChanged;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(20, 188);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(19, 21);
            outputLabel.TabIndex = 7;
            outputLabel.Text = "...";
            // 
            // EventsWinformsApp
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 229);
            Controls.Add(outputLabel);
            Controls.Add(departmentsComboBox);
            Controls.Add(button1);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "EventsWinformsApp";
            Text = "Ereignisse in .net basierent auf Delegates";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private Button button1;
        private ComboBox departmentsComboBox;
        private Label outputLabel;
    }
}