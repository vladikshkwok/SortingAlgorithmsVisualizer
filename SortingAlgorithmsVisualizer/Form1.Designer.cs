namespace SortingAlgorithmsVisualizer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BubbleSortButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.массивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заполнитьРандомноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CoctailSortButton = new System.Windows.Forms.Button();
            this.GnomeSortingButton = new System.Windows.Forms.Button();
            this.MergeSortingButton = new System.Windows.Forms.Button();
            this.SelectionSortingButton = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.HeapSortButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.CapacityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(865, 359);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BubbleSortButton
            // 
            this.BubbleSortButton.Location = new System.Drawing.Point(12, 31);
            this.BubbleSortButton.Name = "BubbleSortButton";
            this.BubbleSortButton.Size = new System.Drawing.Size(120, 42);
            this.BubbleSortButton.TabIndex = 1;
            this.BubbleSortButton.Text = "Сортировка пузырьком";
            this.BubbleSortButton.UseVisualStyleBackColor = true;
            this.BubbleSortButton.Click += new System.EventHandler(this.BubbleSortButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.массивToolStripMenuItem,
            this.приложениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // массивToolStripMenuItem
            // 
            this.массивToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearToolStripMenuItem,
            this.заполнитьРандомноToolStripMenuItem});
            this.массивToolStripMenuItem.Name = "массивToolStripMenuItem";
            this.массивToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.массивToolStripMenuItem.Text = "Массив";
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ClearToolStripMenuItem.Text = "Очистить";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // заполнитьРандомноToolStripMenuItem
            // 
            this.заполнитьРандомноToolStripMenuItem.Name = "заполнитьРандомноToolStripMenuItem";
            this.заполнитьРандомноToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.заполнитьРандомноToolStripMenuItem.Text = "Заполнить рандомно";
            this.заполнитьРандомноToolStripMenuItem.Click += new System.EventHandler(this.FillRandToolStripMenuItem_Click);
            // 
            // приложениеToolStripMenuItem
            // 
            this.приложениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StopToolStripMenuItem});
            this.приложениеToolStripMenuItem.Name = "приложениеToolStripMenuItem";
            this.приложениеToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.приложениеToolStripMenuItem.Text = "Приложение";
            // 
            // StopToolStripMenuItem
            // 
            this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
            this.StopToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.StopToolStripMenuItem.Text = "Остановить";
            this.StopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CoctailSortButton
            // 
            this.CoctailSortButton.Location = new System.Drawing.Point(138, 31);
            this.CoctailSortButton.Name = "CoctailSortButton";
            this.CoctailSortButton.Size = new System.Drawing.Size(120, 42);
            this.CoctailSortButton.TabIndex = 3;
            this.CoctailSortButton.Text = "Сортировка перемешиванием";
            this.CoctailSortButton.UseVisualStyleBackColor = true;
            this.CoctailSortButton.Click += new System.EventHandler(this.CoctailSortButton_Click);
            // 
            // GnomeSortingButton
            // 
            this.GnomeSortingButton.Location = new System.Drawing.Point(264, 31);
            this.GnomeSortingButton.Name = "GnomeSortingButton";
            this.GnomeSortingButton.Size = new System.Drawing.Size(120, 42);
            this.GnomeSortingButton.TabIndex = 4;
            this.GnomeSortingButton.Text = "Gnome сортировка (Stupid sort)";
            this.GnomeSortingButton.UseVisualStyleBackColor = true;
            this.GnomeSortingButton.Click += new System.EventHandler(this.GnomeSortingButton_Click);
            // 
            // MergeSortingButton
            // 
            this.MergeSortingButton.Location = new System.Drawing.Point(390, 31);
            this.MergeSortingButton.Name = "MergeSortingButton";
            this.MergeSortingButton.Size = new System.Drawing.Size(120, 42);
            this.MergeSortingButton.TabIndex = 5;
            this.MergeSortingButton.Text = "Сортировка слиянием";
            this.MergeSortingButton.UseVisualStyleBackColor = true;
            this.MergeSortingButton.Click += new System.EventHandler(this.MergeSortingButton_Click);
            // 
            // SelectionSortingButton
            // 
            this.SelectionSortingButton.Location = new System.Drawing.Point(516, 31);
            this.SelectionSortingButton.Name = "SelectionSortingButton";
            this.SelectionSortingButton.Size = new System.Drawing.Size(120, 42);
            this.SelectionSortingButton.TabIndex = 6;
            this.SelectionSortingButton.Text = "Сортировка выбором";
            this.SelectionSortingButton.UseVisualStyleBackColor = true;
            this.SelectionSortingButton.Click += new System.EventHandler(this.SelectionSortingButton_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.Color.White;
            this.TimerLabel.Location = new System.Drawing.Point(27, 97);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(0, 13);
            this.TimerLabel.TabIndex = 10;
            // 
            // HeapSortButton
            // 
            this.HeapSortButton.Location = new System.Drawing.Point(642, 31);
            this.HeapSortButton.Name = "HeapSortButton";
            this.HeapSortButton.Size = new System.Drawing.Size(120, 42);
            this.HeapSortButton.TabIndex = 11;
            this.HeapSortButton.Text = "Сортировка кучей";
            this.HeapSortButton.UseVisualStyleBackColor = true;
            this.HeapSortButton.Click += new System.EventHandler(this.HeapSortButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(773, 28);
            this.trackBar1.Maximum = 280;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Value = 140;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(770, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Размер массива";
            // 
            // CapacityLabel
            // 
            this.CapacityLabel.AutoSize = true;
            this.CapacityLabel.Location = new System.Drawing.Point(858, 60);
            this.CapacityLabel.Name = "CapacityLabel";
            this.CapacityLabel.Size = new System.Drawing.Size(35, 13);
            this.CapacityLabel.TabIndex = 14;
            this.CapacityLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.CapacityLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.HeapSortButton);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.SelectionSortingButton);
            this.Controls.Add(this.MergeSortingButton);
            this.Controls.Add(this.GnomeSortingButton);
            this.Controls.Add(this.CoctailSortButton);
            this.Controls.Add(this.BubbleSortButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Визуализатор алгоритмов сортировки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BubbleSortButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem массивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заполнитьРандомноToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button CoctailSortButton;
        private System.Windows.Forms.Button GnomeSortingButton;
        private System.Windows.Forms.Button MergeSortingButton;
        private System.Windows.Forms.Button SelectionSortingButton;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Button HeapSortButton;
        private System.Windows.Forms.ToolStripMenuItem приложениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CapacityLabel;
    }
}

