using AutoMapper;
using Microsoft.Azure.Devices.Applications.RemoteMonitoring.Common.DeviceSchema;
using Microsoft.Azure.Devices.Applications.RemoteMonitoring.DeviceAdmin.Web.Models;
using Owin;

namespace Microsoft.Azure.Devices.Applications.RemoteMonitoring.DeviceAdmin.Web
{
    public partial class Startup
    {
        public void ConfigureAutoMapper(IAppBuilder app)
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<dynamic, DeviceCommandViewModel>()
                    .ForMember(x => x.DeviceId, map => map.ResolveUsing((src, dest) => DeviceSchemaHelper.GetDeviceID(src)))
                    .ForMember(x => x.DeviceIsEnabled, map => map.ResolveUsing((src, dest) => DeviceSchemaHelper.GetHubEnabledState(src)))
                    .ForMember(x => x.Commands, map => map.ResolveUsing((src, dest) => src.Commands))
                    .ForMember(x => x.CommandHistory, map => map.ResolveUsing((src, dest) => src.CommandHistory));

                config.CreateMap<dynamic, DeviceCommandModel>()
                    .ForMember(x => x.Name, map => map.ResolveUsing((src, dest) => src.Name))
                    .ForMember(x => x.Parameters, map => map.ResolveUsing((src, dest) => src.Parameters));

                config.CreateMap<dynamic, DeviceCommandParameterModel>()
                    .ForMember(x => x.Name, map => map.ResolveUsing((src, dest) => src.Name))
                    .ForMember(x => x.Type, map => map.ResolveUsing((src, dest) => src.Type));

                config.CreateMap<dynamic, DeviceCommandHistoryEntryModel>()
                    .ForMember(x => x.Name, map => map.ResolveUsing((src, dest) => src.Name))
                    .ForMember(x => x.MessageId, map => map.ResolveUsing((src, dest) => src.MessageId))
                    .ForMember(x => x.ErrorMessage, map => map.ResolveUsing((src, dest) => src.ErrorMessage))
                    .ForMember(x => x.Result, map => map.ResolveUsing((src, dest) => src.Result))
                    .ForMember(x => x.CreatedTime, map => map.ResolveUsing((src, dest) => src.CreatedTime))
                    .ForMember(x => x.UpdatedTime, map => map.ResolveUsing((src, dest) => src.UpdatedTime))
                    .ForMember(x => x.Parameters, map => map.ResolveUsing((src, dest) => src.Parameters));
            });
        }
    }
}