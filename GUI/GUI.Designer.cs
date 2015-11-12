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
            inputGroupBox = new GroupBox();
            pointDy = new TextBox();
            pointDx = new TextBox();
            pointCy = new TextBox();
            pointCx = new TextBox();
            pointBy = new TextBox();
            pointBx = new TextBox();
            pointAy = new TextBox();
            pointAx = new TextBox();
            labelD = new Label();
            labelC = new Label();
            labelB = new Label();
            labelA = new Label();
            pictureBox = new PictureBox();
            clearButton = new Button();
            startButton = new Button();
            trackBar = new TrackBar();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip = new MenuStrip();
            resultGroupBox = new GroupBox();
            resultTextBox = new TextBox();
            scaleGroupBox = new GroupBox();
            inputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(trackBar)).BeginInit();
            menuStrip.SuspendLayout();
            resultGroupBox.SuspendLayout();
            scaleGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // inputGroupBox
            // 
            inputGroupBox.Controls.Add(pointDy);
            inputGroupBox.Controls.Add(pointDx);
            inputGroupBox.Controls.Add(pointCy);
            inputGroupBox.Controls.Add(pointCx);
            inputGroupBox.Controls.Add(pointBy);
            inputGroupBox.Controls.Add(pointBx);
            inputGroupBox.Controls.Add(pointAy);
            inputGroupBox.Controls.Add(pointAx);
            inputGroupBox.Controls.Add(labelD);
            inputGroupBox.Controls.Add(labelC);
            inputGroupBox.Controls.Add(labelB);
            inputGroupBox.Controls.Add(labelA);
            inputGroupBox.Location = new System.Drawing.Point(453, 53);
            inputGroupBox.Name = "inputGroupBox";
            inputGroupBox.Size = new System.Drawing.Size(234, 231);
            inputGroupBox.TabIndex = 0;
            inputGroupBox.TabStop = false;
            inputGroupBox.Text = "Input data";
            // 
            // pointDy
            // 
            pointDy.Location = new System.Drawing.Point(155, 190);
            pointDy.MaxLength = 5;
            pointDy.Name = "pointDy";
            pointDy.Size = new System.Drawing.Size(62, 26);
            pointDy.TabIndex = 13;
            pointDy.Text = "0";
            pointDy.TextAlign = HorizontalAlignment.Center;
            // 
            // pointDx
            // 
            pointDx.Location = new System.Drawing.Point(74, 190);
            pointDx.MaxLength = 5;
            pointDx.Name = "pointDx";
            pointDx.Size = new System.Drawing.Size(62, 26);
            pointDx.TabIndex = 12;
            pointDx.Text = "0";
            pointDx.TextAlign = HorizontalAlignment.Center;
            // 
            // pointCy
            // 
            pointCy.Location = new System.Drawing.Point(155, 140);
            pointCy.MaxLength = 5;
            pointCy.Name = "pointCy";
            pointCy.Size = new System.Drawing.Size(62, 26);
            pointCy.TabIndex = 11;
            pointCy.Text = "0";
            pointCy.TextAlign = HorizontalAlignment.Center;
            // 
            // pointCx
            // 
            pointCx.Location = new System.Drawing.Point(74, 140);
            pointCx.MaxLength = 5;
            pointCx.Name = "pointCx";
            pointCx.Size = new System.Drawing.Size(62, 26);
            pointCx.TabIndex = 10;
            pointCx.Text = "0";
            pointCx.TextAlign = HorizontalAlignment.Center;
            // 
            // pointBy
            // 
            pointBy.Location = new System.Drawing.Point(155, 90);
            pointBy.MaxLength = 5;
            pointBy.Name = "pointBy";
            pointBy.Size = new System.Drawing.Size(62, 26);
            pointBy.TabIndex = 9;
            pointBy.Text = "0";
            pointBy.TextAlign = HorizontalAlignment.Center;
            // 
            // pointBx
            // 
            pointBx.Location = new System.Drawing.Point(74, 90);
            pointBx.MaxLength = 5;
            pointBx.Name = "pointBx";
            pointBx.Size = new System.Drawing.Size(62, 26);
            pointBx.TabIndex = 8;
            pointBx.Text = "0";
            pointBx.TextAlign = HorizontalAlignment.Center;
            // 
            // pointAy
            // 
            pointAy.Location = new System.Drawing.Point(155, 40);
            pointAy.MaxLength = 5;
            pointAy.Name = "pointAy";
            pointAy.Size = new System.Drawing.Size(62, 26);
            pointAy.TabIndex = 7;
            pointAy.Text = "0";
            pointAy.TextAlign = HorizontalAlignment.Center;
            // 
            // pointAx
            // 
            pointAx.Location = new System.Drawing.Point(74, 40);
            pointAx.MaxLength = 5;
            pointAx.Name = "pointAx";
            pointAx.Size = new System.Drawing.Size(62, 26);
            pointAx.TabIndex = 6;
            pointAx.Text = "0";
            pointAx.TextAlign = HorizontalAlignment.Center;
            // 
            // labelD
            // 
            labelD.AutoSize = true;
            labelD.Location = new System.Drawing.Point(14, 193);
            labelD.Name = "labelD";
            labelD.Size = new System.Drawing.Size(21, 20);
            labelD.TabIndex = 3;
            labelD.Text = "D";
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Location = new System.Drawing.Point(15, 143);
            labelC.Name = "labelC";
            labelC.Size = new System.Drawing.Size(20, 20);
            labelC.TabIndex = 2;
            labelC.Text = "C";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new System.Drawing.Point(15, 93);
            labelB.Name = "labelB";
            labelB.Size = new System.Drawing.Size(20, 20);
            labelB.TabIndex = 1;
            labelB.Text = "B";
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new System.Drawing.Point(15, 43);
            labelA.Name = "labelA";
            labelA.Size = new System.Drawing.Size(20, 20);
            labelA.TabIndex = 0;
            labelA.Text = "A";
            // 
            // pictureBox
            // 
            pictureBox.Location = new System.Drawing.Point(12, 53);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(425, 425);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // clearButton
            // 
            clearButton.Location = new System.Drawing.Point(453, 414);
            clearButton.Name = "clearButton";
            clearButton.Size = new System.Drawing.Size(107, 64);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += new System.EventHandler(clearButton_Click);
            // 
            // startButton
            // 
            startButton.Location = new System.Drawing.Point(578, 416);
            startButton.Name = "startButton";
            startButton.Size = new System.Drawing.Size(109, 64);
            startButton.TabIndex = 3;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += new System.EventHandler(startButton_Click);
            // 
            // trackBar
            // 
            trackBar.Location = new System.Drawing.Point(6, 25);
            trackBar.Minimum = 1;
            trackBar.Name = "trackBar";
            trackBar.Size = new System.Drawing.Size(222, 69);
            trackBar.TabIndex = 16;
            trackBar.Value = 5;
            trackBar.Scroll += new System.EventHandler(trackBar_Scroll);
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            exitToolStripMenuItem});
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(124, 30);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += new System.EventHandler(exitToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] {
            fileToolStripMenuItem});
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new System.Drawing.Size(701, 33);
            menuStrip.TabIndex = 5;
            // 
            // resultGroupBox
            // 
            resultGroupBox.Controls.Add(resultTextBox);
            resultGroupBox.Location = new System.Drawing.Point(12, 497);
            resultGroupBox.Name = "resultGroupBox";
            resultGroupBox.Size = new System.Drawing.Size(675, 79);
            resultGroupBox.TabIndex = 6;
            resultGroupBox.TabStop = false;
            resultGroupBox.Text = "Result";
            // 
            // resultTextBox
            // 
            resultTextBox.Enabled = false;
            resultTextBox.Location = new System.Drawing.Point(15, 36);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new System.Drawing.Size(643, 26);
            resultTextBox.TabIndex = 0;
            // 
            // scaleGroupBox
            // 
            scaleGroupBox.Controls.Add(trackBar);
            scaleGroupBox.Location = new System.Drawing.Point(455, 299);
            scaleGroupBox.Name = "scaleGroupBox";
            scaleGroupBox.Size = new System.Drawing.Size(234, 100);
            scaleGroupBox.TabIndex = 17;
            scaleGroupBox.TabStop = false;
            scaleGroupBox.Text = "Scale";
            // 
            // GUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(701, 588);
            Controls.Add(scaleGroupBox);
            Controls.Add(resultGroupBox);
            Controls.Add(menuStrip);
            Controls.Add(startButton);
            Controls.Add(clearButton);
            Controls.Add(pictureBox);
            Controls.Add(inputGroupBox);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            MainMenuStrip = menuStrip;
            Name = "GUI";
            Text = "Geometry";
            inputGroupBox.ResumeLayout(false);
            inputGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(trackBar)).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            resultGroupBox.ResumeLayout(false);
            resultGroupBox.PerformLayout();
            scaleGroupBox.ResumeLayout(false);
            scaleGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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