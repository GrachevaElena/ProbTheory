namespace ProbTheory
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDoExperiments = new System.Windows.Forms.Button();
            this.textBoxNumExp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLambda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelNumExperiments = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.DataGridView();
            this.buttonExperiment = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableStat = new System.Windows.Forms.DataGridView();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XCh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E_XCh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_S2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Me = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableStat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = " С.в. η — время обслуживания покупателя в кассе магазина; распределена показатель" +
    "но с параметром λ.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDoExperiments);
            this.panel1.Controls.Add(this.textBoxNumExp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxLambda);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(9, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 464);
            this.panel1.TabIndex = 1;
            // 
            // buttonDoExperiments
            // 
            this.buttonDoExperiments.Location = new System.Drawing.Point(24, 280);
            this.buttonDoExperiments.Name = "buttonDoExperiments";
            this.buttonDoExperiments.Size = new System.Drawing.Size(181, 31);
            this.buttonDoExperiments.TabIndex = 5;
            this.buttonDoExperiments.Text = "Провести эксперименты";
            this.buttonDoExperiments.UseVisualStyleBackColor = true;
            this.buttonDoExperiments.Click += new System.EventHandler(this.buttonDoExperiments_Click);
            // 
            // textBoxNumExp
            // 
            this.textBoxNumExp.Location = new System.Drawing.Point(59, 245);
            this.textBoxNumExp.Name = "textBoxNumExp";
            this.textBoxNumExp.Size = new System.Drawing.Size(115, 20);
            this.textBoxNumExp.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Задать количество экспериментов:";
            // 
            // textBoxLambda
            // 
            this.textBoxLambda.Location = new System.Drawing.Point(58, 168);
            this.textBoxLambda.Name = "textBoxLambda";
            this.textBoxLambda.Size = new System.Drawing.Size(116, 20);
            this.textBoxLambda.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "λ=";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 102);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(263, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(491, 464);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.StatChar_click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonReset);
            this.tabPage1.Controls.Add(this.labelNumExperiments);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.table);
            this.tabPage1.Controls.Add(this.buttonExperiment);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(483, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Моделирование";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(287, 387);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(187, 45);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Сбросить результаты";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelNumExperiments
            // 
            this.labelNumExperiments.AutoSize = true;
            this.labelNumExperiments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumExperiments.Location = new System.Drawing.Point(305, 359);
            this.labelNumExperiments.Name = "labelNumExperiments";
            this.labelNumExperiments.Size = new System.Drawing.Size(16, 17);
            this.labelNumExperiments.TabIndex = 3;
            this.labelNumExperiments.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество проведенных экспериментов: ";
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(13, 13);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(454, 333);
            this.table.TabIndex = 1;
            // 
            // buttonExperiment
            // 
            this.buttonExperiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExperiment.Location = new System.Drawing.Point(93, 387);
            this.buttonExperiment.Name = "buttonExperiment";
            this.buttonExperiment.Size = new System.Drawing.Size(187, 45);
            this.buttonExperiment.TabIndex = 0;
            this.buttonExperiment.Text = "Провести эксперимент";
            this.buttonExperiment.UseVisualStyleBackColor = true;
            this.buttonExperiment.Click += new System.EventHandler(this.buttonExperiment_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableStat);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(483, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статистические характеристики";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableStat
            // 
            this.tableStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableStat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.E,
            this.XCh,
            this.E_XCh,
            this.D,
            this.S2,
            this.D_S2,
            this.Me,
            this.R});
            this.tableStat.Location = new System.Drawing.Point(13, 15);
            this.tableStat.Name = "tableStat";
            this.tableStat.Size = new System.Drawing.Size(458, 67);
            this.tableStat.TabIndex = 1;
            // 
            // E
            // 
            this.E.HeaderText = "E";
            this.E.Name = "E";
            this.E.ReadOnly = true;
            // 
            // XCh
            // 
            this.XCh.HeaderText = "x^";
            this.XCh.Name = "XCh";
            this.XCh.ReadOnly = true;
            // 
            // E_XCh
            // 
            this.E_XCh.HeaderText = "|E-x^|";
            this.E_XCh.Name = "E_XCh";
            this.E_XCh.ReadOnly = true;
            // 
            // D
            // 
            this.D.HeaderText = "D";
            this.D.Name = "D";
            this.D.ReadOnly = true;
            // 
            // S2
            // 
            this.S2.HeaderText = "S^2";
            this.S2.Name = "S2";
            this.S2.ReadOnly = true;
            // 
            // D_S2
            // 
            this.D_S2.HeaderText = "|D-S^2|";
            this.D_S2.Name = "D_S2";
            this.D_S2.ReadOnly = true;
            // 
            // Me
            // 
            this.Me.HeaderText = "Me^";
            this.Me.Name = "Me";
            this.Me.ReadOnly = true;
            // 
            // R
            // 
            this.R.HeaderText = "R^";
            this.R.Name = "R";
            this.R.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 516);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Моделирование случайных величин";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableStat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxLambda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExperiment;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label labelNumExperiments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxNumExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDoExperiments;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView tableStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn E;
        private System.Windows.Forms.DataGridViewTextBoxColumn XCh;
        private System.Windows.Forms.DataGridViewTextBoxColumn E_XCh;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn S2;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_S2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Me;
        private System.Windows.Forms.DataGridViewTextBoxColumn R;
    }
}