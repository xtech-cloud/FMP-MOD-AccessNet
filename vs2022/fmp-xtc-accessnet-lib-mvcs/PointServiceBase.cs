
//*************************************************************************************
//   !!! Generated by the fmp-cli 1.80.0.  DO NOT EDIT!
//*************************************************************************************

using System.Threading;
using System.Threading.Tasks;
using Grpc.Net.Client;
using XTC.FMP.LIB.MVCS;
using XTC.FMP.MOD.AccessNet.LIB.Proto;

namespace XTC.FMP.MOD.AccessNet.LIB.MVCS
{
    /// <summary>
    /// Point服务层基类
    /// </summary>
    public class PointServiceBase : Service
    {
        public PointServiceMock mock { get; set; } = new PointServiceMock();
    
        /// <summary>
        /// 带uid参数的构造函数
        /// </summary>
        /// <param name="_uid">实例化后的唯一识别码</param>
        /// <param name="_gid">直系的组的ID</param>
        public PointServiceBase(string _uid, string _gid) : base(_uid)
        {
            gid_ = _gid;
        }

        /// <summary>
        /// 注入GRPC通道
        /// </summary>
        /// <param name="_channel">GRPC通道</param>
        public void InjectGrpcChannel(GrpcChannel? _channel)
        {
            grpcChannel_ = _channel;
        }


        /// <summary>
        /// 调用Online
        /// </summary>
        /// <param name="_request">Online的请求</param>
        /// <returns>错误</returns>
        public virtual async Task<Error> CallOnline(PointOnlineRequest? _request, object? _context)
        {
            getLogger()?.Trace("Call Online ...");
            if (null == _request)
            {
                return Error.NewNullErr("parameter:_request is null");
            }

            UuidResponse? response = null;
            if (null != mock.CallOnlineDelegate)
            {
                getLogger()?.Trace("use mock ...");
                response = await mock.CallOnlineDelegate(_request);
            }
            else
            {
                var client = getGrpcClient();
                if (null == client)
                {
                    return await Task.FromResult(Error.NewNullErr("client is null"));
                }
                response = await client.OnlineAsync(_request);
            }

            getModel()?.UpdateProtoOnline(response, _context);
            return Error.OK;
        }

        /// <summary>
        /// 调用Offline
        /// </summary>
        /// <param name="_request">Offline的请求</param>
        /// <returns>错误</returns>
        public virtual async Task<Error> CallOffline(PointOfflineRequest? _request, object? _context)
        {
            getLogger()?.Trace("Call Offline ...");
            if (null == _request)
            {
                return Error.NewNullErr("parameter:_request is null");
            }

            UuidResponse? response = null;
            if (null != mock.CallOfflineDelegate)
            {
                getLogger()?.Trace("use mock ...");
                response = await mock.CallOfflineDelegate(_request);
            }
            else
            {
                var client = getGrpcClient();
                if (null == client)
                {
                    return await Task.FromResult(Error.NewNullErr("client is null"));
                }
                response = await client.OfflineAsync(_request);
            }

            getModel()?.UpdateProtoOffline(response, _context);
            return Error.OK;
        }

        /// <summary>
        /// 调用HeartBeat
        /// </summary>
        /// <param name="_request">HeartBeat的请求</param>
        /// <returns>错误</returns>
        public virtual async Task<Error> CallHeartBeat(PointHeartBeatRequest? _request, object? _context)
        {
            getLogger()?.Trace("Call HeartBeat ...");
            if (null == _request)
            {
                return Error.NewNullErr("parameter:_request is null");
            }

            UuidResponse? response = null;
            if (null != mock.CallHeartBeatDelegate)
            {
                getLogger()?.Trace("use mock ...");
                response = await mock.CallHeartBeatDelegate(_request);
            }
            else
            {
                var client = getGrpcClient();
                if (null == client)
                {
                    return await Task.FromResult(Error.NewNullErr("client is null"));
                }
                response = await client.HeartBeatAsync(_request);
            }

            getModel()?.UpdateProtoHeartBeat(response, _context);
            return Error.OK;
        }

        /// <summary>
        /// 调用Retrieve
        /// </summary>
        /// <param name="_request">Retrieve的请求</param>
        /// <returns>错误</returns>
        public virtual async Task<Error> CallRetrieve(UuidRequest? _request, object? _context)
        {
            getLogger()?.Trace("Call Retrieve ...");
            if (null == _request)
            {
                return Error.NewNullErr("parameter:_request is null");
            }

            PointRetrieveResponse? response = null;
            if (null != mock.CallRetrieveDelegate)
            {
                getLogger()?.Trace("use mock ...");
                response = await mock.CallRetrieveDelegate(_request);
            }
            else
            {
                var client = getGrpcClient();
                if (null == client)
                {
                    return await Task.FromResult(Error.NewNullErr("client is null"));
                }
                response = await client.RetrieveAsync(_request);
            }

            getModel()?.UpdateProtoRetrieve(response, _context);
            return Error.OK;
        }

        /// <summary>
        /// 调用List
        /// </summary>
        /// <param name="_request">List的请求</param>
        /// <returns>错误</returns>
        public virtual async Task<Error> CallList(PointListRequest? _request, object? _context)
        {
            getLogger()?.Trace("Call List ...");
            if (null == _request)
            {
                return Error.NewNullErr("parameter:_request is null");
            }

            PointListResponse? response = null;
            if (null != mock.CallListDelegate)
            {
                getLogger()?.Trace("use mock ...");
                response = await mock.CallListDelegate(_request);
            }
            else
            {
                var client = getGrpcClient();
                if (null == client)
                {
                    return await Task.FromResult(Error.NewNullErr("client is null"));
                }
                response = await client.ListAsync(_request);
            }

            getModel()?.UpdateProtoList(response, _context);
            return Error.OK;
        }


        /// <summary>
        /// 获取直系数据层
        /// </summary>
        /// <returns>数据层</returns>
        protected PointModel? getModel()
        {
            if(null == model_)
                model_ = findModel(PointModel.NAME + "." + gid_) as PointModel;
            return model_;
        }

        /// <summary>
        /// 获取GRPC客户端
        /// </summary>
        /// <returns>GRPC客户端</returns>
        protected Point.PointClient? getGrpcClient()
        {
            if (null == grpcChannel_)
                return null;

            if(null == clientPoint_)
            {
                clientPoint_ = new Point.PointClient(grpcChannel_);
            }
            return clientPoint_;
        }

        /// <summary>
        /// 直系的MVCS的四个组件的组的ID
        /// </summary>
        protected string gid_ = "";

        /// <summary>
        /// GRPC客户端
        /// </summary>
        protected Point.PointClient? clientPoint_;

        /// <summary>
        /// GRPC通道
        /// </summary>
        protected GrpcChannel? grpcChannel_;

        /// <summary>
        /// 直系数据层
        /// </summary>
        private PointModel? model_;
    }

}
