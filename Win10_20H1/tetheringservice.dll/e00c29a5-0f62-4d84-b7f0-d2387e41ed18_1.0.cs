//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\tetheringservice.dll
// Interface ID: e00c29a5-0f62-4d84-b7f0-d2387e41ed18
// Interface Version: 1.0



namespace rpc_e00c29a5_0f62_4d84_b7f0_d2387e41ed18_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_1(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
        }
        public void Write_2(Struct_3 p0)
        {
            WriteStruct<Struct_3>(p0);
        }
        public void Write_3(Struct_4 p0)
        {
            WriteStruct<Struct_4>(p0);
        }
        public void Write_4(Struct_5 p0)
        {
            WriteStruct<Struct_5>(p0);
        }
        public void Write_5(Struct_6 p0)
        {
            WriteStruct<Struct_6>(p0);
        }
        public void Write_6(string p0)
        {
            WriteFixedString(p0, 33);
        }
        public void Write_7(string p0)
        {
            WriteFixedString(p0, 65);
        }
        public void Write_8(string p0)
        {
            WriteFixedString(p0, 46);
        }
        public void Write_9(string p0)
        {
            WriteFixedString(p0, 64);
        }
        public void Write_10(sbyte[] p0)
        {
            WriteFixedPrimitiveArray<sbyte>(p0, 6);
        }
        public void Write_11(string p0)
        {
            WriteFixedString(p0, 256);
        }
        public void Write_12(Struct_4[] p0, long p1)
        {
            WriteConformantStructArray<Struct_4>(p0, p1);
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
        public Struct_1 Read_0()
        {
            return ReadStruct<Struct_1>();
        }
        public Struct_2 Read_1()
        {
            return ReadStruct<Struct_2>();
        }
        public Struct_3 Read_2()
        {
            return ReadStruct<Struct_3>();
        }
        public Struct_4 Read_3()
        {
            return ReadStruct<Struct_4>();
        }
        public Struct_5 Read_4()
        {
            return ReadStruct<Struct_5>();
        }
        public Struct_6 Read_5()
        {
            return ReadStruct<Struct_6>();
        }
        public string Read_6()
        {
            return ReadFixedString(33);
        }
        public string Read_7()
        {
            return ReadFixedString(65);
        }
        public string Read_8()
        {
            return ReadFixedString(46);
        }
        public string Read_9()
        {
            return ReadFixedString(64);
        }
        public sbyte[] Read_10()
        {
            return ReadFixedPrimitiveArray<sbyte>(6);
        }
        public string Read_11()
        {
            return ReadFixedString(256);
        }
        public Struct_4[] Read_12()
        {
            return ReadConformantStructArray<Struct_4>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEnum16(Member0);
            m.Write_1(Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEnum16();
            Member4 = u.Read_1();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 2;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0;
        public Struct_2 Member4;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0, Struct_2 Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_2(Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_2();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 2;
        }
        public Struct_3 Member0;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(Struct_3 Member0)
        {
            this.Member0 = Member0;
        }
    }
    public struct Struct_3 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_6(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
            m.Write_7(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member42, "Member42"));
            m.WriteEnum16(MemberC4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_6();
            Member42 = u.Read_7();
            MemberC4 = u.ReadEnum16();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 2;
        }
        public string Member0;
        public string Member42;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 MemberC4;
        public static Struct_3 CreateDefault()
        {
            Struct_3 ret = new Struct_3();
            ret.Member0 = new string('\0', 33);
            ret.Member42 = new string('\0', 65);
            return ret;
        }
        public Struct_3(string Member0, string Member42, NtApiDotNet.Ndr.Marshal.NdrEnum16 MemberC4)
        {
            this.Member0 = Member0;
            this.Member42 = Member42;
            this.MemberC4 = MemberC4;
        }
    }
    public struct Struct_4 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_4(Member0);
            m.Write_8(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member6, "Member6"));
            m.Write_9(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member62, "Member62"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_4();
            Member6 = u.Read_8();
            Member62 = u.Read_9();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 2;
        }
        public Struct_5 Member0;
        public string Member6;
        public string Member62;
        public static Struct_4 CreateDefault()
        {
            Struct_4 ret = new Struct_4();
            ret.Member6 = new string('\0', 46);
            ret.Member62 = new string('\0', 64);
            return ret;
        }
        public Struct_4(Struct_5 Member0, string Member6, string Member62)
        {
            this.Member0 = Member0;
            this.Member6 = Member6;
            this.Member62 = Member62;
        }
    }
    public struct Struct_5 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_10(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_10();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        public sbyte[] Member0;
        public static Struct_5 CreateDefault()
        {
            Struct_5 ret = new Struct_5();
            ret.Member0 = new sbyte[6];
            return ret;
        }
        public Struct_5(sbyte[] Member0)
        {
            this.Member0 = Member0;
        }
    }
    public struct Struct_6 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.Write_11(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member8, "Member8"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.Read_11();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public string Member8;
        public static Struct_6 CreateDefault()
        {
            Struct_6 ret = new Struct_6();
            ret.Member8 = new string('\0', 256);
            return ret;
        }
        public Struct_6(int Member0, int Member4, string Member8)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("e00c29a5-0f62-4d84-b7f0-d2387e41ed18", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int TetheringSvcGetSharingState(System.Nullable<System.Guid> p0, out NtApiDotNet.Ndr.Marshal.NdrEnum16 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            _Unmarshal_Helper u = SendReceive(0, m);
            p1 = u.ReadEnum16();
            return u.ReadInt32();
        }
        public int TetheringSvcGetDefaultInterface(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, out System.Guid p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            m.WriteEnum16(p1);
            _Unmarshal_Helper u = SendReceive(1, m);
            p2 = u.ReadGuid();
            return u.ReadInt32();
        }
        public int TetheringSvcStartSharing(System.Nullable<System.Guid> p0, System.Nullable<System.Guid> p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
        public int TetheringSvcStopSharing(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
        public int TetheringSvcGetLastApiError()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(4, m);
            return u.ReadInt32();
        }
        public int TetheringSvcGetConfiguration(System.Nullable<System.Guid> p0, ref System.Nullable<Struct_1> p1, ref System.Nullable<Struct_1> p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p1, new System.Action<Struct_1>(m.Write_0));
            m.WriteReferent(p2, new System.Action<Struct_1>(m.Write_0));
            _Unmarshal_Helper u = SendReceive(5, m);
            p1 = u.ReadReferentValue<Struct_1>(new System.Func<Struct_1>(u.Read_0), false);
            p2 = u.ReadReferentValue<Struct_1>(new System.Func<Struct_1>(u.Read_0), false);
            return u.ReadInt32();
        }
        public int TetheringSvcSetConfiguration(System.Nullable<System.Guid> p0, System.Nullable<Struct_1> p1, System.Nullable<Struct_1> p2, int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p1, new System.Action<Struct_1>(m.Write_0));
            m.WriteReferent(p2, new System.Action<Struct_1>(m.Write_0));
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(6, m);
            return u.ReadInt32();
        }
        public int TetheringSvcGetPeerList(System.Nullable<System.Guid> p0, out int p1, out Struct_4[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            _Unmarshal_Helper u = SendReceive(7, m);
            p1 = u.ReadInt32();
            p2 = u.ReadReferent<Struct_4[]>(new System.Func<Struct_4[]>(u.Read_12), false);
            return u.ReadInt32();
        }
        public int TetheringSvcGetSharedInterfaceIndices(out int p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(8, m);
            p0 = u.ReadInt32();
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int TetheringSvcGetMaxClientCount(System.Nullable<System.Guid> p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            _Unmarshal_Helper u = SendReceive(9, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int TetheringSvcAuthorize(System.Nullable<System.Guid> p0, Struct_6 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<System.Guid>(m.WriteGuid));
            m.Write_5(p1);
            _Unmarshal_Helper u = SendReceive(10, m);
            return u.ReadInt32();
        }
        public int TetheringSvcGetErrorString(out string p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(11, m);
            p0 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int TetheringSvcRpcSetPreferredInterface(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, System.Guid p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(12, m);
            return u.ReadInt32();
        }
        public int TetheringSvcRpcGetPreferredInterface(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, out System.Guid p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            _Unmarshal_Helper u = SendReceive(13, m);
            p1 = u.ReadGuid();
            return u.ReadInt32();
        }
        public int TetheringSvcGetIsPeerlessTimeoutEnabled(out int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(14, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int TetheringSvcSetIsPeerlessTimeoutEnabled(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(15, m);
            return u.ReadInt32();
        }
    }
    #endregion
}
