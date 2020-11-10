﻿using GraphQL.Types;
using Libplanet.Standalone;

namespace NineChronicles.Standalone.GraphTypes
{
    public sealed class NodeExceptionType : ObjectGraphType<NodeException>
    {
        public NodeExceptionType()
        {
            Field<NonNullGraphType<IntGraphType>>(
                name: "code",
                description: "The code of NodeException.",
                resolve: context => context.Source.Code);
            Field<NonNullGraphType<StringGraphType>>(
                name: "message",
                description: "The message of NodeException.",
                resolve: context => context.Source.Message);
        }
    }
}
