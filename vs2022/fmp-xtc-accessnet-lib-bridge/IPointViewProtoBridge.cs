
//*************************************************************************************
//   !!! Generated by the fmp-cli 1.80.0.  DO NOT EDIT!
//*************************************************************************************

using System.Threading;
using System.Threading.Tasks;
using XTC.FMP.LIB.MVCS;

namespace XTC.FMP.MOD.AccessNet.LIB.Bridge
{
    /// <summary>
    /// Point的视图桥接层（协议部分）
    /// 处理UI的事件
    /// </summary>
    public interface IPointViewProtoBridge : View.Facade.Bridge
    {

        /// <summary>
        /// 处理Online的提交
        /// </summary>
        Task<Error> OnOnlineSubmit(IDTO _dto, object? _context);


        /// <summary>
        /// 处理Offline的提交
        /// </summary>
        Task<Error> OnOfflineSubmit(IDTO _dto, object? _context);


        /// <summary>
        /// 处理HeartBeat的提交
        /// </summary>
        Task<Error> OnHeartBeatSubmit(IDTO _dto, object? _context);


        /// <summary>
        /// 处理Retrieve的提交
        /// </summary>
        Task<Error> OnRetrieveSubmit(IDTO _dto, object? _context);


        /// <summary>
        /// 处理List的提交
        /// </summary>
        Task<Error> OnListSubmit(IDTO _dto, object? _context);


    }
}

