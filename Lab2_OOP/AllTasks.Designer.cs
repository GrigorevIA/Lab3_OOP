namespace Lab3_OOP
{
    partial class AllTasks
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonRound = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_All_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Polygon = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Rocket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 550);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Location = new System.Drawing.Point(6, 130);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(155, 39);
            this.buttonEllipse.TabIndex = 1;
            this.buttonEllipse.Text = "Эллипс";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonRound
            // 
            this.buttonRound.Location = new System.Drawing.Point(6, 175);
            this.buttonRound.Name = "buttonRound";
            this.buttonRound.Size = new System.Drawing.Size(155, 39);
            this.buttonRound.TabIndex = 2;
            this.buttonRound.Text = "Круг";
            this.buttonRound.UseVisualStyleBackColor = true;
            this.buttonRound.Click += new System.EventHandler(this.buttonRound_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(6, 85);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(155, 39);
            this.buttonSquare.TabIndex = 4;
            this.buttonSquare.Text = "Квадрат";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(6, 40);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(155, 39);
            this.buttonRectangle.TabIndex = 3;
            this.buttonRectangle.Text = "Прямоугольник";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rocket);
            this.groupBox1.Controls.Add(this.Polygon);
            this.groupBox1.Controls.Add(this.Triangle);
            this.groupBox1.Controls.Add(this.button_All_Clear);
            this.groupBox1.Controls.Add(this.buttonRectangle);
            this.groupBox1.Controls.Add(this.buttonSquare);
            this.groupBox1.Controls.Add(this.buttonEllipse);
            this.groupBox1.Controls.Add(this.buttonRound);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(818, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 416);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "           Управление";
            // 
            // button_All_Clear
            // 
            this.button_All_Clear.Location = new System.Drawing.Point(6, 368);
            this.button_All_Clear.Name = "button_All_Clear";
            this.button_All_Clear.Size = new System.Drawing.Size(155, 39);
            this.button_All_Clear.TabIndex = 5;
            this.button_All_Clear.Text = "Очистить холст";
            this.button_All_Clear.UseVisualStyleBackColor = true;
            this.button_All_Clear.Click += new System.EventHandler(this.button_All_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(818, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 68);
            this.label1.TabIndex = 6;
            this.label1.Text = "             СПРАВКА\r\n\r\nЭтот.Холст.Ширина = 800\r\nЭтот.Холст.Высота = 550\r\n";
            // 
            // Polygon
            // 
            this.Polygon.Location = new System.Drawing.Point(6, 220);
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(155, 39);
            this.Polygon.TabIndex = 6;
            this.Polygon.Text = "Многоугольник";
            this.Polygon.UseVisualStyleBackColor = true;
            this.Polygon.Click += new System.EventHandler(this.Polygon_Click);
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(6, 265);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(155, 39);
            this.Triangle.TabIndex = 7;
            this.Triangle.Text = "Треугольник";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Rocket
            // 
            this.Rocket.Location = new System.Drawing.Point(7, 310);
            this.Rocket.Name = "Rocket";
            this.Rocket.Size = new System.Drawing.Size(155, 39);
            this.Rocket.TabIndex = 8;
            this.Rocket.Text = "Ракета!";
            this.Rocket.UseVisualStyleBackColor = true;
            this.Rocket.Click += new System.EventHandler(this.Rocket_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonRound;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_All_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Rocket;
        private System.Windows.Forms.Button Polygon;
        private System.Windows.Forms.Button Triangle;
    }
}

