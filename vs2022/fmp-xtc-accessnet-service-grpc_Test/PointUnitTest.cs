
using NuGet.Frameworks;
using XTC.FMP.MOD.AccessNet.LIB.Proto;

public class PointTest : PointUnitTestBase
{
    public PointTest(TestFixture _testFixture)
        : base(_testFixture)
    {
    }


    public override async Task OnlineTest()
    {
        var request = new PointOnlineRequest();

        // 缺少参数
        var response = await fixture_.getServicePoint().Online(request, fixture_.context);
        Assert.Equal(-400, response.Status.Code);

        // 新设备上线
        request.Point = new PointEntity();
        request.Point.SerialNumber = "0000001";
        response = await fixture_.getServicePoint().Online(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);

        // 再次上线
        response = await fixture_.getServicePoint().Online(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override async Task OfflineTest()
    {
        var request = new PointOfflineRequest();
        var response = await fixture_.getServicePoint().Offline(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override async Task HeartBeatTest()
    {
        var request = new PointHeartBeatRequest();
        var response = await fixture_.getServicePoint().HeartBeat(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override async Task RetrieveTest()
    {
        var request = new UuidRequest();
        var response = await fixture_.getServicePoint().Retrieve(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

    public override async Task ListTest()
    {
        var request = new PointListRequest();
        var response = await fixture_.getServicePoint().List(request, fixture_.context);
        Assert.Equal(0, response.Status.Code);
    }

}
