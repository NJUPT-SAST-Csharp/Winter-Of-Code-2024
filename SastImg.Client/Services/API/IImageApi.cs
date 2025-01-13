// <auto-generated>
//     This code was generated by Refitter.
// </auto-generated>


using Refit;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

#nullable enable annotations

namespace SastImg.Client.Service.API
{
    [System.CodeDom.Compiler.GeneratedCode("Refitter", "1.4.1.0")]
    public partial interface IImageApi
    {
        /// <returns>
        /// A <see cref="Task"/> representing the <see cref="IApiResponse"/> instance containing the result:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>200</term>
        /// <description>OK</description>
        /// </item>
        /// </list>
        /// </returns>
        [Post("/api/albums/{albumId}/add")]
        Task<IApiResponse> Add(long albumId, [Body] Body2 body, CancellationToken cancellationToken = default);

        /// <returns>
        /// A <see cref="Task"/> representing the <see cref="IApiResponse"/> instance containing the result:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>200</term>
        /// <description>OK</description>
        /// </item>
        /// </list>
        /// </returns>
        [Post("/api/albums/{albumId}/images/{imageId}/remove")]
        Task<IApiResponse> Remove2(long albumId, long imageId, CancellationToken cancellationToken = default);

        /// <returns>
        /// A <see cref="Task"/> representing the <see cref="IApiResponse"/> instance containing the result:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>200</term>
        /// <description>OK</description>
        /// </item>
        /// </list>
        /// </returns>
        [Post("/api/albums/{albumId}/images/{imageId}/restore")]
        Task<IApiResponse> Restore2(long albumId, long imageId, CancellationToken cancellationToken = default);

        /// <returns>
        /// A <see cref="Task"/> representing the <see cref="IApiResponse"/> instance containing the result:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>200</term>
        /// <description>OK</description>
        /// </item>
        /// </list>
        /// </returns>
        [Post("/api/albums/{albumId}/images/{imageId}/like")]
        Task<IApiResponse> Like(long albumId, long imageId, CancellationToken cancellationToken = default);

        /// <returns>
        /// A <see cref="Task"/> representing the <see cref="IApiResponse"/> instance containing the result:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>200</term>
        /// <description>OK</description>
        /// </item>
        /// </list>
        /// </returns>
        [Post("/api/albums/{albumId}/images/{imageId}/unlike")]
        Task<IApiResponse> Unlike(long albumId, long imageId, CancellationToken cancellationToken = default);

        /// <returns>
        /// A <see cref="Task"/> representing the <see cref="IApiResponse"/> instance containing the result:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>200</term>
        /// <description>OK</description>
        /// </item>
        /// </list>
        /// </returns>
        [Headers("Accept: text/plain, application/json, text/json")]
        [Get("/api/images")]
        Task<IApiResponse<ICollection<ImageDto>>> ImagesAll([Query] long? uploader, [Query] long? album, [Query] int? page, CancellationToken cancellationToken = default);

        /// <returns>
        /// A <see cref="Task"/> representing the <see cref="IApiResponse"/> instance containing the result:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>200</term>
        /// <description>OK</description>
        /// </item>
        /// </list>
        /// </returns>
        [Headers("Accept: text/plain, application/json, text/json")]
        [Get("/api/images/{id}")]
        Task<IApiResponse<ImageDto>> Images(long id, [Query] int? kind, CancellationToken cancellationToken = default);

        /// <returns>
        /// A <see cref="Task"/> representing the <see cref="IApiResponse"/> instance containing the result:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>200</term>
        /// <description>OK</description>
        /// </item>
        /// </list>
        /// </returns>
        [Headers("Accept: text/plain, application/json, text/json")]
        [Get("/api/images/{id}/info")]
        Task<IApiResponse<DetailedImage>> Info(long id, CancellationToken cancellationToken = default);

        /// <returns>
        /// A <see cref="Task"/> representing the <see cref="IApiResponse"/> instance containing the result:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>200</term>
        /// <description>OK</description>
        /// </item>
        /// </list>
        /// </returns>
        [Headers("Accept: text/plain, application/json, text/json")]
        [Get("/api/albums/{albumId}/images/removed")]
        Task<IApiResponse<ICollection<ImageDto>>> Removed2(long albumId, CancellationToken cancellationToken = default);
    }

}