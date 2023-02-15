namespace XTC.FMP.MOD.AccessNet.App.Service
{
    public class PointEntity : Entity
    {
        /// <summary>
        /// 序列号
        /// </summary>
        public string SerialNumber { get; set; } = "";

        /// <summary>
        /// 设备名称
        /// </summary>
        public string DeviceName { get; set; } = "";

        /// <summary>
        /// 设备型号
        /// </summary>
        public string DeviceModel { get; set; } = "";

        /// <summary>
        /// 设备类型
        /// </summary>
        public string DeviceType { get; set; } = "";

        /// <summary>
        /// 操作系统系列
        /// </summary>
        public string OperatingSystemFamily { get; set; } = "";

        /// <summary>
        /// 操作系统版本
        /// </summary>
        public string OperatingSystemVersion { get; set; } = "";

        /// <summary>
        /// 应用程序公司名称
        /// </summary>
        public string ApplicationCompany { get; set; } = "";

        /// <summary>
        /// 应用程序产品名称
        /// </summary>
        public string ApplicationProduct { get; set; } = "";

        /// <summary>
        /// 应用程序版本
        /// </summary>
        public string ApplicationVersion { get; set; } = "";

        /// <summary>
        /// 应用程序激活时间
        /// </summary>
        public long ApplicationActivated { get; set; } = -1;

        /// <summary>
        /// 应用程序有效期
        /// </summary>
        public int ApplicationExpiry { get; set; } = -1;
    }
}
