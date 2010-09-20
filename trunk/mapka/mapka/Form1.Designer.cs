namespace mapka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButtonPunkty = new System.Windows.Forms.RadioButton();
            this.radioButtonLinie = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1203, 776);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mm);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(10, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 246);
            this.panel1.TabIndex = 1;
            this.panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.przySkrolnieciu);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButtonPunkty
            // 
            this.radioButtonPunkty.AutoSize = true;
            this.radioButtonPunkty.Location = new System.Drawing.Point(142, 10);
            this.radioButtonPunkty.Name = "radioButtonPunkty";
            this.radioButtonPunkty.Size = new System.Drawing.Size(58, 17);
            this.radioButtonPunkty.TabIndex = 5;
            this.radioButtonPunkty.TabStop = true;
            this.radioButtonPunkty.Text = "Punkty";
            this.radioButtonPunkty.UseVisualStyleBackColor = true;
            this.radioButtonPunkty.CheckedChanged += new System.EventHandler(this.radioButtonPunkty_CheckedChanged);
            // 
            // radioButtonLinie
            // 
            this.radioButtonLinie.AutoSize = true;
            this.radioButtonLinie.Location = new System.Drawing.Point(233, 10);
            this.radioButtonLinie.Name = "radioButtonLinie";
            this.radioButtonLinie.Size = new System.Drawing.Size(47, 17);
            this.radioButtonLinie.TabIndex = 6;
            this.radioButtonLinie.TabStop = true;
            this.radioButtonLinie.Text = "Linie";
            this.radioButtonLinie.UseVisualStyleBackColor = true;
            this.radioButtonLinie.CheckedChanged += new System.EventHandler(this.radioButtonLinie_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(325, 10);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 294);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButtonLinie);
            this.Controls.Add(this.radioButtonPunkty);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.SizeChanged += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Move += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButtonPunkty;
        private System.Windows.Forms.RadioButton radioButtonLinie;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

