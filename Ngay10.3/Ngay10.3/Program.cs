using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ngay10._3
{
    class Program
    {

        static void Main(string[] args)
        {
            /* var drives = DriveInfo.GetDrives();

             //DriveInfo drive = new DriveInfo("D");
             foreach(var drive in drives)
             {
                 Console.WriteLine($"Drive: {drive.Name}");
                 Console.WriteLine($"Drive type: {drive.DriveType}");
                 Console.WriteLine($"Label: {drive.VolumeLabel}");
                 Console.WriteLine($"Fomat: {drive.DriveFormat}");
                 Console.WriteLine($"Size: {drive.TotalSize}");
                 Console.WriteLine($"Free: {drive.TotalFreeSpace}");
                 Console.WriteLine("--------------------------");
             }*/

            string path = "ConsoleApp2";
            /*Directory.Delete(path);

            if (Directory.Exists(path))
            {
                Console.WriteLine($"{path} - ton tai");
            }
            else
            {
                Console.WriteLine($"{path} - ko ton tai");
            }*/

            var files = Directory.GetFiles(path);
            foreach(var file in files)
            {
                Console.WriteLine(file);
            }

        }
    }
}
