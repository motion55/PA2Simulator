namespace PA2Simulator
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
            this.PortComboBox = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.Vrms_textBox = new System.Windows.Forms.TextBox();
            this.Irms_textBox = new System.Windows.Forms.TextBox();
            this.Preal_textBox = new System.Windows.Forms.TextBox();
            this.PF_textBox = new System.Windows.Forms.TextBox();
            this.Watthr_textBox = new System.Windows.Forms.TextBox();
            this.Interval_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PA2Test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PortComboBox
            // 
            this.PortComboBox.FormattingEnabled = true;
            this.PortComboBox.Location = new System.Drawing.Point(41, 45);
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(114, 24);
            this.PortComboBox.TabIndex = 3;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(212, 38);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(108, 36);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // Vrms_textBox
            // 
            this.Vrms_textBox.Location = new System.Drawing.Point(41, 115);
            this.Vrms_textBox.Name = "Vrms_textBox";
            this.Vrms_textBox.Size = new System.Drawing.Size(100, 22);
            this.Vrms_textBox.TabIndex = 6;
            this.Vrms_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Irms_textBox
            // 
            this.Irms_textBox.Location = new System.Drawing.Point(212, 115);
            this.Irms_textBox.Name = "Irms_textBox";
            this.Irms_textBox.Size = new System.Drawing.Size(100, 22);
            this.Irms_textBox.TabIndex = 7;
            this.Irms_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Preal_textBox
            // 
            this.Preal_textBox.Location = new System.Drawing.Point(377, 115);
            this.Preal_textBox.Name = "Preal_textBox";
            this.Preal_textBox.Size = new System.Drawing.Size(100, 22);
            this.Preal_textBox.TabIndex = 8;
            this.Preal_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PF_textBox
            // 
            this.PF_textBox.Location = new System.Drawing.Point(41, 171);
            this.PF_textBox.Name = "PF_textBox";
            this.PF_textBox.Size = new System.Drawing.Size(100, 22);
            this.PF_textBox.TabIndex = 9;
            this.PF_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Watthr_textBox
            // 
            this.Watthr_textBox.Location = new System.Drawing.Point(212, 171);
            this.Watthr_textBox.Name = "Watthr_textBox";
            this.Watthr_textBox.Size = new System.Drawing.Size(100, 22);
            this.Watthr_textBox.TabIndex = 10;
            this.Watthr_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Interval_textBox
            // 
            this.Interval_textBox.Location = new System.Drawing.Point(377, 171);
            this.Interval_textBox.Name = "Interval_textBox";
            this.Interval_textBox.Size = new System.Drawing.Size(100, 22);
            this.Interval_textBox.TabIndex = 11;
            this.Interval_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Vrms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Irms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Preal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "P.F.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Watt-Hr.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Time";
            // 
            // PA2Test
            // 
            this.PA2Test.Location = new System.Drawing.Point(377, 38);
            this.PA2Test.Name = "PA2Test";
            this.PA2Test.Size = new System.Drawing.Size(108, 36);
            this.PA2Test.TabIndex = 18;
            this.PA2Test.Text = "PA2 OFF";
            this.PA2Test.UseVisualStyleBackColor = true;
            this.PA2Test.Click += new System.EventHandler(this.PA2Test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 253);
            this.Controls.Add(this.PA2Test);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Interval_textBox);
            this.Controls.Add(this.Watthr_textBox);
            this.Controls.Add(this.PF_textBox);
            this.Controls.Add(this.Preal_textBox);
            this.Controls.Add(this.Irms_textBox);
            this.Controls.Add(this.Vrms_textBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PortComboBox);
            this.Name = "Form1";
            this.Text = "PA2 Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortComboBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox Vrms_textBox;
        private System.Windows.Forms.TextBox Irms_textBox;
        private System.Windows.Forms.TextBox Preal_textBox;
        private System.Windows.Forms.TextBox PF_textBox;
        private System.Windows.Forms.TextBox Watthr_textBox;
        private System.Windows.Forms.TextBox Interval_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PA2Test;
    }
}

