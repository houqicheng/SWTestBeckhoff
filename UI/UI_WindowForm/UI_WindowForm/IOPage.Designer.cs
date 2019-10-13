namespace UI_WindowForm
{
    partial class IOPage
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
            this.ioBtnLamp01 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ioBtnLamp04 = new System.Windows.Forms.Button();
            this.ioBtnLamp03 = new System.Windows.Forms.Button();
            this.ioBtnLamp02 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ioBtnLamp01
            // 
            this.ioBtnLamp01.Location = new System.Drawing.Point(20, 33);
            this.ioBtnLamp01.Name = "ioBtnLamp01";
            this.ioBtnLamp01.Size = new System.Drawing.Size(107, 39);
            this.ioBtnLamp01.TabIndex = 0;
            this.ioBtnLamp01.Text = "Lamp01";
            this.ioBtnLamp01.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Blue;
            this.groupBox1.Controls.Add(this.ioBtnLamp04);
            this.groupBox1.Controls.Add(this.ioBtnLamp03);
            this.groupBox1.Controls.Add(this.ioBtnLamp02);
            this.groupBox1.Controls.Add(this.ioBtnLamp01);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 268);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output List";
            // 
            // ioBtnLamp04
            // 
            this.ioBtnLamp04.Location = new System.Drawing.Point(20, 210);
            this.ioBtnLamp04.Name = "ioBtnLamp04";
            this.ioBtnLamp04.Size = new System.Drawing.Size(107, 39);
            this.ioBtnLamp04.TabIndex = 3;
            this.ioBtnLamp04.Text = "Lamp04";
            this.ioBtnLamp04.UseVisualStyleBackColor = true;
            // 
            // ioBtnLamp03
            // 
            this.ioBtnLamp03.Location = new System.Drawing.Point(20, 152);
            this.ioBtnLamp03.Name = "ioBtnLamp03";
            this.ioBtnLamp03.Size = new System.Drawing.Size(107, 39);
            this.ioBtnLamp03.TabIndex = 2;
            this.ioBtnLamp03.Text = "Lamp03";
            this.ioBtnLamp03.UseVisualStyleBackColor = true;
            // 
            // ioBtnLamp02
            // 
            this.ioBtnLamp02.Location = new System.Drawing.Point(20, 90);
            this.ioBtnLamp02.Name = "ioBtnLamp02";
            this.ioBtnLamp02.Size = new System.Drawing.Size(107, 39);
            this.ioBtnLamp02.TabIndex = 1;
            this.ioBtnLamp02.Text = "Lamp02";
            this.ioBtnLamp02.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Blue;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(457, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 268);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input List";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lamp04";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 39);
            this.button3.TabIndex = 1;
            this.button3.Text = "Pause";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 39);
            this.button4.TabIndex = 0;
            this.button4.Text = "Start";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // IOPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 636);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IOPage";
            this.Text = "IOPage";
            this.Load += new System.EventHandler(this.IOPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ioBtnLamp01;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ioBtnLamp04;
        private System.Windows.Forms.Button ioBtnLamp03;
        private System.Windows.Forms.Button ioBtnLamp02;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}