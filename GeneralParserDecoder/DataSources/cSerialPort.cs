using GeneralParserDecoder.DataSources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralParserDecoder.DataSources
{
    interface IDataSource
    {
        //int Rate; //Interface doesn not allow fields
        //void event DataReceived;
    }
    internal class cDataReceivedArgs : IDataSource
    {
        Guid ID;
        List<byte> Data;
        DateTime ReceptionTime;
    }
    
    internal class cSerialPort : IDataSource 
    {
    }

    internal class cUDP : IDataSource
    {

    }

    internal class cCAN : IDataSource 
    {
    }
   
    internal class cFile : IDataSource
    {
    }


}
