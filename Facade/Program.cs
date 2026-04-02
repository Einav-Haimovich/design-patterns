// client code
using _3._2;

var castingFacade = new CastingFacade(
    new DeviceExplorer());

await castingFacade.CastAsync(
    deviceId: Guid.NewGuid(),
    videoId: Guid.NewGuid());