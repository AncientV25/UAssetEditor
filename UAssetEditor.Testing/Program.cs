﻿using System.Diagnostics;
using UAssetEditor;
using UAssetEditor.Properties;
using Usmap.NET;

var stopwatch = Stopwatch.StartNew();
var uasset = new UAsset(@"C:\Users\oshock\Documents\FModel\Output\Exports\CID_028_Athena_Commando_F.uasset");
uasset.Initialize(@"C:\Program Files\Epic Games\Fortnite\FortniteGame\Content\Paks\global.utoc");
uasset.LoadMappings(@"C:\Users\oshock\Documents\FModel\Output\.data\++Fortnite+Release-26.20-CL-28096793-Android_oo.usmap ");
uasset.ReadAll();
stopwatch.Stop();
Console.WriteLine($"Done in {stopwatch.ElapsedMilliseconds}ms!");