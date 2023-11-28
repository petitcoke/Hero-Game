namespace HeroGameForm
{
    partial class HeroGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDisplay = new Label();
            btnUp = new Button();
            btnDown = new Button();
            btnLeft = new Button();
            btnRight = new Button();
            lblLegend = new Label();
            SuspendLayout();
            // 
            // lblDisplay
            // 
            lblDisplay.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplay.Location = new Point(12, 9);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(668, 568);
            lblDisplay.TabIndex = 0;
            // 
            // btnUp
            // 
            btnUp.Location = new Point(801, 47);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(94, 29);
            btnUp.TabIndex = 1;
            btnUp.Text = "UP";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(801, 118);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(94, 29);
            btnDown.TabIndex = 2;
            btnDown.Text = "DOWN";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(693, 83);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(94, 29);
            btnLeft.TabIndex = 3;
            btnLeft.Text = "LEFT";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(918, 83);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(94, 29);
            btnRight.TabIndex = 4;
            btnRight.Text = "RIGHT";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // lblLegend
            // 
            lblLegend.AutoSize = true;
            lblLegend.Location = new Point(813, 9);
            lblLegend.Name = "lblLegend";
            lblLegend.Size = new Size(59, 20);
            lblLegend.TabIndex = 5;
            lblLegend.Text = "Exit = E";
            // 
            // HeroGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 592);
            Controls.Add(lblLegend);
            Controls.Add(btnRight);
            Controls.Add(btnLeft);
            Controls.Add(btnDown);
            Controls.Add(btnUp);
            Controls.Add(lblDisplay);
            Name = "HeroGame";
            Text = "Hero Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDisplay;
        private Button btnUp;
        private Button btnDown;
        private Button btnLeft;
        private Button btnRight;
        private Label lblLegend;
    }
}