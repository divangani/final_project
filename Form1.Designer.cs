﻿namespace WindowsFormsApplication5
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
            this.components = new System.ComponentModel.Container();
            this.Mpanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Mpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mpanel
            // 
            this.Mpanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Mpanel.Controls.Add(this.button7);
            this.Mpanel.Controls.Add(this.button6);
            this.Mpanel.Controls.Add(this.button5);
            this.Mpanel.Controls.Add(this.button4);
            this.Mpanel.Controls.Add(this.button3);
            this.Mpanel.Controls.Add(this.button2);
            this.Mpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Mpanel.Location = new System.Drawing.Point(40, 0);
            this.Mpanel.Name = "Mpanel";
            this.Mpanel.Size = new System.Drawing.Size(129, 283);
            this.Mpanel.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 42);
            this.button4.TabIndex = 2;
            this.button4.Text = "Stocks";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "Order";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "Registation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 280);
            this.button1.TabIndex = 2;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 283);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 33);
            this.button5.TabIndex = 3;
            this.button5.Text = "Tool";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 184);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 35);
            this.button6.TabIndex = 4;
            this.button6.Text = "Reports";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 225);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(123, 40);
            this.button7.TabIndex = 5;
            this.button7.Text = "Settings";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(478, 283);
            this.Controls.Add(this.Mpanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Mpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mpanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}

