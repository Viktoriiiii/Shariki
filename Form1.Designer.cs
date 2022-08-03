namespace Shariki
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
            this.components = new System.ComponentModel.Container();
            this.panelUpravlenie = new System.Windows.Forms.Panel();
            this.bStart2 = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bStart1 = new System.Windows.Forms.Button();
            this.gBSpeed2 = new System.Windows.Forms.GroupBox();
            this.trackBarShar2 = new System.Windows.Forms.TrackBar();
            this.gBNapravlenie2 = new System.Windows.Forms.GroupBox();
            this.radioBDiagonal2 = new System.Windows.Forms.RadioButton();
            this.radioBGorizontal2 = new System.Windows.Forms.RadioButton();
            this.radioBVertical2 = new System.Windows.Forms.RadioButton();
            this.gBSpeed1 = new System.Windows.Forms.GroupBox();
            this.trackBarShar1 = new System.Windows.Forms.TrackBar();
            this.gBfigur = new System.Windows.Forms.GroupBox();
            this.checkBPlanka = new System.Windows.Forms.CheckBox();
            this.checkBShar2 = new System.Windows.Forms.CheckBox();
            this.checkBShar1 = new System.Windows.Forms.CheckBox();
            this.gBNapravlenie1 = new System.Windows.Forms.GroupBox();
            this.radioBDiagonal1 = new System.Windows.Forms.RadioButton();
            this.radioBGorizontal1 = new System.Windows.Forms.RadioButton();
            this.radioBVertical1 = new System.Windows.Forms.RadioButton();
            this.panelDvigenie = new System.Windows.Forms.Panel();
            this.pictureBoxPlanka = new System.Windows.Forms.PictureBox();
            this.pictureBoxShar2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxShar1 = new System.Windows.Forms.PictureBox();
            this.timerShar1 = new System.Windows.Forms.Timer(this.components);
            this.timerShar2 = new System.Windows.Forms.Timer(this.components);
            this.panelUpravlenie.SuspendLayout();
            this.gBSpeed2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShar2)).BeginInit();
            this.gBNapravlenie2.SuspendLayout();
            this.gBSpeed1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShar1)).BeginInit();
            this.gBfigur.SuspendLayout();
            this.gBNapravlenie1.SuspendLayout();
            this.panelDvigenie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlanka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUpravlenie
            // 
            this.panelUpravlenie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelUpravlenie.Controls.Add(this.bStart2);
            this.panelUpravlenie.Controls.Add(this.bExit);
            this.panelUpravlenie.Controls.Add(this.bStart1);
            this.panelUpravlenie.Controls.Add(this.gBSpeed2);
            this.panelUpravlenie.Controls.Add(this.gBNapravlenie2);
            this.panelUpravlenie.Controls.Add(this.gBSpeed1);
            this.panelUpravlenie.Controls.Add(this.gBfigur);
            this.panelUpravlenie.Controls.Add(this.gBNapravlenie1);
            this.panelUpravlenie.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpravlenie.Location = new System.Drawing.Point(0, 0);
            this.panelUpravlenie.Name = "panelUpravlenie";
            this.panelUpravlenie.Size = new System.Drawing.Size(911, 85);
            this.panelUpravlenie.TabIndex = 0;
            // 
            // bStart2
            // 
            this.bStart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bStart2.Location = new System.Drawing.Point(748, 0);
            this.bStart2.Name = "bStart2";
            this.bStart2.Size = new System.Drawing.Size(87, 50);
            this.bStart2.TabIndex = 10;
            this.bStart2.Text = "Пуск шара 2";
            this.bStart2.UseVisualStyleBackColor = false;
            this.bStart2.Click += new System.EventHandler(this.bStart2_Click);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bExit.Location = new System.Drawing.Point(836, 0);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 50);
            this.bExit.TabIndex = 5;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bStart1
            // 
            this.bStart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bStart1.Location = new System.Drawing.Point(660, 0);
            this.bStart1.Name = "bStart1";
            this.bStart1.Size = new System.Drawing.Size(87, 50);
            this.bStart1.TabIndex = 4;
            this.bStart1.Text = "Пуск шара 1";
            this.bStart1.UseVisualStyleBackColor = false;
            this.bStart1.Click += new System.EventHandler(this.bStart1_Click);
            // 
            // gBSpeed2
            // 
            this.gBSpeed2.Controls.Add(this.trackBarShar2);
            this.gBSpeed2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gBSpeed2.Location = new System.Drawing.Point(436, 0);
            this.gBSpeed2.Name = "gBSpeed2";
            this.gBSpeed2.Size = new System.Drawing.Size(106, 85);
            this.gBSpeed2.TabIndex = 8;
            this.gBSpeed2.TabStop = false;
            this.gBSpeed2.Text = "Скорость шара2";
            this.gBSpeed2.Visible = false;
            // 
            // trackBarShar2
            // 
            this.trackBarShar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackBarShar2.Location = new System.Drawing.Point(3, 16);
            this.trackBarShar2.Name = "trackBarShar2";
            this.trackBarShar2.Size = new System.Drawing.Size(80, 66);
            this.trackBarShar2.TabIndex = 3;
            this.trackBarShar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarShar2.Value = 10;
            this.trackBarShar2.Visible = false;
            this.trackBarShar2.Scroll += new System.EventHandler(this.trackBarShar2_Scroll);
            // 
            // gBNapravlenie2
            // 
            this.gBNapravlenie2.Controls.Add(this.radioBDiagonal2);
            this.gBNapravlenie2.Controls.Add(this.radioBGorizontal2);
            this.gBNapravlenie2.Controls.Add(this.radioBVertical2);
            this.gBNapravlenie2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gBNapravlenie2.Location = new System.Drawing.Point(317, 0);
            this.gBNapravlenie2.Name = "gBNapravlenie2";
            this.gBNapravlenie2.Size = new System.Drawing.Size(119, 85);
            this.gBNapravlenie2.TabIndex = 3;
            this.gBNapravlenie2.TabStop = false;
            this.gBNapravlenie2.Text = "Направление шар2";
            this.gBNapravlenie2.Visible = false;
            // 
            // radioBDiagonal2
            // 
            this.radioBDiagonal2.AutoSize = true;
            this.radioBDiagonal2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioBDiagonal2.Location = new System.Drawing.Point(3, 50);
            this.radioBDiagonal2.Name = "radioBDiagonal2";
            this.radioBDiagonal2.Size = new System.Drawing.Size(113, 17);
            this.radioBDiagonal2.TabIndex = 2;
            this.radioBDiagonal2.Text = "Диагональ";
            this.radioBDiagonal2.UseVisualStyleBackColor = true;
            // 
            // radioBGorizontal2
            // 
            this.radioBGorizontal2.AutoSize = true;
            this.radioBGorizontal2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioBGorizontal2.Location = new System.Drawing.Point(3, 33);
            this.radioBGorizontal2.Name = "radioBGorizontal2";
            this.radioBGorizontal2.Size = new System.Drawing.Size(113, 17);
            this.radioBGorizontal2.TabIndex = 1;
            this.radioBGorizontal2.Text = "Горизонталь";
            this.radioBGorizontal2.UseVisualStyleBackColor = true;
            // 
            // radioBVertical2
            // 
            this.radioBVertical2.AutoSize = true;
            this.radioBVertical2.Checked = true;
            this.radioBVertical2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioBVertical2.Location = new System.Drawing.Point(3, 16);
            this.radioBVertical2.Name = "radioBVertical2";
            this.radioBVertical2.Size = new System.Drawing.Size(113, 17);
            this.radioBVertical2.TabIndex = 0;
            this.radioBVertical2.TabStop = true;
            this.radioBVertical2.Text = "Вертикаль";
            this.radioBVertical2.UseVisualStyleBackColor = true;
            // 
            // gBSpeed1
            // 
            this.gBSpeed1.Controls.Add(this.trackBarShar1);
            this.gBSpeed1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gBSpeed1.Location = new System.Drawing.Point(212, 0);
            this.gBSpeed1.Name = "gBSpeed1";
            this.gBSpeed1.Size = new System.Drawing.Size(105, 85);
            this.gBSpeed1.TabIndex = 3;
            this.gBSpeed1.TabStop = false;
            this.gBSpeed1.Text = "Скорость шара1";
            this.gBSpeed1.Visible = false;
            // 
            // trackBarShar1
            // 
            this.trackBarShar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackBarShar1.Location = new System.Drawing.Point(3, 16);
            this.trackBarShar1.Name = "trackBarShar1";
            this.trackBarShar1.Size = new System.Drawing.Size(80, 66);
            this.trackBarShar1.TabIndex = 2;
            this.trackBarShar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarShar1.Value = 10;
            this.trackBarShar1.Visible = false;
            this.trackBarShar1.Scroll += new System.EventHandler(this.trackBarShar1_Scroll);
            // 
            // gBfigur
            // 
            this.gBfigur.Controls.Add(this.checkBPlanka);
            this.gBfigur.Controls.Add(this.checkBShar2);
            this.gBfigur.Controls.Add(this.checkBShar1);
            this.gBfigur.Dock = System.Windows.Forms.DockStyle.Left;
            this.gBfigur.Location = new System.Drawing.Point(119, 0);
            this.gBfigur.Name = "gBfigur";
            this.gBfigur.Size = new System.Drawing.Size(93, 85);
            this.gBfigur.TabIndex = 1;
            this.gBfigur.TabStop = false;
            this.gBfigur.Text = "Фигуры";
            // 
            // checkBPlanka
            // 
            this.checkBPlanka.AutoSize = true;
            this.checkBPlanka.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBPlanka.Location = new System.Drawing.Point(3, 50);
            this.checkBPlanka.Name = "checkBPlanka";
            this.checkBPlanka.Size = new System.Drawing.Size(87, 17);
            this.checkBPlanka.TabIndex = 2;
            this.checkBPlanka.Text = "Планка";
            this.checkBPlanka.UseVisualStyleBackColor = true;
            this.checkBPlanka.CheckedChanged += new System.EventHandler(this.checkBPlanka_CheckedChanged);
            // 
            // checkBShar2
            // 
            this.checkBShar2.AutoSize = true;
            this.checkBShar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBShar2.Location = new System.Drawing.Point(3, 33);
            this.checkBShar2.Name = "checkBShar2";
            this.checkBShar2.Size = new System.Drawing.Size(87, 17);
            this.checkBShar2.TabIndex = 1;
            this.checkBShar2.Text = "Шар2";
            this.checkBShar2.UseVisualStyleBackColor = true;
            this.checkBShar2.CheckedChanged += new System.EventHandler(this.checkBShar2_CheckedChanged);
            // 
            // checkBShar1
            // 
            this.checkBShar1.AutoSize = true;
            this.checkBShar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBShar1.Location = new System.Drawing.Point(3, 16);
            this.checkBShar1.Name = "checkBShar1";
            this.checkBShar1.Size = new System.Drawing.Size(87, 17);
            this.checkBShar1.TabIndex = 0;
            this.checkBShar1.Text = "Шар1";
            this.checkBShar1.UseVisualStyleBackColor = true;
            this.checkBShar1.CheckedChanged += new System.EventHandler(this.checkBShar1_CheckedChanged);
            // 
            // gBNapravlenie1
            // 
            this.gBNapravlenie1.Controls.Add(this.radioBDiagonal1);
            this.gBNapravlenie1.Controls.Add(this.radioBGorizontal1);
            this.gBNapravlenie1.Controls.Add(this.radioBVertical1);
            this.gBNapravlenie1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gBNapravlenie1.Location = new System.Drawing.Point(0, 0);
            this.gBNapravlenie1.Name = "gBNapravlenie1";
            this.gBNapravlenie1.Size = new System.Drawing.Size(119, 85);
            this.gBNapravlenie1.TabIndex = 0;
            this.gBNapravlenie1.TabStop = false;
            this.gBNapravlenie1.Text = "Направление шар1";
            this.gBNapravlenie1.Visible = false;
            // 
            // radioBDiagonal1
            // 
            this.radioBDiagonal1.AutoSize = true;
            this.radioBDiagonal1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioBDiagonal1.Location = new System.Drawing.Point(3, 50);
            this.radioBDiagonal1.Name = "radioBDiagonal1";
            this.radioBDiagonal1.Size = new System.Drawing.Size(113, 17);
            this.radioBDiagonal1.TabIndex = 2;
            this.radioBDiagonal1.Text = "Диагональ";
            this.radioBDiagonal1.UseVisualStyleBackColor = true;
            // 
            // radioBGorizontal1
            // 
            this.radioBGorizontal1.AutoSize = true;
            this.radioBGorizontal1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioBGorizontal1.Location = new System.Drawing.Point(3, 33);
            this.radioBGorizontal1.Name = "radioBGorizontal1";
            this.radioBGorizontal1.Size = new System.Drawing.Size(113, 17);
            this.radioBGorizontal1.TabIndex = 1;
            this.radioBGorizontal1.Text = "Горизонталь";
            this.radioBGorizontal1.UseVisualStyleBackColor = true;
            // 
            // radioBVertical1
            // 
            this.radioBVertical1.AutoSize = true;
            this.radioBVertical1.Checked = true;
            this.radioBVertical1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioBVertical1.Location = new System.Drawing.Point(3, 16);
            this.radioBVertical1.Name = "radioBVertical1";
            this.radioBVertical1.Size = new System.Drawing.Size(113, 17);
            this.radioBVertical1.TabIndex = 0;
            this.radioBVertical1.TabStop = true;
            this.radioBVertical1.Text = "Вертикаль";
            this.radioBVertical1.UseVisualStyleBackColor = true;
            // 
            // panelDvigenie
            // 
            this.panelDvigenie.Controls.Add(this.pictureBoxPlanka);
            this.panelDvigenie.Controls.Add(this.pictureBoxShar2);
            this.panelDvigenie.Controls.Add(this.pictureBoxShar1);
            this.panelDvigenie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDvigenie.Location = new System.Drawing.Point(0, 85);
            this.panelDvigenie.Name = "panelDvigenie";
            this.panelDvigenie.Size = new System.Drawing.Size(911, 357);
            this.panelDvigenie.TabIndex = 1;
            this.panelDvigenie.DoubleClick += new System.EventHandler(this.panelDvigenie_DoubleClick);
            this.panelDvigenie.Resize += new System.EventHandler(this.Form1_Resize);
            // 
            // pictureBoxPlanka
            // 
            this.pictureBoxPlanka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPlanka.Image = global::Shariki.Properties.Resources.planka1;
            this.pictureBoxPlanka.Location = new System.Drawing.Point(288, 271);
            this.pictureBoxPlanka.Name = "pictureBoxPlanka";
            this.pictureBoxPlanka.Size = new System.Drawing.Size(177, 38);
            this.pictureBoxPlanka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPlanka.TabIndex = 2;
            this.pictureBoxPlanka.TabStop = false;
            this.pictureBoxPlanka.Visible = false;
            // 
            // pictureBoxShar2
            // 
            this.pictureBoxShar2.Image = global::Shariki.Properties.Resources.shar2;
            this.pictureBoxShar2.Location = new System.Drawing.Point(424, 57);
            this.pictureBoxShar2.Name = "pictureBoxShar2";
            this.pictureBoxShar2.Size = new System.Drawing.Size(75, 66);
            this.pictureBoxShar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShar2.TabIndex = 1;
            this.pictureBoxShar2.TabStop = false;
            this.pictureBoxShar2.Visible = false;
            this.pictureBoxShar2.Click += new System.EventHandler(this.bStart2_Click);
            // 
            // pictureBoxShar1
            // 
            this.pictureBoxShar1.Image = global::Shariki.Properties.Resources.shar;
            this.pictureBoxShar1.Location = new System.Drawing.Point(288, 57);
            this.pictureBoxShar1.Name = "pictureBoxShar1";
            this.pictureBoxShar1.Size = new System.Drawing.Size(75, 66);
            this.pictureBoxShar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShar1.TabIndex = 0;
            this.pictureBoxShar1.TabStop = false;
            this.pictureBoxShar1.Visible = false;
            this.pictureBoxShar1.Click += new System.EventHandler(this.bStart1_Click);
            // 
            // timerShar1
            // 
            this.timerShar1.Tick += new System.EventHandler(this.timerShar1_Tick);
            // 
            // timerShar2
            // 
            this.timerShar2.Tick += new System.EventHandler(this.timerShar2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(911, 442);
            this.Controls.Add(this.panelDvigenie);
            this.Controls.Add(this.panelUpravlenie);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Движение";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelUpravlenie.ResumeLayout(false);
            this.gBSpeed2.ResumeLayout(false);
            this.gBSpeed2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShar2)).EndInit();
            this.gBNapravlenie2.ResumeLayout(false);
            this.gBNapravlenie2.PerformLayout();
            this.gBSpeed1.ResumeLayout(false);
            this.gBSpeed1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShar1)).EndInit();
            this.gBfigur.ResumeLayout(false);
            this.gBfigur.PerformLayout();
            this.gBNapravlenie1.ResumeLayout(false);
            this.gBNapravlenie1.PerformLayout();
            this.panelDvigenie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlanka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUpravlenie;
        private System.Windows.Forms.GroupBox gBNapravlenie1;
        private System.Windows.Forms.RadioButton radioBDiagonal1;
        private System.Windows.Forms.RadioButton radioBGorizontal1;
        private System.Windows.Forms.RadioButton radioBVertical1;
        private System.Windows.Forms.GroupBox gBfigur;
        private System.Windows.Forms.CheckBox checkBPlanka;
        private System.Windows.Forms.CheckBox checkBShar2;
        private System.Windows.Forms.CheckBox checkBShar1;
        private System.Windows.Forms.GroupBox gBSpeed1;
        private System.Windows.Forms.TrackBar trackBarShar1;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bStart1;
        private System.Windows.Forms.Panel panelDvigenie;
        private System.Windows.Forms.PictureBox pictureBoxPlanka;
        private System.Windows.Forms.PictureBox pictureBoxShar2;
        private System.Windows.Forms.PictureBox pictureBoxShar1;
        private System.Windows.Forms.Timer timerShar1;
        private System.Windows.Forms.Timer timerShar2;
        private System.Windows.Forms.GroupBox gBNapravlenie2;
        private System.Windows.Forms.RadioButton radioBDiagonal2;
        private System.Windows.Forms.RadioButton radioBGorizontal2;
        private System.Windows.Forms.RadioButton radioBVertical2;
        private System.Windows.Forms.GroupBox gBSpeed2;
        private System.Windows.Forms.TrackBar trackBarShar2;
        private System.Windows.Forms.Button bStart2;
    }
}

