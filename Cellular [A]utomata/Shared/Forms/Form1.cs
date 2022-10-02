using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cellular__A_utomata
{
    public partial class Form1 : Form
    {
        private const int size = 30;
        private int speed = 1;
        private const int maxSpeed = 10;
        private int genCount = 0;
        Button[,] b = new Button[size, size]; //button array
        static Color cBlue = Color.FromArgb(192, 192, 255);
        static Color cYellow = Color.FromArgb(255, 255, 192);
        static Color cPink = Color.FromArgb(255, 192, 255);
        static Color cRed = Color.FromArgb(255, 192, 192);

        private int[] currentCells;
        private int[] newCells;

        Color selected = cBlue;

        GameOfLife.Rules GameOfLife;
        CellularAutomata.Rules CellularAutomata;


        public Form1()
        {
            InitializeComponent();

            GameOfLife = new GameOfLife.Rules();
            CellularAutomata = new CellularAutomata.Rules();
            SetLables();
            SetListBox();
        }

        public Button CreateButton()
        {
            Button newButton = new Button();

            newButton.Width = 25;
            newButton.Height = 25;
            newButton.Margin = System.Windows.Forms.Padding.Empty;
            newButton.BackColor = Color.White;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.FlatAppearance.BorderSize = 0;
            newButton.Click += ArrBtn_Click;

            return newButton;
        }

        public void DrawButtons()
        {
            flowLayoutPanel1.Controls.Clear();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Button currentButton = CreateButton();
                    flowLayoutPanel1.Controls.Add(currentButton);
                    b[i, j] = currentButton;
                }
            }
        }

        private void ArrBtn_Click(object sender, EventArgs e)
        {
            Button buttonArray = (Button)sender;

            if (buttonArray.BackColor != selected)
            {
                buttonArray.BackColor = selected;
            }
            else if (buttonArray.BackColor == selected)
            {
                buttonArray.BackColor = Color.White;
            }
        }

        public void ResetGrid()
        {
            genCount = 0;
            speed = 1;

            CAEnd();
            GoLEnd();

            DisableAllControls();
            DrawButtons();
            SetLables();

            groupBoxGeneral.Enabled = true;
            groupBoxColours.Enabled = true;
            btnExit.Enabled = true;
            btnGoL.Enabled = true;
            btnCA.Enabled = true;
        }

        public void DisableAllControls()
        {
            btnExit.Enabled = false;
            groupBoxGeneral.Enabled = false;
            groupBoxGoL.Enabled = false;
            groupBoxCA.Enabled = false;
            groupBoxColours.Enabled = false;

            listBox1.Enabled = false;
            listBox2.Enabled = false;
        }

        public void EnableGoLControls()
        {
            groupBoxGoL.Enabled = true;
            listBox1.Enabled = true;

            btnCA.Enabled = false;
            btnGoL.Enabled = false;
        }

        public void EnableCAControls()
        {
            currentCells = new int[size];
            newCells = new int[size];

            groupBoxCA.Enabled = true;

            btnCA.Enabled = false;
            btnGoL.Enabled = false;

            listBox2.Enabled = true;
        }

        private void btnNewGrid_Click(object sender, EventArgs e)
        {
            ResetGrid();
        }

        private void btnGoL_Click(object sender, EventArgs e)
        {
            EnableGoLControls();
        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            EnableCAControls();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnNewGrid.Enabled = false;
            btnGoLAdvance.Enabled = false;
            btnBlue.Enabled = false;
            btnYellow.Enabled = false;
            btnPink.Enabled = false;
            btnRed.Enabled = false;

            flowLayoutPanel1.Controls.Clear();

            Application.Exit();
        }

        public void ConvertGrid()
        {
            int[,] currentGrid = new int[size, size];
            int[,] newGrid = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (b[i, j].BackColor != Color.White)
                    {
                        currentGrid[i, j] = 1;
                    }
                    else
                    {
                        currentGrid[i, j] = 0;
                    }

                    newGrid[i, j] = 0;
                }
            }
            newGrid = GameOfLife.Advance(currentGrid, newGrid);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (newGrid[i, j] == 1)
                    {
                        b[i, j].BackColor = selected;
                    }
                    else
                    {
                        b[i, j].BackColor = Color.White;
                    }
                }
            }
            genCount++;
        }

        public void SetLables()
        {
            lblSpeed.Text = "Speed : " + speed;
            lblGen.Text = "Generation : " + genCount;
        }

        public void SetListBox()
        {
            listBox1.Items.Add("Ten Row");
            listBox1.Items.Add("Exploder");
            listBox1.Items.Add("Tumbler");
            listBox1.Items.Add("Random Grid");

            listBox2.DataSource = CellularAutomata.GetAvaliableRules();
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            ConvertGrid();
            SetLables();

        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            btnSelectedColour.BackColor = cBlue;
            selected = cBlue;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            btnSelectedColour.BackColor = cYellow;
            selected = cYellow;
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            btnSelectedColour.BackColor = cPink;
            selected = cPink;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            btnSelectedColour.BackColor = cRed;
            selected = cRed;
        }

        private void btnAutomove_Click(object sender, EventArgs e)
        {
            if (GameOfLifeTimer.Enabled == false)
            {
                GoLBegin();
            }
            else
            {
                GoLEnd();
            }
        }

        public void GoLBegin()
        {
            btnGoLAuto.Text = "Stop";
            GameOfLifeTimer.Enabled = true;
            btnSpeedUpGoL.Enabled = true;
        }

        public void GoLEnd()
        {
            btnGoLAuto.Text = "Advance Auto";
            GameOfLifeTimer.Enabled = false;
            btnSpeedDownGoL.Enabled = false;
            btnSpeedUpGoL.Enabled = false;

            speed = 1;
        }

        private void btnSpeedUp_Click(object sender, EventArgs e)
        {
            GameOfLifeTimer.Interval = (1000 / (2 * speed));

            btnSpeedDownGoL.Enabled = true;


            if (speed != maxSpeed)
            {
                speed++;
            }

            if (speed == maxSpeed)
            {
                btnSpeedUpGoL.Enabled = false;
            }
        }

        private void btnSpeedDown_Click(object sender, EventArgs e)
        {
            GameOfLifeTimer.Interval = (1000 / (2 * speed));

            btnSpeedUpGoL.Enabled = true;

            speed--;

            if (speed == 1)
            {
                btnSpeedDownGoL.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    {
                        //Ten Row
                        ClearGrid();
                        TenRowPattern();
                        break;
                    }
                case 1:
                    {
                        //Exploder
                        ClearGrid();
                        ExploderPattern();
                        break;
                    }
                case 2:
                    {
                        //Tumbler
                        ClearGrid();
                        TumblerPattern();
                        break;
                    }
                case 3:
                    {
                        //Random Grid
                        ClearGrid();
                        RandomPattern();
                        break;
                    }
            }
        }

        public void ClearGrid()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    b[i, j].BackColor = Color.White;
                }
            }
        }

        public void TenRowPattern()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i == 15) && (j < 20 && j >= 10))
                    {
                        b[i, j].BackColor = selected;
                    }
                }
            }
        }

        public void ExploderPattern()
        {
            b[8, 10].BackColor = selected;

            b[9, 10].BackColor = selected;
            b[9, 11].BackColor = selected;
            b[9, 9].BackColor = selected;

            b[10, 11].BackColor = selected;
            b[10, 9].BackColor = selected;

            b[11, 10].BackColor = selected;
        }

        public void TumblerPattern()
        {
            b[5, 7].BackColor = selected;
            b[6, 7].BackColor = selected;
            b[5, 8].BackColor = selected;
            b[6, 8].BackColor = selected;

            b[7, 8].BackColor = selected;
            b[8, 8].BackColor = selected;
            b[9, 8].BackColor = selected;

            b[10, 7].BackColor = selected;
            b[10, 6].BackColor = selected;
            b[9, 6].BackColor = selected;
            b[8, 6].BackColor = selected;

            b[5, 10].BackColor = selected;
            b[6, 10].BackColor = selected;
            b[5, 11].BackColor = selected;
            b[6, 11].BackColor = selected;

            b[7, 10].BackColor = selected;
            b[8, 10].BackColor = selected;
            b[9, 10].BackColor = selected;

            b[10, 11].BackColor = selected;
            b[10, 12].BackColor = selected;
            b[9, 12].BackColor = selected;
            b[8, 12].BackColor = selected;
        }

        public void RandomPattern()
        {
            int randomNum;
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    randomNum = rand.Next(2);

                    if (randomNum == 1)
                    {
                        b[i, j].BackColor = selected;
                    }
                    else
                    {
                        b[i, j].BackColor = Color.White;
                    }
                }
            }
        }

        public void StartCA()
        {
            if (genCount == 0)
            {
                for (int i = 0; i < size; i++)
                {
                    if (b[0, i].BackColor != Color.White)
                    {
                        currentCells[i] = 1;
                    }
                    else
                    {
                        currentCells[i] = 0;
                    }

                    newCells[i] = 0;
                }
            }

            newCells = CellularAutomata.Advance(currentCells);

            for (int i = 0; i < size; i++)
            {
                if (genCount == 30)
                {
                    CAClearGrid();
                    genCount = 0;
                }

                if (newCells[i] == 1)
                {
                    b[(genCount + 1 + size) % size, i].BackColor = selected;
                }
                else
                {
                    b[(genCount + 1 + size) % size, i].BackColor = Color.White;
                }
            }

            currentCells = newCells;

            genCount++;
        }

        public void CAClearGrid()
        {
            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    b[i, j].BackColor = Color.White;
                }
            }
        }

        public void CAChangeRule()
        {
            CellularAutomata.SetSelectedRule((int)listBox2.SelectedItem);
        }

        private void btnCAadvance_Click(object sender, EventArgs e)
        {
            StartCA();
            SetLables();
        }

        private void btnCAauto_Click(object sender, EventArgs e)
        {
            if (CAtimer.Enabled == false)
            {
                CABegin();
            }
            else
            {
                CAEnd();
            }
        }

        public void CABegin()
        {
            btnCAauto.Text = "Stop";
            CAtimer.Enabled = true;
            btnCAadvance.Enabled = false;
        }

        public void CAEnd()
        {
            btnCAauto.Text = "Advance Auto";
            CAtimer.Enabled = false;
            btnCAadvance.Enabled = true;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CAChangeRule();
        }
    }
}
