namespace Speak_Text
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Start_BTN = new System.Windows.Forms.Button();
            this.Stop_BTN = new System.Windows.Forms.Button();
            this.volume_trackBar = new System.Windows.Forms.TrackBar();
            this.sound_value_label = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.PictureBox();
            this.clear = new System.Windows.Forms.PictureBox();
            this.copy = new System.Windows.Forms.PictureBox();
            this.paste = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.volume_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paste)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Aqua;
            this.richTextBox1.Location = new System.Drawing.Point(26, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(333, 155);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Start_BTN
            // 
            this.Start_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Start_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Start_BTN.Image")));
            this.Start_BTN.Location = new System.Drawing.Point(159, 207);
            this.Start_BTN.Name = "Start_BTN";
            this.Start_BTN.Size = new System.Drawing.Size(87, 52);
            this.Start_BTN.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Start_BTN, "Speak");
            this.Start_BTN.UseVisualStyleBackColor = false;
            this.Start_BTN.Click += new System.EventHandler(this.Start_BTN_Click);
            // 
            // Stop_BTN
            // 
            this.Stop_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Stop_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stop_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Stop_BTN.Image")));
            this.Stop_BTN.Location = new System.Drawing.Point(159, 207);
            this.Stop_BTN.Name = "Stop_BTN";
            this.Stop_BTN.Size = new System.Drawing.Size(87, 52);
            this.Stop_BTN.TabIndex = 2;
            this.toolTip1.SetToolTip(this.Stop_BTN, "Pause");
            this.Stop_BTN.UseVisualStyleBackColor = false;
            this.Stop_BTN.Visible = false;
            this.Stop_BTN.Click += new System.EventHandler(this.Stop_BTN_Click);
            // 
            // volume_trackBar
            // 
            this.volume_trackBar.Location = new System.Drawing.Point(9, 277);
            this.volume_trackBar.Maximum = 100;
            this.volume_trackBar.Name = "volume_trackBar";
            this.volume_trackBar.Size = new System.Drawing.Size(104, 45);
            this.volume_trackBar.TabIndex = 3;
            this.volume_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volume_trackBar.Value = 100;
            this.volume_trackBar.Scroll += new System.EventHandler(this.Volume_trackBar_Scroll);
            // 
            // sound_value_label
            // 
            this.sound_value_label.AutoSize = true;
            this.sound_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sound_value_label.ForeColor = System.Drawing.Color.Yellow;
            this.sound_value_label.Location = new System.Drawing.Point(21, 263);
            this.sound_value_label.Name = "sound_value_label";
            this.sound_value_label.Size = new System.Drawing.Size(37, 13);
            this.sound_value_label.TabIndex = 4;
            this.sound_value_label.Text = "100%";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.status_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.status_label.Location = new System.Drawing.Point(29, 25);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(134, 15);
            this.status_label.TabIndex = 5;
            this.status_label.Text = "Write the text to be read";
            // 
            // restart
            // 
            this.restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restart.Image = ((System.Drawing.Image)(resources.GetObject("restart.Image")));
            this.restart.Location = new System.Drawing.Point(365, 57);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(29, 25);
            this.restart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restart.TabIndex = 6;
            this.restart.TabStop = false;
            this.toolTip1.SetToolTip(this.restart, "Restart");
            this.restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // clear
            // 
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Image = ((System.Drawing.Image)(resources.GetObject("clear.Image")));
            this.clear.Location = new System.Drawing.Point(365, 91);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(29, 25);
            this.clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clear.TabIndex = 7;
            this.clear.TabStop = false;
            this.toolTip1.SetToolTip(this.clear, "Clear");
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // copy
            // 
            this.copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copy.Image = ((System.Drawing.Image)(resources.GetObject("copy.Image")));
            this.copy.Location = new System.Drawing.Point(365, 125);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(29, 25);
            this.copy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.copy.TabIndex = 8;
            this.copy.TabStop = false;
            this.toolTip1.SetToolTip(this.copy, "Copy");
            this.copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // paste
            // 
            this.paste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paste.Image = ((System.Drawing.Image)(resources.GetObject("paste.Image")));
            this.paste.Location = new System.Drawing.Point(365, 159);
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(29, 25);
            this.paste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paste.TabIndex = 9;
            this.paste.TabStop = false;
            this.toolTip1.SetToolTip(this.paste, "Paste");
            this.paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(403, 306);
            this.Controls.Add(this.paste);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.sound_value_label);
            this.Controls.Add(this.volume_trackBar);
            this.Controls.Add(this.Start_BTN);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Stop_BTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speak Text";
            ((System.ComponentModel.ISupportInitialize)(this.volume_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Start_BTN;
        private System.Windows.Forms.Button Stop_BTN;
        private System.Windows.Forms.TrackBar volume_trackBar;
        private System.Windows.Forms.Label sound_value_label;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.PictureBox restart;
        private System.Windows.Forms.PictureBox clear;
        private System.Windows.Forms.PictureBox copy;
        private System.Windows.Forms.PictureBox paste;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

