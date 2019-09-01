namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.xes = new System.Windows.Forms.TextBox();
            this.yes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_lin = new System.Windows.Forms.Button();
            this.btn_ste = new System.Windows.Forms.Button();
            this.btn_kub = new System.Windows.Forms.Button();
            this.btn_kva = new System.Windows.Forms.Button();
            this.btn_pok = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_gip = new System.Windows.Forms.Button();
            this.btn_exp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.solution = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // xes
            // 
            this.xes.Location = new System.Drawing.Point(31, 85);
            this.xes.Name = "xes";
            this.xes.Size = new System.Drawing.Size(230, 20);
            this.xes.TabIndex = 1;
            this.xes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xes_KeyPress);
            // 
            // yes
            // 
            this.yes.Location = new System.Drawing.Point(31, 111);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(230, 20);
            this.yes.TabIndex = 2;
            this.yes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yes_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_lin
            // 
            this.btn_lin.Location = new System.Drawing.Point(31, 162);
            this.btn_lin.Name = "btn_lin";
            this.btn_lin.Size = new System.Drawing.Size(112, 23);
            this.btn_lin.TabIndex = 3;
            this.btn_lin.Text = "Линейная";
            this.btn_lin.UseVisualStyleBackColor = true;
            this.btn_lin.Click += new System.EventHandler(this.btn_lin_Click);
            // 
            // btn_ste
            // 
            this.btn_ste.Location = new System.Drawing.Point(31, 191);
            this.btn_ste.Name = "btn_ste";
            this.btn_ste.Size = new System.Drawing.Size(112, 23);
            this.btn_ste.TabIndex = 4;
            this.btn_ste.Text = "Степенная";
            this.btn_ste.UseVisualStyleBackColor = true;
            this.btn_ste.Click += new System.EventHandler(this.btn_ste_Click);
            // 
            // btn_kub
            // 
            this.btn_kub.Location = new System.Drawing.Point(31, 220);
            this.btn_kub.Name = "btn_kub";
            this.btn_kub.Size = new System.Drawing.Size(112, 23);
            this.btn_kub.TabIndex = 5;
            this.btn_kub.Text = "Кубическая";
            this.btn_kub.UseVisualStyleBackColor = true;
            this.btn_kub.Click += new System.EventHandler(this.btn_kub_Click);
            // 
            // btn_kva
            // 
            this.btn_kva.Location = new System.Drawing.Point(31, 249);
            this.btn_kva.Name = "btn_kva";
            this.btn_kva.Size = new System.Drawing.Size(112, 23);
            this.btn_kva.TabIndex = 6;
            this.btn_kva.Text = "Квадратичная";
            this.btn_kva.UseVisualStyleBackColor = true;
            this.btn_kva.Click += new System.EventHandler(this.btn_kva_Click);
            // 
            // btn_pok
            // 
            this.btn_pok.Location = new System.Drawing.Point(149, 162);
            this.btn_pok.Name = "btn_pok";
            this.btn_pok.Size = new System.Drawing.Size(112, 23);
            this.btn_pok.TabIndex = 7;
            this.btn_pok.Text = "Показательная";
            this.btn_pok.UseVisualStyleBackColor = true;
            this.btn_pok.Click += new System.EventHandler(this.btn_pok_Click);
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(149, 191);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(112, 23);
            this.btn_log.TabIndex = 8;
            this.btn_log.Text = "Логарифмическая";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // btn_gip
            // 
            this.btn_gip.Location = new System.Drawing.Point(149, 220);
            this.btn_gip.Name = "btn_gip";
            this.btn_gip.Size = new System.Drawing.Size(112, 23);
            this.btn_gip.TabIndex = 9;
            this.btn_gip.Text = "Гиперболическая";
            this.btn_gip.UseVisualStyleBackColor = true;
            this.btn_gip.Click += new System.EventHandler(this.btn_gip_Click);
            // 
            // btn_exp
            // 
            this.btn_exp.Location = new System.Drawing.Point(149, 249);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(112, 23);
            this.btn_exp.TabIndex = 10;
            this.btn_exp.Text = "Экспоненциальная";
            this.btn_exp.UseVisualStyleBackColor = true;
            this.btn_exp.Click += new System.EventHandler(this.btn_exp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите или откорректируйте значения:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Выберите тип функции:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // solution
            // 
            this.solution.BackColor = System.Drawing.Color.Lavender;
            this.solution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.solution.Location = new System.Drawing.Point(31, 310);
            this.solution.Name = "solution";
            this.solution.ReadOnly = true;
            this.solution.Size = new System.Drawing.Size(230, 187);
            this.solution.TabIndex = 11;
            this.solution.TabStop = false;
            this.solution.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(28, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Решение:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(31, 32);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(230, 23);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Открыть";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // graph
            // 
            this.graph.BackColor = System.Drawing.Color.Transparent;
            this.graph.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea1);
            this.graph.Cursor = System.Windows.Forms.Cursors.Cross;
            this.graph.Enabled = false;
            this.graph.Location = new System.Drawing.Point(297, 12);
            this.graph.Name = "graph";
            this.graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            series2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series2.BackSecondaryColor = System.Drawing.Color.Transparent;
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.DarkRed;
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.MarkerBorderColor = System.Drawing.Color.Transparent;
            series2.Name = "Series2";
            this.graph.Series.Add(series1);
            this.graph.Series.Add(series2);
            this.graph.Size = new System.Drawing.Size(482, 389);
            this.graph.TabIndex = 12;
            this.graph.TabStop = false;
            this.graph.Text = "График";
            this.graph.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.solution);
            this.Controls.Add(this.btn_exp);
            this.Controls.Add(this.btn_gip);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.btn_pok);
            this.Controls.Add(this.btn_kva);
            this.Controls.Add(this.btn_kub);
            this.Controls.Add(this.btn_ste);
            this.Controls.Add(this.btn_lin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.xes);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.ForeColor = System.Drawing.Color.Green;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регрессия";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox xes;
        private System.Windows.Forms.TextBox yes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_lin;
        private System.Windows.Forms.Button btn_ste;
        private System.Windows.Forms.Button btn_kub;
        private System.Windows.Forms.Button btn_kva;
        private System.Windows.Forms.Button btn_pok;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_gip;
        private System.Windows.Forms.Button btn_exp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox solution;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
    }
}
