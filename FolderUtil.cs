using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ATDBMerger
{
    class FolderUtil
    {
        public static void CreateContainerFolders(String[] foldersToCreate)
        {
            foreach (string folder in foldersToCreate)
            {
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
            }
        }

        public static void DeleteDirectory(string target)
        {
            string[] files = Directory.GetFiles(target);
            string[] dirs = Directory.GetDirectories(target);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target, false);
        }

        public static void MoveAndClean(string target,string destination)
        {
            string[] files = Directory.GetFiles(target);
            string[] dirs = Directory.GetDirectories(target);

            foreach (string file in files)
            {
                File.Copy(file, file.Replace(target,destination));
            }

            foreach (string dir in dirs)
            {
                MoveAndClean(dir, dir.Replace(target, destination));
            }
        }
    }
}
