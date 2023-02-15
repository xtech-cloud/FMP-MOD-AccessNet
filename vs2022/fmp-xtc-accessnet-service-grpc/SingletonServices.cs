
using Grpc.Core;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Threading.Tasks;
using XTC.FMP.MOD.AccessNet.LIB.Proto;

namespace XTC.FMP.MOD.AccessNet.App.Service
{
    public class SingletonServices
    {

        private MongoClient mongoClient_;
        private IMongoDatabase mongoDatabase_;
        private PointDAO daoPoint_;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <remarks>
        /// 参数为自动注入，支持多个参数，DatabaseSettings的注入点在Program.cs中，自定义设置可在MyProgram.PreBuild中注入
        /// </remarks>
        public SingletonServices(IOptions<DatabaseSettings> _databaseSettings)
        {
            mongoClient_ = new MongoClient(_databaseSettings.Value.ConnectionString);
            mongoDatabase_ = mongoClient_.GetDatabase(_databaseSettings.Value.DatabaseName);

            daoPoint_ = new PointDAO(mongoDatabase_);
        }

        public PointDAO getPointDAO()
        {
            return daoPoint_;
        }
    }
}
