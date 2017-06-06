namespace SAM_Calculator
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
            this.calcbox = new System.Windows.Forms.TextBox();
            this.Closethis = new System.Windows.Forms.PictureBox();
            this.Dumb = new System.Windows.Forms.CheckBox();
            this.HelpMe = new System.Windows.Forms.Button();
            this.ListenB = new System.Windows.Forms.Button();
            this.ClearT = new System.Windows.Forms.Button();
            this.FunctionPnl = new System.Windows.Forms.Panel();
            this.YText = new System.Windows.Forms.TextBox();
            this.YT = new System.Windows.Forms.Button();
            this.ResultT = new System.Windows.Forms.Button();
            this.XText = new System.Windows.Forms.TextBox();
            this.XT = new System.Windows.Forms.Button();
            this.RadiansT = new System.Windows.Forms.RadioButton();
            this.DegreeT = new System.Windows.Forms.RadioButton();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.XFacT = new System.Windows.Forms.Button();
            this.XY = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.X3 = new System.Windows.Forms.Button();
            this.X2 = new System.Windows.Forms.Button();
            this.PiT = new System.Windows.Forms.Button();
            this.CosecT = new System.Windows.Forms.Button();
            this.SecT = new System.Windows.Forms.Button();
            this.CotT = new System.Windows.Forms.Button();
            this.CosT = new System.Windows.Forms.Button();
            this.SinT = new System.Windows.Forms.Button();
            this.TanT = new System.Windows.Forms.Button();
            this.AngleText = new System.Windows.Forms.TextBox();
            this.AngleT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Closethis)).BeginInit();
            this.FunctionPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // calcbox
            // 
            this.calcbox.BackColor = System.Drawing.Color.Black;
            this.calcbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.calcbox.Location = new System.Drawing.Point(60, 79);
            this.calcbox.Multiline = true;
            this.calcbox.Name = "calcbox";
            this.calcbox.Size = new System.Drawing.Size(390, 225);
            this.calcbox.TabIndex = 0;
            this.calcbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calcbox_KeyPress);
            // 
            // Closethis
            // 
            this.Closethis.BackColor = System.Drawing.Color.Transparent;
            this.Closethis.BackgroundImage = global::SAM_Calculator.Properties.Resources.close_icon;
            this.Closethis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Closethis.Location = new System.Drawing.Point(424, 42);
            this.Closethis.Name = "Closethis";
            this.Closethis.Size = new System.Drawing.Size(26, 25);
            this.Closethis.TabIndex = 172;
            this.Closethis.TabStop = false;
            this.Closethis.Click += new System.EventHandler(this.Closethis_Click);
            // 
            // Dumb
            // 
            this.Dumb.AutoSize = true;
            this.Dumb.Location = new System.Drawing.Point(12, 468);
            this.Dumb.Name = "Dumb";
            this.Dumb.Size = new System.Drawing.Size(15, 14);
            this.Dumb.TabIndex = 180;
            this.Dumb.UseVisualStyleBackColor = true;
            this.Dumb.Visible = false;
            // 
            // HelpMe
            // 
            this.HelpMe.BackColor = System.Drawing.SystemColors.ControlText;
            this.HelpMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpMe.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.HelpMe.Location = new System.Drawing.Point(374, 310);
            this.HelpMe.Name = "HelpMe";
            this.HelpMe.Size = new System.Drawing.Size(66, 66);
            this.HelpMe.TabIndex = 179;
            this.HelpMe.Text = "Help";
            this.HelpMe.UseVisualStyleBackColor = false;
            this.HelpMe.Click += new System.EventHandler(this.HelpMe_Click);
            // 
            // ListenB
            // 
            this.ListenB.BackColor = System.Drawing.SystemColors.ControlText;
            this.ListenB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListenB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListenB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ListenB.Location = new System.Drawing.Point(374, 420);
            this.ListenB.Name = "ListenB";
            this.ListenB.Size = new System.Drawing.Size(66, 32);
            this.ListenB.TabIndex = 176;
            this.ListenB.Text = "Mute";
            this.ListenB.UseVisualStyleBackColor = false;
            this.ListenB.Click += new System.EventHandler(this.ListenB_Click);
            // 
            // ClearT
            // 
            this.ClearT.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClearT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClearT.Location = new System.Drawing.Point(374, 382);
            this.ClearT.Name = "ClearT";
            this.ClearT.Size = new System.Drawing.Size(66, 32);
            this.ClearT.TabIndex = 177;
            this.ClearT.Text = "Clear";
            this.ClearT.UseVisualStyleBackColor = false;
            this.ClearT.Click += new System.EventHandler(this.ClearT_Click);
            // 
            // FunctionPnl
            // 
            this.FunctionPnl.BackColor = System.Drawing.Color.Transparent;
            this.FunctionPnl.Controls.Add(this.YText);
            this.FunctionPnl.Controls.Add(this.YT);
            this.FunctionPnl.Controls.Add(this.ResultT);
            this.FunctionPnl.Controls.Add(this.XText);
            this.FunctionPnl.Controls.Add(this.XT);
            this.FunctionPnl.Controls.Add(this.RadiansT);
            this.FunctionPnl.Controls.Add(this.DegreeT);
            this.FunctionPnl.Controls.Add(this.ResultText);
            this.FunctionPnl.Controls.Add(this.XFacT);
            this.FunctionPnl.Controls.Add(this.XY);
            this.FunctionPnl.Controls.Add(this.Sqrt);
            this.FunctionPnl.Controls.Add(this.X3);
            this.FunctionPnl.Controls.Add(this.X2);
            this.FunctionPnl.Controls.Add(this.PiT);
            this.FunctionPnl.Controls.Add(this.CosecT);
            this.FunctionPnl.Controls.Add(this.SecT);
            this.FunctionPnl.Controls.Add(this.CotT);
            this.FunctionPnl.Controls.Add(this.CosT);
            this.FunctionPnl.Controls.Add(this.SinT);
            this.FunctionPnl.Controls.Add(this.TanT);
            this.FunctionPnl.Controls.Add(this.AngleText);
            this.FunctionPnl.Controls.Add(this.AngleT);
            this.FunctionPnl.Location = new System.Drawing.Point(60, 304);
            this.FunctionPnl.Name = "FunctionPnl";
            this.FunctionPnl.Size = new System.Drawing.Size(308, 214);
            this.FunctionPnl.TabIndex = 178;
            // 
            // YText
            // 
            this.YText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.YText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.YText.Location = new System.Drawing.Point(249, 26);
            this.YText.Name = "YText";
            this.YText.Size = new System.Drawing.Size(50, 26);
            this.YText.TabIndex = 21;
            // 
            // YT
            // 
            this.YT.BackColor = System.Drawing.SystemColors.ControlText;
            this.YT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.YT.Location = new System.Drawing.Point(219, 22);
            this.YT.Name = "YT";
            this.YT.Size = new System.Drawing.Size(24, 32);
            this.YT.TabIndex = 20;
            this.YT.Text = "Y";
            this.YT.UseVisualStyleBackColor = false;
            // 
            // ResultT
            // 
            this.ResultT.BackColor = System.Drawing.SystemColors.ControlText;
            this.ResultT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ResultT.Location = new System.Drawing.Point(7, 174);
            this.ResultT.Name = "ResultT";
            this.ResultT.Size = new System.Drawing.Size(86, 32);
            this.ResultT.TabIndex = 19;
            this.ResultT.Text = "Result";
            this.ResultT.UseVisualStyleBackColor = false;
            // 
            // XText
            // 
            this.XText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.XText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.XText.Location = new System.Drawing.Point(163, 26);
            this.XText.Name = "XText";
            this.XText.Size = new System.Drawing.Size(50, 26);
            this.XText.TabIndex = 18;
            // 
            // XT
            // 
            this.XT.BackColor = System.Drawing.SystemColors.ControlText;
            this.XT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.XT.Location = new System.Drawing.Point(133, 22);
            this.XT.Name = "XT";
            this.XT.Size = new System.Drawing.Size(24, 32);
            this.XT.TabIndex = 17;
            this.XT.Text = "X";
            this.XT.UseVisualStyleBackColor = false;
            // 
            // RadiansT
            // 
            this.RadiansT.AutoSize = true;
            this.RadiansT.BackColor = System.Drawing.Color.Transparent;
            this.RadiansT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadiansT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadiansT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RadiansT.Location = new System.Drawing.Point(99, 1);
            this.RadiansT.Name = "RadiansT";
            this.RadiansT.Size = new System.Drawing.Size(83, 20);
            this.RadiansT.TabIndex = 10;
            this.RadiansT.Text = "Radians";
            this.RadiansT.UseVisualStyleBackColor = false;
            // 
            // DegreeT
            // 
            this.DegreeT.AutoSize = true;
            this.DegreeT.BackColor = System.Drawing.Color.Transparent;
            this.DegreeT.Checked = true;
            this.DegreeT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DegreeT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DegreeT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DegreeT.Location = new System.Drawing.Point(8, 1);
            this.DegreeT.Name = "DegreeT";
            this.DegreeT.Size = new System.Drawing.Size(85, 20);
            this.DegreeT.TabIndex = 9;
            this.DegreeT.TabStop = true;
            this.DegreeT.Text = "Degrees";
            this.DegreeT.UseVisualStyleBackColor = false;
            // 
            // ResultText
            // 
            this.ResultText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ResultText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ResultText.Location = new System.Drawing.Point(99, 178);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(198, 26);
            this.ResultText.TabIndex = 16;
            // 
            // XFacT
            // 
            this.XFacT.BackColor = System.Drawing.SystemColors.ControlText;
            this.XFacT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XFacT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XFacT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.XFacT.Location = new System.Drawing.Point(158, 98);
            this.XFacT.Name = "XFacT";
            this.XFacT.Size = new System.Drawing.Size(70, 32);
            this.XFacT.TabIndex = 15;
            this.XFacT.Text = "X!";
            this.XFacT.UseVisualStyleBackColor = false;
            this.XFacT.Click += new System.EventHandler(this.XFacT_Click);
            // 
            // XY
            // 
            this.XY.BackColor = System.Drawing.SystemColors.ControlText;
            this.XY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XY.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.XY.Location = new System.Drawing.Point(234, 60);
            this.XY.Name = "XY";
            this.XY.Size = new System.Drawing.Size(70, 32);
            this.XY.TabIndex = 14;
            this.XY.Text = "X^Y";
            this.XY.UseVisualStyleBackColor = false;
            this.XY.Click += new System.EventHandler(this.XY_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.BackColor = System.Drawing.SystemColors.ControlText;
            this.Sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sqrt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Sqrt.Location = new System.Drawing.Point(158, 60);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(70, 32);
            this.Sqrt.TabIndex = 13;
            this.Sqrt.Text = "√X";
            this.Sqrt.UseVisualStyleBackColor = false;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // X3
            // 
            this.X3.BackColor = System.Drawing.SystemColors.ControlText;
            this.X3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.X3.Location = new System.Drawing.Point(234, 136);
            this.X3.Name = "X3";
            this.X3.Size = new System.Drawing.Size(70, 32);
            this.X3.TabIndex = 12;
            this.X3.Text = "X^3";
            this.X3.UseVisualStyleBackColor = false;
            this.X3.Click += new System.EventHandler(this.X3_Click);
            // 
            // X2
            // 
            this.X2.BackColor = System.Drawing.SystemColors.ControlText;
            this.X2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.X2.Location = new System.Drawing.Point(234, 98);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(70, 32);
            this.X2.TabIndex = 11;
            this.X2.Text = "X^2";
            this.X2.UseVisualStyleBackColor = false;
            this.X2.Click += new System.EventHandler(this.X2_Click);
            // 
            // PiT
            // 
            this.PiT.BackColor = System.Drawing.SystemColors.ControlText;
            this.PiT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PiT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PiT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PiT.Location = new System.Drawing.Point(158, 136);
            this.PiT.Name = "PiT";
            this.PiT.Size = new System.Drawing.Size(70, 32);
            this.PiT.TabIndex = 8;
            this.PiT.Text = "Pi(π)";
            this.PiT.UseVisualStyleBackColor = false;
            this.PiT.Click += new System.EventHandler(this.PiT_Click);
            // 
            // CosecT
            // 
            this.CosecT.BackColor = System.Drawing.SystemColors.ControlText;
            this.CosecT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CosecT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CosecT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CosecT.Location = new System.Drawing.Point(82, 60);
            this.CosecT.Name = "CosecT";
            this.CosecT.Size = new System.Drawing.Size(70, 32);
            this.CosecT.TabIndex = 7;
            this.CosecT.Text = "Cosec";
            this.CosecT.UseVisualStyleBackColor = false;
            this.CosecT.Click += new System.EventHandler(this.CosecT_Click);
            // 
            // SecT
            // 
            this.SecT.BackColor = System.Drawing.SystemColors.ControlText;
            this.SecT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SecT.Location = new System.Drawing.Point(82, 98);
            this.SecT.Name = "SecT";
            this.SecT.Size = new System.Drawing.Size(69, 32);
            this.SecT.TabIndex = 6;
            this.SecT.Text = "Sec";
            this.SecT.UseVisualStyleBackColor = false;
            this.SecT.Click += new System.EventHandler(this.SecT_Click);
            // 
            // CotT
            // 
            this.CotT.BackColor = System.Drawing.SystemColors.ControlText;
            this.CotT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CotT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CotT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CotT.Location = new System.Drawing.Point(83, 136);
            this.CotT.Name = "CotT";
            this.CotT.Size = new System.Drawing.Size(69, 32);
            this.CotT.TabIndex = 5;
            this.CotT.Text = "Cot";
            this.CotT.UseVisualStyleBackColor = false;
            this.CotT.Click += new System.EventHandler(this.CotT_Click);
            // 
            // CosT
            // 
            this.CosT.BackColor = System.Drawing.SystemColors.ControlText;
            this.CosT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CosT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CosT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CosT.Location = new System.Drawing.Point(7, 98);
            this.CosT.Name = "CosT";
            this.CosT.Size = new System.Drawing.Size(69, 32);
            this.CosT.TabIndex = 4;
            this.CosT.Text = "Cos";
            this.CosT.UseVisualStyleBackColor = false;
            this.CosT.Click += new System.EventHandler(this.CosT_Click);
            // 
            // SinT
            // 
            this.SinT.BackColor = System.Drawing.SystemColors.ControlText;
            this.SinT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SinT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SinT.Location = new System.Drawing.Point(7, 60);
            this.SinT.Name = "SinT";
            this.SinT.Size = new System.Drawing.Size(69, 32);
            this.SinT.TabIndex = 3;
            this.SinT.Text = "Sin";
            this.SinT.UseVisualStyleBackColor = false;
            this.SinT.Click += new System.EventHandler(this.SinT_Click);
            // 
            // TanT
            // 
            this.TanT.BackColor = System.Drawing.SystemColors.ControlText;
            this.TanT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TanT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TanT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TanT.Location = new System.Drawing.Point(7, 136);
            this.TanT.Name = "TanT";
            this.TanT.Size = new System.Drawing.Size(69, 32);
            this.TanT.TabIndex = 2;
            this.TanT.Text = "Tan";
            this.TanT.UseVisualStyleBackColor = false;
            this.TanT.Click += new System.EventHandler(this.TanT_Click);
            // 
            // AngleText
            // 
            this.AngleText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AngleText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AngleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AngleText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AngleText.Location = new System.Drawing.Point(44, 26);
            this.AngleText.Name = "AngleText";
            this.AngleText.Size = new System.Drawing.Size(83, 26);
            this.AngleText.TabIndex = 1;
            // 
            // AngleT
            // 
            this.AngleT.AutoSize = true;
            this.AngleT.BackColor = System.Drawing.SystemColors.ControlText;
            this.AngleT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AngleT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AngleT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AngleT.Location = new System.Drawing.Point(7, 22);
            this.AngleT.Name = "AngleT";
            this.AngleT.Size = new System.Drawing.Size(31, 32);
            this.AngleT.TabIndex = 0;
            this.AngleT.Text = "θ";
            this.AngleT.UseVisualStyleBackColor = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAM_Calculator.Properties.Resources.CalculatorWindow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(490, 550);
            this.Controls.Add(this.Dumb);
            this.Controls.Add(this.HelpMe);
            this.Controls.Add(this.ListenB);
            this.Controls.Add(this.ClearT);
            this.Controls.Add(this.FunctionPnl);
            this.Controls.Add(this.Closethis);
            this.Controls.Add(this.calcbox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculator";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.Closethis)).EndInit();
            this.FunctionPnl.ResumeLayout(false);
            this.FunctionPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calcbox;
        private System.Windows.Forms.PictureBox Closethis;
        private System.Windows.Forms.CheckBox Dumb;
        private System.Windows.Forms.Button HelpMe;
        private System.Windows.Forms.Button ListenB;
        private System.Windows.Forms.Button ClearT;
        private System.Windows.Forms.Panel FunctionPnl;
        private System.Windows.Forms.TextBox YText;
        private System.Windows.Forms.Button YT;
        private System.Windows.Forms.Button ResultT;
        private System.Windows.Forms.TextBox XText;
        private System.Windows.Forms.Button XT;
        private System.Windows.Forms.RadioButton RadiansT;
        private System.Windows.Forms.RadioButton DegreeT;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.Button XFacT;
        private System.Windows.Forms.Button XY;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button X3;
        private System.Windows.Forms.Button X2;
        private System.Windows.Forms.Button PiT;
        private System.Windows.Forms.Button CosecT;
        private System.Windows.Forms.Button SecT;
        private System.Windows.Forms.Button CotT;
        private System.Windows.Forms.Button CosT;
        private System.Windows.Forms.Button SinT;
        private System.Windows.Forms.Button TanT;
        private System.Windows.Forms.TextBox AngleText;
        private System.Windows.Forms.Button AngleT;
    }
}

