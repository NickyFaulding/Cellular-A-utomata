namespace Cellular__A_utomata
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewGrid = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGoLAdvance = new System.Windows.Forms.Button();
            this.btnGoLAuto = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnPink = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnSelectedColour = new System.Windows.Forms.Button();
            this.btnSpeedUpGoL = new System.Windows.Forms.Button();
            this.btnSpeedDownGoL = new System.Windows.Forms.Button();
            this.GameOfLifeTimer = new System.Windows.Forms.Timer(this.components);
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblPresets = new System.Windows.Forms.Label();
            this.groupBoxGoL = new System.Windows.Forms.GroupBox();
            this.groupBoxCA = new System.Windows.Forms.GroupBox();
            this.btnSpeedUpCA = new System.Windows.Forms.Button();
            this.btnCAadvance = new System.Windows.Forms.Button();
            this.btnSpeedDownCA = new System.Windows.Forms.Button();
            this.btnCAauto = new System.Windows.Forms.Button();
            this.CAtimer = new System.Windows.Forms.Timer(this.components);
            this.btnGoL = new System.Windows.Forms.Button();
            this.btnCA = new System.Windows.Forms.Button();
            this.groupBoxColours = new System.Windows.Forms.GroupBox();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.groupBoxGoLOptions = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxGoL.SuspendLayout();
            this.groupBoxCA.SuspendLayout();
            this.groupBoxColours.SuspendLayout();
            this.groupBoxGeneral.SuspendLayout();
            this.groupBoxGoLOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(156, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(750, 750);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnNewGrid
            // 
            this.btnNewGrid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGrid.Location = new System.Drawing.Point(15, 36);
            this.btnNewGrid.Name = "btnNewGrid";
            this.btnNewGrid.Size = new System.Drawing.Size(100, 100);
            this.btnNewGrid.TabIndex = 1;
            this.btnNewGrid.Text = "Create New Grid";
            this.btnNewGrid.UseVisualStyleBackColor = true;
            this.btnNewGrid.Click += new System.EventHandler(this.btnNewGrid_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(121, 36);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 100);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGoLAdvance
            // 
            this.btnGoLAdvance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoLAdvance.Location = new System.Drawing.Point(15, 19);
            this.btnGoLAdvance.Name = "btnGoLAdvance";
            this.btnGoLAdvance.Size = new System.Drawing.Size(100, 100);
            this.btnGoLAdvance.TabIndex = 3;
            this.btnGoLAdvance.Text = "Advance";
            this.btnGoLAdvance.UseVisualStyleBackColor = true;
            this.btnGoLAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // btnGoLAuto
            // 
            this.btnGoLAuto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoLAuto.Location = new System.Drawing.Point(121, 19);
            this.btnGoLAuto.Name = "btnGoLAuto";
            this.btnGoLAuto.Size = new System.Drawing.Size(100, 100);
            this.btnGoLAuto.TabIndex = 4;
            this.btnGoLAuto.Text = "Advance Auto";
            this.btnGoLAuto.UseVisualStyleBackColor = true;
            this.btnGoLAuto.Click += new System.EventHandler(this.btnAutomove_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBlue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlue.Location = new System.Drawing.Point(15, 24);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(100, 100);
            this.btnBlue.TabIndex = 8;
            this.btnBlue.Text = "blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnYellow.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYellow.Location = new System.Drawing.Point(121, 24);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(100, 100);
            this.btnYellow.TabIndex = 7;
            this.btnYellow.Text = "yellow";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnPink
            // 
            this.btnPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPink.Location = new System.Drawing.Point(15, 130);
            this.btnPink.Name = "btnPink";
            this.btnPink.Size = new System.Drawing.Size(100, 100);
            this.btnPink.TabIndex = 6;
            this.btnPink.Text = "pink";
            this.btnPink.UseVisualStyleBackColor = false;
            this.btnPink.Click += new System.EventHandler(this.btnPink_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRed.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRed.Location = new System.Drawing.Point(121, 130);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(100, 100);
            this.btnRed.TabIndex = 5;
            this.btnRed.Text = "red";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnSelectedColour
            // 
            this.btnSelectedColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSelectedColour.Enabled = false;
            this.btnSelectedColour.FlatAppearance.BorderSize = 0;
            this.btnSelectedColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectedColour.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectedColour.Location = new System.Drawing.Point(255, 24);
            this.btnSelectedColour.Name = "btnSelectedColour";
            this.btnSelectedColour.Size = new System.Drawing.Size(206, 206);
            this.btnSelectedColour.TabIndex = 9;
            this.btnSelectedColour.Text = "Selected Colour";
            this.btnSelectedColour.UseVisualStyleBackColor = false;
            // 
            // btnSpeedUpGoL
            // 
            this.btnSpeedUpGoL.Enabled = false;
            this.btnSpeedUpGoL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeedUpGoL.Location = new System.Drawing.Point(121, 125);
            this.btnSpeedUpGoL.Name = "btnSpeedUpGoL";
            this.btnSpeedUpGoL.Size = new System.Drawing.Size(100, 100);
            this.btnSpeedUpGoL.TabIndex = 11;
            this.btnSpeedUpGoL.Text = "Increase Speed";
            this.btnSpeedUpGoL.UseVisualStyleBackColor = true;
            this.btnSpeedUpGoL.Click += new System.EventHandler(this.btnSpeedUp_Click);
            // 
            // btnSpeedDownGoL
            // 
            this.btnSpeedDownGoL.Enabled = false;
            this.btnSpeedDownGoL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeedDownGoL.Location = new System.Drawing.Point(15, 125);
            this.btnSpeedDownGoL.Name = "btnSpeedDownGoL";
            this.btnSpeedDownGoL.Size = new System.Drawing.Size(100, 100);
            this.btnSpeedDownGoL.TabIndex = 10;
            this.btnSpeedDownGoL.Text = "Decrease Speed";
            this.btnSpeedDownGoL.UseVisualStyleBackColor = true;
            this.btnSpeedDownGoL.Click += new System.EventHandler(this.btnSpeedDown_Click);
            // 
            // GameOfLifeTimer
            // 
            this.GameOfLifeTimer.Interval = 1000;
            this.GameOfLifeTimer.Tick += new System.EventHandler(this.btnAdvance_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(12, 709);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(67, 18);
            this.lblSpeed.TabIndex = 12;
            this.lblSpeed.Text = "Speed : ";
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen.Location = new System.Drawing.Point(12, 754);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(97, 18);
            this.lblGen.TabIndex = 13;
            this.lblGen.Text = "Generation : ";
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(9, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(116, 130);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblPresets
            // 
            this.lblPresets.AutoSize = true;
            this.lblPresets.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresets.Location = new System.Drawing.Point(9, 16);
            this.lblPresets.Name = "lblPresets";
            this.lblPresets.Size = new System.Drawing.Size(116, 18);
            this.lblPresets.TabIndex = 15;
            this.lblPresets.Text = "Preset Patterns";
            // 
            // groupBoxGoL
            // 
            this.groupBoxGoL.Controls.Add(this.btnGoLAdvance);
            this.groupBoxGoL.Controls.Add(this.btnGoLAuto);
            this.groupBoxGoL.Controls.Add(this.btnSpeedUpGoL);
            this.groupBoxGoL.Controls.Add(this.btnSpeedDownGoL);
            this.groupBoxGoL.Enabled = false;
            this.groupBoxGoL.Location = new System.Drawing.Point(912, 244);
            this.groupBoxGoL.Name = "groupBoxGoL";
            this.groupBoxGoL.Size = new System.Drawing.Size(233, 232);
            this.groupBoxGoL.TabIndex = 16;
            this.groupBoxGoL.TabStop = false;
            this.groupBoxGoL.Text = "Game of Life";
            // 
            // groupBoxCA
            // 
            this.groupBoxCA.Controls.Add(this.btnSpeedUpCA);
            this.groupBoxCA.Controls.Add(this.btnCAadvance);
            this.groupBoxCA.Controls.Add(this.btnSpeedDownCA);
            this.groupBoxCA.Controls.Add(this.btnCAauto);
            this.groupBoxCA.Enabled = false;
            this.groupBoxCA.Location = new System.Drawing.Point(1152, 244);
            this.groupBoxCA.Name = "groupBoxCA";
            this.groupBoxCA.Size = new System.Drawing.Size(233, 232);
            this.groupBoxCA.TabIndex = 17;
            this.groupBoxCA.TabStop = false;
            this.groupBoxCA.Text = "Cellular Automata";
            // 
            // btnSpeedUpCA
            // 
            this.btnSpeedUpCA.Enabled = false;
            this.btnSpeedUpCA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeedUpCA.Location = new System.Drawing.Point(121, 125);
            this.btnSpeedUpCA.Name = "btnSpeedUpCA";
            this.btnSpeedUpCA.Size = new System.Drawing.Size(100, 100);
            this.btnSpeedUpCA.TabIndex = 13;
            this.btnSpeedUpCA.Text = "Increase Speed";
            this.btnSpeedUpCA.UseVisualStyleBackColor = true;
            // 
            // btnCAadvance
            // 
            this.btnCAadvance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAadvance.Location = new System.Drawing.Point(15, 19);
            this.btnCAadvance.Name = "btnCAadvance";
            this.btnCAadvance.Size = new System.Drawing.Size(100, 100);
            this.btnCAadvance.TabIndex = 3;
            this.btnCAadvance.Text = "Advance";
            this.btnCAadvance.UseVisualStyleBackColor = true;
            this.btnCAadvance.Click += new System.EventHandler(this.btnCAadvance_Click);
            // 
            // btnSpeedDownCA
            // 
            this.btnSpeedDownCA.Enabled = false;
            this.btnSpeedDownCA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeedDownCA.Location = new System.Drawing.Point(15, 125);
            this.btnSpeedDownCA.Name = "btnSpeedDownCA";
            this.btnSpeedDownCA.Size = new System.Drawing.Size(100, 100);
            this.btnSpeedDownCA.TabIndex = 12;
            this.btnSpeedDownCA.Text = "Decrease Speed";
            this.btnSpeedDownCA.UseVisualStyleBackColor = true;
            // 
            // btnCAauto
            // 
            this.btnCAauto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAauto.Location = new System.Drawing.Point(121, 19);
            this.btnCAauto.Name = "btnCAauto";
            this.btnCAauto.Size = new System.Drawing.Size(100, 100);
            this.btnCAauto.TabIndex = 4;
            this.btnCAauto.Text = "Advance Auto";
            this.btnCAauto.UseVisualStyleBackColor = true;
            this.btnCAauto.Click += new System.EventHandler(this.btnCAauto_Click);
            // 
            // CAtimer
            // 
            this.CAtimer.Interval = 1000;
            this.CAtimer.Tick += new System.EventHandler(this.btnCAadvance_Click);
            // 
            // btnGoL
            // 
            this.btnGoL.Enabled = false;
            this.btnGoL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoL.Location = new System.Drawing.Point(255, 36);
            this.btnGoL.Name = "btnGoL";
            this.btnGoL.Size = new System.Drawing.Size(100, 100);
            this.btnGoL.TabIndex = 18;
            this.btnGoL.Text = "Game Of Life";
            this.btnGoL.UseVisualStyleBackColor = true;
            this.btnGoL.Click += new System.EventHandler(this.btnGoL_Click);
            // 
            // btnCA
            // 
            this.btnCA.Enabled = false;
            this.btnCA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCA.Location = new System.Drawing.Point(359, 36);
            this.btnCA.Name = "btnCA";
            this.btnCA.Size = new System.Drawing.Size(100, 100);
            this.btnCA.TabIndex = 19;
            this.btnCA.Text = "Cellular Automata";
            this.btnCA.UseVisualStyleBackColor = true;
            this.btnCA.Click += new System.EventHandler(this.btnCA_Click);
            // 
            // groupBoxColours
            // 
            this.groupBoxColours.Controls.Add(this.btnSelectedColour);
            this.groupBoxColours.Controls.Add(this.btnYellow);
            this.groupBoxColours.Controls.Add(this.btnPink);
            this.groupBoxColours.Controls.Add(this.btnBlue);
            this.groupBoxColours.Controls.Add(this.btnRed);
            this.groupBoxColours.Enabled = false;
            this.groupBoxColours.Location = new System.Drawing.Point(912, 482);
            this.groupBoxColours.Name = "groupBoxColours";
            this.groupBoxColours.Size = new System.Drawing.Size(473, 247);
            this.groupBoxColours.TabIndex = 20;
            this.groupBoxColours.TabStop = false;
            this.groupBoxColours.Text = "Colour Selector";
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Controls.Add(this.btnNewGrid);
            this.groupBoxGeneral.Controls.Add(this.btnExit);
            this.groupBoxGeneral.Controls.Add(this.btnCA);
            this.groupBoxGeneral.Controls.Add(this.btnGoL);
            this.groupBoxGeneral.Location = new System.Drawing.Point(912, 58);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(473, 166);
            this.groupBoxGeneral.TabIndex = 21;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "General Controls";
            // 
            // groupBoxGoLOptions
            // 
            this.groupBoxGoLOptions.Controls.Add(this.listBox1);
            this.groupBoxGoLOptions.Controls.Add(this.lblPresets);
            this.groupBoxGoLOptions.Location = new System.Drawing.Point(3, 58);
            this.groupBoxGoLOptions.Name = "groupBoxGoLOptions";
            this.groupBoxGoLOptions.Size = new System.Drawing.Size(136, 180);
            this.groupBoxGoLOptions.TabIndex = 22;
            this.groupBoxGoLOptions.TabStop = false;
            this.groupBoxGoLOptions.Text = "Game of Life Options";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 246);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cellular Automata Options";
            // 
            // listBox2
            // 
            this.listBox2.Enabled = false;
            this.listBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(9, 75);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(116, 148);
            this.listBox2.TabIndex = 16;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Selected Rule";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 805);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxGoLOptions);
            this.Controls.Add(this.groupBoxGeneral);
            this.Controls.Add(this.groupBoxColours);
            this.Controls.Add(this.groupBoxCA);
            this.Controls.Add(this.groupBoxGoL);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "GoL & CA Simulator";
            this.groupBoxGoL.ResumeLayout(false);
            this.groupBoxCA.ResumeLayout(false);
            this.groupBoxColours.ResumeLayout(false);
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGoLOptions.ResumeLayout(false);
            this.groupBoxGoLOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNewGrid;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGoLAdvance;
        private System.Windows.Forms.Button btnGoLAuto;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnPink;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnSelectedColour;
        private System.Windows.Forms.Button btnSpeedUpGoL;
        private System.Windows.Forms.Button btnSpeedDownGoL;
        private System.Windows.Forms.Timer GameOfLifeTimer;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblPresets;
        private System.Windows.Forms.GroupBox groupBoxGoL;
        private System.Windows.Forms.GroupBox groupBoxCA;
        private System.Windows.Forms.Button btnCAadvance;
        private System.Windows.Forms.Button btnCAauto;
        private System.Windows.Forms.Timer CAtimer;
        private System.Windows.Forms.Button btnGoL;
        private System.Windows.Forms.Button btnCA;
        private System.Windows.Forms.Button btnSpeedUpCA;
        private System.Windows.Forms.Button btnSpeedDownCA;
        private System.Windows.Forms.GroupBox groupBoxColours;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.GroupBox groupBoxGoLOptions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
    }
}

