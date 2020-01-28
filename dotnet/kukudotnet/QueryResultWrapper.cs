﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Microsoft.Research.Kuku
{
    public class QueryResultWrapper
    {
        private readonly QueryResult _resultStruct;

        internal QueryResultWrapper(QueryResult resultStruct)
        {
             _resultStruct = resultStruct;
        }

        public bool Found => _resultStruct.found;

        public bool InStash => _resultStruct.in_stash;

        public uint Location => _resultStruct.location;

        public uint LocFuncIndex => _resultStruct.loc_func_index;
    }
}