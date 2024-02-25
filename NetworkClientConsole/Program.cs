// See https://aka.ms/new-console-template for more information

using ExtensionsLibrary;
using NetworkDummyLib;

"Starting the client...".Dump();
// SyncSocketClient.StartClient();
await AsycnSocketClient.StartClientAsync();