namespace Tyuiu.AlshinAF.Sprint6.Task0.V12
{
    partial class FormMain
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
            ButtonDone_AAF = new Button();
            textBoxTask_AAF = new TextBox();
            textBoxVarX = new TextBox();
            pictureBoxFormula_AAF = new PictureBox();
            labelTask_AAF = new Label();
            labelX_AAF = new Label();
            textBoxResult_AAF = new TextBox();
            labelResult_AAF = new Label();
            buttonHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_AAF).BeginInit();
            SuspendLayout();
            // 
            // ButtonDone_AAF
            // 
            ButtonDone_AAF.Location = new Point(473, 356);
            ButtonDone_AAF.Name = "ButtonDone_AAF";
            ButtonDone_AAF.Size = new Size(270, 68);
            ButtonDone_AAF.TabIndex = 0;
            ButtonDone_AAF.Text = "Выполнить";
            ButtonDone_AAF.UseVisualStyleBackColor = true;
            ButtonDone_AAF.Click += buttonDone_Click;
            // 
            // textBoxTask_AAF
            // 
            textBoxTask_AAF.AccessibleDescription = "";
            textBoxTask_AAF.AccessibleName = "textBoxTask_AAF";
            textBoxTask_AAF.BackColor = SystemColors.Control;
            textBoxTask_AAF.ForeColor = SystemColors.MenuText;
            textBoxTask_AAF.Location = new Point(96, 41);
            textBoxTask_AAF.Multiline = true;
            textBoxTask_AAF.Name = "textBoxTask_AAF";
            textBoxTask_AAF.ReadOnly = true;
            textBoxTask_AAF.Size = new Size(390, 197);
            textBoxTask_AAF.TabIndex = 1;
            textBoxTask_AAF.Tag = "Условие";
            textBoxTask_AAF.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой.";
            textBoxTask_AAF.TextChanged += textBoxTask_AAF_TextChanged;
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(121, 325);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(100, 23);
            textBoxVarX.TabIndex = 2;
            textBoxVarX.TextChanged += textBoxVarX_TextChanged;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress_AAF;
            // 
            // pictureBoxFormula_AAF
            // 
            pictureBoxFormula_AAF.AccessibleName = "pictureBoxFormula_AAF";
            pictureBoxFormula_AAF.Image = Properties.Resources.Untitled;
            pictureBoxFormula_AAF.Location = new Point(556, 95);
            pictureBoxFormula_AAF.Name = "pictureBoxFormula_AAF";
            pictureBoxFormula_AAF.Size = new Size(138, 80);
            pictureBoxFormula_AAF.TabIndex = 3;
            pictureBoxFormula_AAF.TabStop = false;
            pictureBoxFormula_AAF.Click += pictureBox1_Click;
            // 
            // labelTask_AAF
            // 
            labelTask_AAF.AutoSize = true;
            labelTask_AAF.Location = new Point(96, 23);
            labelTask_AAF.Name = "labelTask_AAF";
            labelTask_AAF.Size = new Size(56, 15);
            labelTask_AAF.TabIndex = 4;
            labelTask_AAF.Text = "Условие:";
            // 
            // labelX_AAF
            // 
            labelX_AAF.AutoSize = true;
            labelX_AAF.Location = new Point(121, 307);
            labelX_AAF.Name = "labelX_AAF";
            labelX_AAF.Size = new Size(89, 15);
            labelX_AAF.TabIndex = 5;
            labelX_AAF.Text = "Переменная X:";
            // 
            // textBoxResult_AAF
            // 
            textBoxResult_AAF.Location = new Point(227, 325);
            textBoxResult_AAF.Name = "textBoxResult_AAF";
            textBoxResult_AAF.ReadOnly = true;
            textBoxResult_AAF.Size = new Size(210, 23);
            textBoxResult_AAF.TabIndex = 6;
            textBoxResult_AAF.TextChanged += textBoxResult_TextChanged_AAF;
            textBoxResult_AAF.KeyPress += textBoxVarX_KeyPress_AAF;
            // 
            // labelResult_AAF
            // 
            labelResult_AAF.AutoSize = true;
            labelResult_AAF.Location = new Point(299, 307);
            labelResult_AAF.Name = "labelResult_AAF";
            labelResult_AAF.Size = new Size(63, 15);
            labelResult_AAF.TabIndex = 7;
            labelResult_AAF.Text = "Результат:";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ButtonFace;
            buttonHelp.Location = new Point(392, 379);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 23);
            buttonHelp.TabIndex = 8;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click_AAF;
            // 
            // FormMain
            // 
            AccessibleName = "FormMain";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp);
            Controls.Add(labelResult_AAF);
            Controls.Add(textBoxResult_AAF);
            Controls.Add(labelX_AAF);
            Controls.Add(labelTask_AAF);
            Controls.Add(pictureBoxFormula_AAF);
            Controls.Add(textBoxVarX);
            Controls.Add(textBoxTask_AAF);
            Controls.Add(ButtonDone_AAF);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 12 | Альшин А. Ф.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_AAF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxFormula_AAF;
        private Button buttonHelp;
        private Button ButtonDone_AAF;
        private TextBox textBoxTask_AAF;
        private TextBox textBoxVarX;
        private Label labelTask_AAF;
        private Label labelX_AAF;
        private TextBox textBoxResult_AAF;
        private Label labelResult_AAF;
    }
}
