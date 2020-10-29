using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SortingAlgorithmsVisualizer
{
    public partial class Form1 : Form
    {
        int ARRLENGTH = 250;
        int[] unsortedArray;
        int center;
        static bool isPaused = false;

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
        
        private void BlockButtons(bool block)
        {
            if (block)
            {
                BubbleSortButton.Enabled = false;
                CoctailSortButton.Enabled = false;
                GnomeSortingButton.Enabled = false;
                MergeSortingButton.Enabled = false;
                SelectionSortingButton.Enabled = false;
                HeapSortButton.Enabled = false;
                trackBar1.Enabled = false;
            }
            else
            {
                BubbleSortButton.Enabled = true;
                CoctailSortButton.Enabled = true;
                GnomeSortingButton.Enabled = true;
                MergeSortingButton.Enabled = true;
                SelectionSortingButton.Enabled = true;
                HeapSortButton.Enabled = true;
                trackBar1.Enabled = true;
            }
        }
        private void TimerInit()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
        }
        private void Unstop()
        {
            isPaused = false;
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
            unsortedArray = new int[capacity];
            FillArray(unsortedArray);
        }
        private void GraphicsInit()
        {
            CapacityLabel.Text = ARRLENGTH.ToString();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
            g = Graphics.FromImage(pictureBox1.Image);
            pen = new Pen(Color.Black);
            penCurrent = new Pen(Color.Red);
            pen.Width = 2;
            penCurrent.Width = 2;
            center = (int)(pictureBox1.Width / 2 - ARRLENGTH * 1.5);
        }

        private void DrawArray(int[] array, int current=-1)
        {
            g.Clear(Color.White);
            for (int i = 0, j = 0; i < ARRLENGTH; i++, j += 2) {
                if (i != current)
                    g.DrawLine(pen, new Point(i + center + j, pictureBox1.Height), new Point(i + center + j, pictureBox1.Height - array[i]));
                else
                    g.DrawLine(penCurrent, new Point(i + center + j, pictureBox1.Height), new Point(i + center + j, pictureBox1.Height - array[i]));
            }
            pictureBox1.Refresh();
            Application.DoEvents();

        }

        private void FillArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < ARRLENGTH; i++)
                array[i] = rand.Next(1, 350);
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
            BlockButtons(true);
            BubbleSorting(unsortedArray);
            TimerStop();
            BlockButtons(false);
        }
        private void CoctailSortButton_Click(object sender, EventArgs e)
        {
            TimerRun();
            BlockButtons(true);
            ShakerSorting(unsortedArray);
            TimerStop();
            BlockButtons(false);
        }
        private void GnomeSortingButton_Click(object sender, EventArgs e)
        {
            TimerRun();
            BlockButtons(true);
            GnomeSorting(unsortedArray);
            TimerStop();
            BlockButtons(false);
        }
        private void MergeSortingButton_Click(object sender, EventArgs e)
        {
            TimerRun();
            BlockButtons(true);
            MergeSort(unsortedArray, 0, ARRLENGTH-1);
            TimerStop();
            BlockButtons(false);
        }
        private void SelectionSortingButton_Click(object sender, EventArgs e)
        {
            TimerRun();
            BlockButtons(true);
            SelectionSorting(unsortedArray);
            TimerStop();
            BlockButtons(false);
        }
        private void HeapSortButton_Click(object sender, EventArgs e)
        {
            TimerRun();
            BlockButtons(true);
            HeapSort(unsortedArray);
            TimerStop();
            BlockButtons(false);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ARRLENGTH = trackBar1.Value;
            center = (int)(pictureBox1.Width / 2 - ARRLENGTH * 1.5);
            CapacityLabel.Text = ARRLENGTH.ToString();
            ArrayInit(ARRLENGTH);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            isPaused = true;
        }

        #endregion

        #region StripMenuEvents
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Refresh();
        }
        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isPaused = true;
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
                if (isPaused) break;
                for (int j = 0; j < ARRLENGTH-i-1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        DrawArray(array, j);
                        Swap(array, j, j+1); 
                    }                   
                }
            }
            DrawArray(array);
            Unstop();
        }

        private void ShakerSorting(int[] array)
        {
            int left = 0,
                right = ARRLENGTH - 1;
                
            while (left < right)
            {
                if (isPaused) break;
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
            Unstop();
        }

        private void GnomeSorting(int[] array)
        {
            int i = 1, j = 2;
            while(i < ARRLENGTH)
            {
                if (isPaused) break;
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
            Unstop();
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
                if (isPaused) break;
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
            Unstop();

        }
        private void SelectionSorting(int[] array)
        {
            for (int i = 0; i < ARRLENGTH; i++)
            {
                if (isPaused) break;
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
            Unstop();
        }

        public void HeapSort(int[] arr)
        {
            int n = arr.Length;

            // Build heap (rearrange array) 
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                heapify(arr, n, i);
                if (isPaused) break;
            }

            // One by one extract an element from heap 
            for (int i = n - 1; i > 0; i--)
            {
                if (isPaused) break;
                // Move current root to end 
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                DrawArray(arr, i);
                // call max heapify on the reduced heap 
                heapify(arr, i, 0);
            }
            DrawArray(arr);
            Unstop();
        }


        // To heapify a subtree rooted with node i which is 
        // an index in arr[]. n is size of heap 
        void heapify(int[] arr, int n, int i)
        {
            int largest = i; // Initialize largest as root 
            int l = 2 * i + 1; // left = 2*i + 1 
            int r = 2 * i + 2; // right = 2*i + 2 
            DrawArray(arr, i);
            // If left child is larger than root 
            if (l < n && arr[l] > arr[largest])
                largest = l;

            // If right child is larger than largest so far 
            if (r < n && arr[r] > arr[largest])
                largest = r;

            // If largest is not root 
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Recursively heapify the affected sub-tree 
                heapify(arr, n, largest);
            }
        }

        #endregion
    }
}
