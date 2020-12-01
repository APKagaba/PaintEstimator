namespace Prog1
{
    partial class Program1
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
            this.TotalLengthlbl = new System.Windows.Forms.Label();
            this.LengthTxt = new System.Windows.Forms.TextBox();
            this.Heightlbl = new System.Windows.Forms.Label();
            this.Doorslbl = new System.Windows.Forms.Label();
            this.Windowslbl = new System.Windows.Forms.Label();
            this.Paintlbl = new System.Windows.Forms.Label();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.GallonsMinlbl = new System.Windows.Forms.Label();
            this.HeightTxt = new System.Windows.Forms.TextBox();
            this.DoorsTxt = new System.Windows.Forms.TextBox();
            this.WindowsTxt = new System.Windows.Forms.TextBox();
            this.CoatsTxt = new System.Windows.Forms.TextBox();
            this.outputGlbl = new System.Windows.Forms.Label();
            this.GallonsBuylbl = new System.Windows.Forms.Label();
            this.outputG2lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TotalLengthlbl
            // 
            this.TotalLengthlbl.AutoSize = true;
            this.TotalLengthlbl.Location = new System.Drawing.Point(12, 9);
            this.TotalLengthlbl.Name = "TotalLengthlbl";
            this.TotalLengthlbl.Size = new System.Drawing.Size(120, 17);
            this.TotalLengthlbl.TabIndex = 0;
            this.TotalLengthlbl.Text = "Enter total length:";
            // 
            // LengthTxt
            // 
            this.LengthTxt.Location = new System.Drawing.Point(148, 9);
            this.LengthTxt.Name = "LengthTxt";
            this.LengthTxt.Size = new System.Drawing.Size(100, 22);
            this.LengthTxt.TabIndex = 1;
            // 
            // Heightlbl
            // 
            this.Heightlbl.AutoSize = true;
            this.Heightlbl.Location = new System.Drawing.Point(12, 42);
            this.Heightlbl.Name = "Heightlbl";
            this.Heightlbl.Size = new System.Drawing.Size(49, 17);
            this.Heightlbl.TabIndex = 2;
            this.Heightlbl.Text = "Height";
            // 
            // Doorslbl
            // 
            this.Doorslbl.AutoSize = true;
            this.Doorslbl.Location = new System.Drawing.Point(12, 74);
            this.Doorslbl.Name = "Doorslbl";
            this.Doorslbl.Size = new System.Drawing.Size(114, 17);
            this.Doorslbl.TabIndex = 3;
            this.Doorslbl.Text = "Number of doors";
            // 
            // Windowslbl
            // 
            this.Windowslbl.AutoSize = true;
            this.Windowslbl.Location = new System.Drawing.Point(12, 115);
            this.Windowslbl.Name = "Windowslbl";
            this.Windowslbl.Size = new System.Drawing.Size(130, 17);
            this.Windowslbl.TabIndex = 4;
            this.Windowslbl.Text = "Number of windows";
            // 
            // Paintlbl
            // 
            this.Paintlbl.AutoSize = true;
            this.Paintlbl.Location = new System.Drawing.Point(12, 144);
            this.Paintlbl.Name = "Paintlbl";
            this.Paintlbl.Size = new System.Drawing.Size(95, 17);
            this.Paintlbl.TabIndex = 5;
            this.Paintlbl.Text = "Coats of paint";
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(148, 267);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(173, 32);
            this.CalcBtn.TabIndex = 10;
            this.CalcBtn.Text = "Calculate Gallons";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // GallonsMinlbl
            // 
            this.GallonsMinlbl.AutoSize = true;
            this.GallonsMinlbl.Location = new System.Drawing.Point(12, 175);
            this.GallonsMinlbl.Name = "GallonsMinlbl";
            this.GallonsMinlbl.Size = new System.Drawing.Size(115, 17);
            this.GallonsMinlbl.TabIndex = 11;
            this.GallonsMinlbl.Text = "Minimum Gallons";
            // 
            // HeightTxt
            // 
            this.HeightTxt.Location = new System.Drawing.Point(148, 39);
            this.HeightTxt.Name = "HeightTxt";
            this.HeightTxt.Size = new System.Drawing.Size(100, 22);
            this.HeightTxt.TabIndex = 13;
            // 
            // DoorsTxt
            // 
            this.DoorsTxt.Location = new System.Drawing.Point(148, 74);
            this.DoorsTxt.Name = "DoorsTxt";
            this.DoorsTxt.Size = new System.Drawing.Size(100, 22);
            this.DoorsTxt.TabIndex = 14;
            // 
            // WindowsTxt
            // 
            this.WindowsTxt.Location = new System.Drawing.Point(148, 112);
            this.WindowsTxt.Name = "WindowsTxt";
            this.WindowsTxt.Size = new System.Drawing.Size(100, 22);
            this.WindowsTxt.TabIndex = 15;
            // 
            // CoatsTxt
            // 
            this.CoatsTxt.Location = new System.Drawing.Point(148, 144);
            this.CoatsTxt.Name = "CoatsTxt";
            this.CoatsTxt.Size = new System.Drawing.Size(100, 22);
            this.CoatsTxt.TabIndex = 16;
            // 
            // outputGlbl
            // 
            this.outputGlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputGlbl.Location = new System.Drawing.Point(148, 175);
            this.outputGlbl.Name = "outputGlbl";
            this.outputGlbl.Size = new System.Drawing.Size(100, 23);
            this.outputGlbl.TabIndex = 17;
            // 
            // GallonsBuylbl
            // 
            this.GallonsBuylbl.AutoSize = true;
            this.GallonsBuylbl.Location = new System.Drawing.Point(12, 212);
            this.GallonsBuylbl.Name = "GallonsBuylbl";
            this.GallonsBuylbl.Size = new System.Drawing.Size(99, 17);
            this.GallonsBuylbl.TabIndex = 18;
            this.GallonsBuylbl.Text = "Gallons to buy";
            // 
            // outputG2lbl
            // 
            this.outputG2lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputG2lbl.Location = new System.Drawing.Point(148, 212);
            this.outputG2lbl.Name = "outputG2lbl";
            this.outputG2lbl.Size = new System.Drawing.Size(100, 23);
            this.outputG2lbl.TabIndex = 19;
            // 
            // Program1
            // 
            this.AcceptButton = this.CalcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputG2lbl);
            this.Controls.Add(this.GallonsBuylbl);
            this.Controls.Add(this.outputGlbl);
            this.Controls.Add(this.CoatsTxt);
            this.Controls.Add(this.WindowsTxt);
            this.Controls.Add(this.DoorsTxt);
            this.Controls.Add(this.HeightTxt);
            this.Controls.Add(this.GallonsMinlbl);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.Paintlbl);
            this.Controls.Add(this.Windowslbl);
            this.Controls.Add(this.Doorslbl);
            this.Controls.Add(this.Heightlbl);
            this.Controls.Add(this.LengthTxt);
            this.Controls.Add(this.TotalLengthlbl);
            this.Name = "Program1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalLengthlbl;
        private System.Windows.Forms.TextBox LengthTxt;
        private System.Windows.Forms.Label Heightlbl;
        private System.Windows.Forms.Label Doorslbl;
        private System.Windows.Forms.Label Windowslbl;
        private System.Windows.Forms.Label Paintlbl;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Label GallonsMinlbl;
        private System.Windows.Forms.TextBox HeightTxt;
        private System.Windows.Forms.TextBox DoorsTxt;
        private System.Windows.Forms.TextBox WindowsTxt;
        private System.Windows.Forms.TextBox CoatsTxt;
        private System.Windows.Forms.Label outputGlbl;
        private System.Windows.Forms.Label GallonsBuylbl;
        private System.Windows.Forms.Label outputG2lbl;
    }
}

