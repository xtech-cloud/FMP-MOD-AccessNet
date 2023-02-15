
using Microsoft.AspNetCore.Components;
using XTC.FMP.LIB.MVCS;
using XTC.FMP.MOD.AccessNet.LIB.Proto;
using XTC.FMP.MOD.AccessNet.LIB.Bridge;
using XTC.FMP.MOD.AccessNet.LIB.MVCS;

namespace XTC.FMP.MOD.AccessNet.LIB.Razor
{
    public partial class PointComponent
    {
        public class PointUiBridge : IPointUiBridge
        {

            public PointUiBridge(PointComponent _razor)
            {
                razor_ = _razor;
            }

            public void Alert(string _code, string _message, object? _context)
            {
                if (null == razor_.messageService_)
                    return;
                Task.Run(async () =>
                {
                    await razor_.messageService_.Error(_message);
                }); 
            }


            public void RefreshOnline(IDTO _dto, object? _context)
            {
                var dto = _dto as UuidResponseDTO;
                razor_.__debugOnline = dto?.Value.ToString();
            }

            public void RefreshOffline(IDTO _dto, object? _context)
            {
                var dto = _dto as UuidResponseDTO;
                razor_.__debugOffline = dto?.Value.ToString();
            }

            public void RefreshHeartBeat(IDTO _dto, object? _context)
            {
                var dto = _dto as UuidResponseDTO;
                razor_.__debugHeartBeat = dto?.Value.ToString();
            }

            public void RefreshRetrieve(IDTO _dto, object? _context)
            {
                var dto = _dto as PointRetrieveResponseDTO;
                razor_.__debugRetrieve = dto?.Value.ToString();
            }

            public void RefreshList(IDTO _dto, object? _context)
            {
                var dto = _dto as PointListResponseDTO;
                razor_.__debugList = dto?.Value.ToString();
            }


            private PointComponent razor_;
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }

        private async Task __debugClick()
        {
            var bridge = (getFacade()?.getViewBridge() as IPointViewBridge);
            if (null == bridge)
            {
                logger_?.Error("bridge is null");
                return;
            }

            var reqOnline = new PointOnlineRequest();
            var dtoOnline = new PointOnlineRequestDTO(reqOnline);
            logger_?.Trace("invoke OnOnlineSubmit");
            await bridge.OnOnlineSubmit(dtoOnline, null);

            var reqOffline = new PointOfflineRequest();
            var dtoOffline = new PointOfflineRequestDTO(reqOffline);
            logger_?.Trace("invoke OnOfflineSubmit");
            await bridge.OnOfflineSubmit(dtoOffline, null);

            var reqHeartBeat = new PointHeartBeatRequest();
            var dtoHeartBeat = new PointHeartBeatRequestDTO(reqHeartBeat);
            logger_?.Trace("invoke OnHeartBeatSubmit");
            await bridge.OnHeartBeatSubmit(dtoHeartBeat, null);

            var reqRetrieve = new UuidRequest();
            var dtoRetrieve = new UuidRequestDTO(reqRetrieve);
            logger_?.Trace("invoke OnRetrieveSubmit");
            await bridge.OnRetrieveSubmit(dtoRetrieve, null);

            var reqList = new PointListRequest();
            var dtoList = new PointListRequestDTO(reqList);
            logger_?.Trace("invoke OnListSubmit");
            await bridge.OnListSubmit(dtoList, null);

        }


        private string? __debugOnline;

        private string? __debugOffline;

        private string? __debugHeartBeat;

        private string? __debugRetrieve;

        private string? __debugList;

    }
}
