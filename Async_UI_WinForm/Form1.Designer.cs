namespace Async_UI_WinForm
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
            this.btnDoWorkAsync = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDoWorkAsync
            // 
            this.btnDoWorkAsync.Location = new System.Drawing.Point(75, 132);
            this.btnDoWorkAsync.Name = "btnDoWorkAsync";
            this.btnDoWorkAsync.Size = new System.Drawing.Size(124, 23);
            this.btnDoWorkAsync.TabIndex = 0;
            this.btnDoWorkAsync.Text = "DoWorkAsync";
            this.btnDoWorkAsync.UseVisualStyleBackColor = true;
            this.btnDoWorkAsync.Click += new System.EventHandler(this.btnDoWorkAsync_Click);
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Location = new System.Drawing.Point(89, 46);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(102, 13);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "AsyncMethodResult";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnDoWorkAsync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoWorkAsync;
        private System.Windows.Forms.Label txtResult;
    }
}

