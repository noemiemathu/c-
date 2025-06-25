
using AudioDevices.Devices;
using static AudioDevices.Devices.MemoRecorder;

MemoRecorder memo = new MemoRecorder(1000);
memo.MaxCartridgeType = MemoCartridgeType.C90Plus;
memo.Make = "Sony";
memo.Model = "FE190";
memo.PriceExBtw = 129.95M;
memo.CreationDate = DateTime.Now.AddMonths(-6);

Console.WriteLine(memo.DisplayIdentity(true, true));
Console.WriteLine(memo.DisplayStorageCapacity());
Console.WriteLine("Consumer price: {0:f2}", memo.ConsumerPrice);
Console.WriteLine(memo.GetDeviceLifeTime());
Console.ReadLine();
