using System.Runtime.InteropServices;

namespace ZlibNet
{
    public static class Zlib
    {
        [DllImport("ZlibC.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static void _uncompress(
            [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] dest,
            ulong destLen,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] src,
            ulong srcLen);

        public static void Uncompress(byte[] dest, ulong destLen, byte[] src, ulong srcLen)
            => _uncompress(dest, destLen, src, srcLen);
    }
}
