namespace Lab3_OOP
{
    partial class All
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
            this.buttonRound = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Polygon = new System.Windows.Forms.Button();
            this.Rocket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRound
            // 
            this.buttonRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonRound.Location = new System.Drawing.Point(11, 163);
            this.buttonRound.Name = "buttonRound";
            this.buttonRound.Size = new System.Drawing.Size(253, 39);
            this.buttonRound.TabIndex = 2;
            this.buttonRound.Text = "Круг";
            this.buttonRound.UseVisualStyleBackColor = true;
            this.buttonRound.Click += new System.EventHandler(this.buttonRound_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonEllipse.Location = new System.Drawing.Point(11, 118);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(253, 39);
            this.buttonEllipse.TabIndex = 1;
            this.buttonEllipse.Text = "Эллипс";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSquare.Location = new System.Drawing.Point(11, 73);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(253, 39);
            this.buttonSquare.TabIndex = 4;
            this.buttonSquare.Text = "Квадрат";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonRectangle.Location = new System.Drawing.Point(12, 28);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(253, 39);
            this.buttonRectangle.TabIndex = 3;
            this.buttonRectangle.Text = "Прямоугольник";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // Triangle
            // 
            this.Triangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Triangle.Location = new System.Drawing.Point(11, 253);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(253, 39);
            this.Triangle.TabIndex = 7;
            this.Triangle.Text = "Треугольник";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Polygon
            // 
            this.Polygon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Polygon.Location = new System.Drawing.Point(11, 208);
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(253, 39);
            this.Polygon.TabIndex = 6;
            this.Polygon.Text = "Многоугольник";
            this.Polygon.UseVisualStyleBackColor = true;
            this.Polygon.Click += new System.EventHandler(this.Polygon_Click);
            // 
            // Rocket
            // 
            this.Rocket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Rocket.Location = new System.Drawing.Point(12, 298);
            this.Rocket.Name = "Rocket";
            this.Rocket.Size = new System.Drawing.Size(253, 39);
            this.Rocket.TabIndex = 8;
            this.Rocket.Text = "Ракета!";
            this.Rocket.UseVisualStyleBackColor = true;
            this.Rocket.Click += new System.EventHandler(this.Rocket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Выберите фигуру";
            // 
            // All
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(278, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rocket);
            this.Controls.Add(this.Polygon);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.buttonRound);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonEllipse);
            this.Name = "All";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRound;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Polygon;
        private System.Windows.Forms.Button Rocket;
        private System.Windows.Forms.Label label1;
    }
}

