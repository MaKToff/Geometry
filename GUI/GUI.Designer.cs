using System.Windows.Forms;

namespace GUI
{
    partial class GUI
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
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.pointDy = new System.Windows.Forms.TextBox();
            this.pointDx = new System.Windows.Forms.TextBox();
            this.pointCy = new System.Windows.Forms.TextBox();
            this.pointCx = new System.Windows.Forms.TextBox();
            this.pointBy = new System.Windows.Forms.TextBox();
            this.pointBx = new System.Windows.Forms.TextBox();
            this.pointAy = new System.Windows.Forms.TextBox();
            this.pointAx = new System.Windows.Forms.TextBox();
            this.labelD = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.scaleGroupBox = new System.Windows.Forms.GroupBox();
            this.inputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.resultGroupBox.SuspendLayout();
            this.scaleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.pointDy);
            this.inputGroupBox.Controls.Add(this.pointDx);
            this.inputGroupBox.Controls.Add(this.pointCy);
            this.inputGroupBox.Controls.Add(this.pointCx);
            this.inputGroupBox.Controls.Add(this.pointBy);
            this.inputGroupBox.Controls.Add(this.pointBx);
            this.inputGroupBox.Controls.Add(this.pointAy);
            this.inputGroupBox.Controls.Add(this.pointAx);
            this.inputGroupBox.Controls.Add(this.labelD);
            this.inputGroupBox.Controls.Add(this.labelC);
            this.inputGroupBox.Controls.Add(this.labelB);
            this.inputGroupBox.Controls.Add(this.labelA);
            this.inputGroupBox.Location = new System.Drawing.Point(453, 53);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(234, 231);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input data";
            // 
            // pointDy
            // 
            this.pointDy.Location = new System.Drawing.Point(155, 190);
            this.pointDy.MaxLength = 5;
            this.pointDy.Name = "pointDy";
            this.pointDy.Size = new System.Drawing.Size(62, 26);
            this.pointDy.TabIndex = 13;
            this.pointDy.Text = "0";
            this.pointDy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pointDx
            // 
            this.pointDx.Location = new System.Drawing.Point(74, 190);
            this.pointDx.MaxLength = 5;
            this.pointDx.Name = "pointDx";
            this.pointDx.Size = new System.Drawing.Size(62, 26);
            this.pointDx.TabIndex = 12;
            this.pointDx.Text = "0";
            this.pointDx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pointCy
            // 
            this.pointCy.Location = new System.Drawing.Point(155, 140);
            this.pointCy.MaxLength = 5;
            this.pointCy.Name = "pointCy";
            this.pointCy.Size = new System.Drawing.Size(62, 26);
            this.pointCy.TabIndex = 11;
            this.pointCy.Text = "0";
            this.pointCy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pointCx
            // 
            this.pointCx.Location = new System.Drawing.Point(74, 140);
            this.pointCx.MaxLength = 5;
            this.pointCx.Name = "pointCx";
            this.pointCx.Size = new System.Drawing.Size(62, 26);
            this.pointCx.TabIndex = 10;
            this.pointCx.Text = "0";
            this.pointCx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pointBy
            // 
            this.pointBy.Location = new System.Drawing.Point(155, 90);
            this.pointBy.MaxLength = 5;
            this.pointBy.Name = "pointBy";
            this.pointBy.Size = new System.Drawing.Size(62, 26);
            this.pointBy.TabIndex = 9;
            this.pointBy.Text = "0";
            this.pointBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pointBx
            // 
            this.pointBx.Location = new System.Drawing.Point(74, 90);
            this.pointBx.MaxLength = 5;
            this.pointBx.Name = "pointBx";
            this.pointBx.Size = new System.Drawing.Size(62, 26);
            this.pointBx.TabIndex = 8;
            this.pointBx.Text = "0";
            this.pointBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pointAy
            // 
            this.pointAy.Location = new System.Drawing.Point(155, 40);
            this.pointAy.MaxLength = 5;
            this.pointAy.Name = "pointAy";
            this.pointAy.Size = new System.Drawing.Size(62, 26);
            this.pointAy.TabIndex = 7;
            this.pointAy.Text = "0";
            this.pointAy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pointAx
            // 
            this.pointAx.Location = new System.Drawing.Point(74, 40);
            this.pointAx.MaxLength = 5;
            this.pointAx.Name = "pointAx";
            this.pointAx.Size = new System.Drawing.Size(62, 26);
            this.pointAx.TabIndex = 6;
            this.pointAx.Text = "0";
            this.pointAx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(14, 193);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(21, 20);
            this.labelD.TabIndex = 3;
            this.labelD.Text = "D";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(15, 143);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(20, 20);
            this.labelC.TabIndex = 2;
            this.labelC.Text = "C";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(15, 93);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(20, 20);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "B";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(15, 43);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(20, 20);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "A";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 53);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(425, 425);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(453, 414);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(107, 64);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(578, 416);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(109, 64);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(6, 25);
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(222, 69);
            this.trackBar.TabIndex = 16;
            this.trackBar.Value = 5;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(701, 33);
            this.menuStrip.TabIndex = 5;
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.resultTextBox);
            this.resultGroupBox.Location = new System.Drawing.Point(12, 497);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(675, 79);
            this.resultGroupBox.TabIndex = 6;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Result";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Enabled = false;
            this.resultTextBox.Location = new System.Drawing.Point(15, 36);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(643, 26);
            this.resultTextBox.TabIndex = 0;
            // 
            // scaleGroupBox
            // 
            this.scaleGroupBox.Controls.Add(this.trackBar);
            this.scaleGroupBox.Location = new System.Drawing.Point(455, 299);
            this.scaleGroupBox.Name = "scaleGroupBox";
            this.scaleGroupBox.Size = new System.Drawing.Size(234, 100);
            this.scaleGroupBox.TabIndex = 17;
            this.scaleGroupBox.TabStop = false;
            this.scaleGroupBox.Text = "Scale";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 588);
            this.Controls.Add(this.scaleGroupBox);
            this.Controls.Add(this.resultGroupBox);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.inputGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "GUI";
            this.Text = "Geometry";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            this.scaleGroupBox.ResumeLayout(false);
            this.scaleGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox inputGroupBox;
        private Label labelD;
        private Label labelC;
        private Label labelB;
        private Label labelA;
        private TextBox pointCy;
        private TextBox pointCx;
        private TextBox pointBy;
        private TextBox pointBx;
        private TextBox pointAy;
        private TextBox pointAx;
        private PictureBox pictureBox;
        private Button clearButton;
        private Button startButton;
        private TextBox pointDy;
        private TextBox pointDx;
        private TrackBar trackBar;
        private ToolStripMenuItem fileToolStripMenuItem;
        private MenuStrip menuStrip;
        private GroupBox resultGroupBox;
        private TextBox resultTextBox;
        private GroupBox scaleGroupBox;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}