using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AddYAMLWebConfigTestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string fileName = textBox1.Text + ".zip";
            string path = @"C:\GlanceData\" + fileName;

            string zipPath = path;
            string extractPath = @"C:\TestCreateZip";
            
            try { ZipFile.ExtractToDirectory(zipPath, extractPath); }
            catch (SystemException ex) { MessageBox.Show(ex.ToString()); }


            // The extracted folder will be the value in textBox1.Text

            // Test copying a file in from another destination

          



        }

        private void DeleteFile_Click(object sender, EventArgs e)
        {

            File.Delete(@"C:\TestDelete\web.config");

        }

        private void TestCopy_Click(object sender, EventArgs e)
        {
            string oldPathAndName = @"C:\Glance_3_0_0_31\wwwroot\Web.myglancenet.config";
            string newPathAndName = @"C:\TestDelete\web.config";

            System.IO.File.Copy(oldPathAndName, newPathAndName);

        }

        private void ZipFiles_Click(object sender, EventArgs e)
        {



           // ZipFile.CreateFromDirectory()
        }

        private void AddtoZip_Click(object sender, EventArgs e)
        {
            string zipPath = @"c:\TestCreateZip\Glance_3_2_0_3.zip";
            string extractPath = @"c:\TestCreateZip\extract";
            string newFile = @"c:\TestCreateZip\newfile.txt";
            string newFile2 = @"c:\TestCreateZip\newfile2.txt";

            using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Update))
            {
                //archive.GetEntry(@"Glance_3_2_0_3/wwwroot/Web.config").Delete();
                //archive.GetEntry("NewEntry.txt").Delete();
                archive.CreateEntryFromFile(newFile, "NewEntry2.txt");
                archive.CreateEntryFromFile(newFile2, "NewEntry3.txt");
                archive.ExtractToDirectory(extractPath);
            } 
        }

        private void DeleteDir_Click(object sender, EventArgs e)
        {
            Directory.Delete(@"c:\TestCreateZip\extract", true);
        }

        private void DeleteFromZip_Click(object sender, EventArgs e)
        {

          //  string oldfilename = @"C:\TestCreateZip\extract\newfile.txt";
          //  string newfilename = @"C:\TestCreateZip\extract\newfilerename.txt";

            // We don't use the full file path below because it is relative to the ZipArchive.

            string oldfilename = "TestZip/newfile.txt";
            string newfilename = "TestZip/newfilerename.txt";


            string zipPath = @"c:\TestCreateZip\TestZip.zip";
            string extractPath = @"c:\TestCreateZip\extract";
            string newFile = @"c:\TestCreateZip\Web.myglancenet.config";
         //   string newFile2 = @"c:\TestCreateZip\newfile2.txt";

            using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Update))
            {
                archive.GetEntry(@"TestZip/Web.config").Delete();
                
                archive.CreateEntryFromFile(newFile, "TestZip/Web.config");

                // archive.GetEntry(@"Glance_3_2_0_3/wwwroot/Web.config").Delete();
                //archive.GetEntry("NewEntry.txt").Delete();

                //Below would be used to rename the web.config i.e. from web.myglancenet.config to web.config after deleting the current web.config file in ther. 
                archive.RenameEntry(oldfilename, newfilename);
                archive.ExtractToDirectory(extractPath);
               
                // File.Move(oldfilename, newfilename);
                // rename file:   System.IO.File.Move("oldfilename", "newfilename");

            } 


        }

       

        
      

    }
}
