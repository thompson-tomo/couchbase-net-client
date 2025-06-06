using System;

#nullable enable

namespace Couchbase.Core
{
    /// <summary>
    /// Default implementation of <see cref="IServiceUriProvider"/>.
    /// </summary>
    internal sealed class ServiceUriProvider : IServiceUriProvider
    {
        private readonly ClusterContext _clusterContext;

        public ServiceUriProvider(ClusterContext clusterContext)
        {
            _clusterContext = clusterContext ?? throw new ArgumentNullException(nameof(clusterContext));
        }

        /// <inheritdoc />
        public Uri GetRandomAnalyticsUri() =>
            _clusterContext.GetRandomNodeForService(ServiceType.Analytics).AnalyticsUri;

        /// <inheritdoc />
        public Uri GetRandomQueryUri() =>
            _clusterContext.GetRandomNodeForService(ServiceType.Query).QueryUri;

        /// <inheritdoc />
        public Uri GetRandomSearchUri() =>
            _clusterContext.GetRandomNodeForService(ServiceType.Search).SearchUri;

        /// <inheritdoc />
        public Uri GetRandomManagementUri() =>
            _clusterContext.GetRandomNodeForService(ServiceType.Management).ManagementUri;

        /// <inheritdoc />
        public Uri GetRandomViewsUri(string bucketName) =>
            _clusterContext.GetRandomNodeForService(ServiceType.Views, bucketName).ViewsUri;

        /// <inheritdoc />
        public Uri GetRandomEventingUri() =>
            _clusterContext.GetRandomNodeForService(ServiceType.Eventing).EventingUri;

        #region AppTelemetry Utils

        /// <inheritdoc />
        public IClusterNode GetRandomAnalyticsNode() =>
            _clusterContext.GetRandomNodeForService(ServiceType.Analytics);

        /// <inheritdoc />
        public IClusterNode GetRandomQueryNode() =>
            _clusterContext.GetRandomNodeForService(ServiceType.Query);

        /// <inheritdoc />
        public IClusterNode GetRandomSearchNode() =>
            _clusterContext.GetRandomNodeForService(ServiceType.Search);

        /// <inheritdoc />
        public IClusterNode GetRandomManagementNode() =>
            _clusterContext.GetRandomNodeForService(ServiceType.Management);

        /// <inheritdoc />
        public IClusterNode GetRandomViewsNode(string bucketName) =>
            _clusterContext.GetRandomNodeForService(ServiceType.Views, bucketName);

        /// <inheritdoc />
        public IClusterNode GetRandomEventingNode() =>
            _clusterContext.GetRandomNodeForService(ServiceType.Eventing);

        #endregion
    }
}


/* ************************************************************
 *
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2021 Couchbase, Inc.
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * ************************************************************/
