namespace _8_Puzzle
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            bt4 = new Button();
            bt5 = new Button();
            bt6 = new Button();
            bt7 = new Button();
            bt8 = new Button();
            textBoxTime = new TextBox();
            textBoxStep = new TextBox();
            btMix = new Button();
            btSolve = new Button();
            btExit = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.35971F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.64029F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 134F));
            tableLayoutPanel1.Controls.Add(bt1, 0, 0);
            tableLayoutPanel1.Controls.Add(bt2, 1, 0);
            tableLayoutPanel1.Controls.Add(bt3, 2, 0);
            tableLayoutPanel1.Controls.Add(bt4, 0, 1);
            tableLayoutPanel1.Controls.Add(bt5, 1, 1);
            tableLayoutPanel1.Controls.Add(bt6, 2, 1);
            tableLayoutPanel1.Controls.Add(bt7, 0, 2);
            tableLayoutPanel1.Controls.Add(bt8, 1, 2);
            tableLayoutPanel1.Location = new Point(171, 176);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.23256F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.76744F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableLayoutPanel1.Size = new Size(413, 307);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // bt1
            // 
            bt1.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bt1.Location = new Point(3, 3);
            bt1.Name = "bt1";
            bt1.Size = new Size(134, 99);
            bt1.TabIndex = 0;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            // 
            // bt2
            // 
            bt2.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bt2.Location = new Point(143, 3);
            bt2.Name = "bt2";
            bt2.Size = new Size(132, 99);
            bt2.TabIndex = 1;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            // 
            // bt3
            // 
            bt3.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bt3.Location = new Point(281, 3);
            bt3.Name = "bt3";
            bt3.Size = new Size(129, 99);
            bt3.TabIndex = 2;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            // 
            // bt4
            // 
            bt4.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bt4.Location = new Point(3, 108);
            bt4.Name = "bt4";
            bt4.Size = new Size(134, 99);
            bt4.TabIndex = 3;
            bt4.Text = "4";
            bt4.UseVisualStyleBackColor = true;
            // 
            // bt5
            // 
            bt5.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bt5.Location = new Point(143, 108);
            bt5.Name = "bt5";
            bt5.Size = new Size(132, 99);
            bt5.TabIndex = 4;
            bt5.Text = "5";
            bt5.UseVisualStyleBackColor = true;
            // 
            // bt6
            // 
            bt6.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bt6.Location = new Point(281, 108);
            bt6.Name = "bt6";
            bt6.Size = new Size(129, 99);
            bt6.TabIndex = 5;
            bt6.Text = "6";
            bt6.UseVisualStyleBackColor = true;
            // 
            // bt7
            // 
            bt7.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bt7.Location = new Point(3, 213);
            bt7.Name = "bt7";
            bt7.Size = new Size(134, 91);
            bt7.TabIndex = 6;
            bt7.Text = "7";
            bt7.UseVisualStyleBackColor = true;
            // 
            // bt8
            // 
            bt8.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bt8.Location = new Point(143, 213);
            bt8.Name = "bt8";
            bt8.Size = new Size(132, 91);
            bt8.TabIndex = 7;
            bt8.Text = "8";
            bt8.UseVisualStyleBackColor = true;
            // 
            // textBoxTime
            // 
            textBoxTime.BackColor = SystemColors.GradientActiveCaption;
            textBoxTime.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxTime.Location = new Point(677, 206);
            textBoxTime.Multiline = true;
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(123, 41);
            textBoxTime.TabIndex = 1;
            // 
            // textBoxStep
            // 
            textBoxStep.BackColor = SystemColors.GradientActiveCaption;
            textBoxStep.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxStep.Location = new Point(894, 206);
            textBoxStep.Multiline = true;
            textBoxStep.Name = "textBoxStep";
            textBoxStep.Size = new Size(125, 41);
            textBoxStep.TabIndex = 2;
            // 
            // btMix
            // 
            btMix.BackColor = SystemColors.Desktop;
            btMix.Font = new Font("Tw Cen MT Condensed Extra Bold", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btMix.ForeColor = SystemColors.ControlLightLight;
            btMix.Location = new Point(792, 319);
            btMix.Name = "btMix";
            btMix.Size = new Size(112, 36);
            btMix.TabIndex = 3;
            btMix.Text = "Xáo trộn";
            btMix.UseVisualStyleBackColor = false;
            // 
            // btSolve
            // 
            btSolve.BackColor = SystemColors.Desktop;
            btSolve.Font = new Font("Tw Cen MT Condensed Extra Bold", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btSolve.ForeColor = SystemColors.ButtonFace;
            btSolve.Location = new Point(792, 419);
            btSolve.Name = "btSolve";
            btSolve.Size = new Size(112, 36);
            btSolve.TabIndex = 4;
            btSolve.Text = "Giải";
            btSolve.UseVisualStyleBackColor = false;
            // 
            // btExit
            // 
            btExit.Font = new Font("Tw Cen MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btExit.Location = new Point(1172, 438);
            btExit.Name = "btExit";
            btExit.Size = new Size(114, 42);
            btExit.TabIndex = 5;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(675, 170);
            label1.Name = "label1";
            label1.Size = new Size(125, 24);
            label1.TabIndex = 6;
            label1.Text = "Thời gian";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(894, 170);
            label2.Name = "label2";
            label2.Size = new Size(108, 24);
            label2.TabIndex = 7;
            label2.Text = "Số bước ";
            // 
            // label3
            // 
            label3.Font = new Font("Algerian", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(259, 21);
            label3.Name = "label3";
            label3.Size = new Size(875, 95);
            label3.TabIndex = 8;
            label3.Text = "Trò chơi 8 PUZZLE";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1298, 482);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btExit);
            Controls.Add(btSolve);
            Controls.Add(btMix);
            Controls.Add(textBoxStep);
            Controls.Add(textBoxTime);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button bt4;
        private Button bt5;
        private Button bt6;
        private Button bt7;
        private Button bt8;
        private TextBox textBoxTime;
        private TextBox textBoxStep;
        private Button btMix;
        private Button btSolve;
        private Button btExit;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}