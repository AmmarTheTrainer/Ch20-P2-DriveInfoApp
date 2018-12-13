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

            //FileInfo f2 = new FileInfo(@":\Test2.dat");
            //using (FileStream fs2 = f2.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            //{
            //    // use the filestream here
            //}

            #endregion

            #region The FileInfo.OpenRead() and FileInfo.OpenWrite() Methods

            //// Get a FileStream object with read-only permissions.
            //FileInfo f3 = new FileInfo(@"C:\Test3.dat");
            //using (FileStream readOnlyStream = f3.OpenRead())
            //{
            //    // Use the FileStream object...
            //}
            //// Now get a FileStream object with write-only permissions.
            //FileInfo f4 = new FileInfo(@"C:\Test4.dat");
            //using (FileStream writeOnlyStream = f4.OpenWrite())
            //{
            //    // Use the FileStream object...
            //}

            #endregion

            #region The FileInfo.OpenText() Method

            //// Get a StreamReader object.
            ////FileInfo f5 = new FileInfo(@"C:\boot.ini");
            //FileInfo f5 = new FileInfo(@"C:\Users\Public\ghori.txt");
            //using (StreamReader sreader = f5.OpenText())
            //{
            //    Console.WriteLine(sreader.ReadToEnd());
            //    // Use the StreamReader object...
            //}

            #endregion

            #region The FileInfo.CreateText() and FileInfo.AppendText() Methods

            //FileInfo f6 = new FileInfo(@"C:\Test6.txt");
            //using (StreamWriter swriter = f6.CreateText())
            //{
            //    // Use the StreamWriter object...
            //}
            //FileInfo f7 = new FileInfo(@"C:\FinalTest.txt");
            //using (StreamWriter swriterAppend = f7.AppendText())
            //{
            //    // Use the StreamWriter object...
            //}

            #endregion

            #region Working with the File Type

            //// Obtain FileStream object via File.Create().
            //using (FileStream fs = File.Create(@"C:\Test.dat"))
            //{ }
            //// Obtain FileStream object via File.Open().
            //using (FileStream fs2 = File.Open(@"C:\Test2.dat",
            //FileMode.OpenOrCreate,
            //FileAccess.ReadWrite, FileShare.None))
            //{ }
            //// Get a FileStream object with read-only permissions.
            //using (FileStream readOnlyStream = File.OpenRead(@"Test3.dat"))
            //{ }
            //// Get a FileStream object with write-only permissions.
            //using (FileStream writeOnlyStream = File.OpenWrite(@"Test4.dat"))
            //{ }
            //// Get a StreamReader object.
            //using (StreamReader sreader = File.OpenText(@"C:\boot.ini"))
            //{ }
            //// Get some StreamWriters.
            //using (StreamWriter swriter = File.CreateText(@"C:\Test6.txt"))
            //{ }
            //using (StreamWriter swriterAppend = File.AppendText(@"C:\FinalTest.txt"))
            //{ }

            #endregion

            #region Additional File-Centric Members

            Console.WriteLine("***** Simple I/O with the File Type *****\n");
            string[] myTasks = {
                                    "Fix bathroom sink", "Call Dave",
                                    "Call Mom and Dad", "Play Xbox One"
                                };
            // Write out all data to file on C drive.
            File.WriteAllLines(@"tasks.txt", myTasks);
            // Read it all back and print out.
            foreach (string task in File.ReadAllLines(@"tasks.txt"))
            {
                Console.WriteLine("TODO: {0}", task);
            }

            #endregion
            
            Console.ReadLine();
        }
    }
}
