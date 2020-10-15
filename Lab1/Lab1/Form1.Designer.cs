namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NetworksComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OutTrafficLabel = new System.Windows.Forms.Label();
            this.InTrafficLabel = new System.Windows.Forms.Label();
            this.InternetLabel = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.IPv6Label = new System.Windows.Forms.Label();
            this.IPv4Label = new System.Windows.Forms.Label();
            this.OnButton = new System.Windows.Forms.Button();
            this.OffButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NetworksComboBox
            // 
            this.NetworksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NetworksComboBox.FormattingEnabled = true;
            this.NetworksComboBox.Location = new System.Drawing.Point(12, 18);
            this.NetworksComboBox.Name = "NetworksComboBox";
            this.NetworksComboBox.Size = new System.Drawing.Size(388, 24);
            this.NetworksComboBox.TabIndex = 0;
            this.NetworksComboBox.SelectedIndexChanged += new System.EventHandler(this.NetworksComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IPv4:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "IPv6:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Internet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Out:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "In:";
            // 
            // OutTrafficLabel
            // 
            this.OutTrafficLabel.AutoSize = true;
            this.OutTrafficLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutTrafficLabel.Location = new System.Drawing.Point(50, 236);
            this.OutTrafficLabel.Name = "OutTrafficLabel";
            this.OutTrafficLabel.Size = new System.Drawing.Size(63, 20);
            this.OutTrafficLabel.TabIndex = 12;
            this.OutTrafficLabel.Text = "0 bytes";
            // 
            // InTrafficLabel
            // 
            this.InTrafficLabel.AutoSize = true;
            this.InTrafficLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InTrafficLabel.Location = new System.Drawing.Point(38, 202);
            this.InTrafficLabel.Name = "InTrafficLabel";
            this.InTrafficLabel.Size = new System.Drawing.Size(63, 20);
            this.InTrafficLabel.TabIndex = 11;
            this.InTrafficLabel.Text = "0 bytes";
            // 
            // InternetLabel
            // 
            this.InternetLabel.AutoSize = true;
            this.InternetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InternetLabel.Location = new System.Drawing.Point(88, 167);
            this.InternetLabel.Name = "InternetLabel";
            this.InternetLabel.Size = new System.Drawing.Size(107, 20);
            this.InternetLabel.TabIndex = 10;
            this.InternetLabel.Text = "Not Available";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StateLabel.Location = new System.Drawing.Point(67, 133);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(48, 20);
            this.StateLabel.TabIndex = 9;
            this.StateLabel.Text = "State";
            // 
            // IPv6Label
            // 
            this.IPv6Label.AutoSize = true;
            this.IPv6Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IPv6Label.Location = new System.Drawing.Point(60, 101);
            this.IPv6Label.Name = "IPv6Label";
            this.IPv6Label.Size = new System.Drawing.Size(41, 20);
            this.IPv6Label.TabIndex = 8;
            this.IPv6Label.Text = "Text";
            // 
            // IPv4Label
            // 
            this.IPv4Label.AutoSize = true;
            this.IPv4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IPv4Label.Location = new System.Drawing.Point(60, 67);
            this.IPv4Label.Name = "IPv4Label";
            this.IPv4Label.Size = new System.Drawing.Size(41, 20);
            this.IPv4Label.TabIndex = 7;
            this.IPv4Label.Text = "Text";
            // 
            // OnButton
            // 
            this.OnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OnButton.Location = new System.Drawing.Point(12, 275);
            this.OnButton.Name = "OnButton";
            this.OnButton.Size = new System.Drawing.Size(187, 43);
            this.OnButton.TabIndex = 13;
            this.OnButton.Text = "Turn ON";
            this.OnButton.UseVisualStyleBackColor = true;
            this.OnButton.Click += new System.EventHandler(this.OnButton_Click);
            // 
            // OffButton
            // 
            this.OffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OffButton.Location = new System.Drawing.Point(213, 275);
            this.OffButton.Name = "OffButton";
            this.OffButton.Size = new System.Drawing.Size(187, 43);
            this.OffButton.TabIndex = 14;
            this.OffButton.Text = "Turn OFF";
            this.OffButton.UseVisualStyleBackColor = true;
            this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 330);
            this.Controls.Add(this.OffButton);
            this.Controls.Add(this.OnButton);
            this.Controls.Add(this.OutTrafficLabel);
            this.Controls.Add(this.InTrafficLabel);
            this.Controls.Add(this.InternetLabel);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.IPv6Label);
            this.Controls.Add(this.IPv4Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NetworksComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "NetworkObserver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NetworksComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label OutTrafficLabel;
        private System.Windows.Forms.Label InTrafficLabel;
        private System.Windows.Forms.Label InternetLabel;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label IPv6Label;
        private System.Windows.Forms.Label IPv4Label;
        private System.Windows.Forms.Button OnButton;
        private System.Windows.Forms.Button OffButton;
    }
}

