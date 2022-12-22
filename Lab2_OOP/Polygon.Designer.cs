namespace Lab3_OOP
{
    partial class Polygon
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dX = new System.Windows.Forms.TextBox();
            this.dY = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ChangeCords = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dX);
            this.groupBox2.Controls.Add(this.dY);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.ChangeCords);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(6, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 141);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменить существующий";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(240, 34);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 23);
            this.Delete.TabIndex = 74;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 16);
            this.label13.TabIndex = 73;
            this.label13.Text = "Многоугольник:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 24);
            this.comboBox1.TabIndex = 72;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(80, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 16);
            this.label14.TabIndex = 60;
            this.label14.Text = "Смещение координат:";
            // 
            // dX
            // 
            this.dX.Location = new System.Drawing.Point(21, 99);
            this.dX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dX.Name = "dX";
            this.dX.Size = new System.Drawing.Size(63, 22);
            this.dX.TabIndex = 61;
            // 
            // dY
            // 
            this.dY.Location = new System.Drawing.Point(113, 99);
            this.dY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dY.Name = "dY";
            this.dY.Size = new System.Drawing.Size(63, 22);
            this.dY.TabIndex = 62;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 16);
            this.label15.TabIndex = 63;
            this.label15.Text = "X:";
            // 
            // ChangeCords
            // 
            this.ChangeCords.Location = new System.Drawing.Point(195, 98);
            this.ChangeCords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeCords.Name = "ChangeCords";
            this.ChangeCords.Size = new System.Drawing.Size(94, 23);
            this.ChangeCords.TabIndex = 70;
            this.ChangeCords.Text = "Изменить";
            this.ChangeCords.UseVisualStyleBackColor = true;
            this.ChangeCords.Click += new System.EventHandler(this.ChangeCords_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(93, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 16);
            this.label16.TabIndex = 64;
            this.label16.Text = "Y:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(86, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 16);
            this.label17.TabIndex = 81;
            this.label17.Text = "МНОГОУГОЛЬНИК";
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(246, 2);
            this.button_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(94, 23);
            this.button_back.TabIndex = 80;
            this.button_back.Text = "Закрыть";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancelPoints);
            this.groupBox1.Controls.Add(this.ConfirmNum);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.PointsNum);
            this.groupBox1.Controls.Add(this.AddPoint);
            this.groupBox1.Controls.Add(this.Points_Label);
            this.groupBox1.Controls.Add(this.X_cord);
            this.groupBox1.Controls.Add(this.Y_cord);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.Draw);
            this.groupBox1.Location = new System.Drawing.Point(6, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 179);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нарисовать новый";
            // 
            // CancelPoints
            // 
            this.CancelPoints.Location = new System.Drawing.Point(46, 143);
            this.CancelPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelPoints.Name = "CancelPoints";
            this.CancelPoints.Size = new System.Drawing.Size(243, 23);
            this.CancelPoints.TabIndex = 64;
            this.CancelPoints.Text = "Сбросить точки";
            this.CancelPoints.UseVisualStyleBackColor = true;
            this.CancelPoints.Click += new System.EventHandler(this.CancelPoints_Click);
            // 
            // ConfirmNum
            // 
            this.ConfirmNum.Location = new System.Drawing.Point(211, 22);
            this.ConfirmNum.Name = "ConfirmNum";
            this.ConfirmNum.Size = new System.Drawing.Size(117, 23);
            this.ConfirmNum.TabIndex = 63;
            this.ConfirmNum.Text = "Подтвердить";
            this.ConfirmNum.UseVisualStyleBackColor = true;
            this.ConfirmNum.Click += new System.EventHandler(this.ConfirmNum_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 16);
            this.label18.TabIndex = 62;
            this.label18.Text = "Кол-во точек:";
            // 
            // PointsNum
            // 
            this.PointsNum.Location = new System.Drawing.Point(105, 22);
            this.PointsNum.Name = "PointsNum";
            this.PointsNum.Size = new System.Drawing.Size(100, 22);
            this.PointsNum.TabIndex = 61;
            // 
            // AddPoint
            // 
            this.AddPoint.Location = new System.Drawing.Point(193, 88);
            this.AddPoint.Name = "AddPoint";
            this.AddPoint.Size = new System.Drawing.Size(135, 23);
            this.AddPoint.TabIndex = 60;
            this.AddPoint.Text = "Добавить точку";
            this.AddPoint.UseVisualStyleBackColor = true;
            this.AddPoint.Click += new System.EventHandler(this.AddPoint_Click);
            // 
            // Points_Label
            // 
            this.Points_Label.AutoSize = true;
            this.Points_Label.Location = new System.Drawing.Point(87, 60);
            this.Points_Label.Name = "Points_Label";
            this.Points_Label.Size = new System.Drawing.Size(161, 16);
            this.Points_Label.TabIndex = 49;
            this.Points_Label.Text = "Координаты 1-ой точки:";
            // 
            // X_cord
            // 
            this.X_cord.Location = new System.Drawing.Point(27, 89);
            this.X_cord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.X_cord.Name = "X_cord";
            this.X_cord.Size = new System.Drawing.Size(57, 22);
            this.X_cord.TabIndex = 50;
            // 
            // Y_cord
            // 
            this.Y_cord.Location = new System.Drawing.Point(121, 89);
            this.Y_cord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Y_cord.Name = "Y_cord";
            this.Y_cord.Size = new System.Drawing.Size(55, 22);
            this.Y_cord.TabIndex = 51;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 92);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 16);
            this.label20.TabIndex = 52;
            this.label20.Text = "X:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(99, 92);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 16);
            this.label21.TabIndex = 53;
            this.label21.Text = "Y:";
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(46, 116);
            this.Draw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(243, 23);
            this.Draw.TabIndex = 59;
            this.Draw.Text = "Нарисовать многоугольник";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // FormPolygons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 405);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPolygons";
            this.Text = "FormPolygons";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPolygons_MouseDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox dX;
        private System.Windows.Forms.TextBox dY;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ChangeCords;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}