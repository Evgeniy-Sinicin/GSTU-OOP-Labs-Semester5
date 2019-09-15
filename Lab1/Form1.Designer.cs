namespace Lab1
{
    partial class Form1
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
            this.button = new System.Windows.Forms.Button();
            this.textBoxActualArray = new System.Windows.Forms.TextBox();
            this.textBoxExpectedArray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWithQuality = new System.Windows.Forms.Label();
            this.labelWithError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(289, 66);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(118, 23);
            this.button.TabIndex = 0;
            this.button.Text = "Измерить";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxActualArray
            // 
            this.textBoxActualArray.Location = new System.Drawing.Point(12, 27);
            this.textBoxActualArray.Name = "textBoxActualArray";
            this.textBoxActualArray.Size = new System.Drawing.Size(252, 20);
            this.textBoxActualArray.TabIndex = 1;
            this.textBoxActualArray.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxActualArray_KeyDown);
            // 
            // textBoxExpectedArray
            // 
            this.textBoxExpectedArray.Location = new System.Drawing.Point(12, 68);
            this.textBoxExpectedArray.Name = "textBoxExpectedArray";
            this.textBoxExpectedArray.Size = new System.Drawing.Size(252, 20);
            this.textBoxExpectedArray.TabIndex = 2;
            this.textBoxExpectedArray.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxExpectedArray_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вектор фактических значений";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вектор ожидаемых значений";
            // 
            // labelWithQuality
            // 
            this.labelWithQuality.AutoSize = true;
            this.labelWithQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWithQuality.Location = new System.Drawing.Point(285, 27);
            this.labelWithQuality.Name = "labelWithQuality";
            this.labelWithQuality.Size = new System.Drawing.Size(112, 20);
            this.labelWithQuality.TabIndex = 5;
            this.labelWithQuality.Text = "Качество: 0%";
            // 
            // labelWithError
            // 
            this.labelWithError.AutoSize = true;
            this.labelWithError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWithError.ForeColor = System.Drawing.Color.Red;
            this.labelWithError.Location = new System.Drawing.Point(12, 91);
            this.labelWithError.Name = "labelWithError";
            this.labelWithError.Size = new System.Drawing.Size(0, 15);
            this.labelWithError.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 110);
            this.Controls.Add(this.labelWithError);
            this.Controls.Add(this.labelWithQuality);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExpectedArray);
            this.Controls.Add(this.textBoxActualArray);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Метрика качества";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBoxActualArray;
        private System.Windows.Forms.TextBox textBoxExpectedArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelWithQuality;
        private System.Windows.Forms.Label labelWithError;
    }
}

