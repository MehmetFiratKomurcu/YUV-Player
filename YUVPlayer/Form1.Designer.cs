namespace YUVPlayer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.widthTB = new System.Windows.Forms.TextBox();
            this.heightTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radio444 = new System.Windows.Forms.RadioButton();
            this.radio422 = new System.Windows.Forms.RadioButton();
            this.radio420 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pathTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(887, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(884, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // widthTB
            // 
            this.widthTB.Location = new System.Drawing.Point(948, 16);
            this.widthTB.Name = "widthTB";
            this.widthTB.Size = new System.Drawing.Size(141, 20);
            this.widthTB.TabIndex = 2;
            // 
            // heightTB
            // 
            this.heightTB.Location = new System.Drawing.Point(948, 59);
            this.heightTB.Name = "heightTB";
            this.heightTB.Size = new System.Drawing.Size(141, 20);
            this.heightTB.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(887, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Convert .YUV to .BMP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radio444
            // 
            this.radio444.AutoSize = true;
            this.radio444.Checked = true;
            this.radio444.Location = new System.Drawing.Point(887, 127);
            this.radio444.Name = "radio444";
            this.radio444.Size = new System.Drawing.Size(49, 17);
            this.radio444.TabIndex = 5;
            this.radio444.TabStop = true;
            this.radio444.Text = "4:4:4";
            this.radio444.UseVisualStyleBackColor = true;
            // 
            // radio422
            // 
            this.radio422.AutoSize = true;
            this.radio422.Location = new System.Drawing.Point(887, 150);
            this.radio422.Name = "radio422";
            this.radio422.Size = new System.Drawing.Size(49, 17);
            this.radio422.TabIndex = 6;
            this.radio422.TabStop = true;
            this.radio422.Text = "4:2:2";
            this.radio422.UseVisualStyleBackColor = true;
            // 
            // radio420
            // 
            this.radio420.AutoSize = true;
            this.radio420.Location = new System.Drawing.Point(887, 173);
            this.radio420.Name = "radio420";
            this.radio420.Size = new System.Drawing.Size(49, 17);
            this.radio420.TabIndex = 7;
            this.radio420.TabStop = true;
            this.radio420.Text = "4:2:0";
            this.radio420.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(884, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "YUV Formats";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1014, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Select File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pathTB
            // 
            this.pathTB.Location = new System.Drawing.Point(948, 201);
            this.pathTB.Name = "pathTB";
            this.pathTB.Size = new System.Drawing.Size(141, 20);
            this.pathTB.TabIndex = 10;
            this.pathTB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(884, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Path:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(843, 464);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(351, 491);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 14;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(454, 491);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 15;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 526);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pathTB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radio420);
            this.Controls.Add(this.radio422);
            this.Controls.Add(this.radio444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.heightTB);
            this.Controls.Add(this.widthTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox widthTB;
        protected System.Windows.Forms.TextBox heightTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radio444;
        private System.Windows.Forms.RadioButton radio422;
        private System.Windows.Forms.RadioButton radio420;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox pathTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
    }
}

