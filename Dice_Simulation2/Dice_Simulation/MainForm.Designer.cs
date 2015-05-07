namespace Dice_Simulation
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
            this.btnRoll1 = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.btnRoll2 = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRoll1
            // 
            this.btnRoll1.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll1.Location = new System.Drawing.Point(21, 12);
            this.btnRoll1.Name = "btnRoll1";
            this.btnRoll1.Size = new System.Drawing.Size(97, 49);
            this.btnRoll1.TabIndex = 0;
            this.btnRoll1.Text = "Roll # 1";
            this.btnRoll1.UseVisualStyleBackColor = true;
            this.btnRoll1.Click += new System.EventHandler(this.btnRoll1_Click);
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(21, 67);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(332, 277);
            this.lstResults.TabIndex = 1;
            // 
            // btnRoll2
            // 
            this.btnRoll2.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll2.Location = new System.Drawing.Point(138, 12);
            this.btnRoll2.Name = "btnRoll2";
            this.btnRoll2.Size = new System.Drawing.Size(97, 49);
            this.btnRoll2.TabIndex = 2;
            this.btnRoll2.Text = "Roll # 2";
            this.btnRoll2.UseVisualStyleBackColor = true;
            this.btnRoll2.Click += new System.EventHandler(this.btnRoll2_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompare.Location = new System.Drawing.Point(256, 12);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(97, 49);
            this.btnCompare.TabIndex = 3;
            this.btnCompare.Text = "Compare sequences";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnRoll1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 358);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnRoll2);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnRoll1);
            this.Name = "MainForm";
            this.Text = "Dice Simulation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRoll1;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Button btnRoll2;
        private System.Windows.Forms.Button btnCompare;
    }
}

