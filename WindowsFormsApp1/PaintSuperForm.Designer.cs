﻿namespace WindowsFormsApp1
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
            this.Ellipse_Tool_Button = new System.Windows.Forms.Button();
            this.Color_Button = new System.Windows.Forms.Button();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.Eraser_Button = new System.Windows.Forms.Button();
            this.Circle_Tool_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Pentagon_Button = new System.Windows.Forms.Button();
            this.Redo_Button = new System.Windows.Forms.Button();
            this.Undo_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Load_Button
            // 
            this.Load_Button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Load_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Load_Button.FlatAppearance.BorderSize = 3;
            this.Load_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Load_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Load_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load_Button.Location = new System.Drawing.Point(36, 26);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(55, 46);
            this.Load_Button.TabIndex = 1;
            this.Load_Button.Text = "Load";
            this.Load_Button.UseVisualStyleBackColor = false;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Save_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Save_Button.FlatAppearance.BorderSize = 3;
            this.Save_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Save_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Button.Location = new System.Drawing.Point(97, 26);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(55, 46);
            this.Save_Button.TabIndex = 2;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Pen_Tool_Button
            // 
            this.Pen_Tool_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Pen_Tool_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Pen_Tool_Button.FlatAppearance.BorderSize = 3;
            this.Pen_Tool_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Pen_Tool_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Pen_Tool_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pen_Tool_Button.Image = global::WindowsFormsApp1.Properties.Resources.pencil;
            this.Pen_Tool_Button.Location = new System.Drawing.Point(199, 26);
            this.Pen_Tool_Button.Name = "Pen_Tool_Button";
            this.Pen_Tool_Button.Size = new System.Drawing.Size(55, 46);
            this.Pen_Tool_Button.TabIndex = 3;
            this.Pen_Tool_Button.Text = "Pen";
            this.Pen_Tool_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pen_Tool_Button.UseVisualStyleBackColor = false;
            this.Pen_Tool_Button.Click += new System.EventHandler(this.Pen_Tool_Button_Click);
            // 
            // Line_Tool_Button
            // 
            this.Line_Tool_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Line_Tool_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Line_Tool_Button.FlatAppearance.BorderSize = 3;
            this.Line_Tool_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Line_Tool_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Line_Tool_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Line_Tool_Button.Image = global::WindowsFormsApp1.Properties.Resources.line;
            this.Line_Tool_Button.Location = new System.Drawing.Point(260, 26);
            this.Line_Tool_Button.Name = "Line_Tool_Button";
            this.Line_Tool_Button.Size = new System.Drawing.Size(55, 46);
            this.Line_Tool_Button.TabIndex = 4;
            this.Line_Tool_Button.Text = "Line";
            this.Line_Tool_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Line_Tool_Button.UseVisualStyleBackColor = false;
            this.Line_Tool_Button.Click += new System.EventHandler(this.Line_Tool_Button_Click);
            // 
            // Rectangle_Tool_Button
            // 
            this.Rectangle_Tool_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Rectangle_Tool_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Rectangle_Tool_Button.FlatAppearance.BorderSize = 3;
            this.Rectangle_Tool_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Rectangle_Tool_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Rectangle_Tool_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rectangle_Tool_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rectangle_Tool_Button.Image = global::WindowsFormsApp1.Properties.Resources.rectangle;
            this.Rectangle_Tool_Button.Location = new System.Drawing.Point(321, 26);
            this.Rectangle_Tool_Button.Name = "Rectangle_Tool_Button";
            this.Rectangle_Tool_Button.Size = new System.Drawing.Size(55, 46);
            this.Rectangle_Tool_Button.TabIndex = 5;
            this.Rectangle_Tool_Button.Text = "Rectangle";
            this.Rectangle_Tool_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Rectangle_Tool_Button.UseVisualStyleBackColor = false;
            this.Rectangle_Tool_Button.Click += new System.EventHandler(this.Rectangle_Tool_Button_Click);
            // 
            // Ellipse_Tool_Button
            // 
            this.Ellipse_Tool_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Ellipse_Tool_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Ellipse_Tool_Button.FlatAppearance.BorderSize = 3;
            this.Ellipse_Tool_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Ellipse_Tool_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Ellipse_Tool_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ellipse_Tool_Button.Image = global::WindowsFormsApp1.Properties.Resources.circle;
            this.Ellipse_Tool_Button.Location = new System.Drawing.Point(382, 26);
            this.Ellipse_Tool_Button.Name = "Ellipse_Tool_Button";
            this.Ellipse_Tool_Button.Size = new System.Drawing.Size(55, 46);
            this.Ellipse_Tool_Button.TabIndex = 7;
            this.Ellipse_Tool_Button.Text = "Ellipse";
            this.Ellipse_Tool_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Ellipse_Tool_Button.UseVisualStyleBackColor = false;
            this.Ellipse_Tool_Button.Click += new System.EventHandler(this.Ellipse_Tool_Button_Click);
            // 
            // Color_Button
            // 
            this.Color_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Color_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Color_Button.FlatAppearance.BorderSize = 3;
            this.Color_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Color_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Color_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color_Button.Image = global::WindowsFormsApp1.Properties.Resources.color;
            this.Color_Button.Location = new System.Drawing.Point(582, 26);
            this.Color_Button.Name = "Color_Button";
            this.Color_Button.Size = new System.Drawing.Size(55, 46);
            this.Color_Button.TabIndex = 8;
            this.Color_Button.Text = "color";
            this.Color_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Color_Button.UseVisualStyleBackColor = false;
            this.Color_Button.Click += new System.EventHandler(this.Color_Button_Click);
            // 
            // Eraser_Button
            // 
            this.Eraser_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Eraser_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Eraser_Button.FlatAppearance.BorderSize = 3;
            this.Eraser_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Eraser_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Eraser_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eraser_Button.Image = global::WindowsFormsApp1.Properties.Resources.eraser;
            this.Eraser_Button.Location = new System.Drawing.Point(643, 26);
            this.Eraser_Button.Name = "Eraser_Button";
            this.Eraser_Button.Size = new System.Drawing.Size(55, 46);
            this.Eraser_Button.TabIndex = 9;
            this.Eraser_Button.Text = "Eraser";
            this.Eraser_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eraser_Button.UseVisualStyleBackColor = false;
            this.Eraser_Button.Click += new System.EventHandler(this.Eraser_Button_Click);
            // 
            // Circle_Tool_Button
            // 
            this.Circle_Tool_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Circle_Tool_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Circle_Tool_Button.FlatAppearance.BorderSize = 3;
            this.Circle_Tool_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Circle_Tool_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Circle_Tool_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Circle_Tool_Button.Image = global::WindowsFormsApp1.Properties.Resources.circle;
            this.Circle_Tool_Button.Location = new System.Drawing.Point(443, 26);
            this.Circle_Tool_Button.Name = "Circle_Tool_Button";
            this.Circle_Tool_Button.Size = new System.Drawing.Size(55, 46);
            this.Circle_Tool_Button.TabIndex = 10;
            this.Circle_Tool_Button.Text = "Circle";
            this.Circle_Tool_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Circle_Tool_Button.UseVisualStyleBackColor = false;
            this.Circle_Tool_Button.Click += new System.EventHandler(this.Circle_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Clear_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Clear_Button.FlatAppearance.BorderSize = 3;
            this.Clear_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Clear_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Button.Location = new System.Drawing.Point(722, 26);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(55, 46);
            this.Clear_Button.TabIndex = 11;
            this.Clear_Button.Text = "New";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Pentagon_Button
            // 
            this.Pentagon_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Pentagon_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Pentagon_Button.FlatAppearance.BorderSize = 3;
            this.Pentagon_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Pentagon_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Pentagon_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pentagon_Button.Location = new System.Drawing.Point(504, 26);
            this.Pentagon_Button.Name = "Pentagon_Button";
            this.Pentagon_Button.Size = new System.Drawing.Size(55, 46);
            this.Pentagon_Button.TabIndex = 12;
            this.Pentagon_Button.Text = "pentagon";
            this.Pentagon_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pentagon_Button.UseVisualStyleBackColor = false;
            this.Pentagon_Button.Click += new System.EventHandler(this.Polygon_Button_Click);
            // 
            // Redo_Button
            // 
            this.Redo_Button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Redo_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Redo_Button.FlatAppearance.BorderSize = 3;
            this.Redo_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Redo_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Redo_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Redo_Button.Location = new System.Drawing.Point(97, 78);
            this.Redo_Button.Name = "Redo_Button";
            this.Redo_Button.Size = new System.Drawing.Size(55, 46);
            this.Redo_Button.TabIndex = 13;
            this.Redo_Button.Text = "Redo";
            this.Redo_Button.UseVisualStyleBackColor = false;
            this.Redo_Button.Click += new System.EventHandler(this.Redo_Button_Click);
            // 
            // Undo_Button
            // 
            this.Undo_Button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Undo_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Undo_Button.FlatAppearance.BorderSize = 3;
            this.Undo_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Undo_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Undo_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Undo_Button.Location = new System.Drawing.Point(36, 78);
            this.Undo_Button.Name = "Undo_Button";
            this.Undo_Button.Size = new System.Drawing.Size(55, 46);
            this.Undo_Button.TabIndex = 14;
            this.Undo_Button.Text = "Undo";
            this.Undo_Button.UseVisualStyleBackColor = false;
            this.Undo_Button.Click += new System.EventHandler(this.Undo_Button_Click);
            // 
            // PaintSuperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 572);
            this.Controls.Add(this.Undo_Button);
            this.Controls.Add(this.Redo_Button);
            this.Controls.Add(this.Pentagon_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Circle_Tool_Button);
            this.Controls.Add(this.Eraser_Button);
            this.Controls.Add(this.Color_Button);
            this.Controls.Add(this.Ellipse_Tool_Button);
            this.Controls.Add(this.Rectangle_Tool_Button);
            this.Controls.Add(this.Line_Tool_Button);
            this.Controls.Add(this.Pen_Tool_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Load_Button);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(837, 578);
            this.Name = "PaintSuperForm";
            this.Text = "PaintSuper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaintSuperForm_FormClosing);
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
        private System.Windows.Forms.Button Ellipse_Tool_Button;
        private System.Windows.Forms.Button Color_Button;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Button Eraser_Button;
        private System.Windows.Forms.Button Circle_Tool_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Pentagon_Button;
        private System.Windows.Forms.Button Redo_Button;
        private System.Windows.Forms.Button Undo_Button;
    }
}

