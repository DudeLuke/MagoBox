using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KirbyFDGH
{
    //The string table hashes for FDG 3 are calculated with the 64-bit FNV-1a hash algorithm
    public static class FNV1a
    {
        public static ulong Calculate(byte[] data)
        {
            ulong hash = 0xcbf29ce484222325;

            for (var i = 0; i < data.Length; i++)
            {
                hash = hash ^ data[i];
                hash *= 0x100000001b3;
            }

            return hash;
        }
    }
}
