//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\sessenv.dll
// Interface ID: b12fd546-c875-4b41-97d8-950487662202
// Interface Version: 1.0



namespace rpc_b12fd546_c875_4b41_97d8_950487662202_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(string p0)
        {
            WriteFixedString(p0, 256);
        }
        public void Write_2(string p0, long p1)
        {
            WriteConformantVaryingString(p0, p1);
        }
        public void Write_3(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_4(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_5(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
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
        public string Read_1()
        {
            return ReadFixedString(256);
        }
        public byte[] Read_2()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_3()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_4()
        {
            return ReadConformantArray<byte>();
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
            m.Write_1(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member200, "Member200"));
            m.Write_1(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member400, "Member400"));
            m.Write_1(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member600, "Member600"));
            m.Write_1(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member800, "Member800"));
            m.Write_1(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(MemberA00, "MemberA00"));
            m.WriteInt32(MemberC00);
            m.WriteInt32(MemberC04);
            m.WriteInt32(MemberC08);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_1();
            Member200 = u.Read_1();
            Member400 = u.Read_1();
            Member600 = u.Read_1();
            Member800 = u.Read_1();
            MemberA00 = u.Read_1();
            MemberC00 = u.ReadInt32();
            MemberC04 = u.ReadInt32();
            MemberC08 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public string Member0;
        public string Member200;
        public string Member400;
        public string Member600;
        public string Member800;
        public string MemberA00;
        public int MemberC00;
        public int MemberC04;
        public int MemberC08;
        public static Struct_0 CreateDefault()
        {
            Struct_0 ret = new Struct_0();
            ret.Member0 = new string('\0', 256);
            ret.Member200 = new string('\0', 256);
            ret.Member400 = new string('\0', 256);
            ret.Member600 = new string('\0', 256);
            ret.Member800 = new string('\0', 256);
            ret.MemberA00 = new string('\0', 256);
            return ret;
        }
        public Struct_0(string Member0, string Member200, string Member400, string Member600, string Member800, string MemberA00, int MemberC00, int MemberC04, int MemberC08)
        {
            this.Member0 = Member0;
            this.Member200 = Member200;
            this.Member400 = Member400;
            this.Member600 = Member600;
            this.Member800 = Member800;
            this.MemberA00 = MemberA00;
            this.MemberC00 = MemberC00;
            this.MemberC04 = MemberC04;
            this.MemberC08 = MemberC08;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("b12fd546-c875-4b41-97d8-950487662202", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int RpcCreateUserVhdTemplate(string p0, int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(0, m);
            return u.ReadInt32();
        }
        public int RpcGetCreateUserProfileVhd(string p0, string p1, int p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(1, m);
            p3 = u.ReadConformantVaryingString();
            return u.ReadInt32();
        }
        public int RpcDestroyUserProfileVhd(string p0, string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
        public int RpcRepairUserProfileVhd(string p0, string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
        public int RpcReEncryptUserCredential(int p0, byte[] p1, string p2, int p3, byte[] p4, string p5, out string p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_3(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            m.WriteInt32(p3);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"), p3);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"));
            _Unmarshal_Helper u = SendReceive(4, m);
            p6 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int RpcDeleteFileFromVHD(string p0, string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadInt32();
        }
        public int RpcSetupVhdForRdv(string p0, string p1, string p2, string p3, byte[] p4, int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            m.Write_5(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"), p5);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(6, m);
            return u.ReadInt32();
        }
        public int RpcCopyRdvFolderFromVhdToHost(string p0, string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(7, m);
            return u.ReadInt32();
        }
        public int RpcQueryVhdOfflineInformation(string p0, out System.Nullable<Struct_0> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(8, m);
            p1 = u.ReadReferentValue<Struct_0>(new System.Func<Struct_0>(u.Read_0), false);
            return u.ReadInt32();
        }
    }
    #endregion
}
