using DatabaseHandler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Try1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        public void Print<T>(T obj)
        {
            MessageBox.Show(obj.ToString());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeData();      
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataContext.Instance.SaveDataContext();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataContext.Instance.SaveDataContext();
        }

        private void InitializeData()
        {
            foreach(Control tabControl in tabControl.Controls)
            {
                foreach(Control control in tabControl.Controls)
                {
                    if (control is DataGridView)
                    {
                        ((DataGridView)control).AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }

            picturesDataGridView.DataSource = DataContext.Instance.Pictures;
            artistsDataGridView.DataSource = DataContext.Instance.Artists;
            museumsDataGridView.DataSource = DataContext.Instance.Museums;

            auctionListBox.Items.Clear();
            auctionPicturesDataGridView.DataSource = null;
            foreach (var auction in DataContext.Instance.Auctions)
            {
                auctionListBox.Items.Add(String.Format("Title: {0}, Date: {1}", auction.Title,auction.Date));
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void очиститьБазуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseDialogForm closeDialogForm = new CloseDialogForm();
            if (closeDialogForm.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
            }
        }

        private void auctionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (auctionListBox.SelectedItem == null)
                return;

            var auction = DataContext.Instance.Auctions[auctionListBox.SelectedIndex];
            auctionPicturesDataGridView.DataSource = null;
            auctionPicturesDataGridView.DataSource = auction.Items;
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                DataContext.Instance.SaveDataContext();
                File.Copy(DataContext.Instance.Path, Path.Combine(fbd.SelectedPath + @"\db.dat"));
            }
        }

        private void изменитьФайлБазыДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Database file (.dat)|*.dat";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofd.FileName))
                {
                    DataContext.Instance.Path = ofd.FileName;
                    DataContext.Instance.Initialize();
                    InitializeData();
                }
            }
        }
    }
}
