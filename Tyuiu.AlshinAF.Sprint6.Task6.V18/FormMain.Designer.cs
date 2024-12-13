namespace Tyuiu.AlshinAF.Sprint6.Task6.V18
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            textBoxLoadFromFile = new TextBox();
            textBoxResult = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            groupBox1 = new GroupBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(469, 132);
            button1.Name = "button1";
            button1.Size = new Size(260, 40);
            button1.TabIndex = 0;
            button1.Text = "button1";
            toolTip1.SetToolTip(button1, "Выберите нужный файл для обработки");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(469, 190);
            button2.Name = "button2";
            button2.Size = new Size(260, 38);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxLoadFromFile
            // 
            textBoxLoadFromFile.Location = new Point(3, 89);
            textBoxLoadFromFile.Multiline = true;
            textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            textBoxLoadFromFile.Size = new Size(195, 249);
            textBoxLoadFromFile.TabIndex = 2;
            textBoxLoadFromFile.TextChanged += textBoxLoadFromFile_TextChanged;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(204, 89);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(216, 249);
            textBoxResult.TabIndex = 3;
            textBoxResult.TextChanged += textBox2_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(3, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 276);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.Location = new Point(553, 234);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxLoadFromFile);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBoxLoadFromFile;
        private TextBox textBoxResult;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private GroupBox groupBox1;
        private Button button3;
    }
}
