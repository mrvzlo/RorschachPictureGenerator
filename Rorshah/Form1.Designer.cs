namespace Rorshah
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.N2ChanceInput = new System.Windows.Forms.TextBox();
            this.N1ChanceInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.N3ChanceInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.N4ChanceInput = new System.Windows.Forms.TextBox();
            this.MinIterationBar = new System.Windows.Forms.HScrollBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1247, 597);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // N2ChanceInput
            // 
            this.N2ChanceInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.N2ChanceInput.Location = new System.Drawing.Point(3, 384);
            this.N2ChanceInput.Name = "N2ChanceInput";
            this.N2ChanceInput.Size = new System.Drawing.Size(87, 20);
            this.N2ChanceInput.TabIndex = 8;
            this.N2ChanceInput.TextChanged += new System.EventHandler(this.Input2_TextChanged);
            // 
            // N1ChanceInput
            // 
            this.N1ChanceInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.N1ChanceInput.Location = new System.Drawing.Point(3, 308);
            this.N1ChanceInput.Name = "N1ChanceInput";
            this.N1ChanceInput.Size = new System.Drawing.Size(87, 20);
            this.N1ChanceInput.TabIndex = 2;
            this.N1ChanceInput.TextChanged += new System.EventHandler(this.Input1_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "3 neighbors chance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 50);
            this.label4.TabIndex = 7;
            this.label4.Text = "2 neighbors chance";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "1 neighbor chance";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GenerateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBtn.Location = new System.Drawing.Point(0, 562);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(93, 35);
            this.GenerateBtn.TabIndex = 3;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // N3ChanceInput
            // 
            this.N3ChanceInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.N3ChanceInput.Location = new System.Drawing.Point(3, 460);
            this.N3ChanceInput.Name = "N3ChanceInput";
            this.N3ChanceInput.Size = new System.Drawing.Size(87, 20);
            this.N3ChanceInput.TabIndex = 6;
            this.N3ChanceInput.TextChanged += new System.EventHandler(this.Input3_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ColorBtn);
            this.panel1.Controls.Add(this.MinIterationBar);
            this.panel1.Controls.Add(this.N4ChanceInput);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.GenerateBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.N3ChanceInput);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.N1ChanceInput);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.N2ChanceInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1247, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 597);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "4 neighbors chance";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label5.Visible = false;
            // 
            // N4ChanceInput
            // 
            this.N4ChanceInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.N4ChanceInput.Location = new System.Drawing.Point(3, 536);
            this.N4ChanceInput.Name = "N4ChanceInput";
            this.N4ChanceInput.Size = new System.Drawing.Size(87, 20);
            this.N4ChanceInput.TabIndex = 10;
            this.N4ChanceInput.Visible = false;
            this.N4ChanceInput.TextChanged += new System.EventHandler(this.Input4_TextChanged);
            // 
            // MinIterationBar
            // 
            this.MinIterationBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinIterationBar.Location = new System.Drawing.Point(3, 235);
            this.MinIterationBar.Minimum = 1;
            this.MinIterationBar.Name = "MinIterationBar";
            this.MinIterationBar.Size = new System.Drawing.Size(87, 20);
            this.MinIterationBar.TabIndex = 11;
            this.MinIterationBar.Value = 10;
            this.MinIterationBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MinIterationBar_Scroll);
            // 
            // ColorBtn
            // 
            this.ColorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBtn.BackColor = System.Drawing.Color.Black;
            this.ColorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ColorBtn.ForeColor = System.Drawing.Color.White;
            this.ColorBtn.Location = new System.Drawing.Point(3, 147);
            this.ColorBtn.Name = "ColorBtn";
            this.ColorBtn.Size = new System.Drawing.Size(87, 35);
            this.ColorBtn.TabIndex = 12;
            this.ColorBtn.Text = "Color";
            this.ColorBtn.UseVisualStyleBackColor = false;
            this.ColorBtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 50);
            this.label1.TabIndex = 13;
            this.label1.Text = "Minimal size 10";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 597);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox N2ChanceInput;
        private System.Windows.Forms.TextBox N1ChanceInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.TextBox N3ChanceInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox N4ChanceInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar MinIterationBar;
        private System.Windows.Forms.Button ColorBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
    }
}

