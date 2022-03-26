namespace P01_Figures
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.tbFirstInput = new System.Windows.Forms.TextBox();
            this.tbSecondInput = new System.Windows.Forms.TextBox();
            this.tbThirdInput = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSecondInput = new System.Windows.Forms.Label();
            this.labelThirdInput = new System.Windows.Forms.Label();
            this.perimeter = new System.Windows.Forms.Label();
            this.perimeterResult = new System.Windows.Forms.Label();
            this.arealb = new System.Windows.Forms.Label();
            this.areaResult = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.rbCircle);
            this.groupBox1.Controls.Add(this.rbRectangle);
            this.groupBox1.Controls.Add(this.rbSquare);
            this.groupBox1.Controls.Add(this.rbTriangle);
            this.groupBox1.Location = new System.Drawing.Point(56, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 30);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(43, 182);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(55, 19);
            this.rbCircle.TabIndex = 3;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            this.rbCircle.CheckedChanged += new System.EventHandler(this.rbCircle_CheckedChanged);
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(43, 137);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(77, 19);
            this.rbRectangle.TabIndex = 2;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            this.rbRectangle.CheckedChanged += new System.EventHandler(this.rbRectangle_CheckedChanged);
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Location = new System.Drawing.Point(43, 93);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(61, 19);
            this.rbSquare.TabIndex = 1;
            this.rbSquare.TabStop = true;
            this.rbSquare.Text = "Square";
            this.rbSquare.UseVisualStyleBackColor = true;
            this.rbSquare.CheckedChanged += new System.EventHandler(this.rbSquare_CheckedChanged);
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Location = new System.Drawing.Point(43, 48);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(66, 19);
            this.rbTriangle.TabIndex = 0;
            this.rbTriangle.TabStop = true;
            this.rbTriangle.Text = "Triangle";
            this.rbTriangle.UseVisualStyleBackColor = true;
            this.rbTriangle.CheckedChanged += new System.EventHandler(this.rbTriangle_CheckedChanged);
            // 
            // tbFirstInput
            // 
            this.tbFirstInput.Location = new System.Drawing.Point(364, 75);
            this.tbFirstInput.Name = "tbFirstInput";
            this.tbFirstInput.Size = new System.Drawing.Size(100, 23);
            this.tbFirstInput.TabIndex = 1;
            // 
            // tbSecondInput
            // 
            this.tbSecondInput.Location = new System.Drawing.Point(364, 113);
            this.tbSecondInput.Name = "tbSecondInput";
            this.tbSecondInput.Size = new System.Drawing.Size(100, 23);
            this.tbSecondInput.TabIndex = 2;
            // 
            // tbThirdInput
            // 
            this.tbThirdInput.Location = new System.Drawing.Point(364, 153);
            this.tbThirdInput.Name = "tbThirdInput";
            this.tbThirdInput.Size = new System.Drawing.Size(100, 23);
            this.tbThirdInput.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(300, 219);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(190, 72);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "a=";
            // 
            // labelSecondInput
            // 
            this.labelSecondInput.AutoSize = true;
            this.labelSecondInput.Location = new System.Drawing.Point(336, 116);
            this.labelSecondInput.Name = "labelSecondInput";
            this.labelSecondInput.Size = new System.Drawing.Size(22, 15);
            this.labelSecondInput.TabIndex = 6;
            this.labelSecondInput.Text = "b=";
            // 
            // labelThirdInput
            // 
            this.labelThirdInput.AutoSize = true;
            this.labelThirdInput.Location = new System.Drawing.Point(336, 157);
            this.labelThirdInput.Name = "labelThirdInput";
            this.labelThirdInput.Size = new System.Drawing.Size(21, 15);
            this.labelThirdInput.TabIndex = 7;
            this.labelThirdInput.Text = "c=";
            // 
            // perimeter
            // 
            this.perimeter.AutoSize = true;
            this.perimeter.Location = new System.Drawing.Point(300, 201);
            this.perimeter.Name = "perimeter";
            this.perimeter.Size = new System.Drawing.Size(61, 15);
            this.perimeter.TabIndex = 8;
            this.perimeter.Text = "Perimeter:";
            // 
            // perimeterResult
            // 
            this.perimeterResult.AutoSize = true;
            this.perimeterResult.Location = new System.Drawing.Point(364, 201);
            this.perimeterResult.Name = "perimeterResult";
            this.perimeterResult.Size = new System.Drawing.Size(0, 15);
            this.perimeterResult.TabIndex = 9;
            // 
            // arealb
            // 
            this.arealb.AutoSize = true;
            this.arealb.Location = new System.Drawing.Point(415, 201);
            this.arealb.Name = "arealb";
            this.arealb.Size = new System.Drawing.Size(34, 15);
            this.arealb.TabIndex = 10;
            this.arealb.Text = "Area:";
            // 
            // areaResult
            // 
            this.areaResult.AutoSize = true;
            this.areaResult.Location = new System.Drawing.Point(452, 201);
            this.areaResult.Name = "areaResult";
            this.areaResult.Size = new System.Drawing.Size(0, 15);
            this.areaResult.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(62, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 47);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(104, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 19);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Area";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 19);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Perimeter";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.areaResult);
            this.Controls.Add(this.arealb);
            this.Controls.Add(this.perimeterResult);
            this.Controls.Add(this.perimeter);
            this.Controls.Add(this.labelThirdInput);
            this.Controls.Add(this.labelSecondInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.tbThirdInput);
            this.Controls.Add(this.tbSecondInput);
            this.Controls.Add(this.tbFirstInput);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.TextBox tbFirstInput;
        private System.Windows.Forms.TextBox tbSecondInput;
        private System.Windows.Forms.TextBox tbThirdInput;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSecondInput;
        private System.Windows.Forms.Label labelThirdInput;
        private System.Windows.Forms.Label perimeter;
        private System.Windows.Forms.Label perimeterResult;
        private System.Windows.Forms.Label arealb;
        private System.Windows.Forms.Label areaResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
