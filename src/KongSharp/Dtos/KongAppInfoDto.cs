// #region File Annotation
// 
// Author：Zhiqiang Li
// 
// FileName：KongAppInfo.cs
// 
// Project：KongSharp
// 
// CreateDate：2018/08/03
// 
// Note: The reference to this document code must not delete this note, and indicate the source!
// 
// #endregion

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Revival.KongSharp.Dtos
{
    /// <summary>
    /// Kong's information
    /// </summary>
    public class KongAppInfoDto
    {
        [JsonProperty("hostname")]
        public string HostName { get; set; }

        /// <summary>
        /// A UUID representing the running Kong node. This UUID is randomly generated when Kong starts, so the node will have a different node_id each time it is restarted.
        /// </summary>
        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("lua_version")]
        public string LuaVersion { get; set; }

        [JsonProperty("plugins")]
        public KongAppPluginsDto Plugins { get; set; }

        [JsonProperty("configuration")]
        public KongAppConfigurationDto Configuration { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        #region Internal class

        public class KongAppConfigurationDto
        {

        }

        public class KongAppPluginsDto
        {

            /// <summary>
            /// Names of plugins that are installed on the node.
            /// </summary>
            [JsonProperty("available_on_server")]
            public List<KongPluginDto> Plugins { get; set; }

            /// <summary>
            /// Names of plugins that are enabled/configured. That is, the plugins configurations currently in the datastore shared by all Kong nodes.
            /// </summary>
            [JsonProperty("enabled_in_cluster")]
            public List<KongClusterDto> Clusters { get; set; }
        }

        /// <summary>
        /// Kong cluster information
        /// </summary>
        public class KongClusterDto
        {

        }

        /// <summary>
        /// Kong plugins information.
        /// </summary>
        public class KongPluginDto
        {

        }

        #endregion
    }
}