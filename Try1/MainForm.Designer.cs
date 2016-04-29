namespace Try1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.picturesTabPage = new System.Windows.Forms.TabPage();
            this.picturesDataGridView = new System.Windows.Forms.DataGridView();
            this.artistsTabPage = new System.Windows.Forms.TabPage();
            this.artistsDataGridView = new System.Windows.Forms.DataGridView();
            this.museumsTabPage = new System.Windows.Forms.TabPage();
            this.museumsDataGridView = new System.Windows.Forms.DataGridView();
            this.auctionTabPage = new System.Windows.Forms.TabPage();
            this.auctionListBox = new System.Windows.Forms.ListBox();
            this.auctionPicturesDataGridView = new System.Windows.Forms.DataGridView();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьФайлБазыДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.picturesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturesDataGridView)).BeginInit();
            this.artistsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistsDataGridView)).BeginInit();
            this.museumsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.museumsDataGridView)).BeginInit();
            this.auctionTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auctionPicturesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mainMenuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.изменитьФайлБазыДанныхToolStripMenuItem,
            this.очиститьБазуToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // очиститьБазуToolStripMenuItem
            // 
            this.очиститьБазуToolStripMenuItem.Name = "очиститьБазуToolStripMenuItem";
            this.очиститьБазуToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.очиститьБазуToolStripMenuItem.Text = "Очистить базу";
            this.очиститьБазуToolStripMenuItem.Click += new System.EventHandler(this.очиститьБазуToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.picturesTabPage);
            this.tabControl.Controls.Add(this.artistsTabPage);
            this.tabControl.Controls.Add(this.museumsTabPage);
            this.tabControl.Controls.Add(this.auctionTabPage);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1001, 501);
            this.tabControl.TabIndex = 1;
            // 
            // picturesTabPage
            // 
            this.picturesTabPage.Controls.Add(this.picturesDataGridView);
            this.picturesTabPage.Location = new System.Drawing.Point(4, 22);
            this.picturesTabPage.Name = "picturesTabPage";
            this.picturesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.picturesTabPage.Size = new System.Drawing.Size(993, 475);
            this.picturesTabPage.TabIndex = 0;
            this.picturesTabPage.Text = "Картины";
            this.picturesTabPage.UseVisualStyleBackColor = true;
            // 
            // picturesDataGridView
            // 
            this.picturesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.picturesDataGridView.Location = new System.Drawing.Point(6, 6);
            this.picturesDataGridView.Name = "picturesDataGridView";
            this.picturesDataGridView.Size = new System.Drawing.Size(979, 460);
            this.picturesDataGridView.TabIndex = 0;
            // 
            // artistsTabPage
            // 
            this.artistsTabPage.Controls.Add(this.artistsDataGridView);
            this.artistsTabPage.Location = new System.Drawing.Point(4, 22);
            this.artistsTabPage.Name = "artistsTabPage";
            this.artistsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.artistsTabPage.Size = new System.Drawing.Size(993, 475);
            this.artistsTabPage.TabIndex = 1;
            this.artistsTabPage.Text = "Художники";
            this.artistsTabPage.UseVisualStyleBackColor = true;
            // 
            // artistsDataGridView
            // 
            this.artistsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artistsDataGridView.Location = new System.Drawing.Point(7, 7);
            this.artistsDataGridView.Name = "artistsDataGridView";
            this.artistsDataGridView.Size = new System.Drawing.Size(979, 460);
            this.artistsDataGridView.TabIndex = 1;
            // 
            // museumsTabPage
            // 
            this.museumsTabPage.Controls.Add(this.museumsDataGridView);
            this.museumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.museumsTabPage.Name = "museumsTabPage";
            this.museumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.museumsTabPage.Size = new System.Drawing.Size(993, 475);
            this.museumsTabPage.TabIndex = 2;
            this.museumsTabPage.Text = "Музеи";
            this.museumsTabPage.UseVisualStyleBackColor = true;
            // 
            // museumsDataGridView
            // 
            this.museumsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.museumsDataGridView.Location = new System.Drawing.Point(7, 7);
            this.museumsDataGridView.Name = "museumsDataGridView";
            this.museumsDataGridView.Size = new System.Drawing.Size(979, 460);
            this.museumsDataGridView.TabIndex = 2;
            // 
            // auctionTabPage
            // 
            this.auctionTabPage.Controls.Add(this.auctionPicturesDataGridView);
            this.auctionTabPage.Controls.Add(this.auctionListBox);
            this.auctionTabPage.Location = new System.Drawing.Point(4, 22);
            this.auctionTabPage.Name = "auctionTabPage";
            this.auctionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.auctionTabPage.Size = new System.Drawing.Size(993, 475);
            this.auctionTabPage.TabIndex = 3;
            this.auctionTabPage.Text = "Аукцион";
            this.auctionTabPage.UseVisualStyleBackColor = true;
            // 
            // auctionListBox
            // 
            this.auctionListBox.FormattingEnabled = true;
            this.auctionListBox.Location = new System.Drawing.Point(8, 6);
            this.auctionListBox.Name = "auctionListBox";
            this.auctionListBox.Size = new System.Drawing.Size(313, 459);
            this.auctionListBox.TabIndex = 0;
            this.auctionListBox.SelectedIndexChanged += new System.EventHandler(this.auctionListBox_SelectedIndexChanged);
            // 
            // auctionPicturesDataGridView
            // 
            this.auctionPicturesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.auctionPicturesDataGridView.Location = new System.Drawing.Point(327, 6);
            this.auctionPicturesDataGridView.Name = "auctionPicturesDataGridView";
            this.auctionPicturesDataGridView.Size = new System.Drawing.Size(658, 459);
            this.auctionPicturesDataGridView.TabIndex = 1;
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // изменитьФайлБазыДанныхToolStripMenuItem
            // 
            this.изменитьФайлБазыДанныхToolStripMenuItem.Name = "изменитьФайлБазыДанныхToolStripMenuItem";
            this.изменитьФайлБазыДанныхToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.изменитьФайлБазыДанныхToolStripMenuItem.Text = "Изменить файл базы данных";
            this.изменитьФайлБазыДанныхToolStripMenuItem.Click += new System.EventHandler(this.изменитьФайлБазыДанныхToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 527);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник любителя живописи";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.picturesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturesDataGridView)).EndInit();
            this.artistsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.artistsDataGridView)).EndInit();
            this.museumsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.museumsDataGridView)).EndInit();
            this.auctionTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.auctionPicturesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage picturesTabPage;
        private System.Windows.Forms.DataGridView picturesDataGridView;
        private System.Windows.Forms.TabPage artistsTabPage;
        private System.Windows.Forms.DataGridView artistsDataGridView;
        private System.Windows.Forms.ToolStripMenuItem очиститьБазуToolStripMenuItem;
        private System.Windows.Forms.TabPage museumsTabPage;
        private System.Windows.Forms.DataGridView museumsDataGridView;
        private System.Windows.Forms.TabPage auctionTabPage;
        private System.Windows.Forms.ListBox auctionListBox;
        private System.Windows.Forms.DataGridView auctionPicturesDataGridView;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьФайлБазыДанныхToolStripMenuItem;
    }
}

