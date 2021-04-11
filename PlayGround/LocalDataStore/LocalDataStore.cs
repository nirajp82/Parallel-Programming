using System;
using System.Threading;

namespace ParallelProgramming
{
    public class LocalDataStore
    {
        static LocalDataStoreSlot _userRoles = Thread.GetNamedDataSlot("UserRole");

        public static string UseRoles
        {
            get
            {
                object data = Thread.GetData(_userRoles);
                return data == null ? "" : (string)data; // null == uninitialized
            }
            set
            {
                Thread.SetData(_userRoles, ((string)Thread.GetData(_userRoles)) + ", " + value);
            }
        }
    }
}