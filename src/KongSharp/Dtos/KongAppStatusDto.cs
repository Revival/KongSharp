// #region File Annotation
// 
// Author：Zhiqiang Li
// 
// FileName：KongAppStatusDto.cs
// 
// Project：KongSharp
// 
// CreateDate：2018/08/03
// 
// Note: The reference to this document code must not delete this note, and indicate the source!
// 
// #endregion

using Newtonsoft.Json;

namespace Revival.KongSharp.Dtos
{
    public class KongAppStatusDto
    {
        /// <summary>
        /// Metrics about the nginx HTTP/S server.
        /// </summary>
        [JsonProperty("server")]
        public KongAppServerStatusDto Server { get; set; }

        /// <summary>
        /// Metrics about the database.
        /// </summary>
        [JsonProperty("database")]
        public KongAppDbStatusDto Database { get; set; }

        #region Internal class

        public class KongAppServerStatusDto
        {
            /// <summary>
            /// The total number of client requests.
            /// </summary>
            [JsonProperty("total_requests")]
            public long TotalRequests { get; set; }

            /// <summary>
            /// The current number of active client connections including Waiting connections.
            /// </summary>
            [JsonProperty("connections_active")]
            public int ConnectionsActive { get; set; }

            /// <summary>
            /// The total number of accepted client connections.
            /// </summary>
            [JsonProperty("connections_accepted")]
            public int ConnectionsAccepted { get; set; }

            /// <summary>
            /// The total number of handled connections. Generally, the parameter value is the same as accepts unless some resource limits have been reached.
            /// </summary>
            [JsonProperty("connections_handled")]
            public int ConnectionsHandled { get; set; }

            /// <summary>
            /// The current number of connections where Kong is reading the request header.
            /// </summary>
            [JsonProperty("connections_reading")]
            public int ConnectionsReading { get; set; }

            /// <summary>
            /// The current number of connections where nginx is writing the response back to the client.
            /// </summary>
            [JsonProperty("connections_writing")]
            public int ConnectionsWriting { get; set; }

            /// <summary>
            /// The current number of idle client connections waiting for a request.
            /// </summary>
            [JsonProperty("connections_waiting")]
            public int ConnectionsWaiting { get; set; }
        }

        /// <summary>
        /// Kong's database status.
        /// </summary>
        public class KongAppDbStatusDto
        {
            /// <summary>
            /// A boolean value reflecting the state of the database connection. Please note that this flag does not reflect the health of the database itself.
            /// </summary>
            [JsonProperty("reachable")]
            public bool Reachable { get; set; }
        }

        #endregion
    }


}