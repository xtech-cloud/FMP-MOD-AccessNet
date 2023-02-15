
using System;
using LibMVCS = XTC.FMP.LIB.MVCS;
using XTC.FMP.MOD.AccessNet.LIB.MVCS;
using XTC.FMP.MOD.AccessNet.LIB.Bridge;

namespace XTC.FMP.MOD.AccessNet.LIB.Unity
{
    public class PointUiBridge : PointUiBridgeBase
    {
        public override void RefreshOnline(IDTO _dto, object _context)
        {
            var dto = _dto as UuidResponseDTO;
            logger.Info(dto.Value.Uuid);
        }
    }
}
