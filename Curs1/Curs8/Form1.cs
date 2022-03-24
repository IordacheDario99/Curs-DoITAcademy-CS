using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs8
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/gorun/source/repos/Curs DoITAcademy C#/Curs1/Curs8/Source/Data.txt";
            StreamReader sr = new StreamReader(path);
            //messageDsiplay.Text = sr.ReadLine();
            messageDsiplay.Text = sr.ReadToEnd();
            sr.Close();
        
        }

        private void browseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = browseFileDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                string path = browseFileDialog.FileName;
                StreamReader sr = new StreamReader(path);
                messageDsiplay.Text = sr.ReadToEnd();
                sr.Close();

                
            }
            else
            {
                messageDsiplay.Text = "Nu ati selectat nimic ";

            }

        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            /*while (true)
            {
                i++;
                string path = $"C:/Users/gorun/source/repos/Curs DoITAcademy C#/Curs1/Curs8/Source/Data{i}.txt";
                string text = messageDsiplay.Text;
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(text);
                sw.Close();
            }*/
            string path = "C:/Users/gorun/source/repos/Curs DoITAcademy C#/Curs1/Curs8/Source/Data.txt";
            string text = messageDsiplay.Text;
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(text);
            sw.Close();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                string text = messageDsiplay.Text;
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(text);
                sw.Close();
            }

            
        
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            string source = "C:/Users/gorun/source/repos/Curs DoITAcademy C#/Curs1/Curs8/Source/Data.txt";
            string newDestination = "C:/Users/gorun/source/repos/Curs DoITAcademy C#/Curs1/Curs8/Extras/Data.txt";
            File.Copy(source, newDestination,true);
        }

        private void moveFileButton_Click(object sender, EventArgs e)
        {
            string source = "C:/Users/gorun/source/repos/Curs DoITAcademy C#/Curs1/Curs8/Source/Data.txt";
            string newDestination = "C:/Users/gorun/source/repos/Curs DoITAcademy C#/Curs1/Curs8/Extras/Data2.txt";

            File.Move(source,newDestination);
        }

        private void deleteFilebutton_Click(object sender, EventArgs e)
        {
            string source = "C:/Users/gorun/source/repos/Curs DoITAcademy C#/Curs1/Curs8/Source/Data300.txt";

            File.Delete(source);
        }
    }
}
