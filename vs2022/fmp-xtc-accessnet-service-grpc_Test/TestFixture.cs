
using XTC.FMP.MOD.AccessNet.App.Service;

/// <summary>
/// 测试上下文，用于共享测试资源
/// </summary>
public class TestFixture : TestFixtureBase
{
    private SingletonServices singletonServices_;

    public TestFixture()
        : base()
    {
        singletonServices_ = new SingletonServices(new DatabaseOptions());
    }

    public override void Dispose()
    {
        base.Dispose();
    }


    protected override void newHealthyService()
    {
        serviceHealthy_ = new HealthyService(singletonServices_);
    }

    protected override void newPointService()
    {
        servicePoint_ = new PointService(singletonServices_);
    }

}
