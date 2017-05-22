using Task4_3_IPControl.Lib;
using Task4_3_IPControl.Lib.control;

namespace Task4_3_IPControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._myIpControl1 = new Task4_3_IPControl.Lib.control.MyIpControl();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _myIpControl1
            // 
            this._myIpControl1.BackColor = System.Drawing.Color.Turquoise;
            this._myIpControl1.Location = new System.Drawing.Point(41, 12);
            this._myIpControl1.MyIpAddress = ((System.Net.IPAddress)(resources.GetObject("_myIpControl1.MyIpAddress")));
            this._myIpControl1.Name = "_myIpControl1";
            this._myIpControl1.Size = new System.Drawing.Size(100, 20);
            this._myIpControl1.TabIndex = 2;
            this._myIpControl1.Text = "0.0.0.0";
            this._myIpControl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(55, 46);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 81);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this._myIpControl1);
            this.Name = "Form1";
            this.Text = "Ip Address Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyIpControl _myIpControl1;
        private System.Windows.Forms.Button resetButton;


    }
}

