
namespace SortingVisualizer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.btnMerge = new RJCodeAdvance.RJControls.RJButton();
            this.btnSelect = new RJCodeAdvance.RJControls.RJButton();
            this.btnInsert = new RJCodeAdvance.RJControls.RJButton();
            this.btnBubble = new RJCodeAdvance.RJControls.RJButton();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChild = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.panelBotones.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(102)))));
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.rjButton1);
            this.panelBotones.Controls.Add(this.labelStatus);
            this.panelBotones.Controls.Add(this.btnMerge);
            this.panelBotones.Controls.Add(this.btnSelect);
            this.panelBotones.Controls.Add(this.btnInsert);
            this.panelBotones.Controls.Add(this.btnBubble);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones.Location = new System.Drawing.Point(0, 40);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(200, 410);
            this.panelBotones.TabIndex = 0;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(11, 387);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(35, 13);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "label2";
            this.labelStatus.Visible = false;
            // 
            // btnMerge
            // 
            this.btnMerge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(102)))));
            this.btnMerge.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(102)))));
            this.btnMerge.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(156)))), ((int)(((byte)(158)))));
            this.btnMerge.BorderRadius = 0;
            this.btnMerge.BorderSize = 1;
            this.btnMerge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMerge.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMerge.FlatAppearance.BorderSize = 0;
            this.btnMerge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMerge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerge.ForeColor = System.Drawing.Color.White;
            this.btnMerge.Location = new System.Drawing.Point(0, 150);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(198, 50);
            this.btnMerge.TabIndex = 3;
            this.btnMerge.Text = "Merge";
            this.btnMerge.TextColor = System.Drawing.Color.White;
            this.btnMerge.UseVisualStyleBackColor = false;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(102)))));
            this.btnSelect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(102)))));
            this.btnSelect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(156)))), ((int)(((byte)(158)))));
            this.btnSelect.BorderRadius = 0;
            this.btnSelect.BorderSize = 1;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(0, 100);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(198, 50);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.TextColor = System.Drawing.Color.White;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(102)))));
            this.btnInsert.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(102)))));
            this.btnInsert.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(156)))), ((int)(((byte)(158)))));
            this.btnInsert.BorderRadius = 0;
            this.btnInsert.BorderSize = 1;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(0, 50);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(198, 50);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnBubble
            // 
            this.btnBubble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(102)))));
            this.btnBubble.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(102)))));
            this.btnBubble.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(156)))), ((int)(((byte)(158)))));
            this.btnBubble.BorderRadius = 0;
            this.btnBubble.BorderSize = 1;
            this.btnBubble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBubble.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBubble.FlatAppearance.BorderSize = 0;
            this.btnBubble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBubble.ForeColor = System.Drawing.Color.White;
            this.btnBubble.Location = new System.Drawing.Point(0, 0);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(198, 50);
            this.btnBubble.TabIndex = 0;
            this.btnBubble.Text = "Bubble";
            this.btnBubble.TextColor = System.Drawing.Color.White;
            this.btnBubble.UseVisualStyleBackColor = false;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(156)))), ((int)(((byte)(158)))));
            this.panelSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSuperior.Controls.Add(this.iconPictureBox2);
            this.panelSuperior.Controls.Add(this.iconPictureBox1);
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(800, 40);
            this.panelSuperior.TabIndex = 1;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown_1);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(156)))), ((int)(((byte)(158)))));
            this.iconPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 29;
            this.iconPictureBox2.Location = new System.Drawing.Point(727, 5);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 29);
            this.iconPictureBox2.TabIndex = 2;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(156)))), ((int)(((byte)(158)))));
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 29;
            this.iconPictureBox1.Location = new System.Drawing.Point(765, 5);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 29);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visualizador de Ordenamiento";
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(94)))), ((int)(((byte)(97)))));
            this.panelChild.Controls.Add(this.chart1);
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(200, 40);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(600, 410);
            this.panelChild.TabIndex = 2;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineWidth = 0;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Honeydew;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.LabelForeColor = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(600, 410);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(102)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(102)))));
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(156)))), ((int)(((byte)(158)))));
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.LawnGreen;
            this.rjButton1.Location = new System.Drawing.Point(0, 200);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(198, 50);
            this.rjButton1.TabIndex = 5;
            this.rjButton1.Text = "Reset Values";
            this.rjButton1.TextColor = System.Drawing.Color.LawnGreen;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelChild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private RJCodeAdvance.RJControls.RJButton btnMerge;
        private RJCodeAdvance.RJControls.RJButton btnSelect;
        private RJCodeAdvance.RJControls.RJButton btnInsert;
        private RJCodeAdvance.RJControls.RJButton btnBubble;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label labelStatus;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
    }
}

