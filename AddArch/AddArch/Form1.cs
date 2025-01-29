using iHistorian_SDK;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AddArch
{
    public partial class Form1 : Form
    {
        //variable to hold the Historian server connection
        public Server sc;
        public string outtext;
        public static string ServerName;
        public static string ArchivePath;


        private string HistorianServerName;

        /*private bool fileOpened = false;
        private string openFileName;

        private static Archives myarchives;
        private static Archive myarchive;*/

        private static string folderName;

        public Form1()
        {
            InitializeComponent();
            //Closing += ExecuteOnClosing;
        }

        /*void ExecuteOnClosing(object sender, CancelEventArgs e)
        {
            try
            {
                if (sc.Connected)
                {
                    sc.Disconnect();
                }
            }
            catch (Exception EX)
            {
                //MessageBox.Show(EX.ToString());
            }
        }*/


        private void Form1_Load(object sender, EventArgs e)
        {
            txtHistorianSRV.Text = System.Environment.MachineName;
            HistorianServerName = txtHistorianSRV.Text;
            ServerName = txtHistorianSRV.Text;

            btnDisconnect.Enabled = false;
            //путь по умолчанию
            foldPath.Text = @"D:\Proficy Historian Data\Archives";
            folderName = @"D:\Proficy Historian Data\Archives";

            outtext = "";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            sc = new Server();

            try
            {
                sc.Connect(HistorianServerName);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
            if (sc.Connected)
            {
                MessageBox.Show("Historian Server Connected");

                labelConn.Text = "Подключено";
                labelConn.ForeColor = Color.Blue;

                //Выставим синий цвет при связи с сервером
                txtHistorianSRV.ForeColor = Color.Blue;

                btnDisconnect.Enabled = true;
                btnConnect.Enabled = false;
                //Вызываем функцию обновления данных
                RefreshDataStores();
            }
            else
            {
                MessageBox.Show("Historian Server Fails to Connect");
                txtHistorianSRV.ForeColor = Color.Red;

                labelConn.Text = "Не удалось";
                labelConn.ForeColor = Color.Red;
            }
        }

        private void RefreshDataStores()
        {
            DataStores MyDataStores = sc.DataStores;
            int getDataStoreCount = MyDataStores.Count;
            textBox1.Text = ("Количество Storage - " + getDataStoreCount + "\r\n");

            IEnumerator enumerator = MyDataStores.Item.GetEnumerator();
            while (enumerator.MoveNext())
            {
                object obj2 = enumerator.Current;
                DataStore mydatastore = (DataStore)obj2;
                cmbDataStores.Items.Add(mydatastore.Name);
                //textBox1.Text += ("Storage - " + mydatastore.Name + "\r\n");

                /*_Archives archives = mydatastore.Archives;
                string text = "ArchiveDefaultPath";
                ArchivePath = archives.get_ArchivingOptions(ref text);
                textBox1.Text += ("ArchivePath - " + ArchivePath + "\r\n");*/

            }
            cmbDataStores.SelectedIndex = 1;
            if (enumerator is IDisposable)
            {
                (enumerator as IDisposable).Dispose();
            }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            sc.Disconnect();

            MessageBox.Show("Historian Server Disconnected");

            labelConn.Text = "Отключено";
            labelConn.ForeColor = Color.Red;//YellowGreen;
            txtHistorianSRV.ForeColor = Color.Red;

            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            outtext = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                foldPath.Text = folderName;

            }
        }

        //Проверка доступности файла.
        public static bool IsFileInUse(string sFile)
        {
            try
            {
                using (new FileStream(sFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                }
            }
            catch (Exception ex)
            {
                return true;
            }
            return false;
        }


        private void GetFilesNames(string dir)
        {
            if (!Directory.Exists(dir))
            {
                MessageBox.Show("Директория не существует - " + dir);
            }
            try
            {
                //получаем массив имен файлов по нужной маске, заданной в textBox2
                string[] array = Directory.GetFiles(dir,textBox2.Text+"*.iha");

                textBox1.Text += ("Количество файлов в директории " + array.Length + " \r\n");
                outtext += (dir + ". Количество файлов в директории " + array.Length + " \r\n");

                int i = 0;
                while (i < array.Length)
                {
                    //Получаем имя файла из массива
                    string text = array[i];
                    
                    if(!IsFileInUse(text))
                    {
                        //outtext += "Добавляем файл - " + text + "\r\n";
                        //textBox1.Text += ("Добавляем файл - " + text + "\r\n");

                        //Начинаем
                        try
                        {
                            RestoreArchive(text);
                        }
                        catch (Exception adding)
                        {
                            MessageBox.Show(adding.Message);
                        }
                    }
                    else
                    {
                        outtext += "Файл - " + text + " уже используется Historian! "+ "\r\n";
                        textBox1.Text += ("Файл - " + text + " уже используется Historian! " + "\r\n");
                    }



                    i++;
                }
                WriteLogToFile(outtext);
                outtext = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RestoreArchive(string openFileName)
        {
            //Если файл не занят проверили на уровне выше

            int num = 0; //FileSize

            string achriv = Path.GetFileNameWithoutExtension(openFileName);
            outtext += ("Добавляем архив \r\n");
            textBox1.Text += ("Добавляем архив \r\n");

            textBox1.Text += ("Имя архива (ArchiveName) - " + achriv + "\r\n");
            outtext += ("Имя архива (ArchiveName) - " + achriv + "\r\n");
            textBox1.Text += ("Имя переданного файла, он же Путь (FileLocation) - " + openFileName + "\r\n");
            outtext += ("Имя переданного файла, он же Путь (FileLocation) - " + openFileName + "\r\n");
            
            //textBox1.Text += ("FileSize - " + num + "\r\n");

            try
                {
                    sc.Archives.Add(ref achriv, ref openFileName, ref num); //, ref .Datastore
                }
                catch (Exception adding)
                {
                    //MessageBox.Show(adding.Message);
                    textBox1.Text += (adding.Message + "\r\n");
                }


        }

        public static string ConvertToUNC(string LocalPath)
        {
            string result;
            if (String.Compare(LocalPath.Substring(0, 2), "\\\\", false) == 0)
            {
                // Просто локальный путь D:\Proficy Historian Data\Archives\DHSSystem_1.iha
                result = LocalPath;
            }
            else
            {
                // Конвертируем для работы по сети в стиле \\DESKTOP-7DTPHE8\D$\Proficy Historian Data\Archives\DHSSystem_1.iha
                result = "\\\\" + ServerName + "\\" + LocalPath.Replace(":", "$");
            }
            return result;
        }

        public void WriteLogToFile(string message)
        {
            try
            {
                string currentdir = Directory.GetCurrentDirectory();
                StreamWriter streamWriter = new StreamWriter(currentdir + "LogFile_" + DateTime.Now.ToString("yyyy-M-d_hh-mm") + ".log", true);
                streamWriter.WriteLine(string.Concat(new object[]
                {
                    /*"[",
                    DateTime.Now,
                    "] ",*/
                    message
                }));
                streamWriter.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
        }

        private void butFinal_Click(object sender, EventArgs e)
        {
            //true если параметр равен null
            if(sc.Connected)
            {
                if (/*!string.IsNullOrEmpty(folderName) || */ !string.IsNullOrEmpty(foldPath.Text))
                {
                    //Имя берем из поля
                    GetFilesNames(foldPath.Text); //folderName
                }
                else
                {
                    MessageBox.Show("Не задан путь!");
                    //outtext += ("Не задан путь!" + " \r\n");
                }
            }
            else
            {
                MessageBox.Show("Сначала подключитесь к серверу!");
                //outtext += ("Сначала подключитесь к серверу!" + " \r\n");
            }

        }
    }
}
