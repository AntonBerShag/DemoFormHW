namespace ClassWork09._11._2022
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
            this.labelResoltion2 = new System.Windows.Forms.Label();
            this.buttonMake8angle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonRun = new System.Windows.Forms.Button();
            this.richTextBoxRun = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelResoltion2
            // 
            this.labelResoltion2.AutoSize = true;
            this.labelResoltion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResoltion2.Location = new System.Drawing.Point(48, 38);
            this.labelResoltion2.Name = "labelResoltion2";
            this.labelResoltion2.Size = new System.Drawing.Size(205, 24);
            this.labelResoltion2.TabIndex = 1;
            this.labelResoltion2.Text = "Разрешение экрана";
            // 
            // buttonMake8angle
            // 
            this.buttonMake8angle.Location = new System.Drawing.Point(105, 12);
            this.buttonMake8angle.Name = "buttonMake8angle";
            this.buttonMake8angle.Size = new System.Drawing.Size(75, 23);
            this.buttonMake8angle.TabIndex = 2;
            this.buttonMake8angle.Text = "8-угольник";
            this.buttonMake8angle.UseVisualStyleBackColor = true;
            this.buttonMake8angle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonMake8angle_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(67, 207);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(103, 23);
            this.buttonRun.TabIndex = 4;
            this.buttonRun.Text = "Выбрать файл";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonRun_MouseClick);
            // 
            // richTextBoxRun
            // 
            this.richTextBoxRun.Location = new System.Drawing.Point(52, 155);
            this.richTextBoxRun.Name = "richTextBoxRun";
            this.richTextBoxRun.Size = new System.Drawing.Size(309, 46);
            this.richTextBoxRun.TabIndex = 5;
            this.richTextBoxRun.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxRun);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonMake8angle);
            this.Controls.Add(this.labelResoltion2);
            this.Name = "Form1";
            this.Text = "Расширение экрана";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick_1);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelResoltion2;
        private System.Windows.Forms.Button buttonMake8angle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.RichTextBox richTextBoxRun;
    }
}

