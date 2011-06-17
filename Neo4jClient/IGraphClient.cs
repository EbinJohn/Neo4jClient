﻿using System.Collections.Generic;
using System.Collections.Specialized;

namespace Neo4jClient
{
    public interface IGraphClient
    {
        NodeReference<TNode> Create<TNode>(TNode node, params IRelationshipAllowingParticipantNode<TNode>[] relationships) where TNode : class;
        TNode Get<TNode>(NodeReference reference);
        TNode Get<TNode>(NodeReference<TNode> reference);
        void Delete(NodeReference reference, DeleteMode mode);
        string ExecuteScalarGremlin(string query, NameValueCollection queryParameters);
        IEnumerable<TNode> ExecuteGetAllNodesGremlin<TNode>(string query, NameValueCollection queryParameters);
    }
}