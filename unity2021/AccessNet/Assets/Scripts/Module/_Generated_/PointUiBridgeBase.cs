
//*************************************************************************************
//   !!! Generated by the fmp-cli 1.70.0.  DO NOT EDIT!
//*************************************************************************************

using System;
using System.Threading;
using LibMVCS = XTC.FMP.LIB.MVCS;
using XTC.FMP.MOD.AccessNet.LIB.Bridge;

namespace XTC.FMP.MOD.AccessNet.LIB.Unity
{

    public class PointUiBridgeBase : IPointUiBridge
    {
        public LibMVCS.Logger logger { get; set; }

        public virtual void Alert(string _code, string _message, object _context)
        {
            throw new NotImplementedException();
        }


        public virtual void RefreshOnline(IDTO _dto, object _context)
        {
            throw new NotImplementedException();
        }

        public virtual void RefreshOffline(IDTO _dto, object _context)
        {
            throw new NotImplementedException();
        }

        public virtual void RefreshHeartBeat(IDTO _dto, object _context)
        {
            throw new NotImplementedException();
        }

        public virtual void RefreshRetrieve(IDTO _dto, object _context)
        {
            throw new NotImplementedException();
        }

        public virtual void RefreshList(IDTO _dto, object _context)
        {
            throw new NotImplementedException();
        }

    }
}
