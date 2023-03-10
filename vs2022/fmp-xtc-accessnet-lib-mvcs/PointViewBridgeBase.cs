
//*************************************************************************************
//   !!! Generated by the fmp-cli 1.80.0.  DO NOT EDIT!
//*************************************************************************************

using System.Threading;
using System.Threading.Tasks;
using XTC.FMP.LIB.MVCS;
using XTC.FMP.MOD.AccessNet.LIB.Bridge;

namespace XTC.FMP.MOD.AccessNet.LIB.MVCS
{
    /// <summary>
    /// Point的视图桥接层基类（协议部分）
    /// 处理UI的事件
    /// </summary>
    public class PointViewBridgeBase : IPointViewBridge
    {

        /// <summary>
        /// 直系服务层
        /// </summary>
        public PointService? service { get; set; }


        /// <summary>
        /// 处理Online的提交
        /// </summary>
        /// <param name="_dto">PointOnlineRequest的数据传输对象</param>
        /// <returns>错误</returns>
        public virtual async Task<Error> OnOnlineSubmit(IDTO _dto, object? _context)
        {
            PointOnlineRequestDTO? dto = _dto as PointOnlineRequestDTO;
            if(null == service)
            {
                return Error.NewNullErr("service is null");
            }
            return await service.CallOnline(dto?.Value, _context);
        }

        /// <summary>
        /// 处理Offline的提交
        /// </summary>
        /// <param name="_dto">PointOfflineRequest的数据传输对象</param>
        /// <returns>错误</returns>
        public virtual async Task<Error> OnOfflineSubmit(IDTO _dto, object? _context)
        {
            PointOfflineRequestDTO? dto = _dto as PointOfflineRequestDTO;
            if(null == service)
            {
                return Error.NewNullErr("service is null");
            }
            return await service.CallOffline(dto?.Value, _context);
        }

        /// <summary>
        /// 处理HeartBeat的提交
        /// </summary>
        /// <param name="_dto">PointHeartBeatRequest的数据传输对象</param>
        /// <returns>错误</returns>
        public virtual async Task<Error> OnHeartBeatSubmit(IDTO _dto, object? _context)
        {
            PointHeartBeatRequestDTO? dto = _dto as PointHeartBeatRequestDTO;
            if(null == service)
            {
                return Error.NewNullErr("service is null");
            }
            return await service.CallHeartBeat(dto?.Value, _context);
        }

        /// <summary>
        /// 处理Retrieve的提交
        /// </summary>
        /// <param name="_dto">UuidRequest的数据传输对象</param>
        /// <returns>错误</returns>
        public virtual async Task<Error> OnRetrieveSubmit(IDTO _dto, object? _context)
        {
            UuidRequestDTO? dto = _dto as UuidRequestDTO;
            if(null == service)
            {
                return Error.NewNullErr("service is null");
            }
            return await service.CallRetrieve(dto?.Value, _context);
        }

        /// <summary>
        /// 处理List的提交
        /// </summary>
        /// <param name="_dto">PointListRequest的数据传输对象</param>
        /// <returns>错误</returns>
        public virtual async Task<Error> OnListSubmit(IDTO _dto, object? _context)
        {
            PointListRequestDTO? dto = _dto as PointListRequestDTO;
            if(null == service)
            {
                return Error.NewNullErr("service is null");
            }
            return await service.CallList(dto?.Value, _context);
        }


    }
}
