namespace LibreriaConnection.views
{
    partial class ConsultaPrestamoPorFecha
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 54);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 88;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.FechaSelecionada1);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(18, 234);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 89;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.fechaSelecionada2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 42);
            this.label1.TabIndex = 94;
            this.label1.Text = "Consulta Prestamo Por Fecha";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(290, 54);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(572, 311);
            this.dataGridView2.TabIndex = 95;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(912, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 34);
            this.button1.TabIndex = 96;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultaPrestamoPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "ConsultaPrestamoPorFecha";
            this.Text = "ConsultaPrestamoPorFecha";
            this.Load += new System.EventHandler(this.Consulta);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
    }
}