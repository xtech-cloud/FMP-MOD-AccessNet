
//*************************************************************************************
//   !!! Generated by the fmp-cli 1.80.0.  DO NOT EDIT!
//*************************************************************************************

public abstract class PointUnitTestBase : IClassFixture<TestFixture>
{
    /// <summary>
    /// 测试上下文
    /// </summary>
    protected TestFixture fixture_ { get; set; }

    public PointUnitTestBase(TestFixture _testFixture)
    {
        fixture_ = _testFixture;
    }


    [Fact]
    public abstract Task OnlineTest();

    [Fact]
    public abstract Task OfflineTest();

    [Fact]
    public abstract Task HeartBeatTest();

    [Fact]
    public abstract Task RetrieveTest();

    [Fact]
    public abstract Task ListTest();

}
