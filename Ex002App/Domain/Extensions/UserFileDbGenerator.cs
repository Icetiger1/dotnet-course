using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Extensions
{
    public static class FileDbGenerator
    {
        public static void Create(int count, string path, string prefix)
        {
            if (!File.Exists(path))
            {

                for (int i = 0; i < count; i++)
                {
                    File.AppendAllText(path, $"{prefix}_{i + 1}\n");
                }
            }
        }
    }
}
