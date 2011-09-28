// ServerResult.cs
//

namespace HelloWorld.Scripts
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// ��������� �����.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    public class ServerResult : Record
    {
        /// <summary>
        /// ������ �����������.
        /// </summary>
        [PreserveCase]
        public string Greeting;
        
        /// <summary>
        /// ����������� �����.
        /// </summary>
        [PreserveCase]
        public string TimeStamp;
    }
}
