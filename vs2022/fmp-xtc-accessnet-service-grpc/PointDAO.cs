using MongoDB.Driver;

namespace XTC.FMP.MOD.AccessNet.App.Service
{
    public class PointDAO : MongoDAO<PointEntity>
    {
        public PointDAO(IMongoDatabase _mongoDatabase)
            : base(_mongoDatabase, "Point")
        {
        }

        public PointEntity NewFromProtoEntity(LIB.Proto.PointEntity _entity)
        {
            var point = new PointEntity()
            {
                SerialNumber = _entity.SerialNumber,
                DeviceName = _entity.DeviceName,
                DeviceModel = _entity.DeviceModel,
                DeviceType = _entity.DeviceType,
                OperatingSystemFamily = _entity.OperatingSystemFamily,
                OperatingSystemVersion = _entity.OperatingSystemVersion,
                ApplicationCompany = _entity.ApplicationCompany,
                ApplicationProduct = _entity.ApplicationProduct,
                ApplicationVersion = _entity.ApplicationVersion,
                ApplicationActivated = _entity.ApplicationActivated,
                ApplicationExpiry = _entity.ApplicationExpiry,
            };
            return point;
        }

        public LIB.Proto.PointEntity NewToProtoEntity(PointEntity _entity)
        {
            var point = new LIB.Proto.PointEntity()
            {
                Uuid = _entity.Uuid.ToString(),
                SerialNumber = _entity.SerialNumber,
                DeviceName = _entity.DeviceName,
                DeviceModel = _entity.DeviceModel,
                DeviceType = _entity.DeviceType,
                OperatingSystemFamily = _entity.OperatingSystemFamily,
                OperatingSystemVersion = _entity.OperatingSystemVersion,
                ApplicationCompany = _entity.ApplicationCompany,
                ApplicationProduct = _entity.ApplicationProduct,
                ApplicationVersion = _entity.ApplicationVersion,
                ApplicationActivated = _entity.ApplicationActivated,
                ApplicationExpiry = _entity.ApplicationExpiry,
            };
            return point;
        }

        public void Clone(PointEntity _from, PointEntity _to)
        {
            _to.DeviceName = _from.DeviceName;
            _to.DeviceModel = _from.DeviceModel;
            _to.DeviceType = _from.DeviceType;
            _to.OperatingSystemFamily = _from.OperatingSystemFamily;
            _to.OperatingSystemVersion = _from.OperatingSystemVersion;
            _to.ApplicationCompany = _from.ApplicationCompany;
            _to.ApplicationProduct = _from.ApplicationProduct;
            _to.ApplicationVersion = _from.ApplicationVersion;
            _to.ApplicationActivated = _from.ApplicationActivated;
            _to.ApplicationExpiry = _from.ApplicationExpiry;
        }


        /// <summary>
        /// 查找实体
        /// </summary>
        /// <param name="_serialNumber">序列号</param>
        /// <returns></returns>
        public virtual async Task<PointEntity?> FindWithSerialNumberAsync(string _serialNumber) =>
            await collection_.Find(x => x.SerialNumber.Equals(_serialNumber)).FirstOrDefaultAsync();
    }
}
