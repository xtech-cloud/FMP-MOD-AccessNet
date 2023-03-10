
//*************************************************************************************
//   !!! Generated by the fmp-cli 1.80.0.  DO NOT EDIT!
//*************************************************************************************

using System.Net;
using Grpc.Core;
using System.Threading.Tasks;
using XTC.FMP.MOD.AccessNet.LIB.Proto;

namespace XTC.FMP.MOD.AccessNet.App.Service
{
    /// <summary>
    /// Point基类
    /// </summary>
    public class PointServiceBase : LIB.Proto.Point.PointBase
    {
    

        public override async Task<UuidResponse> Online(PointOnlineRequest _request, ServerCallContext _context)
        {
            try
            {
                return await safeOnline(_request, _context);
            }
            catch (ArgumentRequiredException ex)
            {
                return await Task.Run(() => new UuidResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.BadRequest.GetHashCode(), Message = ex.Message },
                });
            }
            catch (Exception ex)
            {
                return await Task.Run(() => new UuidResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.InternalServerError.GetHashCode(), Message = ex.Message },
                });
            }
        }

        public override async Task<UuidResponse> Offline(PointOfflineRequest _request, ServerCallContext _context)
        {
            try
            {
                return await safeOffline(_request, _context);
            }
            catch (ArgumentRequiredException ex)
            {
                return await Task.Run(() => new UuidResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.BadRequest.GetHashCode(), Message = ex.Message },
                });
            }
            catch (Exception ex)
            {
                return await Task.Run(() => new UuidResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.InternalServerError.GetHashCode(), Message = ex.Message },
                });
            }
        }

        public override async Task<UuidResponse> HeartBeat(PointHeartBeatRequest _request, ServerCallContext _context)
        {
            try
            {
                return await safeHeartBeat(_request, _context);
            }
            catch (ArgumentRequiredException ex)
            {
                return await Task.Run(() => new UuidResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.BadRequest.GetHashCode(), Message = ex.Message },
                });
            }
            catch (Exception ex)
            {
                return await Task.Run(() => new UuidResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.InternalServerError.GetHashCode(), Message = ex.Message },
                });
            }
        }

        public override async Task<PointRetrieveResponse> Retrieve(UuidRequest _request, ServerCallContext _context)
        {
            try
            {
                return await safeRetrieve(_request, _context);
            }
            catch (ArgumentRequiredException ex)
            {
                return await Task.Run(() => new PointRetrieveResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.BadRequest.GetHashCode(), Message = ex.Message },
                });
            }
            catch (Exception ex)
            {
                return await Task.Run(() => new PointRetrieveResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.InternalServerError.GetHashCode(), Message = ex.Message },
                });
            }
        }

        public override async Task<PointListResponse> List(PointListRequest _request, ServerCallContext _context)
        {
            try
            {
                return await safeList(_request, _context);
            }
            catch (ArgumentRequiredException ex)
            {
                return await Task.Run(() => new PointListResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.BadRequest.GetHashCode(), Message = ex.Message },
                });
            }
            catch (Exception ex)
            {
                return await Task.Run(() => new PointListResponse
                {
                    Status = new LIB.Proto.Status() { Code = -HttpStatusCode.InternalServerError.GetHashCode(), Message = ex.Message },
                });
            }
        }



        protected virtual async Task<UuidResponse> safeOnline(PointOnlineRequest _request, ServerCallContext _context)
        {
            return await Task.Run(() => new UuidResponse {
                    Status = new LIB.Proto.Status() { Code = -1, Message = "Not Implemented" },
            });
        }

        protected virtual async Task<UuidResponse> safeOffline(PointOfflineRequest _request, ServerCallContext _context)
        {
            return await Task.Run(() => new UuidResponse {
                    Status = new LIB.Proto.Status() { Code = -1, Message = "Not Implemented" },
            });
        }

        protected virtual async Task<UuidResponse> safeHeartBeat(PointHeartBeatRequest _request, ServerCallContext _context)
        {
            return await Task.Run(() => new UuidResponse {
                    Status = new LIB.Proto.Status() { Code = -1, Message = "Not Implemented" },
            });
        }

        protected virtual async Task<PointRetrieveResponse> safeRetrieve(UuidRequest _request, ServerCallContext _context)
        {
            return await Task.Run(() => new PointRetrieveResponse {
                    Status = new LIB.Proto.Status() { Code = -1, Message = "Not Implemented" },
            });
        }

        protected virtual async Task<PointListResponse> safeList(PointListRequest _request, ServerCallContext _context)
        {
            return await Task.Run(() => new PointListResponse {
                    Status = new LIB.Proto.Status() { Code = -1, Message = "Not Implemented" },
            });
        }

    }
}

