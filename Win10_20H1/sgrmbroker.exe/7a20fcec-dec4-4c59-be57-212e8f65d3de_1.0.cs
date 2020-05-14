//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\sgrmbroker.exe
// Interface ID: 7a20fcec-dec4-4c59-be57-212e8f65d3de
// Interface Version: 1.0

namespace rpc_7a20fcec_dec4_4c59_be57_212e8f65d3de_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(sbyte[] p0)
        {
            WriteFixedPrimitiveArray<sbyte>(p0, 128);
        }
        public void Write_2(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_3(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public sbyte[] Read_1()
        {
            return ReadFixedPrimitiveArray<sbyte>(128);
        }
        public sbyte[] Read_2()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_3()
        {
            return ReadConformantArray<sbyte>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_1(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
            m.WriteInt32(Member80);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_1();
            Member80 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public sbyte[] Member0;
        public int Member80;
        public static Struct_0 CreateDefault()
        {
            Struct_0 ret = new Struct_0();
            ret.Member0 = new sbyte[128];
            return ret;
        }
        public Struct_0(sbyte[] Member0, int Member80)
        {
            this.Member0 = Member0;
            this.Member80 = Member80;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("7a20fcec-dec4-4c59-be57-212e8f65d3de", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int s_SgrmCreateSession(string p0, Struct_0 p1, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p2, out NtApiDotNet.Ndr.Marshal.NdrUInt3264 p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.Write_0(p1);
            _Unmarshal_Helper u = SendReceive(0, m);
            p2 = u.ReadContextHandle();
            p3 = u.ReadUInt3264();
            return u.ReadInt32();
        }
        public int s_SgrmEndSession(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int s_GetSessionReport(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out sbyte[] p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(2, m);
            p1 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_2), false);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_GetRuntimeReport(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_0 p1, out sbyte[] p2, out int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_0(p1);
            _Unmarshal_Helper u = SendReceive(3, m);
            p2 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_3), false);
            p3 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_GetSessionCertificate(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out sbyte[] p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(4, m);
            p1 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_2), false);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
    }
    #endregion
}
