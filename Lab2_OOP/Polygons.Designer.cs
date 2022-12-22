namespace Lab3_OOP
{
    partial class Polygons
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Delete = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dX = new System.Windows.Forms.TextBox();
            this.dY = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ChangeCords = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.CancelPoints = new System.Windows.Forms.Button();
            this.ConfirmNum = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.PointsNum = new System.Windows.Forms.TextBox();
            this.AddPoint = new System.Windows.Forms.Button();
            this.Points_Label = new System.Windows.Forms.Label();
            this.X_cord = new System.Windows.Forms.TextBox();
            this.Y_cord = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Delete.Location = new System.Drawing.Point(397, 367);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(136, 37);
            this.Delete.TabIndex = 74;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label13.Location = new System.Drawing.Point(28, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(199, 29);
            this.label13.TabIndex = 73;
            this.label13.Text = "Многоугольник:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 367);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(336, 37);
            this.comboBox1.TabIndex = 72;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dX
            // 
            this.dX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dX.Location = new System.Drawing.Point(79, 422);
            this.dX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dX.Name = "dX";
            this.dX.Size = new System.Drawing.Size(132, 34);
            this.dX.TabIndex = 61;
            // 
            // dY
            // 
            this.dY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dY.Location = new System.Drawing.Point(79, 461);
            this.dY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dY.Name = "dY";
            this.dY.Size = new System.Drawing.Size(132, 34);
            this.dY.TabIndex = 62;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label15.Location = new System.Drawing.Point(37, 422);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 29);
            this.label15.TabIndex = 63;
            this.label15.Text = "X:";
            // 
            // ChangeCords
            // 
            this.ChangeCords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ChangeCords.Location = new System.Drawing.Point(397, 437);
            this.ChangeCords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeCords.Name = "ChangeCords";
            this.ChangeCords.Size = new System.Drawing.Size(136, 36);
            this.ChangeCords.TabIndex = 70;
            this.ChangeCords.Text = "Изменить";
            this.ChangeCords.UseVisualStyleBackColor = true;
            this.ChangeCords.Click += new System.EventHandler(this.ChangeCords_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label16.Location = new System.Drawing.Point(38, 461);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 29);
            this.label16.TabIndex = 64;
            this.label16.Text = "Y:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label17.Location = new System.Drawing.Point(86, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(233, 29);
            this.label17.TabIndex = 81;
            this.label17.Text = "МНОГОУГОЛЬНИК";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Red;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_back.Location = new System.Drawing.Point(505, 9);
            this.button_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(41, 37);
            this.button_back.TabIndex = 80;
            this.button_back.Text = "Х";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // CancelPoints
            // 
            this.CancelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CancelPoints.Location = new System.Drawing.Point(159, 276);
            this.CancelPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelPoints.Name = "CancelPoints";
            this.CancelPoints.Size = new System.Drawing.Size(243, 36);
            this.CancelPoints.TabIndex = 64;
            this.CancelPoints.Text = "Сбросить точки";
            this.CancelPoints.UseVisualStyleBackColor = true;
            this.CancelPoints.Click += new System.EventHandler(this.CancelPoints_Click);
            // 
            // ConfirmNum
            // 
            this.ConfirmNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ConfirmNum.Location = new System.Drawing.Point(356, 55);
            this.ConfirmNum.Name = "ConfirmNum";
            this.ConfirmNum.Size = new System.Drawing.Size(177, 34);
            this.ConfirmNum.TabIndex = 63;
            this.ConfirmNum.Text = "Подтвердить";
            this.ConfirmNum.UseVisualStyleBackColor = true;
            this.ConfirmNum.Click += new System.EventHandler(this.ConfirmNum_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label18.Location = new System.Drawing.Point(21, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(171, 29);
            this.label18.TabIndex = 62;
            this.label18.Text = "Кол-во точек:";
            // 
            // PointsNum
            // 
            this.PointsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PointsNum.Location = new System.Drawing.Point(198, 55);
            this.PointsNum.Name = "PointsNum";
            this.PointsNum.Size = new System.Drawing.Size(121, 34);
            this.PointsNum.TabIndex = 61;
            // 
            // AddPoint
            // 
            this.AddPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddPoint.Location = new System.Drawing.Point(356, 164);
            this.AddPoint.Name = "AddPoint";
            this.AddPoint.Size = new System.Drawing.Size(177, 33);
            this.AddPoint.TabIndex = 60;
            this.AddPoint.Text = "Добавить точку";
            this.AddPoint.UseVisualStyleBackColor = true;
            this.AddPoint.Click += new System.EventHandler(this.AddPoint_Click);
            // 
            // Points_Label
            // 
            this.Points_Label.AutoSize = true;
            this.Points_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Points_Label.Location = new System.Drawing.Point(27, 103);
            this.Points_Label.Name = "Points_Label";
            this.Points_Label.Size = new System.Drawing.Size(292, 29);
            this.Points_Label.TabIndex = 49;
            this.Points_Label.Text = "Координаты 1-ой точки:";
            // 
            // X_cord
            // 
            this.X_cord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.X_cord.Location = new System.Drawing.Point(199, 142);
            this.X_cord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.X_cord.Name = "X_cord";
            this.X_cord.Size = new System.Drawing.Size(109, 34);
            this.X_cord.TabIndex = 50;
            // 
            // Y_cord
            // 
            this.Y_cord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Y_cord.Location = new System.Drawing.Point(198, 180);
            this.Y_cord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Y_cord.Name = "Y_cord";
            this.Y_cord.Size = new System.Drawing.Size(110, 34);
            this.Y_cord.TabIndex = 51;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label20.Location = new System.Drawing.Point(27, 145);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 29);
            this.label20.TabIndex = 52;
            this.label20.Text = "X";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label21.Location = new System.Drawing.Point(28, 185);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 29);
            this.label21.TabIndex = 53;
            this.label21.Text = "Y";
            // 
            // Draw
            // 
            this.Draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Draw.Location = new System.Drawing.Point(159, 236);
            this.Draw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(243, 36);
            this.Draw.TabIndex = 59;
            this.Draw.Text = "Нарисовать многоугольник";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(562, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 550);
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Polygons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1373, 574);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CancelPoints);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ConfirmNum);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.PointsNum);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.AddPoint);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Points_Label);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.X_cord);
            this.Controls.Add(this.Y_cord);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dX);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.dY);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ChangeCords);
            this.Name = "Polygons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPolygons";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPolygons_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox dX;
        private System.Windows.Forms.TextBox dY;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ChangeCords;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button ConfirmNum;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox PointsNum;
        private System.Windows.Forms.Button AddPoint;
        private System.Windows.Forms.Label Points_Label;
        private System.Windows.Forms.TextBox X_cord;
        private System.Windows.Forms.TextBox Y_cord;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.Button CancelPoints;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}