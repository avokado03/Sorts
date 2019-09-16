namespace Sorts
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bubbleRb = new System.Windows.Forms.RadioButton();
            this.insertRb = new System.Windows.Forms.RadioButton();
            this.mergeRb = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.genArrayBox = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите алгоритм:";
            // 
            // bubbleRb
            // 
            this.bubbleRb.AutoSize = true;
            this.bubbleRb.Location = new System.Drawing.Point(16, 65);
            this.bubbleRb.Name = "bubbleRb";
            this.bubbleRb.Size = new System.Drawing.Size(77, 17);
            this.bubbleRb.TabIndex = 1;
            this.bubbleRb.TabStop = true;
            this.bubbleRb.Text = "BubbleSort";
            this.bubbleRb.UseVisualStyleBackColor = true;
            this.bubbleRb.CheckedChanged += new System.EventHandler(this.BubbleRb_CheckedChanged);
            // 
            // insertRb
            // 
            this.insertRb.AutoSize = true;
            this.insertRb.Location = new System.Drawing.Point(16, 89);
            this.insertRb.Name = "insertRb";
            this.insertRb.Size = new System.Drawing.Size(85, 17);
            this.insertRb.TabIndex = 2;
            this.insertRb.TabStop = true;
            this.insertRb.Text = "Insertion sort";
            this.insertRb.UseVisualStyleBackColor = true;
            this.insertRb.CheckedChanged += new System.EventHandler(this.InsertRb_CheckedChanged);
            // 
            // mergeRb
            // 
            this.mergeRb.AutoSize = true;
            this.mergeRb.Location = new System.Drawing.Point(136, 65);
            this.mergeRb.Name = "mergeRb";
            this.mergeRb.Size = new System.Drawing.Size(75, 17);
            this.mergeRb.TabIndex = 3;
            this.mergeRb.TabStop = true;
            this.mergeRb.Text = "Merge sort";
            this.mergeRb.UseVisualStyleBackColor = true;
            this.mergeRb.CheckedChanged += new System.EventHandler(this.MergeRb_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(136, 89);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(243, 65);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(243, 89);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(85, 17);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(347, 65);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(85, 17);
            this.radioButton7.TabIndex = 7;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "radioButton7";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(347, 89);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(85, 17);
            this.radioButton8.TabIndex = 8;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "radioButton8";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // genArrayBox
            // 
            this.genArrayBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.genArrayBox.Location = new System.Drawing.Point(12, 165);
            this.genArrayBox.Name = "genArrayBox";
            this.genArrayBox.ReadOnly = true;
            this.genArrayBox.Size = new System.Drawing.Size(568, 20);
            this.genArrayBox.TabIndex = 9;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(16, 124);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(191, 23);
            this.generateBtn.TabIndex = 10;
            this.generateBtn.Text = "Сгенерировать массив";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Enabled = false;
            this.sortBtn.Location = new System.Drawing.Point(243, 124);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(189, 23);
            this.sortBtn.TabIndex = 11;
            this.sortBtn.Text = "Отсортировать";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultBox.Location = new System.Drawing.Point(12, 211);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(569, 396);
            this.resultBox.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 619);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.genArrayBox);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.mergeRb);
            this.Controls.Add(this.insertRb);
            this.Controls.Add(this.bubbleRb);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton bubbleRb;
        private System.Windows.Forms.RadioButton insertRb;
        private System.Windows.Forms.RadioButton mergeRb;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.TextBox genArrayBox;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.TextBox resultBox;
    }
}

