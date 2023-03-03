using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Filters
{
    public partial class Form1 : Form
    {
        Bitmap image;
        List<Bitmap> listBm;
        int size = 0;
        float[,] arr;
        private int mmkWidth = 3;
        private int mmkHeight = 3;
        private int[,] mmkMatrix = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };

        public Form1()
        {
            InitializeComponent();
        }

        

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter= " Image Files| *.png; *.jpg; *.bmp| All Files(*.*)| *.*"; // Doing filter for formats "jpg/ png/ bmp
            if( dialog.ShowDialog()==DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                listBm = new List<Bitmap>();
                listBm.Add(new Bitmap(image));
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }

        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filter)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
            {
                image = newImage;
                listBm.Add(new Bitmap(image));
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void blurringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter); // Запускает выполнение фоновой операции.
        }

        private void gaussFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void grayScaLeFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void brigtnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new BrigthnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void sobelFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new SobelFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void sharpnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new SharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            dialog.Title = "Save an Image File";
            dialog.ShowDialog(); // запускает диалоговое окно

            if (dialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)dialog.OpenFile();
                
                    switch (dialog.FilterIndex)
                    {
                        case 1:
                            this.image.Save(fs,
                                System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                        case 2:
                            this.image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Bmp);
                            break;

                        case 3:
                            this.image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                    }
                fs.Close();
            }
        }

        private void Undo_Click(object sender, EventArgs e)
        {        
            if (listBm.Last<Bitmap>() != listBm.First<Bitmap>())
            {
                listBm.Remove(listBm.Last<Bitmap>());
                image = listBm.Last<Bitmap>();
                pictureBox1.Image = image;
            }
        }

        private void wave1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Filter filter = new Wave();
          //  backgroundWorker1.RunWorkerAsync(filter);
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Filter filter = new Transfer();
            //backgroundWorker1.RunWorkerAsync(filter);

        }

        private void sharFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new SharFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void prewittFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new PrewittFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void medianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new MedianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            Dilation df = new Dilation(mmkWidth, mmkHeight, mmkMatrix);
            backgroundWorker1.RunWorkerAsync(df);
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Erosion ef = new Erosion(mmkWidth, mmkHeight, mmkMatrix);
            backgroundWorker1.RunWorkerAsync(ef);
        }
        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            Openning of = new Openning(mmkWidth, mmkHeight, mmkMatrix);
            backgroundWorker1.RunWorkerAsync(of);
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Closing cf = new Closing(mmkWidth, mmkHeight, mmkMatrix);
            backgroundWorker1.RunWorkerAsync(cf);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (size != 0)
            {
                arr = new float[size, size];
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                        arr[i, j] = (float)Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = Convert.ToInt32(comboBox1.SelectedItem);

            //создаём матрицу

            dataGridView1.RowCount = size;
            dataGridView1.ColumnCount = size;

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                        dataGridView1.Rows[i].Cells[j].Value = 0;
            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dataGridView1.AutoResizeColumns();
        }


        private void linearStretchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new LinearStretching();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void grayColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new GrayColor();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            TopHat thf = new TopHat(mmkWidth, mmkHeight, mmkMatrix);
            backgroundWorker1.RunWorkerAsync(thf);
        }

        private void expansionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Expansion();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void стеклоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlassFilter gf = new GlassFilter();
            backgroundWorker1.RunWorkerAsync(gf);
        }

        private void поворотToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateFilters rf = new RotateFilters();
            backgroundWorker1.RunWorkerAsync(rf);
        }

        private void размытостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MotionBlur mb = new MotionBlur();
            backgroundWorker1.RunWorkerAsync(mb);
        }

        private void mathMorfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void вертикальнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Wave();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void горизонтальнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Wave1();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void cдвигToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Transfer();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == false)
            {
                dataGridView1.Visible = true;
                comboBox1.Visible = true;
                button1.Visible = true;
            }
            else
            {
                dataGridView1.Visible = false;
                comboBox1.Visible = false;
                button1.Visible = false;

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editKernelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == false)
            {
                dataGridView1.Visible = true;
                comboBox1.Visible = true;
                button1.Visible = true;
            }
            else
            {
                dataGridView1.Visible = false;
                comboBox1.Visible = false;
                button1.Visible = false;

            }

        }

        private void дополнительноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Sinus();
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}
