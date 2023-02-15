
using Grpc.Core;
using System.Threading.Tasks;
using XTC.FMP.MOD.AccessNet.LIB.Proto;

namespace XTC.FMP.MOD.AccessNet.App.Service
{
    public class PointService : PointServiceBase
    {
        private readonly SingletonServices singletonServices_;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <remarks>
        /// 支持多个参数，均为自动注入，注入点位于MyProgram.PreBuild
        /// </remarks>
        /// <param name="_singletonServices">自动注入的单例服务</param>
        public PointService(SingletonServices _singletonServices)
        {
            singletonServices_ = _singletonServices;
        }

        protected override async Task<UuidResponse> safeOnline(PointOnlineRequest _request, ServerCallContext _context)
        {
            ArgumentChecker.CheckRequiredObject(_request.Point, "Point");
            ArgumentChecker.CheckRequiredString(_request.Point.SerialNumber, "Point.SerialNumber");

            var dao = singletonServices_.getPointDAO();
            var newPoint = dao.NewFromProtoEntity(_request.Point);
            // 使用序列号查找一个接入点
            var point = await dao.FindWithSerialNumberAsync(_request.Point.SerialNumber);
            if (null == point)
            {
                // 新建
                point = newPoint;
                point.Uuid = Guid.NewGuid();
                await dao.CreateAsync(point);
            }
            else
            {
                dao.Clone(newPoint, point);
                await dao.UpdateAsync(point.Uuid?.ToString() ?? "", point);
            }

            return new UuidResponse
            {
                Status = new LIB.Proto.Status { Code = 0, Message = "" },
                Uuid = point.Uuid.ToString(),
            };

        }

        protected override async Task<PointListResponse> safeList(PointListRequest _request, ServerCallContext _context)
        {
            var dao = singletonServices_.getPointDAO();

            var total = await dao.CountAsync();
            var pointS = await dao.ListAsync((int)_request.Offset, (int)_request.Count);

            var response = new PointListResponse
            {
                Status = new LIB.Proto.Status { Code = 0, Message = "" },
                Total = total,
            };

            foreach (var point in pointS)
            {
                response.PointS.Add(dao.NewToProtoEntity(point));
            }
            return response;
        }
    }
}
