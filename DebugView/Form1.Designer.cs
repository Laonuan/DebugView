﻿namespace DebugView
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonReflash = new System.Windows.Forms.Button();
            this.buttonAutoReflash = new System.Windows.Forms.Button();
            this.buttonSize = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.checkBoxAutoScroll = new System.Windows.Forms.CheckBox();
            this.buttonSide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLog.Location = new System.Drawing.Point(12, 39);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(600, 664);
            this.richTextBoxLog.TabIndex = 6;
            this.richTextBoxLog.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonReflash
            // 
            this.buttonReflash.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonReflash.Location = new System.Drawing.Point(12, 709);
            this.buttonReflash.Name = "buttonReflash";
            this.buttonReflash.Size = new System.Drawing.Size(75, 23);
            this.buttonReflash.TabIndex = 0;
            this.buttonReflash.Text = "Refresh";
            this.buttonReflash.UseVisualStyleBackColor = true;
            this.buttonReflash.Click += new System.EventHandler(this.buttonReflash_Click);
            // 
            // buttonAutoReflash
            // 
            this.buttonAutoReflash.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAutoReflash.Location = new System.Drawing.Point(363, 709);
            this.buttonAutoReflash.Name = "buttonAutoReflash";
            this.buttonAutoReflash.Size = new System.Drawing.Size(86, 23);
            this.buttonAutoReflash.TabIndex = 2;
            this.buttonAutoReflash.Text = "Auto Refresh";
            this.buttonAutoReflash.UseVisualStyleBackColor = true;
            this.buttonAutoReflash.Click += new System.EventHandler(this.buttonAutoReflash_Click);
            // 
            // buttonSize
            // 
            this.buttonSize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSize.Location = new System.Drawing.Point(246, 709);
            this.buttonSize.Name = "buttonSize";
            this.buttonSize.Size = new System.Drawing.Size(75, 23);
            this.buttonSize.TabIndex = 1;
            this.buttonSize.Tag = "";
            this.buttonSize.Text = "Reduce";
            this.buttonSize.UseVisualStyleBackColor = true;
            this.buttonSize.Click += new System.EventHandler(this.buttonSize_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(531, 10);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(80, 23);
            this.buttonOpenFile.TabIndex = 5;
            this.buttonOpenFile.Text = "Select File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(12, 12);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(513, 21);
            this.textBoxFilePath.TabIndex = 4;
            this.textBoxFilePath.TextChanged += new System.EventHandler(this.textBoxFilePath_TextChanged);
            // 
            // checkBoxAutoScroll
            // 
            this.checkBoxAutoScroll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBoxAutoScroll.AutoSize = true;
            this.checkBoxAutoScroll.Location = new System.Drawing.Point(521, 713);
            this.checkBoxAutoScroll.Name = "checkBoxAutoScroll";
            this.checkBoxAutoScroll.Size = new System.Drawing.Size(90, 16);
            this.checkBoxAutoScroll.TabIndex = 3;
            this.checkBoxAutoScroll.Text = "Auto Scroll";
            this.checkBoxAutoScroll.UseVisualStyleBackColor = true;
            // 
            // buttonSide
            // 
            this.buttonSide.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSide.Location = new System.Drawing.Point(129, 709);
            this.buttonSide.Name = "buttonSide";
            this.buttonSide.Size = new System.Drawing.Size(75, 23);
            this.buttonSide.TabIndex = 7;
            this.buttonSide.Text = "Right Side";
            this.buttonSide.UseVisualStyleBackColor = true;
            this.buttonSide.Click += new System.EventHandler(this.btnSide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 741);
            this.Controls.Add(this.buttonSide);
            this.Controls.Add(this.checkBoxAutoScroll);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.buttonSize);
            this.Controls.Add(this.buttonAutoReflash);
            this.Controls.Add(this.buttonReflash);
            this.Controls.Add(this.richTextBoxLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Tag = "";
            this.Text = "DebugView";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonReflash;
        private System.Windows.Forms.Button buttonAutoReflash;
        private System.Windows.Forms.Button buttonSize;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.CheckBox checkBoxAutoScroll;
        private System.Windows.Forms.Button buttonSide;
    }
}

