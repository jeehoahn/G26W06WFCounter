namespace G26W06WFCounter
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
        private void InitializeComponent() {
            labelCount = new Label();
            btnAdd = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelCount
            // 
            labelCount.BackColor = SystemColors.Info;
            labelCount.Font = new Font("맑은 고딕", 36F);
            labelCount.Location = new Point(187, 56);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(425, 325);
            labelCount.TabIndex = 0;
            labelCount.Text = "0";
            labelCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(634, 156);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "증가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += OnAdd;
            // 
            // button1
            // 
            button1.Location = new Point(634, 200);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "감소";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Controls.Add(labelCount);
            Name = "Form1";
            Text = "Counter";
            ResumeLayout(false);
        }

        #endregion

        private Label labelCount;
        private Button btnAdd;
        private Button button1;
    }
}
