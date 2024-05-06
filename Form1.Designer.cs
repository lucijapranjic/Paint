namespace Paint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.PictureBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.File = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.File.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Controls.Add(this.colorPicker);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.btnFill);
            this.panel1.Controls.Add(this.btnPencil);
            this.panel1.Controls.Add(this.btnEraser);
            this.panel1.Controls.Add(this.btnEllipse);
            this.panel1.Controls.Add(this.File);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 128);
            this.panel1.TabIndex = 0;
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.White;
            this.btnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.ForeColor = System.Drawing.Color.Black;
            this.btnLine.Image = global::Paint.Properties.Resources.line;
            this.btnLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLine.Location = new System.Drawing.Point(622, 48);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(68, 52);
            this.btnLine.TabIndex = 13;
            this.btnLine.Text = "Line";
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.White;
            this.btnRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.ForeColor = System.Drawing.Color.Black;
            this.btnRectangle.Image = global::Paint.Properties.Resources.rectangle;
            this.btnRectangle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRectangle.Location = new System.Drawing.Point(557, 48);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(68, 52);
            this.btnRectangle.TabIndex = 12;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(212, 39);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(75, 71);
            this.pic_color.TabIndex = 11;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // colorPicker
            // 
            this.colorPicker.Image = global::Paint.Properties.Resources.color_palette;
            this.colorPicker.Location = new System.Drawing.Point(12, 29);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(194, 91);
            this.colorPicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorPicker.TabIndex = 10;
            this.colorPicker.TabStop = false;
            this.colorPicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorPicker_MouseClick);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.White;
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.ForeColor = System.Drawing.Color.Black;
            this.btnColor.Image = global::Paint.Properties.Resources.color;
            this.btnColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColor.Location = new System.Drawing.Point(293, 48);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(56, 52);
            this.btnColor.TabIndex = 9;
            this.btnColor.Text = "Color";
            this.btnColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.White;
            this.btnFill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFill.ForeColor = System.Drawing.Color.Black;
            this.btnFill.Image = global::Paint.Properties.Resources.bucket;
            this.btnFill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFill.Location = new System.Drawing.Point(345, 48);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(56, 52);
            this.btnFill.TabIndex = 8;
            this.btnFill.Text = "Fill";
            this.btnFill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.BackColor = System.Drawing.Color.White;
            this.btnPencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPencil.ForeColor = System.Drawing.Color.Black;
            this.btnPencil.Image = global::Paint.Properties.Resources.pencil;
            this.btnPencil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPencil.Location = new System.Drawing.Point(398, 48);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(56, 52);
            this.btnPencil.TabIndex = 7;
            this.btnPencil.Text = "Pencil";
            this.btnPencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPencil.UseVisualStyleBackColor = false;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.BackColor = System.Drawing.Color.White;
            this.btnEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraser.ForeColor = System.Drawing.Color.Black;
            this.btnEraser.Image = global::Paint.Properties.Resources.eraser;
            this.btnEraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEraser.Location = new System.Drawing.Point(451, 48);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(56, 52);
            this.btnEraser.TabIndex = 6;
            this.btnEraser.Text = "Eraser";
            this.btnEraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.White;
            this.btnEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEllipse.ForeColor = System.Drawing.Color.Black;
            this.btnEllipse.Image = global::Paint.Properties.Resources.circle;
            this.btnEllipse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEllipse.Location = new System.Drawing.Point(504, 48);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(56, 52);
            this.btnEllipse.TabIndex = 5;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 100);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 128);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(784, 283);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // File
            // 
            this.File.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.File.Location = new System.Drawing.Point(0, 0);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(784, 24);
            this.File.TabIndex = 16;
            this.File.Text = "File";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(180, 22);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Open";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Clear";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "Copy";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "Paste";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(687, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add Image";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.File;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.File.ResumeLayout(false);
            this.File.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.PictureBox colorPicker;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.MenuStrip File;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Button button1;
    }
}

