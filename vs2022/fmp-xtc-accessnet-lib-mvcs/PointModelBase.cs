
//*************************************************************************************
//   !!! Generated by the fmp-cli 1.80.0.  DO NOT EDIT!
//*************************************************************************************

using System.Threading;
using XTC.FMP.LIB.MVCS;
using XTC.FMP.MOD.AccessNet.LIB.Proto;

namespace XTC.FMP.MOD.AccessNet.LIB.MVCS
{
    /// <summary>
    /// Point数据层基类
    /// </summary>
    public class PointModelBase : Model
    {
        /// <summary>
        /// 带uid参数的构造函数
        /// </summary>
        /// <param name="_uid">实例化后的唯一识别码</param>
        /// <param name="_gid">直系的组的ID</param>
        public PointModelBase(string _uid, string _gid) : base(_uid)
        {
            gid_ = _gid;
        }


        /// <summary>
        /// 更新Online的数据
        /// </summary>
        /// <param name="_response">Online的回复</param>
        public virtual void UpdateProtoOnline(UuidResponse _response, object? _context)
        {
            getController()?.UpdateProtoOnline(status_ as PointModel.PointStatus, _response, _context);
        }

        /// <summary>
        /// 更新Offline的数据
        /// </summary>
        /// <param name="_response">Offline的回复</param>
        public virtual void UpdateProtoOffline(UuidResponse _response, object? _context)
        {
            getController()?.UpdateProtoOffline(status_ as PointModel.PointStatus, _response, _context);
        }

        /// <summary>
        /// 更新HeartBeat的数据
        /// </summary>
        /// <param name="_response">HeartBeat的回复</param>
        public virtual void UpdateProtoHeartBeat(UuidResponse _response, object? _context)
        {
            getController()?.UpdateProtoHeartBeat(status_ as PointModel.PointStatus, _response, _context);
        }

        /// <summary>
        /// 更新Retrieve的数据
        /// </summary>
        /// <param name="_response">Retrieve的回复</param>
        public virtual void UpdateProtoRetrieve(PointRetrieveResponse _response, object? _context)
        {
            getController()?.UpdateProtoRetrieve(status_ as PointModel.PointStatus, _response, _context);
        }

        /// <summary>
        /// 更新List的数据
        /// </summary>
        /// <param name="_response">List的回复</param>
        public virtual void UpdateProtoList(PointListResponse _response, object? _context)
        {
            getController()?.UpdateProtoList(status_ as PointModel.PointStatus, _response, _context);
        }


        /// <summary>
        /// 获取直系控制层
        /// </summary>
        /// <returns>控制层</returns>
        protected PointController? getController()
        {
            if(null == controller_)
                controller_ = findController(PointController.NAME + "." + gid_) as PointController;
            return controller_;
        }

        /// <summary>
        /// 直系的MVCS的四个组件的组的ID
        /// </summary>
        protected string gid_ = "";

        /// <summary>
        /// 直系控制层
        /// </summary>
        private PointController? controller_;
    }
}

