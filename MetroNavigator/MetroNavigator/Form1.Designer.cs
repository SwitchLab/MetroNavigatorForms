namespace MetroNavigator
{
    partial class Menu
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.navigationButton = new System.Windows.Forms.Button();
            this.meetingsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navigationButton
            // 
            this.navigationButton.Location = new System.Drawing.Point(70, 56);
            this.navigationButton.Name = "navigationButton";
            this.navigationButton.Size = new System.Drawing.Size(272, 78);
            this.navigationButton.TabIndex = 0;
            this.navigationButton.Text = "Navigation";
            this.navigationButton.UseVisualStyleBackColor = true;
            this.navigationButton.Click += new System.EventHandler(this.navigationButton_Click);
            // 
            // meetingsButton
            // 
            this.meetingsButton.Location = new System.Drawing.Point(70, 254);
            this.meetingsButton.Name = "meetingsButton";
            this.meetingsButton.Size = new System.Drawing.Size(272, 89);
            this.meetingsButton.TabIndex = 1;
            this.meetingsButton.Text = "Meetings/Places";
            this.meetingsButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(70, 482);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(272, 93);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 672);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.meetingsButton);
            this.Controls.Add(this.navigationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button navigationButton;
        private System.Windows.Forms.Button meetingsButton;
        private System.Windows.Forms.Button exitButton;
    }
}

