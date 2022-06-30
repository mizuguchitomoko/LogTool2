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


namespace LogTool2
{
    public partial class Form1 : Form
    {
        private BindingList<Class1> class1s = new BindingList<Class1>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialogを生成
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //オープンファイルダイアログを表示する
            openFileDialog.FileName = "";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                openFileDialog.Filter = "Text File(*.txt;*.log)|*.txt;*.log"; //拡張子.logと.txt形式のファイルのみ許容する
                var filePath = openFileDialog.FileName;

                string[] lines = System.IO.File.ReadAllLines(filePath);

                class1s.Clear();//前回の表示をクリア

                foreach (string line in lines)//lineは行単体
                {
                    if ((line.IndexOf("< Start Logging >") == -1) && (line.IndexOf("< Stop Logging  >") == -1))
                    {

                        string[] row = line.Split(']');//row変数が各項目ばらばらになったものが入る
                        for (int i = 0; i < row.Length; i++)
                        {
                            Class1 dto = new Class1(
                                row[0],
                                row[1],
                                row[2]
                                );

                            class1s.Add(dto);
                        }
                    }
                }
                dataGridView1.DataSource = class1s;//表示ができる
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
            
    }
}
