namespace AusteraGame
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
            this.panMap = new System.Windows.Forms.Panel();
            this.btnGenerateMap = new System.Windows.Forms.Button();
            this.btnPlaceHero = new System.Windows.Forms.Button();
            this.labScale = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labDistance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panMap
            // 
            this.panMap.Location = new System.Drawing.Point(0, 0);
            this.panMap.Name = "panMap";
            this.panMap.Size = new System.Drawing.Size(750, 750);
            this.panMap.TabIndex = 1;
            // 
            // btnGenerateMap
            // 
            this.btnGenerateMap.Location = new System.Drawing.Point(756, 12);
            this.btnGenerateMap.Name = "btnGenerateMap";
            this.btnGenerateMap.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateMap.TabIndex = 2;
            this.btnGenerateMap.Text = "Generate";
            this.btnGenerateMap.UseVisualStyleBackColor = true;
            this.btnGenerateMap.Click += new System.EventHandler(this.btnGenerateMap_Click);
            // 
            // btnPlaceHero
            // 
            this.btnPlaceHero.Location = new System.Drawing.Point(756, 41);
            this.btnPlaceHero.Name = "btnPlaceHero";
            this.btnPlaceHero.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceHero.TabIndex = 3;
            this.btnPlaceHero.Text = "Place Hero";
            this.btnPlaceHero.UseVisualStyleBackColor = true;
            this.btnPlaceHero.Click += new System.EventHandler(this.btnPlaceHero_Click);
            // 
            // labScale
            // 
            this.labScale.AutoSize = true;
            this.labScale.Location = new System.Drawing.Point(765, 474);
            this.labScale.Name = "labScale";
            this.labScale.Size = new System.Drawing.Size(21, 13);
            this.labScale.TabIndex = 4;
            this.labScale.Text = "km";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(756, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "|--------------|";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(756, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Distance Travelled: ";
            // 
            // labDistance
            // 
            this.labDistance.AutoSize = true;
            this.labDistance.Location = new System.Drawing.Point(864, 437);
            this.labDistance.Name = "labDistance";
            this.labDistance.Size = new System.Drawing.Size(0, 13);
            this.labDistance.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 761);
            this.Controls.Add(this.labDistance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labScale);
            this.Controls.Add(this.btnPlaceHero);
            this.Controls.Add(this.btnGenerateMap);
            this.Controls.Add(this.panMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panMap;
        private System.Windows.Forms.Button btnGenerateMap;
        private System.Windows.Forms.Button btnPlaceHero;
        private System.Windows.Forms.Label labScale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labDistance;
    }
}

