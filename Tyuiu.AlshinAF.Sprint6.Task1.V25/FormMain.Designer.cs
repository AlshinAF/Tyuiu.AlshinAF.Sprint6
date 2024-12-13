namespace Tyuiu.AlshinAF.Sprint6.Task1.V25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pictureBoxTask_AAF = new PictureBox();
            buttonDone_AAF = new Button();
            buttonHelp_AAF = new Button();
            textBoxStartValue_AAF = new TextBox();
            textBoxStopValue_AAF = new TextBox();
            labelStart_AAF = new Label();
            labelStop_AAF = new Label();
            labelResult_AAF = new Label();
            textBoxResult_AAF = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_AAF).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxTask_AAF
            // 
            pictureBoxTask_AAF.Image = (Image)resources.GetObject("pictureBoxTask_AAF.Image");
            pictureBoxTask_AAF.Location = new Point(0, -1);
            pictureBoxTask_AAF.Name = "pictureBoxTask_AAF";
            pictureBoxTask_AAF.Size = new Size(644, 209);
            pictureBoxTask_AAF.TabIndex = 0;
            pictureBoxTask_AAF.TabStop = false;
            // 
            // buttonDone_AAF
            // 
            buttonDone_AAF.Location = new Point(410, 404);
            buttonDone_AAF.Name = "buttonDone_AAF";
            buttonDone_AAF.Size = new Size(234, 55);
            buttonDone_AAF.TabIndex = 1;
            buttonDone_AAF.Text = "Выполнить";
            buttonDone_AAF.UseVisualStyleBackColor = true;
            buttonDone_AAF.Click += buttonDone_AAF_Click;
            // 
            // buttonHelp_AAF
            // 
            buttonHelp_AAF.Location = new Point(329, 420);
            buttonHelp_AAF.Name = "buttonHelp_AAF";
            buttonHelp_AAF.Size = new Size(75, 39);
            buttonHelp_AAF.TabIndex = 2;
            buttonHelp_AAF.Text = "?";
            buttonHelp_AAF.UseVisualStyleBackColor = true;
            buttonHelp_AAF.Click += buttonHelp_AAF_Click;
            // 
            // textBoxStartValue_AAF
            // 
            textBoxStartValue_AAF.Location = new Point(12, 291);
            textBoxStartValue_AAF.Name = "textBoxStartValue_AAF";
            textBoxStartValue_AAF.Size = new Size(100, 23);
            textBoxStartValue_AAF.TabIndex = 3;
            textBoxStartValue_AAF.TextChanged += textBoxStartValue_AAF_TextChanged;
            // 
            // textBoxStopValue_AAF
            // 
            textBoxStopValue_AAF.Location = new Point(118, 291);
            textBoxStopValue_AAF.Name = "textBoxStopValue_AAF";
            textBoxStopValue_AAF.Size = new Size(100, 23);
            textBoxStopValue_AAF.TabIndex = 4;
            textBoxStopValue_AAF.TextChanged += textBoxStopValue_AAF_TextChanged;
            // 
            // labelStart_AAF
            // 
            labelStart_AAF.AutoSize = true;
            labelStart_AAF.Location = new Point(12, 273);
            labelStart_AAF.Name = "labelStart_AAF";
            labelStart_AAF.Size = new Size(69, 15);
            labelStart_AAF.TabIndex = 5;
            labelStart_AAF.Text = "Старт шага";
            // 
            // labelStop_AAF
            // 
            labelStop_AAF.AutoSize = true;
            labelStop_AAF.Location = new Point(118, 273);
            labelStop_AAF.Name = "labelStop_AAF";
            labelStop_AAF.Size = new Size(75, 15);
            labelStop_AAF.TabIndex = 6;
            labelStop_AAF.Text = "Конец шага:";
            // 
            // labelResult_AAF
            // 
            labelResult_AAF.AutoSize = true;
            labelResult_AAF.Location = new Point(717, 24);
            labelResult_AAF.Name = "labelResult_AAF";
            labelResult_AAF.Size = new Size(63, 15);
            labelResult_AAF.TabIndex = 7;
            labelResult_AAF.Text = "Результат:";
            // 
            // textBoxResult_AAF
            // 
            textBoxResult_AAF.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_AAF.Location = new Point(717, 42);
            textBoxResult_AAF.Multiline = true;
            textBoxResult_AAF.Name = "textBoxResult_AAF";
            textBoxResult_AAF.ScrollBars = ScrollBars.Vertical;
            textBoxResult_AAF.Size = new Size(340, 448);
            textBoxResult_AAF.TabIndex = 8;
            textBoxResult_AAF.TextChanged += textBoxResult_AAF_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 502);
            Controls.Add(textBoxResult_AAF);
            Controls.Add(labelResult_AAF);
            Controls.Add(labelStop_AAF);
            Controls.Add(labelStart_AAF);
            Controls.Add(textBoxStopValue_AAF);
            Controls.Add(textBoxStartValue_AAF);
            Controls.Add(buttonHelp_AAF);
            Controls.Add(buttonDone_AAF);
            Controls.Add(pictureBoxTask_AAF);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 25 | Альшин А. Ф.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_AAF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxTask_AAF;
        private Button buttonDone_AAF;
        private Button buttonHelp_AAF;
        private TextBox textBoxStartValue_AAF;
        private TextBox textBoxStopValue_AAF;
        private Label labelStart_AAF;
        private Label labelStop_AAF;
        private Label labelResult_AAF;
        private TextBox textBoxResult_AAF;
    }
}
