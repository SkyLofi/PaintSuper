namespace WindowsFormsApp1
{
    partial class PaintSuperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintSuperForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Load_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Pen_Tool_Button = new System.Windows.Forms.Button();
            this.Line_Tool_Button = new System.Windows.Forms.Button();
            this.Rectangle_Tool_Button = new System.Windows.Forms.Button();
            this.Circle_Tool_Button = new System.Windows.Forms.Button();
            this.Ellipse_Tool_Button = new System.Windows.Forms.Button();
            this.Color_Button = new System.Windows.Forms.Button();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.Eraser_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1125, 618);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Load_Button
            // 
            this.Load_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Load_Button.FlatAppearance.BorderSize = 3;
            this.Load_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Load_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Load_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load_Button.Location = new System.Drawing.Point(39, 27);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(55, 46);
            this.Load_Button.TabIndex = 1;
            this.Load_Button.Text = "Load";
            this.Load_Button.UseVisualStyleBackColor = true;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Save_Button.FlatAppearance.BorderSize = 3;
            this.Save_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Save_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Button.Location = new System.Drawing.Point(100, 27);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(55, 46);
            this.Save_Button.TabIndex = 2;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Pen_Tool_Button
            // 
            this.Pen_Tool_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Pen_Tool_Button.FlatAppearance.BorderSize = 3;
            this.Pen_Tool_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Pen_Tool_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Pen_Tool_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pen_Tool_Button.Location = new System.Drawing.Point(161, 27);
            this.Pen_Tool_Button.Name = "Pen_Tool_Button";
            this.Pen_Tool_Button.Size = new System.Drawing.Size(55, 46);
            this.Pen_Tool_Button.TabIndex = 3;
            this.Pen_Tool_Button.Text = "Pen";
            this.Pen_Tool_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pen_Tool_Button.UseVisualStyleBackColor = true;
            this.Pen_Tool_Button.Click += new System.EventHandler(this.Pen_Tool_Button_Click);
            // 
            // Line_Tool_Button
            // 
            this.Line_Tool_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Line_Tool_Button.FlatAppearance.BorderSize = 3;
            this.Line_Tool_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Line_Tool_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Line_Tool_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Line_Tool_Button.Location = new System.Drawing.Point(222, 27);
            this.Line_Tool_Button.Name = "Line_Tool_Button";
            this.Line_Tool_Button.Size = new System.Drawing.Size(55, 46);
            this.Line_Tool_Button.TabIndex = 4;
            this.Line_Tool_Button.Text = "Line";
            this.Line_Tool_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Line_Tool_Button.UseVisualStyleBackColor = true;
            this.Line_Tool_Button.Click += new System.EventHandler(this.Line_Tool_Button_Click);
            // 
            // Rectangle_Tool_Button
            // 
            this.Rectangle_Tool_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Rectangle_Tool_Button.FlatAppearance.BorderSize = 3;
            this.Rectangle_Tool_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Rectangle_Tool_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Rectangle_Tool_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rectangle_Tool_Button.Location = new System.Drawing.Point(283, 27);
            this.Rectangle_Tool_Button.Name = "Rectangle_Tool_Button";
            this.Rectangle_Tool_Button.Size = new System.Drawing.Size(55, 46);
            this.Rectangle_Tool_Button.TabIndex = 5;
            this.Rectangle_Tool_Button.Text = "Rectangle";
            this.Rectangle_Tool_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Rectangle_Tool_Button.UseVisualStyleBackColor = true;
            this.Rectangle_Tool_Button.Click += new System.EventHandler(this.Rectangle_Tool_Button_Click);
            // 
            // Circle_Tool_Button
            // 
            this.Circle_Tool_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Circle_Tool_Button.FlatAppearance.BorderSize = 3;
            this.Circle_Tool_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Circle_Tool_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Circle_Tool_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Circle_Tool_Button.Location = new System.Drawing.Point(344, 27);
            this.Circle_Tool_Button.Name = "Circle_Tool_Button";
            this.Circle_Tool_Button.Size = new System.Drawing.Size(55, 46);
            this.Circle_Tool_Button.TabIndex = 6;
            this.Circle_Tool_Button.Text = "Circle";
            this.Circle_Tool_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Circle_Tool_Button.UseVisualStyleBackColor = true;
            this.Circle_Tool_Button.Click += new System.EventHandler(this.Circle_Tool_Button_Click);
            // 
            // Ellipse_Tool_Button
            // 
            this.Ellipse_Tool_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Ellipse_Tool_Button.FlatAppearance.BorderSize = 3;
            this.Ellipse_Tool_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Ellipse_Tool_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Ellipse_Tool_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ellipse_Tool_Button.Location = new System.Drawing.Point(405, 27);
            this.Ellipse_Tool_Button.Name = "Ellipse_Tool_Button";
            this.Ellipse_Tool_Button.Size = new System.Drawing.Size(55, 46);
            this.Ellipse_Tool_Button.TabIndex = 7;
            this.Ellipse_Tool_Button.Text = "Ellipse";
            this.Ellipse_Tool_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Ellipse_Tool_Button.UseVisualStyleBackColor = true;
            this.Ellipse_Tool_Button.Click += new System.EventHandler(this.Ellipse_Tool_Button_Click);
            // 
            // Color_Button
            // 
            this.Color_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Color_Button.FlatAppearance.BorderSize = 3;
            this.Color_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Color_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Color_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color_Button.Location = new System.Drawing.Point(466, 27);
            this.Color_Button.Name = "Color_Button";
            this.Color_Button.Size = new System.Drawing.Size(55, 46);
            this.Color_Button.TabIndex = 8;
            this.Color_Button.Text = "color";
            this.Color_Button.UseVisualStyleBackColor = true;
            this.Color_Button.Click += new System.EventHandler(this.Color_Button_Click);
            // 
            // Eraser_Button
            // 
            this.Eraser_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Eraser_Button.FlatAppearance.BorderSize = 3;
            this.Eraser_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Eraser_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Eraser_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eraser_Button.Location = new System.Drawing.Point(527, 27);
            this.Eraser_Button.Name = "Eraser_Button";
            this.Eraser_Button.Size = new System.Drawing.Size(55, 46);
            this.Eraser_Button.TabIndex = 9;
            this.Eraser_Button.Text = "Eraser";
            this.Eraser_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eraser_Button.UseVisualStyleBackColor = true;
            this.Eraser_Button.Click += new System.EventHandler(this.Eraser_Button_Click);
            // 
            // PaintSuperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 642);
            this.Controls.Add(this.Eraser_Button);
            this.Controls.Add(this.Color_Button);
            this.Controls.Add(this.Ellipse_Tool_Button);
            this.Controls.Add(this.Circle_Tool_Button);
            this.Controls.Add(this.Rectangle_Tool_Button);
            this.Controls.Add(this.Line_Tool_Button);
            this.Controls.Add(this.Pen_Tool_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Load_Button);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaintSuperForm";
            this.Text = "PaintSuper";
            this.Load += new System.EventHandler(this.PaintSuperForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Load_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Pen_Tool_Button;
        private System.Windows.Forms.Button Line_Tool_Button;
        private System.Windows.Forms.Button Rectangle_Tool_Button;
        private System.Windows.Forms.Button Circle_Tool_Button;
        private System.Windows.Forms.Button Ellipse_Tool_Button;
        private System.Windows.Forms.Button Color_Button;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Button Eraser_Button;
    }
}

