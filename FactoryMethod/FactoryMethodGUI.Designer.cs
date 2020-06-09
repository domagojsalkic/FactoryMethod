namespace FactoryMethod
{
    partial class FactoryMethodShapeCreator
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
            this.xPosLabel = new System.Windows.Forms.Label();
            this.yPosLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.xPos = new System.Windows.Forms.TextBox();
            this.yPos = new System.Windows.Forms.TextBox();
            this.widthPos = new System.Windows.Forms.TextBox();
            this.heightPos = new System.Windows.Forms.TextBox();
            this.squareBtn = new System.Windows.Forms.RadioButton();
            this.ellipseBtn = new System.Windows.Forms.RadioButton();
            this.createBtn = new System.Windows.Forms.Button();
            this.drawingPanel = new FactoryMethod.DrawingPanel(this.components);
            this.SuspendLayout();
            // 
            // xPosLabel
            // 
            this.xPosLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xPosLabel.AutoSize = true;
            this.xPosLabel.Location = new System.Drawing.Point(602, 9);
            this.xPosLabel.Name = "xPosLabel";
            this.xPosLabel.Size = new System.Drawing.Size(17, 13);
            this.xPosLabel.TabIndex = 0;
            this.xPosLabel.Text = "X:";
            // 
            // yPosLabel
            // 
            this.yPosLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yPosLabel.AutoSize = true;
            this.yPosLabel.Location = new System.Drawing.Point(602, 32);
            this.yPosLabel.Name = "yPosLabel";
            this.yPosLabel.Size = new System.Drawing.Size(17, 13);
            this.yPosLabel.TabIndex = 1;
            this.yPosLabel.Text = "Y:";
            // 
            // widthLabel
            // 
            this.widthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(581, 55);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Width:";
            // 
            // heightLabel
            // 
            this.heightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(578, 78);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Height:";
            // 
            // xPos
            // 
            this.xPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xPos.Location = new System.Drawing.Point(638, 6);
            this.xPos.Name = "xPos";
            this.xPos.Size = new System.Drawing.Size(100, 20);
            this.xPos.TabIndex = 4;
            // 
            // yPos
            // 
            this.yPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yPos.Location = new System.Drawing.Point(638, 29);
            this.yPos.Name = "yPos";
            this.yPos.Size = new System.Drawing.Size(100, 20);
            this.yPos.TabIndex = 5;
            // 
            // widthPos
            // 
            this.widthPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.widthPos.Location = new System.Drawing.Point(638, 52);
            this.widthPos.Name = "widthPos";
            this.widthPos.Size = new System.Drawing.Size(100, 20);
            this.widthPos.TabIndex = 6;
            // 
            // heightPos
            // 
            this.heightPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.heightPos.Location = new System.Drawing.Point(638, 75);
            this.heightPos.Name = "heightPos";
            this.heightPos.Size = new System.Drawing.Size(100, 20);
            this.heightPos.TabIndex = 7;
            // 
            // squareBtn
            // 
            this.squareBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.squareBtn.AutoSize = true;
            this.squareBtn.Location = new System.Drawing.Point(653, 116);
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(59, 17);
            this.squareBtn.TabIndex = 8;
            this.squareBtn.TabStop = true;
            this.squareBtn.Text = "Square";
            this.squareBtn.UseVisualStyleBackColor = true;
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ellipseBtn.AutoSize = true;
            this.ellipseBtn.Location = new System.Drawing.Point(653, 139);
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(55, 17);
            this.ellipseBtn.TabIndex = 9;
            this.ellipseBtn.TabStop = true;
            this.ellipseBtn.Text = "Ellipse";
            this.ellipseBtn.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            this.createBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createBtn.Location = new System.Drawing.Point(653, 171);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 10;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // drawingPanel
            // 
            this.drawingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingPanel.Location = new System.Drawing.Point(12, 12);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(560, 426);
            this.drawingPanel.TabIndex = 11;
            // 
            // FactoryMethodShapeCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.ellipseBtn);
            this.Controls.Add(this.squareBtn);
            this.Controls.Add(this.heightPos);
            this.Controls.Add(this.widthPos);
            this.Controls.Add(this.yPos);
            this.Controls.Add(this.xPos);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.yPosLabel);
            this.Controls.Add(this.xPosLabel);
            this.Name = "FactoryMethodShapeCreator";
            this.Text = "Factory Method Shape Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xPosLabel;
        private System.Windows.Forms.Label yPosLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox xPos;
        private System.Windows.Forms.TextBox yPos;
        private System.Windows.Forms.TextBox widthPos;
        private System.Windows.Forms.TextBox heightPos;
        private System.Windows.Forms.RadioButton squareBtn;
        private System.Windows.Forms.RadioButton ellipseBtn;
        private System.Windows.Forms.Button createBtn;
        private DrawingPanel drawingPanel;
    }
}

