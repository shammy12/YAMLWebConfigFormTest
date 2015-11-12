using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddYAMLWebConfigTestForm
{
    public static class MyClass
    {
       public static void RenameEntry(this ZipArchive archive, string oldName, string newName)
        {
            ZipArchiveEntry oldEntry = archive.GetEntry(oldName),
                newEntry = archive.CreateEntry(newName);

            using (Stream oldStream = oldEntry.Open())
            using (Stream newStream = newEntry.Open())
            {
                oldStream.CopyTo(newStream);
            }

            oldEntry.Delete();

           //TestRepoChangeCommit

            /******    ZipArchive archive = ...; open archive in "update" mode
                       string oldName = ...,
                       newName = ...; // names initialized as appropriate

                  archive.RenameEntry(oldName, newName); ******/

        }
    }
}
