using Bridge.Platforms;
using Bridge.Transmissions;

void StartLive(IPlatform platform) {
    Console.WriteLine("Aguarde...");
    Live live = new(platform);
    live.Broadcasting();
    live.Result();
}
void StartLiveAdvanced(IPlatform platform) {
    Console.WriteLine("Aguarde...");
    AdvancedLive live = new(platform);
    live.Broadcasting();
    live.Subtitle();
    live.Comments();
    live.Record();
    live.Result();
}

StartLiveAdvanced(new YouTube());
StartLive(new Facebook());
StartLive(new TwitchTV());
StartLiveAdvanced(new DLive());

Console.ReadKey();