namespace Mandelbrot_MINA
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.updnTreshold = new System.Windows.Forms.NumericUpDown();
      this.lblValues = new System.Windows.Forms.Label();
      this.chkColor = new System.Windows.Forms.CheckBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.btnLeft = new System.Windows.Forms.Button();
      this.btnUp = new System.Windows.Forms.Button();
      this.btnDown = new System.Windows.Forms.Button();
      this.btnRight = new System.Windows.Forms.Button();
      this.btnZoomIn = new System.Windows.Forms.Button();
      this.lblTime = new System.Windows.Forms.Label();
      this.pbRealSize = new System.Windows.Forms.PictureBox();
      this.btnZoomOut = new System.Windows.Forms.Button();
      this.btnReset = new System.Windows.Forms.Button();
      this.pbZoomed = new System.Windows.Forms.PictureBox();
      this.label2 = new System.Windows.Forms.Label();
      this.updnCenter = new System.Windows.Forms.NumericUpDown();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.updnTreshold)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbRealSize)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbZoomed)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.updnCenter)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.updnCenter);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.updnTreshold);
      this.panel1.Controls.Add(this.lblValues);
      this.panel1.Controls.Add(this.chkColor);
      this.panel1.Controls.Add(this.tableLayoutPanel1);
      this.panel1.Controls.Add(this.lblTime);
      this.panel1.Controls.Add(this.pbRealSize);
      this.panel1.Controls.Add(this.btnZoomOut);
      this.panel1.Controls.Add(this.btnReset);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(714, 90);
      this.panel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(325, 64);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(77, 13);
      this.label1.TabIndex = 10;
      this.label1.Text = "Treshold B/W:";
      // 
      // updnTreshold
      // 
      this.updnTreshold.Location = new System.Drawing.Point(408, 61);
      this.updnTreshold.Name = "updnTreshold";
      this.updnTreshold.Size = new System.Drawing.Size(46, 20);
      this.updnTreshold.TabIndex = 9;
      this.updnTreshold.ValueChanged += new System.EventHandler(this.updnTreshold_ValueChanged);
      // 
      // lblValues
      // 
      this.lblValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblValues.Location = new System.Drawing.Point(326, 4);
      this.lblValues.Name = "lblValues";
      this.lblValues.Size = new System.Drawing.Size(234, 49);
      this.lblValues.TabIndex = 8;
      this.lblValues.Text = "?";
      this.lblValues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // chkColor
      // 
      this.chkColor.AutoSize = true;
      this.chkColor.Location = new System.Drawing.Point(280, 36);
      this.chkColor.Name = "chkColor";
      this.chkColor.Size = new System.Drawing.Size(50, 17);
      this.chkColor.TabIndex = 7;
      this.chkColor.Text = "Color";
      this.chkColor.UseVisualStyleBackColor = true;
      this.chkColor.CheckedChanged += new System.EventHandler(this.chkColor_CheckedChanged);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.Controls.Add(this.btnLeft, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.btnUp, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnDown, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.btnRight, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.btnZoomIn, 1, 1);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(138, 4);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(136, 80);
      this.tableLayoutPanel1.TabIndex = 6;
      // 
      // btnLeft
      // 
      this.btnLeft.Location = new System.Drawing.Point(3, 29);
      this.btnLeft.Name = "btnLeft";
      this.btnLeft.Size = new System.Drawing.Size(39, 20);
      this.btnLeft.TabIndex = 0;
      this.btnLeft.Text = "<";
      this.btnLeft.UseVisualStyleBackColor = true;
      this.btnLeft.Click += new System.EventHandler(this.btnJoystick_Click);
      // 
      // btnUp
      // 
      this.btnUp.Location = new System.Drawing.Point(48, 3);
      this.btnUp.Name = "btnUp";
      this.btnUp.Size = new System.Drawing.Size(39, 20);
      this.btnUp.TabIndex = 1;
      this.btnUp.Text = "^";
      this.btnUp.UseVisualStyleBackColor = true;
      this.btnUp.Click += new System.EventHandler(this.btnJoystick_Click);
      // 
      // btnDown
      // 
      this.btnDown.Location = new System.Drawing.Point(48, 55);
      this.btnDown.Name = "btnDown";
      this.btnDown.Size = new System.Drawing.Size(39, 22);
      this.btnDown.TabIndex = 2;
      this.btnDown.Text = "v";
      this.btnDown.UseVisualStyleBackColor = true;
      this.btnDown.Click += new System.EventHandler(this.btnJoystick_Click);
      // 
      // btnRight
      // 
      this.btnRight.Location = new System.Drawing.Point(93, 29);
      this.btnRight.Name = "btnRight";
      this.btnRight.Size = new System.Drawing.Size(40, 20);
      this.btnRight.TabIndex = 3;
      this.btnRight.Text = ">";
      this.btnRight.UseVisualStyleBackColor = true;
      this.btnRight.Click += new System.EventHandler(this.btnJoystick_Click);
      // 
      // btnZoomIn
      // 
      this.btnZoomIn.Location = new System.Drawing.Point(48, 29);
      this.btnZoomIn.Name = "btnZoomIn";
      this.btnZoomIn.Size = new System.Drawing.Size(39, 20);
      this.btnZoomIn.TabIndex = 4;
      this.btnZoomIn.Text = "Z+";
      this.btnZoomIn.UseVisualStyleBackColor = true;
      this.btnZoomIn.Click += new System.EventHandler(this.btnJoystick_Click);
      // 
      // lblTime
      // 
      this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblTime.Location = new System.Drawing.Point(4, 39);
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(128, 45);
      this.lblTime.TabIndex = 1;
      this.lblTime.Text = "?";
      this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pbRealSize
      // 
      this.pbRealSize.Location = new System.Drawing.Point(4, 4);
      this.pbRealSize.Name = "pbRealSize";
      this.pbRealSize.Size = new System.Drawing.Size(128, 32);
      this.pbRealSize.TabIndex = 0;
      this.pbRealSize.TabStop = false;
      // 
      // btnZoomOut
      // 
      this.btnZoomOut.Location = new System.Drawing.Point(280, 61);
      this.btnZoomOut.Name = "btnZoomOut";
      this.btnZoomOut.Size = new System.Drawing.Size(39, 20);
      this.btnZoomOut.TabIndex = 6;
      this.btnZoomOut.Text = "Z-";
      this.btnZoomOut.UseVisualStyleBackColor = true;
      this.btnZoomOut.Click += new System.EventHandler(this.btnJoystick_Click);
      // 
      // btnReset
      // 
      this.btnReset.Location = new System.Drawing.Point(280, 7);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(40, 20);
      this.btnReset.TabIndex = 5;
      this.btnReset.Text = "Res";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnJoystick_Click);
      // 
      // pbZoomed
      // 
      this.pbZoomed.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pbZoomed.Location = new System.Drawing.Point(0, 90);
      this.pbZoomed.Name = "pbZoomed";
      this.pbZoomed.Size = new System.Drawing.Size(714, 429);
      this.pbZoomed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pbZoomed.TabIndex = 2;
      this.pbZoomed.TabStop = false;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(467, 65);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 13);
      this.label2.TabIndex = 12;
      this.label2.Text = "Center:";
      // 
      // updnCenter
      // 
      this.updnCenter.Location = new System.Drawing.Point(514, 62);
      this.updnCenter.Name = "updnCenter";
      this.updnCenter.Size = new System.Drawing.Size(46, 20);
      this.updnCenter.TabIndex = 11;
      this.updnCenter.ValueChanged += new System.EventHandler(this.updnCenter_ValueChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(714, 519);
      this.Controls.Add(this.pbZoomed);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.updnTreshold)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pbRealSize)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbZoomed)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.updnCenter)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblTime;
    private System.Windows.Forms.PictureBox pbRealSize;
    private System.Windows.Forms.PictureBox pbZoomed;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown updnTreshold;
    private System.Windows.Forms.Label lblValues;
    private System.Windows.Forms.CheckBox chkColor;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button btnLeft;
    private System.Windows.Forms.Button btnUp;
    private System.Windows.Forms.Button btnDown;
    private System.Windows.Forms.Button btnRight;
    private System.Windows.Forms.Button btnZoomIn;
    private System.Windows.Forms.Button btnZoomOut;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown updnCenter;
  }
}

