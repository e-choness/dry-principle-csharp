// See https://aka.ms/new-console-template for more information

using ExtensionsLibrary;
using NetworkDummyLib;

"Starting the server...".Dump();
SyncSocketServer.StartListener();
