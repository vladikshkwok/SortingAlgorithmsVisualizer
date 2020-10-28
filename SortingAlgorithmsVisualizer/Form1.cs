using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithmsVisualizer
{
    public partial class Form1 : Form
    {
        int ARRLENGTH = 250;
        int[] unsortedArray;

        Bitmap bitmap;
        Graphics g;
        Pen pen, penCurrent;
        System.Windows.Forms.Timer timer;
        int timerCounter;


        public Form1()
        {
            InitializeComponent();
            GraphicsInit();
            ArrayInit();
            TimerInit();
        }
        private void TimerInit()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
        }
        private void TimerRun()
        {
            timerCounter = 0;
            TimerLabel.Text = $"{timerCounter} s.";
            timer.Start();
        }
        private void TimerStop()
        {
            timer.Stop();
        }
        void Timer_Tick(object sender, EventArgs e)
        {
           timerCounter++;
            if (timerCounter < 60)
                this.TimerLabel.Text = $"{timerCounter} s.";
            else
                this.TimerLabel.Text = $"{timerCounter/60} m. {timerCounter % 60} s.";
        }
        private void ArrayInit(int capacity=250)
        {
            OKButton.Enabled = false;
            unsortedArray = new int[capacity];
            FillArray(unsortedArray);
        }
        private void GraphicsInit()
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
            g = Graphics.FromImage(pictureBox1.Image);
            pen = new Pen(Color.Black);
            penCurrent = new Pen(Color.Red);
            pen.Width = 2;
            penCurrent.Width = 2;
            
        }

        private void DrawArray(int[] array, int current=-1)
        {
            g.Clear(Color.White);
            for (int i = 0, j = 0; i < ARRLENGTH; i++, j += 2) {
                if (i != current)
                    g.DrawLine(pen, new Point(i + 15 + j, pictureBox1.Height), new Point(i + 15 + j, pictureBox1.Height - array[i]));
                else
                    g.DrawLine(penCurrent, new Point(i + 15 + j, pictureBox1.Height), new Point(i + 15 + j, pictureBox1.Height - array[i]));
            }
            pictureBox1.Refresh();
            Application.DoEvents();

        }

        private void FillArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < ARRLENGTH; i++)
                array[i] = rand.Next(1, 200);
            DrawArray(array);
        }

        static void Swap(int[] array, int i, int j)
        {
            int glass = array[i];
            array[i] = array[j];
            array[j] = glass;
        }

        #region ButtonsClickEvents

        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            TimerRun();
            BubbleSorting(unsortedArray);
            TimerStop();
        }
        private void CoctailSortButton_Click(object sender, EventArgs e)
        {
            TimerRun();
            ShakerSorting(unsortedArray);
            TimerStop();
        }
        private void GnomeSortingButton_Click(object sender, EventArgs e)
        {
            TimerRun();
            GnomeSorting(unsortedArray);
            TimerStop();
        }
        private void MergeSortingButton_Click(object sender, EventArgs e)
        {
            TimerRun();
            MergeSort(unsortedArray, 0, ARRLENGTH-1);
            TimerStop();
        }
        private void SelectionSortingButton_Click(object sender, EventArgs e)
        {
            TimerRun();
            SelectionSorting(unsortedArray);
            TimerStop();
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            ARRLENGTH = Convert.ToInt32(ArrayCapacitySetter.Text);
            ArrayInit(ARRLENGTH);
            OKButton.Enabled = true;
        }

        private void ArrayCapacitySetter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(ArrayCapacitySetter.Text) <= 0 || Convert.ToInt32(ArrayCapacitySetter.Text) > 253)
                    OKButton.Enabled = false;
                else
                {
                    OKButton.Enabled = true;
                }
            }
            catch (Exception er) { OKButton.Enabled = false; }
        }


        #endregion

        #region StripMenuEvents
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Refresh();
        }

        private void FillRandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillArray(unsortedArray);
            DrawArray(unsortedArray);
        }
        #endregion

        #region Sorting algorithms
        private void BubbleSorting(int[] array)
        {
            for (int i = 0; i < ARRLENGTH; i++)
            {
                for (int j = i + 1; j < ARRLENGTH; j++)
                {
                    if (array[i] > array[j])
                    {
                        DrawArray(array, j);
                        Swap(array, i, j); 
                    }                   
                }
            }
            DrawArray(array);
        }

        private void ShakerSorting(int[] array)
        {
            int left = 0,
                right = ARRLENGTH - 1;
                
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                        DrawArray(array, i);
                    }
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    if (array[i - 1] > array[i])
                    {
                        Swap(array, i - 1, i);
                        DrawArray(array, i);
                    }
                }
                left++;
            }
            DrawArray(array);
        }

        private void GnomeSorting(int[] array)
        {
            int i = 1, j = 2;
            while(i < ARRLENGTH)
            {
                if (array[i-1] < array[i])
                {
                    i = j;
                    j++;
                }
                else
                {
                    Swap(array, i - 1, i);
                    DrawArray(array, i);
                    i--;
                    if (i == 0)
                    {
                        i = j;
                        j++;
                    }
                }
            }
            DrawArray(array);
        }

        private void Merge(int[] array, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(array, left, leftArray, 0, middle - left + 1);
            Array.Copy(array, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    array[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                DrawArray(array, k);
            }
            DrawArray(array);
        }



        private void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                
                int middle = (left + right) / 2;
                DrawArray(array);
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);
                
                Merge(array, left, middle, right);
            }
            
        }
        private void SelectionSorting(int[] array)
        {
            for (int i = 0; i < ARRLENGTH; i++)
            {
                int min = i;
                for (int j = i + 1; j < ARRLENGTH; j++)
                {
                    if (array[j] < array[min])
                        min = j;
                    DrawArray(array, j);
                }
                Swap(array, i, min);

                DrawArray(array, min);
            }
            DrawArray(array);
        }

        #endregion
    }
}
