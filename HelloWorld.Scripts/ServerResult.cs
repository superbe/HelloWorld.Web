// ServerResult.cs
//

namespace HelloWorld.Scripts
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Модельный класс.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    public class ServerResult : Record
    {
        /// <summary>
        /// Строка приветствия.
        /// </summary>
        [PreserveCase]
        public string Greeting;
        
        /// <summary>
        /// Сегодняшнее число.
        /// </summary>
        [PreserveCase]
        public string TimeStamp;
    }
}
