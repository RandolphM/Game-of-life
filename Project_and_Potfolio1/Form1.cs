using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Project_and_Potfolio1
{
    public partial class Form1 : Form
    {
        // universe
        int u_width;
        int u_height;
        bool[,] universe;

        //color
        Color gridcolor;
        Color cellcolor;
        //timer
        Timer T = new Timer();
        int mill;
        //Generations couter
        int generations = 0;
        // random generator
        Random rand = new Random();
        //boundery variables
        bool toroidal = Properties.Settings.Default.Toroidal;
        bool Finite = Properties.Settings.Default.Finite;

        public Form1()
        {
            InitializeComponent();
            u_width = Properties.Settings.Default.universe_W;
            u_height = Properties.Settings.Default.universe_H;
            gridcolor = Properties.Settings.Default.grid_color;
            cellcolor = Properties.Settings.Default.Cell_color;
            mill = Properties.Settings.Default.time_interval;
            universe = new bool[u_width, u_height];
            Gen_toolStripStatusLabel.Text = "Generations = " + generations;
            cellStripStatusLabel.Text = "Number of living cells = " + Alivecells();
            generation_lable.Text = "Generations = " + generations;
            cells_lable.Text = "Number of living cells = " + Alivecells();
            univers_label.Text = "universe size { Width = " + u_width + ", Height = " + u_height + "}";
            if (Finite)
            {
                boundery_lable.Text = "Boundery = Finite";
                bound_toolStripStatusLabel.Text = "Boundery = Finite";
            }
            else
            {
                boundery_lable.Text = "Boundery = Toroidal";
                bound_toolStripStatusLabel.Text = "Boundery = Toroidal";
            }
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            float width = (float)graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            float Height = (float)graphicsPanel1.ClientSize.Height / universe.GetLength(1);

            //Pen & Brush
            Pen gridpen = new Pen(gridcolor, 1);
            Brush cell_brush = new SolidBrush(cellcolor);

            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {

                    RectangleF RECT = Rectangle.Empty;
                    RECT.X = (x * width);
                    RECT.Y = y * Height;
                    RECT.Width = width;
                    RECT.Height = Height;
                    // cell paint 
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cell_brush, RECT.X, RECT.Y, RECT.Width, RECT.Height);
                    }
                    // grid paint
                    e.Graphics.DrawRectangle(gridpen, RECT.X, RECT.Y, RECT.Width, RECT.Height);
                }
            }

            gridpen.Dispose();
            cell_brush.Dispose();
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            float width = (float)graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            float Height = (float)graphicsPanel1.ClientSize.Height / universe.GetLength(1);

            if (e.Button == MouseButtons.Left)
            {
                float x = e.X / width;
                float y = e.Y / Height;

                universe[(int)x, (int)y] = !universe[(int)x, (int)y];

                graphicsPanel1.Invalidate();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PlayToolStripButton_Click(object sender, EventArgs e)
        {
            T.Enabled = true;
            T.Interval = mill;
            T.Tick += Tick;
            PlayToolStripButton.Enabled = false;
            NextToolStripButton.Enabled = false;
            pauseToolStripButton.Enabled = true;
        }

        private void Tick(object sender, EventArgs e)
        {
            lifeProcess();
            NextGenerationUpdate();
            graphicsPanel1.Invalidate();
        }

        private void NextGenerationUpdate()
        {
            generations++;
            Gen_toolStripStatusLabel.Text = "Generations = " + generations;
            cellStripStatusLabel.Text = "Number of living cells = " + Alivecells();
            generation_lable.Text = "Generations = " + generations;
            cells_lable.Text = "Number of living cells = " + Alivecells();

        }

        private int Alivecells()
        {
            int cells = 0;
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    if (universe[x, y] == true)
                    {
                        cells++;
                    }
                }
            }
            return cells;
        }

        private void pauseToolStripButton_Click(object sender, EventArgs e)
        {
            T.Enabled = false;
            pauseToolStripButton.Enabled = false;
            PlayToolStripButton.Enabled = true;
            NextToolStripButton.Enabled = true;
        }

        private void NextToolStripButton_Click(object sender, EventArgs e)
        {
            T.Enabled = false;
            Tick(sender, e);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cleanuni();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            cleanuni();
        }

        private int Neighbours(int x, int y)
        {
            int neighbors = 0;
            if (Finite)
            {
                if (x < 0 || x >= universe.GetLength(0))
                    return 0;
                if (y < 0 || y >= universe.GetLength(1))
                    return 0;

                for (int X_ = x - 1; X_ <= x + 1; X_++)
                {

                    for (int Y_ = y - 1; Y_ <= y + 1; Y_++)
                    {
                        if (X_ < 0 || X_ >= universe.GetLength(0) || Y_ < 0 || Y_ >= universe.GetLength(1))
                            continue;

                        if (x == X_ && y == Y_)
                            continue;
                        bool cell = universe[X_, Y_];
                        if (cell)
                            neighbors++;
                    }
                }
            }
            else if (toroidal)
            {
                if (x < 0 || x >= universe.GetLength(0))
                    return 0;
                if (y < 0 || y >= universe.GetLength(1))
                    return 0;

                for (int X_ = x - 1; X_ <= x + 1; X_++)
                {

                    for (int Y_ = y - 1; Y_ <= y + 1; Y_++)
                    {
                        int _x = X_;
                        int _y = Y_;

                        // toroidal x
                        if (_x > universe.GetLength(0) - 1)
                            _x = 0;
                        if (_x < 0)
                            _x = universe.GetLength(0) - 1;
                        // toroidal y
                        if (_y > universe.GetLength(1) - 1)
                            _y = 0;
                        if (_y < 0)
                            _y = universe.GetLength(1) - 1;


                        if (x == X_ && y == Y_)
                            continue;
                        bool cell = universe[_x, _y];
                        if (cell)
                            neighbors++;
                    }
                }
            }
            return neighbors;

        }

        private void lifeProcess()
        {
            //int width = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            //int Height = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

            bool[,] ScratchPad = new bool[u_width, u_height];
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    if (universe[x, y] == false && Neighbours(x, y) == 3)
                        ScratchPad[x, y] = true;
                    else if (universe[x, y] == true && (Neighbours(x, y) == 2 || Neighbours(x, y) == 3))
                        ScratchPad[x, y] = true;
                    else if (universe[x, y] == true && (Neighbours(x, y) < 2 || Neighbours(x, y) > 3))
                        ScratchPad[x, y] = false;
                }
            }
            universe = ScratchPad;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void Random_btn_Click(object sender, EventArgs e)
        {

            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    if (rand.Next() % 4 == 0)
                    {
                        universe[x, y] = true;
                    }
                }
            }
            graphicsPanel1.Invalidate();
            cellStripStatusLabel.Text = "Number of living cells = " + Alivecells();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            T.Enabled = true;
            T.Interval = mill;
            T.Tick += Tick;
            PlayToolStripButton.Enabled = false;
            NextToolStripButton.Enabled = false;
            pauseToolStripButton.Enabled = true;

        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            T.Enabled = false;
            pauseToolStripButton.Enabled = false;
            PlayToolStripButton.Enabled = true;
            NextToolStripButton.Enabled = true;
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            T.Enabled = false;
            Tick(sender, e);
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cleanuni();
        }

        private void cleanuni()
        {
            universe = new bool[u_width, u_height];

            //for (int x = 0; x < universe.GetLength(0); x++)
            //{
            //    for (int y = 0; y < universe.GetLength(1); y++)
            //    {
            //        universe[x, y] = false;
            //    }
            //}
            graphicsPanel1.Invalidate();
            generations = 0;
            Gen_toolStripStatusLabel.Text = "Generations = " + generations;
            cellStripStatusLabel.Text = "Number of living cells = " + Alivecells();
            generation_lable.Text = "Generations = " + generations;
            cells_lable.Text = "Number of living cells = " + Alivecells();
            univers_label.Text = "universe size { Width = " + u_width + ", Height = " + u_height + "}";
            if (Finite)
            {
                boundery_lable.Text = "Boundery = Finite";
                bound_toolStripStatusLabel.Text = "Boundery = Finite";
            }
            else
            {
                boundery_lable.Text = "Boundery = Toroidal";
                bound_toolStripStatusLabel.Text = "Boundery = Toroidal";
            }
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            options_Form opf = new options_Form();
            opf.milliseconds = mill;
            opf.width = u_width;
            opf.height = u_height;
            opf.grid_color = gridcolor;
            opf.Cell_color = cellcolor;
            opf.grid_tor = toroidal;
            opf.grid_Fin = Finite;

            if (opf.ShowDialog() == DialogResult.OK)
            {
                mill = opf.milliseconds;
                u_width = opf.width;
                u_height = opf.height;
                universe = new bool[u_width, u_height];
                gridcolor = opf.grid_color;
                cellcolor = opf.Cell_color;
                Finite = opf.grid_Fin;
                toroidal = opf.grid_tor;
            }
            cleanuni();
            graphicsPanel1.Invalidate();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            gridcolor = Properties.Settings.Default.grid_color;
            cellcolor = Properties.Settings.Default.Cell_color;
            u_width = Properties.Settings.Default.universe_W;
            u_height = Properties.Settings.Default.universe_H;
            mill = Properties.Settings.Default.time_interval;
            Finite = Properties.Settings.Default.Finite;
            toroidal = Properties.Settings.Default.Toroidal;
            cleanuni();
            graphicsPanel1.Invalidate();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            gridcolor = Properties.Settings.Default.grid_color;
            cellcolor = Properties.Settings.Default.Cell_color;
            u_width = Properties.Settings.Default.universe_W;
            u_height = Properties.Settings.Default.universe_H;
            mill = Properties.Settings.Default.time_interval;
            Finite = Properties.Settings.Default.Finite;
            toroidal = Properties.Settings.Default.Toroidal;
            cleanuni();
            graphicsPanel1.Invalidate();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.grid_color = gridcolor;
            Properties.Settings.Default.Cell_color = cellcolor;
            Properties.Settings.Default.universe_W = u_width;
            Properties.Settings.Default.universe_H = u_height;
            Properties.Settings.Default.time_interval = mill;
            Properties.Settings.Default.Finite = Finite;
            Properties.Settings.Default.Toroidal = toroidal;
            Properties.Settings.Default.Save();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdlg = new SaveFileDialog();
            sdlg.Filter = "All files|*.*|Cells|*.cells* ";
            sdlg.FilterIndex = 2;
            sdlg.DefaultExt = "Cells";
            if (sdlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter text = new StreamWriter(sdlg.FileName + ".txt");
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    StringBuilder str = new StringBuilder();
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        if (universe[x, y] == true)
                        {
                            str.Append('O');
                        }
                        else if (universe[x, y] == false)
                        {
                            str.Append('.');
                        }
                    }
                    text.WriteLine(str.ToString());
                }

                text.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdlg = new SaveFileDialog();
            sdlg.Filter = "All files|*.*|Cells|*.cells* ";
            sdlg.FilterIndex = 2;
            sdlg.DefaultExt = "Cells";
            if (sdlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter text = new StreamWriter(sdlg.FileName + ".txt");
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    StringBuilder str = new StringBuilder();
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        if (universe[x, y] == true)
                        {
                            str.Append('O');
                        }
                        else if (universe[x, y] == false)
                        {
                            str.Append('.');
                        }
                    }
                    text.WriteLine(str.ToString());
                }

                text.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamReader reader = new StreamReader(dlg.FileName);

                // Create a couple variables to calculate the width and height
                // of the data in the file.
                int maxWidth = 0;
                int maxHeight = 0;

                // Iterate through the file once to get its size.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();

                    // If the row begins with '!' then it is a comment
                    // and should be ignored
                    if (row.StartsWith("!"))
                        continue;

                    // If the row is not a comment then it is a row of cells.
                    // Increment the maxHeight variable for each row read.
                    maxHeight++;

                    // Get the length of the current row string
                    // and adjust the maxWidth variable if necessary.
                    maxWidth = row.Length;
                }

                // Resize the current universe and scratchPad
                // to the width and height of the file calculated above.
               
                u_width = maxWidth;
                u_height = maxHeight;
                cleanuni();

                // Reset the file pointer back to the beginning of the file.
                reader.BaseStream.Seek(0, SeekOrigin.Begin);

                int y = 0;
                // Iterate through the file again, this time reading in the cells.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();

                    // If the row begins with '!' then
                    // it is a comment and should be ignored.
                    if (row.StartsWith("!"))
                        continue;
                    // If the row is not a comment then 
                    // it is a row of cells and needs to be iterated through.
                    for (int xPos = 0; xPos < row.Length; xPos++)
                    {
                        // If row[xPos] is a 'O' (capital O) then
                        // set the corresponding cell in the universe to alive.
                        if (row[xPos] == 'O')
                            universe[xPos, y] = true;
                        // If row[xPos] is a '.' (period) then
                        // set the corresponding cell in the universe to dead.
                        if (row[xPos] == '.')
                            universe[xPos, y] = false;
                    }

                    y++;
                }

                // Close the file.
                reader.Close();
                graphicsPanel1.Invalidate();
                
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All files|*.*|Cells|*.cells* ";
            dlg.FilterIndex = 2;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamReader reader = new StreamReader(dlg.FileName);

                // Create a couple variables to calculate the width and height
                // of the data in the file.
                int maxWidth = 0;
                int maxHeight = 0;

                // Iterate through the file once to get its size.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();

                    // If the row begins with '!' then it is a comment
                    // and should be ignored
                    if (row.StartsWith("!"))
                        continue;

                    // If the row is not a comment then it is a row of cells.
                    // Increment the maxHeight variable for each row read.
                    maxHeight++;

                    // Get the length of the current row string
                    // and adjust the maxWidth variable if necessary.
                    maxWidth = row.Length;
                }

                // Resize the current universe and scratchPad
                // to the width and height of the file calculated above.
                u_width = maxWidth;
                u_height = maxHeight;
                cleanuni();
                // Reset the file pointer back to the beginning of the file.
                reader.BaseStream.Seek(0, SeekOrigin.Begin);

                int y = 0;
                // Iterate through the file again, this time reading in the cells.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();

                    // If the row begins with '!' then
                    // it is a comment and should be ignored.
                    if (row.StartsWith("!"))
                        continue;
                    // If the row is not a comment then 
                    // it is a row of cells and needs to be iterated through.
                    for (int xPos = 0; xPos < row.Length; xPos++)
                    {
                        // If row[xPos] is a 'O' (capital O) then
                        // set the corresponding cell in the universe to alive.
                        if (row[xPos] == 'O')
                            universe[xPos, y] = true;
                        // If row[xPos] is a '.' (period) then
                        // set the corresponding cell in the universe to dead.
                        if (row[xPos] == '.')
                            universe[xPos, y] = false;
                    }

                    y++;
                }

                // Close the file.
                reader.Close();
                graphicsPanel1.Invalidate();
            }
        }

        private void hideLablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            generation_lable.Visible = false;
            cells_lable.Visible = false;
            univers_label.Visible = false;
            boundery_lable.Visible = false;
        }

        private void showLablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            generation_lable.Visible = true;
            cells_lable.Visible = true;
            univers_label.Visible = true;
            boundery_lable.Visible = true;
        }
    }
}
