using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch20_P2_DriveInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***** Fun with DriveInfo *****\n");
            //// Get info regarding all drives.
            //DriveInfo[] myDrives = DriveInfo.GetDrives();
            //// Now print drive stats.
            //foreach (DriveInfo d in myDrives)
            //{
            //    Console.WriteLine("Name: {0}", d.Name);
            //    Console.WriteLine("Type: {0}", d.DriveType);
            //    // Check to see whether the drive is mounted.
            //    if (d.IsReady)
            //    {
            //        Console.WriteLine("Free space: {0}", d.TotalFreeSpace);
            //        Console.WriteLine("Format: {0}", d.DriveFormat);
            //        Console.WriteLine("Label: {0}", d.VolumeLabel);
            //    }
            //    Console.WriteLine();
            //}

            //// Make a new file on the C drive.
            //FileInfo f = new FileInfo(@"C:\Test.dat");
            //FileStream fs = f.Create();
            //// Use the FileStream object...
            //// Close down file stream.
            //fs.Close();

            // Defining a using scope for file I/O
            // types is ideal.
            //FileInfo f = new FileInfo(@"C:\Test.dat");
            //using (FileStream fs = f.Create())
            //{
            //    // Use the FileStream object...
            //}

            #region The FileInfo.Open() Method

            FileInfo f2 = new FileInfo(@":\Test2.dat");
            using (FileStream fs2 = f2.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                // use the filestream here
            }

            #endregion


            Console.ReadLine();
        }
    }
}
