namespace vp_lab_6
{
    partial class Form1
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
            this.ARows = new System.Windows.Forms.NumericUpDown();
            this.ALabel = new System.Windows.Forms.Label();
            this.AColumns = new System.Windows.Forms.NumericUpDown();
            this.BLabel = new System.Windows.Forms.Label();
            this.BRows = new System.Windows.Forms.NumericUpDown();
            this.BColumns = new System.Windows.Forms.NumericUpDown();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SubBtn = new System.Windows.Forms.Button();
            this.MultBABtn = new System.Windows.Forms.Button();
            this.TraceABtn = new System.Windows.Forms.Button();
            this.TraceBBtn = new System.Windows.Forms.Button();
            this.MultABBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ARows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // ARows
            // 
            this.ARows.Location = new System.Drawing.Point(216, 96);
            this.ARows.Name = "ARows";
            this.ARows.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ARows.Size = new System.Drawing.Size(55, 27);
            this.ARows.TabIndex = 0;
            this.ARows.ValueChanged += new System.EventHandler(this.MatrixA_ValueChanged);
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(265, 42);
            this.ALabel.Name = "ALabel";
            this.ALabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ALabel.Size = new System.Drawing.Size(88, 20);
            this.ALabel.TabIndex = 1;
            this.ALabel.Text = "Матриця A:";
            // 
            // AColumns
            // 
            this.AColumns.Location = new System.Drawing.Point(342, 96);
            this.AColumns.Name = "AColumns";
            this.AColumns.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AColumns.Size = new System.Drawing.Size(55, 27);
            this.AColumns.TabIndex = 0;
            this.AColumns.ValueChanged += new System.EventHandler(this.MatrixA_ValueChanged);
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(931, 42);
            this.BLabel.Name = "BLabel";
            this.BLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BLabel.Size = new System.Drawing.Size(87, 20);
            this.BLabel.TabIndex = 1;
            this.BLabel.Text = "Матриця B:";
            // 
            // BRows
            // 
            this.BRows.Location = new System.Drawing.Point(883, 96);
            this.BRows.Name = "BRows";
            this.BRows.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BRows.Size = new System.Drawing.Size(55, 27);
            this.BRows.TabIndex = 0;
            this.BRows.ValueChanged += new System.EventHandler(this.MatrixB_ValueChanged);
            // 
            // BColumns
            // 
            this.BColumns.Location = new System.Drawing.Point(1017, 96);
            this.BColumns.Name = "BColumns";
            this.BColumns.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BColumns.Size = new System.Drawing.Size(55, 27);
            this.BColumns.TabIndex = 0;
            this.BColumns.ValueChanged += new System.EventHandler(this.MatrixB_ValueChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(595, 105);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 29);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "A+B";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SubBtn
            // 
            this.SubBtn.Location = new System.Drawing.Point(595, 140);
            this.SubBtn.Name = "SubBtn";
            this.SubBtn.Size = new System.Drawing.Size(94, 29);
            this.SubBtn.TabIndex = 2;
            this.SubBtn.Text = "A - B";
            this.SubBtn.UseVisualStyleBackColor = true;
            this.SubBtn.Click += new System.EventHandler(this.SubBtn_Click);
            // 
            // MultBABtn
            // 
            this.MultBABtn.Location = new System.Drawing.Point(595, 212);
            this.MultBABtn.Name = "MultBABtn";
            this.MultBABtn.Size = new System.Drawing.Size(94, 29);
            this.MultBABtn.TabIndex = 2;
            this.MultBABtn.Text = "B * A";
            this.MultBABtn.UseVisualStyleBackColor = true;
            this.MultBABtn.Click += new System.EventHandler(this.MultBABtn_Click);
            // 
            // TraceABtn
            // 
            this.TraceABtn.Location = new System.Drawing.Point(595, 247);
            this.TraceABtn.Name = "TraceABtn";
            this.TraceABtn.Size = new System.Drawing.Size(94, 29);
            this.TraceABtn.TabIndex = 2;
            this.TraceABtn.Text = "Trace (A)";
            this.TraceABtn.UseVisualStyleBackColor = true;
            this.TraceABtn.Click += new System.EventHandler(this.TraceABtn_Click);
            // 
            // TraceBBtn
            // 
            this.TraceBBtn.Location = new System.Drawing.Point(595, 282);
            this.TraceBBtn.Name = "TraceBBtn";
            this.TraceBBtn.Size = new System.Drawing.Size(94, 29);
            this.TraceBBtn.TabIndex = 2;
            this.TraceBBtn.Text = "Trace (B)";
            this.TraceBBtn.UseVisualStyleBackColor = true;
            this.TraceBBtn.Click += new System.EventHandler(this.TraceBBtn_Click);
            // 
            // MultABBtn
            // 
            this.MultABBtn.Location = new System.Drawing.Point(595, 177);
            this.MultABBtn.Name = "MultABBtn";
            this.MultABBtn.Size = new System.Drawing.Size(94, 29);
            this.MultABBtn.TabIndex = 2;
            this.MultABBtn.Text = "A * B";
            this.MultABBtn.UseVisualStyleBackColor = true;
            this.MultABBtn.Click += new System.EventHandler(this.MultABBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 739);
            this.Controls.Add(this.TraceBBtn);
            this.Controls.Add(this.TraceABtn);
            this.Controls.Add(this.MultABBtn);
            this.Controls.Add(this.MultBABtn);
            this.Controls.Add(this.SubBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.BColumns);
            this.Controls.Add(this.BRows);
            this.Controls.Add(this.AColumns);
            this.Controls.Add(this.ARows);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ARows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ARows;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.NumericUpDown AColumns;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.NumericUpDown BRows;
        private System.Windows.Forms.NumericUpDown BColumns;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SubBtn;
        private System.Windows.Forms.Button MultBABtn;
        private System.Windows.Forms.Button TraceABtn;
        private System.Windows.Forms.Button TraceBBtn;
        private System.Windows.Forms.Button MultABBtn;
    }
}
