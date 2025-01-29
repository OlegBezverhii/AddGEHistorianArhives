namespace AddArch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelConn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtHistorianSRV = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.foldPath = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtArchiveFileSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDataStores = new System.Windows.Forms.ComboBox();
            this.butFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelConn
            // 
            this.labelConn.AutoSize = true;
            this.labelConn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelConn.Location = new System.Drawing.Point(103, 9);
            this.labelConn.Name = "labelConn";
            this.labelConn.Size = new System.Drawing.Size(61, 13);
            this.labelConn.TabIndex = 19;
            this.labelConn.Text = "Состояние";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Имя сервера";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(261, 26);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(61, 38);
            this.btnConnect.TabIndex = 17;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtHistorianSRV
            // 
            this.txtHistorianSRV.Location = new System.Drawing.Point(15, 26);
            this.txtHistorianSRV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHistorianSRV.Multiline = true;
            this.txtHistorianSRV.Name = "txtHistorianSRV";
            this.txtHistorianSRV.Size = new System.Drawing.Size(227, 38);
            this.txtHistorianSRV.TabIndex = 16;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(328, 26);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 38);
            this.btnDisconnect.TabIndex = 20;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Выберите путь к архивам";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.SelectedPath = "D:\\Proficy Historian Data\\Archives";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Выбрать путь до папки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // foldPath
            // 
            this.foldPath.Location = new System.Drawing.Point(15, 82);
            this.foldPath.Name = "foldPath";
            this.foldPath.Size = new System.Drawing.Size(227, 20);
            this.foldPath.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 210);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(388, 132);
            this.textBox1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Лог программы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Именование файлов (маска)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 26;
            this.textBox2.Text = "DHSSystem";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "MB";
            // 
            // txtArchiveFileSize
            // 
            this.txtArchiveFileSize.Location = new System.Drawing.Point(171, 144);
            this.txtArchiveFileSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArchiveFileSize.Name = "txtArchiveFileSize";
            this.txtArchiveFileSize.Size = new System.Drawing.Size(47, 20);
            this.txtArchiveFileSize.TabIndex = 27;
            this.txtArchiveFileSize.Text = "500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Размер архива";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Data Store Name";
            // 
            // cmbDataStores
            // 
            this.cmbDataStores.FormattingEnabled = true;
            this.cmbDataStores.Location = new System.Drawing.Point(115, 168);
            this.cmbDataStores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDataStores.Name = "cmbDataStores";
            this.cmbDataStores.Size = new System.Drawing.Size(178, 21);
            this.cmbDataStores.TabIndex = 30;
            // 
            // butFinal
            // 
            this.butFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butFinal.Location = new System.Drawing.Point(299, 168);
            this.butFinal.Name = "butFinal";
            this.butFinal.Size = new System.Drawing.Size(104, 23);
            this.butFinal.TabIndex = 32;
            this.butFinal.Text = "Приступить!";
            this.butFinal.UseVisualStyleBackColor = true;
            this.butFinal.Click += new System.EventHandler(this.butFinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 354);
            this.Controls.Add(this.butFinal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbDataStores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtArchiveFileSize);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.foldPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.labelConn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtHistorianSRV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Добавление архивов Historian";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtHistorianSRV;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox foldPath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtArchiveFileSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbDataStores;
        private System.Windows.Forms.Button butFinal;
    }
}

