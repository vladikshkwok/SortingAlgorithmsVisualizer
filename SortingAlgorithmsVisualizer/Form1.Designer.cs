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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CoctailSortButton = new System.Windows.Forms.Button();
            this.GnomeSortingButton = new System.Windows.Forms.Button();
            this.MergeSortingButton = new System.Windows.Forms.Button();
            this.SelectionSortingButton = new System.Windows.Forms.Button();
            this.ArrayCapacitySetter = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.HeapSortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.BubbleSortButton.Size = new System.Drawing.Size(122, 42);
            this.BubbleSortButton.TabIndex = 1;
            this.BubbleSortButton.Text = "Сортировка пузырьком";
            this.BubbleSortButton.UseVisualStyleBackColor = true;
            this.BubbleSortButton.Click += new System.EventHandler(this.BubbleSortButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.массивToolStripMenuItem});
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CoctailSortButton
            // 
            this.CoctailSortButton.Location = new System.Drawing.Point(140, 31);
            this.CoctailSortButton.Name = "CoctailSortButton";
            this.CoctailSortButton.Size = new System.Drawing.Size(122, 42);
            this.CoctailSortButton.TabIndex = 3;
            this.CoctailSortButton.Text = "Сортировка перемешиванием";
            this.CoctailSortButton.UseVisualStyleBackColor = true;
            this.CoctailSortButton.Click += new System.EventHandler(this.CoctailSortButton_Click);
            // 
            // GnomeSortingButton
            // 
            this.GnomeSortingButton.Location = new System.Drawing.Point(268, 31);
            this.GnomeSortingButton.Name = "GnomeSortingButton";
            this.GnomeSortingButton.Size = new System.Drawing.Size(122, 42);
            this.GnomeSortingButton.TabIndex = 4;
            this.GnomeSortingButton.Text = "Gnome сортировка (Stupid sort)";
            this.GnomeSortingButton.UseVisualStyleBackColor = true;
            this.GnomeSortingButton.Click += new System.EventHandler(this.GnomeSortingButton_Click);
            // 
            // MergeSortingButton
            // 
            this.MergeSortingButton.Location = new System.Drawing.Point(396, 31);
            this.MergeSortingButton.Name = "MergeSortingButton";
            this.MergeSortingButton.Size = new System.Drawing.Size(122, 42);
            this.MergeSortingButton.TabIndex = 5;
            this.MergeSortingButton.Text = "Сортировка слиянием";
            this.MergeSortingButton.UseVisualStyleBackColor = true;
            this.MergeSortingButton.Click += new System.EventHandler(this.MergeSortingButton_Click);
            // 
            // SelectionSortingButton
            // 
            this.SelectionSortingButton.Location = new System.Drawing.Point(524, 31);
            this.SelectionSortingButton.Name = "SelectionSortingButton";
            this.SelectionSortingButton.Size = new System.Drawing.Size(122, 42);
            this.SelectionSortingButton.TabIndex = 6;
            this.SelectionSortingButton.Text = "Сортировка выбором";
            this.SelectionSortingButton.UseVisualStyleBackColor = true;
            this.SelectionSortingButton.Click += new System.EventHandler(this.SelectionSortingButton_Click);
            // 
            // ArrayCapacitySetter
            // 
            this.ArrayCapacitySetter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ArrayCapacitySetter.Location = new System.Drawing.Point(679, 4);
            this.ArrayCapacitySetter.Name = "ArrayCapacitySetter";
            this.ArrayCapacitySetter.Size = new System.Drawing.Size(198, 20);
            this.ArrayCapacitySetter.TabIndex = 7;
            this.ArrayCapacitySetter.Tag = "";
            this.ArrayCapacitySetter.Text = "Введите кол-во до 280 и нажмите ОК";
            this.ArrayCapacitySetter.TextChanged += new System.EventHandler(this.ArrayCapacitySetter_TextChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(794, 31);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(83, 42);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
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
            this.HeapSortButton.Location = new System.Drawing.Point(652, 31);
            this.HeapSortButton.Name = "HeapSortButton";
            this.HeapSortButton.Size = new System.Drawing.Size(122, 42);
            this.HeapSortButton.TabIndex = 11;
            this.HeapSortButton.Text = "Сортировка кучей";
            this.HeapSortButton.UseVisualStyleBackColor = true;
            this.HeapSortButton.Click += new System.EventHandler(this.HeapSortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.HeapSortButton);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ArrayCapacitySetter);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox ArrayCapacitySetter;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Button HeapSortButton;
    }
}

