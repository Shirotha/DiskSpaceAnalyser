using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DiskSpaceAnalyser
{
    public class FolderInfo
    {

        [DllImport("Shlwapi.dll", CharSet = CharSet.Auto)]
        private static extern Int32 StrFormatByteSize(
            long fileSize,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder buffer,
            int bufferSize);

        public static string SizeString(long size)
        {
            StringBuilder sb = new StringBuilder(20);
            StrFormatByteSize(size, sb, 20);
            return sb.ToString();
        }

        private DirectoryInfo _dir;
        public DirectoryInfo Directory => _dir;

        private FolderInfo _parent;
        public FolderInfo Parent => _parent;

        private List<FolderInfo> _children;
        public List<FolderInfo> Children => _children;

        private long _size;
        public long Size
        {
            get
            {
                if (_size < 0)
                    Load();
                return _size;
            }
        }


        public FolderInfo(DirectoryInfo dir)
        {
            _dir = dir;
            _size = -1;
            _children = new List<FolderInfo>();
            _parent = null;
        }

        public override string ToString()
        {
            if (_size < 0)
                return _dir.ToString();
            else
                return String.Format("{0} ({1})", _dir.ToString(), SizeString(_size));
        }

        public FolderInfo(DirectoryInfo dir, FolderInfo parent) : this(dir)
        {
            _parent = parent;
        }
        
        public IEnumerable<FileInfo> Load()
        {
            _size = 0;
            IEnumerator<FileInfo> files;
            try
            {
                files = _dir.EnumerateFiles().GetEnumerator();
            }
            catch
            {
                files = null;
            }
            if (files != null)
            {
                FileInfo file;
                while (true)
                {
                    try
                    {
                        if (!files.MoveNext())
                            break;
                        file = files.Current;
                    }
                    catch
                    {
                        file = null;
                    }

                    if (file != null)
                    {
                        yield return file;
                        _size += file.Length;
                    }
                }
            }

            IEnumerator<DirectoryInfo> dirs;
            try
            {
                dirs = _dir.EnumerateDirectories().GetEnumerator();
            }
            catch
            {
                dirs = null;
            }
            if (dirs != null)
            {
                DirectoryInfo dir;
                while (true)
                {
                    try
                    {
                        if (!dirs.MoveNext())
                            break;
                        dir = dirs.Current;
                    }
                    catch
                    {
                        dir = null;
                    }

                    if (dir != null)
                    {
                        FolderInfo child = new FolderInfo(dir, this);
                        _children.Add(child);
                        foreach (FileInfo f in child.Load())
                            yield return f;
                        _size += child._size;
                    }
                }
            }

            _children = _children.OrderByDescending(f => f.Size).ToList();
        }

    }
}
