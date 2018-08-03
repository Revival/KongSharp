// #region File Annotation
// 
// Author：Zhiqiang Li
// 
// FileName：KongApiClient.cs
// 
// Project：KongSharp
// 
// CreateDate：2018/08/03
// 
// Note: The reference to this document code must not delete this note, and indicate the source!
// 
// #endregion

using System.Threading.Tasks;
using Refit;
using Revival.KongSharp.Dtos;

namespace Revival.KongSharp
{
    public interface IKongApi
    {
        #region Application

        /// <summary>
        /// Get kong's application information.
        /// <para/>
        /// success code: 200 Ok.
        /// </summary>
        /// <returns></returns>
        [Get("/")]
        Task<KongAppInfoDto> GetKongAppInfo();

        /// <summary>
        /// Get kong's running status.
        /// <para/>
        /// success code: 200 Ok.
        /// </summary>
        /// <returns></returns>
        [Get("status")]
        Task<KongAppStatusDto> GetStatus();

            #endregion

        #region Service

        /// <summary>
        /// Add a service(api).
        /// <para/>
        /// success code: 201 Created.
        /// </summary>
        /// <param name="dto">service info.</param>
        /// <returns></returns>
        [Post("/services/")]
        Task AddService([Body] KongServiceDto dto);

        /// <summary>
        /// Get a service(api) info.
        /// <para/>
        /// success code: 200 Ok.
        /// </summary>
        /// <param name="serviceNameOrId">service's name of id.</param>
        /// <returns></returns>
        [Get("/services/{nameorid}")]
        Task<KongServiceDto> RetrieveService([AliasAs("nameorid")]string serviceNameOrId);

        /// <summary>
        /// Get a service(api) info by route id.
        /// <para/>
        /// success code: 200 Ok.
        /// </summary>
        /// <param name="routeId">route id.</param>
        /// <returns></returns>
        [Get("/routes/{routeid}/service")]
        Task<KongServiceDto> RetrieveServiceByRouteId([AliasAs("routeid")]string routeId);

        #endregion
    }
}