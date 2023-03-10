

using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using LibMVCS = XTC.FMP.LIB.MVCS;
using XTC.FMP.MOD.AccessNet.LIB.Proto;
using XTC.FMP.MOD.AccessNet.LIB.MVCS;

namespace XTC.FMP.MOD.AccessNet.LIB.Unity
{
    /// <summary>
    /// 实例类
    /// </summary>
    public class MyInstance : MyInstanceBase
    {

        public MyInstance(string _uid, string _style, MyConfig _config, MyCatalog _catalog, LibMVCS.Logger _logger, Dictionary<string, LibMVCS.Any> _settings, MyEntryBase _entry, MonoBehaviour _mono, GameObject _rootAttachments)
            : base(_uid, _style, _config, _catalog, _logger, _settings, _entry, _mono, _rootAttachments)
        {
        }

        /// <summary>
        /// 当被创建时
        /// </summary>
        /// <remarks>
        /// 可用于加载主题目录的数据
        /// </remarks>
        public void HandleCreated()
        {
        }

        /// <summary>
        /// 当被删除时
        /// </summary>
        public void HandleDeleted()
        {
        }

        /// <summary>
        /// 当被打开时
        /// </summary>
        /// <remarks>
        /// 可用于加载内容目录的数据
        /// </remarks>
        public void HandleOpened(string _source, string _uri)
        {
            rootUI.gameObject.SetActive(true);
            rootWorld.gameObject.SetActive(true);

            long activated = 0;
            int expiry = 90;
            var request = new PointOnlineRequest();
            request.Point = new PointEntity();
            request.Point.SerialNumber = settings_["serialnumber"].AsString();
            request.Point.DeviceName = SystemInfo.deviceName;
            request.Point.DeviceModel = SystemInfo.deviceModel;
            request.Point.DeviceType = SystemInfo.deviceType.ToString();
            request.Point.OperatingSystemFamily = SystemInfo.operatingSystemFamily.ToString();
            request.Point.OperatingSystemVersion = SystemInfo.operatingSystem;
            request.Point.ApplicationCompany = Application.companyName;
            request.Point.ApplicationProduct = Application.productName;
            request.Point.ApplicationVersion = Application.version;
            request.Point.ApplicationActivated = activated;
            request.Point.ApplicationExpiry = expiry;
            var dto = new PointOnlineRequestDTO(request);
            viewBridgePoint.OnOnlineSubmit(dto, null);
        }

        /// <summary>
        /// 当被关闭时
        /// </summary>
        public void HandleClosed()
        {
            rootUI.gameObject.SetActive(false);
            rootWorld.gameObject.SetActive(false);
        }
    }
}
