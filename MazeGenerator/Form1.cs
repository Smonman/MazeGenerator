using Microsoft.WindowsAPICodePack.Taskbar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MazeGenerator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r;

        Bitmap maze;
        Graphics g;
        Tile[,] grid;
        Stack<Tile> stack;
        int size;
        int width;
        int height;
        int cols;
        int rows;

        bool drawEveryStep;
        bool finished;

        Stopwatch sw;

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress, Handle);
        }

        void Clear()
        {
            pictureBox_output.Image = null;
            toolStripStatusLabel_timeelapsed.Text = string.Empty;
        }

        void GetInput()
        {
            width = (int)numericUpDown_width.Value;
            height = (int)numericUpDown_height.Value;
            size = (int)numericUpDown_size.Value;
            cols = width / size;
            rows = height / size;
            drawEveryStep = checkBox_drawEveryStep.Checked;
        }

        void Setup()
        {
            r = new Random();
            maze = new Bitmap(cols * size + 1, rows * size + 1);
            g = Graphics.FromImage(maze);
            grid = new Tile[cols, rows];
            stack = new Stack<Tile>();
            finished = false;
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    grid[x, y] = new Tile(x, y, size, cols, rows, r);
                }
            }
            sw = new Stopwatch();
        }

        private void backgroundWorker_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker w = (BackgroundWorker)sender;
            Generate(w);
        }

        void Generate(BackgroundWorker w)
        {
            int tileCount = cols * rows;
            int visitedTiles = 1;
            int percentage = 0;
            Tile curTile = grid[0, 0];
            curTile.visited = true;
            Tile nextTile;
            while (!finished && !w.CancellationPending)
            {
                List<Tile> stackList = new List<Tile>();
                stackList = stack.ToList<Tile>();
                for (int i = 0; i < stackList.Count; i++)
                {
                    if (stackList[i].GetNeighborCount(grid) <= 0 && stackList[i] != grid[0, 0])
                    {
                        stackList.RemoveAt(i);
                    }
                }
                stack = new Stack<Tile>(stackList);
                nextTile = curTile.GetNextNeighbor(grid);
                if (nextTile != null)
                {
                    nextTile.visited = true;
                    RemoveWalls(curTile, nextTile);
                    if (curTile.GetNeighborCount(grid) > 0)
                    {
                        stack.Push(curTile);
                    }
                    curTile = nextTile;

                    visitedTiles++;
                    percentage = (int)Math.Floor(((float)visitedTiles / tileCount) * 100);
                    backgroundWorker_worker.ReportProgress(percentage);
                    //Console.WriteLine(percentage + "% | Tile count: " + tileCount + " | Cur Tile Count: " + visitedTiles);
                }
                else if (stack.Count > 0)
                {
                    curTile = stack.Pop();
                }
                else
                {
                    finished = true;
                }
                if (drawEveryStep)
                {
                    Draw();
                }
            }
            Draw();
            toolStripStatusLabel_timeelapsed.Text = sw.Elapsed.ToString();
        }

        void RemoveWalls(Tile cur, Tile next)
        {
            int x = cur.x - next.x;
            int y = cur.y - next.y;
            if (x == 1)
            {
                cur.walls[3] = false;
                next.walls[1] = false;
            }
            else if (x == -1)
            {
                cur.walls[1] = false;
                next.walls[3] = false;
            }
            if (y == 1)
            {
                cur.walls[0] = false;
                next.walls[2] = false;
            }
            else if (y == -1)
            {
                cur.walls[2] = false;
                next.walls[0] = false;
            }
        }

        void Draw()
        {
            g.Clear(Color.White);
            foreach (Tile t in grid)
            {
                t.Show(ref g);
            }
            pictureBox_output.Invoke((MethodInvoker)(() => pictureBox_output.Image = new Bitmap(maze)));
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            Clear();
            GetInput();
            Setup();
            sw.Start();
            backgroundWorker_worker.RunWorkerAsync();

            button_generate.Enabled = false;
            button_stop.Enabled = true;
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal, Handle);
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            Finish();
        }


        private void backgroundWorker_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Finish();
        }

        void Finish()
        {
            sw.Stop();
            Draw();
            backgroundWorker_worker.CancelAsync();
            button_generate.Invoke((MethodInvoker)(() => button_generate.Enabled = true));
            button_stop.Invoke((MethodInvoker)(() => button_stop.Enabled = false));
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress, Handle);
        }

        private void backgroundWorker_worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                toolStripProgressBar_progessbar.Value = e.ProgressPercentage;
            }
            catch
            {
                Console.WriteLine("Toolstrip Progessbar Error");
            }
            TaskbarManager.Instance.SetProgressValue(e.ProgressPercentage, 100, Handle);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "bmp(*.bmp) | *.bmp | jpeg(*.jpeg) | *.jpeg | png(*.png) | *.png | tiff(*.tiff) | *.tiff";
            ImageFormat imgFormat;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string extension = Path.GetExtension(sfd.FileName);
                switch (extension)
                {
                    case ".bmp":
                        imgFormat = ImageFormat.Bmp;
                        break;
                    case ".jpeg":
                        imgFormat = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        imgFormat = ImageFormat.Png;
                        break;
                    case ".tiff":
                        imgFormat = ImageFormat.Tiff;
                        break;
                    default:
                        imgFormat = ImageFormat.Png;
                        break;
                }
                pictureBox_output.Image.Save(sfd.FileName, imgFormat);
            }
        }
    }
}
