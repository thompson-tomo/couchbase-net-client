using System;
using Couchbase.Core;

#nullable enable

namespace Couchbase.KeyValue;

internal sealed class CounterResult : MutationResult, ICounterResult
{
    internal CounterResult(ulong value, ulong cas, TimeSpan? expiry, MutationToken? token)
        : base(cas, expiry, token)
    {
        Content = value;
    }

    public ulong Content { get; }
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
