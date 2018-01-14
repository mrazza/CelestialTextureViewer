namespace TextureViewer
{
    partial class MainForm
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
            this.colorPictureBox = new System.Windows.Forms.PictureBox();
            this.normalPictureBox = new System.Windows.Forms.PictureBox();
            this.browseColorButton = new System.Windows.Forms.Button();
            this.browseNormalButton = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.normalLabel = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.normalVectorTitleLabel = new System.Windows.Forms.Label();
            this.normalVectorXLabel = new System.Windows.Forms.Label();
            this.normalVectorZLabel = new System.Windows.Forms.Label();
            this.normalVectorYLabel = new System.Windows.Forms.Label();
            this.normalVectorXValueLabel = new System.Windows.Forms.Label();
            this.normalVectorYValueLabel = new System.Windows.Forms.Label();
            this.normalVectorZValueLabel = new System.Windows.Forms.Label();
            this.normalVectorLengthLabel = new System.Windows.Forms.Label();
            this.normalVectorLengthValueLabel = new System.Windows.Forms.Label();
            this.normalizeButton = new System.Windows.Forms.Button();
            this.noteLabel = new System.Windows.Forms.Label();
            this.vectorTransformationsTitleLabel = new System.Windows.Forms.Label();
            this.vectorTransformationsYLabel = new System.Windows.Forms.Label();
            this.vectorTransformationsZLabel = new System.Windows.Forms.Label();
            this.vectorTransformationsXLabel = new System.Windows.Forms.Label();
            this.vectorTransformationXTextBox = new System.Windows.Forms.TextBox();
            this.vectorTransformationYTextBox = new System.Windows.Forms.TextBox();
            this.vectorTransformationZTextBox = new System.Windows.Forms.TextBox();
            this.applyTransformationButton = new System.Windows.Forms.Button();
            this.zoomedNormalMapPictureBox = new System.Windows.Forms.PictureBox();
            this.directionLabel = new System.Windows.Forms.Label();
            this.zoomedColorPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomedNormalMapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomedColorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // colorPictureBox
            // 
            this.colorPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.colorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPictureBox.Location = new System.Drawing.Point(12, 25);
            this.colorPictureBox.Name = "colorPictureBox";
            this.colorPictureBox.Size = new System.Drawing.Size(420, 634);
            this.colorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colorPictureBox.TabIndex = 0;
            this.colorPictureBox.TabStop = false;
            this.colorPictureBox.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.colorPictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.colorPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.colorPictureBox_MouseMove);
            // 
            // normalPictureBox
            // 
            this.normalPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.normalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.normalPictureBox.Location = new System.Drawing.Point(438, 25);
            this.normalPictureBox.Name = "normalPictureBox";
            this.normalPictureBox.Size = new System.Drawing.Size(420, 634);
            this.normalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.normalPictureBox.TabIndex = 1;
            this.normalPictureBox.TabStop = false;
            this.normalPictureBox.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.normalPictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.normalPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.normalPictureBox_MouseMove);
            // 
            // browseColorButton
            // 
            this.browseColorButton.Location = new System.Drawing.Point(15, 669);
            this.browseColorButton.Name = "browseColorButton";
            this.browseColorButton.Size = new System.Drawing.Size(75, 23);
            this.browseColorButton.TabIndex = 2;
            this.browseColorButton.Text = "Browse";
            this.toolTip.SetToolTip(this.browseColorButton, "Browse for an optional color map to load.");
            this.browseColorButton.UseVisualStyleBackColor = true;
            this.browseColorButton.Click += new System.EventHandler(this.browseColorButton_Click);
            // 
            // browseNormalButton
            // 
            this.browseNormalButton.Location = new System.Drawing.Point(438, 669);
            this.browseNormalButton.Name = "browseNormalButton";
            this.browseNormalButton.Size = new System.Drawing.Size(75, 23);
            this.browseNormalButton.TabIndex = 3;
            this.browseNormalButton.Text = "Browse";
            this.toolTip.SetToolTip(this.browseNormalButton, "Browse for a normal map to load.");
            this.browseNormalButton.UseVisualStyleBackColor = true;
            this.browseNormalButton.Click += new System.EventHandler(this.browseNormalButton_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(12, 9);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(55, 13);
            this.colorLabel.TabIndex = 4;
            this.colorLabel.Text = "Color Map";
            // 
            // normalLabel
            // 
            this.normalLabel.AutoSize = true;
            this.normalLabel.Location = new System.Drawing.Point(435, 9);
            this.normalLabel.Name = "normalLabel";
            this.normalLabel.Size = new System.Drawing.Size(64, 13);
            this.normalLabel.TabIndex = 5;
            this.normalLabel.Text = "Normal Map";
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(957, 669);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "Export";
            this.toolTip.SetToolTip(this.exportButton, "Export the normal map with the specified vector transformations.");
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // normalVectorTitleLabel
            // 
            this.normalVectorTitleLabel.AutoSize = true;
            this.normalVectorTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalVectorTitleLabel.Location = new System.Drawing.Point(864, 25);
            this.normalVectorTitleLabel.Name = "normalVectorTitleLabel";
            this.normalVectorTitleLabel.Size = new System.Drawing.Size(87, 13);
            this.normalVectorTitleLabel.TabIndex = 7;
            this.normalVectorTitleLabel.Text = "Normal Vector";
            // 
            // normalVectorXLabel
            // 
            this.normalVectorXLabel.AutoSize = true;
            this.normalVectorXLabel.Location = new System.Drawing.Point(867, 42);
            this.normalVectorXLabel.Name = "normalVectorXLabel";
            this.normalVectorXLabel.Size = new System.Drawing.Size(17, 13);
            this.normalVectorXLabel.TabIndex = 8;
            this.normalVectorXLabel.Text = "X:";
            // 
            // normalVectorZLabel
            // 
            this.normalVectorZLabel.AutoSize = true;
            this.normalVectorZLabel.Location = new System.Drawing.Point(867, 68);
            this.normalVectorZLabel.Name = "normalVectorZLabel";
            this.normalVectorZLabel.Size = new System.Drawing.Size(17, 13);
            this.normalVectorZLabel.TabIndex = 9;
            this.normalVectorZLabel.Text = "Z:";
            // 
            // normalVectorYLabel
            // 
            this.normalVectorYLabel.AutoSize = true;
            this.normalVectorYLabel.Location = new System.Drawing.Point(867, 55);
            this.normalVectorYLabel.Name = "normalVectorYLabel";
            this.normalVectorYLabel.Size = new System.Drawing.Size(17, 13);
            this.normalVectorYLabel.TabIndex = 10;
            this.normalVectorYLabel.Text = "Y:";
            // 
            // normalVectorXValueLabel
            // 
            this.normalVectorXValueLabel.AutoSize = true;
            this.normalVectorXValueLabel.Location = new System.Drawing.Point(890, 42);
            this.normalVectorXValueLabel.Name = "normalVectorXValueLabel";
            this.normalVectorXValueLabel.Size = new System.Drawing.Size(27, 13);
            this.normalVectorXValueLabel.TabIndex = 11;
            this.normalVectorXValueLabel.Text = "N/A";
            // 
            // normalVectorYValueLabel
            // 
            this.normalVectorYValueLabel.AutoSize = true;
            this.normalVectorYValueLabel.Location = new System.Drawing.Point(890, 55);
            this.normalVectorYValueLabel.Name = "normalVectorYValueLabel";
            this.normalVectorYValueLabel.Size = new System.Drawing.Size(27, 13);
            this.normalVectorYValueLabel.TabIndex = 12;
            this.normalVectorYValueLabel.Text = "N/A";
            // 
            // normalVectorZValueLabel
            // 
            this.normalVectorZValueLabel.AutoSize = true;
            this.normalVectorZValueLabel.Location = new System.Drawing.Point(890, 68);
            this.normalVectorZValueLabel.Name = "normalVectorZValueLabel";
            this.normalVectorZValueLabel.Size = new System.Drawing.Size(27, 13);
            this.normalVectorZValueLabel.TabIndex = 13;
            this.normalVectorZValueLabel.Text = "N/A";
            // 
            // normalVectorLengthLabel
            // 
            this.normalVectorLengthLabel.AutoSize = true;
            this.normalVectorLengthLabel.Location = new System.Drawing.Point(867, 83);
            this.normalVectorLengthLabel.Name = "normalVectorLengthLabel";
            this.normalVectorLengthLabel.Size = new System.Drawing.Size(43, 13);
            this.normalVectorLengthLabel.TabIndex = 14;
            this.normalVectorLengthLabel.Text = "Length:";
            // 
            // normalVectorLengthValueLabel
            // 
            this.normalVectorLengthValueLabel.AutoSize = true;
            this.normalVectorLengthValueLabel.Location = new System.Drawing.Point(913, 83);
            this.normalVectorLengthValueLabel.Name = "normalVectorLengthValueLabel";
            this.normalVectorLengthValueLabel.Size = new System.Drawing.Size(27, 13);
            this.normalVectorLengthValueLabel.TabIndex = 15;
            this.normalVectorLengthValueLabel.Text = "N/A";
            // 
            // normalizeButton
            // 
            this.normalizeButton.Location = new System.Drawing.Point(876, 669);
            this.normalizeButton.Name = "normalizeButton";
            this.normalizeButton.Size = new System.Drawing.Size(75, 23);
            this.normalizeButton.TabIndex = 16;
            this.normalizeButton.Text = "Normalize";
            this.normalizeButton.UseVisualStyleBackColor = true;
            this.normalizeButton.Click += new System.EventHandler(this.normalizeButton_Click);
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(864, 607);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(157, 52);
            this.noteLabel.TabIndex = 17;
            this.noteLabel.Text = "NOTE:\r\nPositive X is RIGHT.\r\nPositive Y is DOWN.\r\nPositive Z is OUT OF SCREEN.";
            // 
            // vectorTransformationsTitleLabel
            // 
            this.vectorTransformationsTitleLabel.AutoSize = true;
            this.vectorTransformationsTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vectorTransformationsTitleLabel.Location = new System.Drawing.Point(864, 135);
            this.vectorTransformationsTitleLabel.Name = "vectorTransformationsTitleLabel";
            this.vectorTransformationsTitleLabel.Size = new System.Drawing.Size(138, 13);
            this.vectorTransformationsTitleLabel.TabIndex = 18;
            this.vectorTransformationsTitleLabel.Text = "Vector Transformations";
            // 
            // vectorTransformationsYLabel
            // 
            this.vectorTransformationsYLabel.AutoSize = true;
            this.vectorTransformationsYLabel.Location = new System.Drawing.Point(867, 182);
            this.vectorTransformationsYLabel.Name = "vectorTransformationsYLabel";
            this.vectorTransformationsYLabel.Size = new System.Drawing.Size(17, 13);
            this.vectorTransformationsYLabel.TabIndex = 21;
            this.vectorTransformationsYLabel.Text = "Y:";
            // 
            // vectorTransformationsZLabel
            // 
            this.vectorTransformationsZLabel.AutoSize = true;
            this.vectorTransformationsZLabel.Location = new System.Drawing.Point(867, 208);
            this.vectorTransformationsZLabel.Name = "vectorTransformationsZLabel";
            this.vectorTransformationsZLabel.Size = new System.Drawing.Size(17, 13);
            this.vectorTransformationsZLabel.TabIndex = 20;
            this.vectorTransformationsZLabel.Text = "Z:";
            // 
            // vectorTransformationsXLabel
            // 
            this.vectorTransformationsXLabel.AutoSize = true;
            this.vectorTransformationsXLabel.Location = new System.Drawing.Point(867, 156);
            this.vectorTransformationsXLabel.Name = "vectorTransformationsXLabel";
            this.vectorTransformationsXLabel.Size = new System.Drawing.Size(17, 13);
            this.vectorTransformationsXLabel.TabIndex = 19;
            this.vectorTransformationsXLabel.Text = "X:";
            // 
            // vectorTransformationXTextBox
            // 
            this.vectorTransformationXTextBox.Location = new System.Drawing.Point(890, 153);
            this.vectorTransformationXTextBox.Name = "vectorTransformationXTextBox";
            this.vectorTransformationXTextBox.Size = new System.Drawing.Size(131, 20);
            this.vectorTransformationXTextBox.TabIndex = 22;
            this.vectorTransformationXTextBox.Text = "1.0";
            this.vectorTransformationXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyKeyPress);
            // 
            // vectorTransformationYTextBox
            // 
            this.vectorTransformationYTextBox.Location = new System.Drawing.Point(890, 179);
            this.vectorTransformationYTextBox.Name = "vectorTransformationYTextBox";
            this.vectorTransformationYTextBox.Size = new System.Drawing.Size(131, 20);
            this.vectorTransformationYTextBox.TabIndex = 23;
            this.vectorTransformationYTextBox.Text = "1.0";
            this.vectorTransformationYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyKeyPress);
            // 
            // vectorTransformationZTextBox
            // 
            this.vectorTransformationZTextBox.Location = new System.Drawing.Point(890, 205);
            this.vectorTransformationZTextBox.Name = "vectorTransformationZTextBox";
            this.vectorTransformationZTextBox.Size = new System.Drawing.Size(131, 20);
            this.vectorTransformationZTextBox.TabIndex = 24;
            this.vectorTransformationZTextBox.Text = "1.0";
            this.vectorTransformationZTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersOnlyKeyPress);
            // 
            // applyTransformationButton
            // 
            this.applyTransformationButton.Location = new System.Drawing.Point(916, 231);
            this.applyTransformationButton.Name = "applyTransformationButton";
            this.applyTransformationButton.Size = new System.Drawing.Size(75, 23);
            this.applyTransformationButton.TabIndex = 25;
            this.applyTransformationButton.Text = "Apply";
            this.applyTransformationButton.UseVisualStyleBackColor = true;
            this.applyTransformationButton.Click += new System.EventHandler(this.applyTransformationButton_Click);
            // 
            // zoomedNormalMapPictureBox
            // 
            this.zoomedNormalMapPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zoomedNormalMapPictureBox.Location = new System.Drawing.Point(887, 298);
            this.zoomedNormalMapPictureBox.Name = "zoomedNormalMapPictureBox";
            this.zoomedNormalMapPictureBox.Size = new System.Drawing.Size(128, 128);
            this.zoomedNormalMapPictureBox.TabIndex = 26;
            this.zoomedNormalMapPictureBox.TabStop = false;
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Location = new System.Drawing.Point(867, 98);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(27, 13);
            this.directionLabel.TabIndex = 27;
            this.directionLabel.Text = "N/A";
            // 
            // zoomedColorPictureBox
            // 
            this.zoomedColorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zoomedColorPictureBox.Location = new System.Drawing.Point(887, 448);
            this.zoomedColorPictureBox.Name = "zoomedColorPictureBox";
            this.zoomedColorPictureBox.Size = new System.Drawing.Size(128, 128);
            this.zoomedColorPictureBox.TabIndex = 28;
            this.zoomedColorPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 702);
            this.Controls.Add(this.zoomedColorPictureBox);
            this.Controls.Add(this.directionLabel);
            this.Controls.Add(this.zoomedNormalMapPictureBox);
            this.Controls.Add(this.applyTransformationButton);
            this.Controls.Add(this.vectorTransformationZTextBox);
            this.Controls.Add(this.vectorTransformationYTextBox);
            this.Controls.Add(this.vectorTransformationXTextBox);
            this.Controls.Add(this.vectorTransformationsYLabel);
            this.Controls.Add(this.vectorTransformationsZLabel);
            this.Controls.Add(this.vectorTransformationsXLabel);
            this.Controls.Add(this.vectorTransformationsTitleLabel);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.normalizeButton);
            this.Controls.Add(this.normalVectorLengthValueLabel);
            this.Controls.Add(this.normalVectorLengthLabel);
            this.Controls.Add(this.normalVectorZValueLabel);
            this.Controls.Add(this.normalVectorYValueLabel);
            this.Controls.Add(this.normalVectorXValueLabel);
            this.Controls.Add(this.normalVectorYLabel);
            this.Controls.Add(this.normalVectorZLabel);
            this.Controls.Add(this.normalVectorXLabel);
            this.Controls.Add(this.normalVectorTitleLabel);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.normalLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.normalPictureBox);
            this.Controls.Add(this.colorPictureBox);
            this.Controls.Add(this.browseNormalButton);
            this.Controls.Add(this.browseColorButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Celestial Texture Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomedNormalMapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomedColorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox colorPictureBox;
        private System.Windows.Forms.PictureBox normalPictureBox;
        private System.Windows.Forms.Button browseColorButton;
        private System.Windows.Forms.Button browseNormalButton;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label normalLabel;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label normalVectorTitleLabel;
        private System.Windows.Forms.Label normalVectorXLabel;
        private System.Windows.Forms.Label normalVectorZLabel;
        private System.Windows.Forms.Label normalVectorYLabel;
        private System.Windows.Forms.Label normalVectorXValueLabel;
        private System.Windows.Forms.Label normalVectorYValueLabel;
        private System.Windows.Forms.Label normalVectorZValueLabel;
        private System.Windows.Forms.Label normalVectorLengthLabel;
        private System.Windows.Forms.Label normalVectorLengthValueLabel;
        private System.Windows.Forms.Button normalizeButton;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label vectorTransformationsTitleLabel;
        private System.Windows.Forms.Label vectorTransformationsYLabel;
        private System.Windows.Forms.Label vectorTransformationsZLabel;
        private System.Windows.Forms.Label vectorTransformationsXLabel;
        private System.Windows.Forms.TextBox vectorTransformationXTextBox;
        private System.Windows.Forms.TextBox vectorTransformationYTextBox;
        private System.Windows.Forms.TextBox vectorTransformationZTextBox;
        private System.Windows.Forms.Button applyTransformationButton;
        private System.Windows.Forms.PictureBox zoomedNormalMapPictureBox;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.PictureBox zoomedColorPictureBox;
    }
}

