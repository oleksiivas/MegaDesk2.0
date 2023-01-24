namespace MegaDesk_Earl
{
    partial class AddQuote
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
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.widthControl = new System.Windows.Forms.NumericUpDown();
            this.depthControl = new System.Windows.Forms.NumericUpDown();
            this.drawersControl = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.surfaceComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rushOrder14Days = new System.Windows.Forms.RadioButton();
            this.rushOrder7Days = new System.Windows.Forms.RadioButton();
            this.rushOrder5Days = new System.Windows.Forms.RadioButton();
            this.rushOrder3Days = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.widthLimitText = new System.Windows.Forms.Label();
            this.depthLimitText = new System.Windows.Forms.Label();
            this.drawerLimitText = new System.Windows.Forms.Label();
            this.Warning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widthControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersControl)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(125, 49);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(157, 23);
            this.FirstNameBox.TabIndex = 0;
            this.FirstNameBox.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(322, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(413, 49);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(157, 23);
            this.LastNameBox.TabIndex = 1;
            this.LastNameBox.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Desk Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(33, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Depth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(33, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Width";
            // 
            // widthControl
            // 
            this.widthControl.Location = new System.Drawing.Point(91, 128);
            this.widthControl.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthControl.Minimum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.widthControl.Name = "widthControl";
            this.widthControl.Size = new System.Drawing.Size(120, 23);
            this.widthControl.TabIndex = 10;
            this.widthControl.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            // 
            // depthControl
            // 
            this.depthControl.Location = new System.Drawing.Point(91, 157);
            this.depthControl.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthControl.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthControl.Name = "depthControl";
            this.depthControl.Size = new System.Drawing.Size(120, 23);
            this.depthControl.TabIndex = 11;
            this.depthControl.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // drawersControl
            // 
            this.drawersControl.Location = new System.Drawing.Point(413, 130);
            this.drawersControl.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawersControl.Name = "drawersControl";
            this.drawersControl.Size = new System.Drawing.Size(157, 23);
            this.drawersControl.TabIndex = 13;
            this.drawersControl.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(307, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "# of Drawers";
            // 
            // surfaceComboBox
            // 
            this.surfaceComboBox.FormattingEnabled = true;
            this.surfaceComboBox.Location = new System.Drawing.Point(412, 161);
            this.surfaceComboBox.Name = "surfaceComboBox";
            this.surfaceComboBox.Size = new System.Drawing.Size(158, 23);
            this.surfaceComboBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(283, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Surface Material";
            // 
            // rushOrder14Days
            // 
            this.rushOrder14Days.AutoSize = true;
            this.rushOrder14Days.Checked = true;
            this.rushOrder14Days.Location = new System.Drawing.Point(228, 241);
            this.rushOrder14Days.Name = "rushOrder14Days";
            this.rushOrder14Days.Size = new System.Drawing.Size(65, 19);
            this.rushOrder14Days.TabIndex = 16;
            this.rushOrder14Days.TabStop = true;
            this.rushOrder14Days.Text = "14 Days";
            this.rushOrder14Days.UseVisualStyleBackColor = true;
            // 
            // rushOrder7Days
            // 
            this.rushOrder7Days.AutoSize = true;
            this.rushOrder7Days.Location = new System.Drawing.Point(163, 241);
            this.rushOrder7Days.Name = "rushOrder7Days";
            this.rushOrder7Days.Size = new System.Drawing.Size(59, 19);
            this.rushOrder7Days.TabIndex = 17;
            this.rushOrder7Days.Text = "7 Days";
            this.rushOrder7Days.UseVisualStyleBackColor = true;
            // 
            // rushOrder5Days
            // 
            this.rushOrder5Days.AutoSize = true;
            this.rushOrder5Days.Location = new System.Drawing.Point(98, 241);
            this.rushOrder5Days.Name = "rushOrder5Days";
            this.rushOrder5Days.Size = new System.Drawing.Size(59, 19);
            this.rushOrder5Days.TabIndex = 18;
            this.rushOrder5Days.Text = "5 Days";
            this.rushOrder5Days.UseVisualStyleBackColor = true;
            // 
            // rushOrder3Days
            // 
            this.rushOrder3Days.AutoSize = true;
            this.rushOrder3Days.Location = new System.Drawing.Point(33, 241);
            this.rushOrder3Days.Name = "rushOrder3Days";
            this.rushOrder3Days.Size = new System.Drawing.Size(59, 19);
            this.rushOrder3Days.TabIndex = 19;
            this.rushOrder3Days.Text = "3 Days";
            this.rushOrder3Days.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 30);
            this.label9.TabIndex = 20;
            this.label9.Text = "Rush Order";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(26, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 25);
            this.button1.TabIndex = 21;
            this.button1.Text = "Save and Show Quote";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(164, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 25);
            this.button2.TabIndex = 22;
            this.button2.Text = "Discard and return to Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ReturnToMenu);
            // 
            // widthLimitText
            // 
            this.widthLimitText.AutoSize = true;
            this.widthLimitText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.widthLimitText.Location = new System.Drawing.Point(217, 130);
            this.widthLimitText.Name = "widthLimitText";
            this.widthLimitText.Size = new System.Drawing.Size(39, 15);
            this.widthLimitText.TabIndex = 23;
            this.widthLimitText.Text = "Width";
            // 
            // depthLimitText
            // 
            this.depthLimitText.AutoSize = true;
            this.depthLimitText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depthLimitText.Location = new System.Drawing.Point(216, 163);
            this.depthLimitText.Name = "depthLimitText";
            this.depthLimitText.Size = new System.Drawing.Size(39, 15);
            this.depthLimitText.TabIndex = 24;
            this.depthLimitText.Text = "Depth";
            // 
            // drawerLimitText
            // 
            this.drawerLimitText.AutoSize = true;
            this.drawerLimitText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drawerLimitText.Location = new System.Drawing.Point(576, 134);
            this.drawerLimitText.Name = "drawerLimitText";
            this.drawerLimitText.Size = new System.Drawing.Size(44, 15);
            this.drawerLimitText.TabIndex = 25;
            this.drawerLimitText.Text = "Drawer";
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Warning.ForeColor = System.Drawing.Color.Crimson;
            this.Warning.Location = new System.Drawing.Point(125, 16);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(0, 21);
            this.Warning.TabIndex = 26;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 337);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.drawerLimitText);
            this.Controls.Add(this.depthLimitText);
            this.Controls.Add(this.widthLimitText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rushOrder3Days);
            this.Controls.Add(this.rushOrder5Days);
            this.Controls.Add(this.rushOrder7Days);
            this.Controls.Add(this.rushOrder14Days);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.surfaceComboBox);
            this.Controls.Add(this.drawersControl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.depthControl);
            this.Controls.Add(this.widthControl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameBox);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.widthControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FirstNameBox;
        private Label label1;
        private Label label2;
        private TextBox LastNameBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown widthControl;
        private NumericUpDown depthControl;
        private NumericUpDown drawersControl;
        private Label label7;
        private ComboBox surfaceComboBox;
        private Label label8;
        private RadioButton rushOrder14Days;
        private RadioButton rushOrder7Days;
        private RadioButton rushOrder5Days;
        private RadioButton rushOrder3Days;
        private Label label9;
        private Button button1;
        private Button button2;
        private Label widthLimitText;
        private Label depthLimitText;
        private Label drawerLimitText;
        private Label Warning;
    }
}