using System;
using Unity.Entities;

//[Serializable]
// A component used to limit when NetworkDrivers are created. The PingDriverSystem uses this to create the
// NetworkDrivers when requested
//public struct PingDriverComponentData : IComponentData
//{
 //   public int isServer;
//}


public struct PingDriverComponent : IComponentData {

    public int isServer;
}
