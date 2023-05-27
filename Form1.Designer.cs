
namespace zadanie13
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonCreate.Location = new System.Drawing.Point(226, 143);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(422, 39);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Создать 2 упорядоченных массива";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox10.Location = new System.Drawing.Point(151, 45);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(556, 32);
            this.textBox10.TabIndex = 3;
            // 
            // textBox17
            // 
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox17.Location = new System.Drawing.Point(151, 80);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(556, 32);
            this.textBox17.TabIndex = 4;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxResult.Location = new System.Drawing.Point(61, 222);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(789, 32);
            this.textBoxResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 331);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.buttonCreate);
            this.Name = "Form1";
            this.Text = "задание 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

