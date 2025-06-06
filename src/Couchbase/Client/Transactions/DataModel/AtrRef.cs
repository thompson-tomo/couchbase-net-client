﻿#nullable enable
using System.Text.Json.Serialization;
using Newtonsoft.Json;
#pragma warning disable CS1591

namespace Couchbase.Client.Transactions.DataModel
{
    // TODO: this class should be made internal
    public class AtrRef
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonProperty("bkt")]
        [JsonPropertyName("bkt")]
        public string? BucketName { get; set; }

        [JsonProperty("scp")]
        [JsonPropertyName("scp")]
        public string? ScopeName { get; set; }

        [JsonProperty("coll")]
        [JsonPropertyName("coll")]
        public string? CollectionName { get; set; }

        public override string ToString() => $"{BucketName ?? "-"}/{ScopeName ?? "-"}/{CollectionName ?? "-"}/{Id ?? "-"}";
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
