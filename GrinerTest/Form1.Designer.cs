namespace GrienerTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSource = new System.Windows.Forms.Button();
            this.btnClip = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnLoadResult = new System.Windows.Forms.Button();
            this.btnClearResult = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.btnSminusC = new System.Windows.Forms.Button();
            this.btnCMinusS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(33, 74);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(75, 23);
            this.btnSource.TabIndex = 0;
            this.btnSource.Text = "Subject";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnClip
            // 
            this.btnClip.Location = new System.Drawing.Point(139, 74);
            this.btnClip.Name = "btnClip";
            this.btnClip.Size = new System.Drawing.Size(75, 23);
            this.btnClip.TabIndex = 1;
            this.btnClip.Text = "Clip";
            this.btnClip.UseVisualStyleBackColor = true;
            this.btnClip.Click += new System.EventHandler(this.btnClip_Click);
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.White;
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(32, 169);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(773, 565);
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // btnLoadResult
            // 
            this.btnLoadResult.Location = new System.Drawing.Point(287, 74);
            this.btnLoadResult.Name = "btnLoadResult";
            this.btnLoadResult.Size = new System.Drawing.Size(75, 23);
            this.btnLoadResult.TabIndex = 4;
            this.btnLoadResult.Text = "Intersect";
            this.btnLoadResult.UseVisualStyleBackColor = true;
            this.btnLoadResult.Click += new System.EventHandler(this.btnIntersection_Click);
            // 
            // btnClearResult
            // 
            this.btnClearResult.Location = new System.Drawing.Point(0, 0);
            this.btnClearResult.Name = "btnClearResult";
            this.btnClearResult.Size = new System.Drawing.Size(75, 23);
            this.btnClearResult.TabIndex = 14;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.Location = new System.Drawing.Point(45, 115);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(152, 24);
            this.lblSelected.TabIndex = 6;
            this.lblSelected.Text = "Subject Selected";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(731, 74);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Clear";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(368, 74);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(75, 23);
            this.btnUnion.TabIndex = 8;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // btnSminusC
            // 
            this.btnSminusC.Location = new System.Drawing.Point(459, 74);
            this.btnSminusC.Name = "btnSminusC";
            this.btnSminusC.Size = new System.Drawing.Size(75, 23);
            this.btnSminusC.TabIndex = 9;
            this.btnSminusC.Text = "C - S";
            this.btnSminusC.UseVisualStyleBackColor = true;
            this.btnSminusC.Click += new System.EventHandler(this.btnCminusS_Click);
            // 
            // btnCMinusS
            // 
            this.btnCMinusS.Location = new System.Drawing.Point(549, 74);
            this.btnCMinusS.Name = "btnCMinusS";
            this.btnCMinusS.Size = new System.Drawing.Size(75, 23);
            this.btnCMinusS.TabIndex = 10;
            this.btnCMinusS.Text = "S - C";
            this.btnCMinusS.UseVisualStyleBackColor = true;
            this.btnCMinusS.Click += new System.EventHandler(this.btnSMinusC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(835, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select Polygon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Operation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 756);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCMinusS);
            this.Controls.Add(this.btnSminusC);
            this.Controls.Add(this.btnUnion);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.btnClearResult);
            this.Controls.Add(this.btnLoadResult);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnClip);
            this.Controls.Add(this.btnSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnClip;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnLoadResult;
        private System.Windows.Forms.Button btnClearResult;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.Button btnSminusC;
        private System.Windows.Forms.Button btnCMinusS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

