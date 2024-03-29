﻿using System;

using R5T.T0041;
using R5T.T0108;


namespace R5T.T0103.X002
{
    public static class Instances
    {
        public static IPathOperator PathOperator { get; } = T0041.PathOperator.Instance;
        public static IRepositoryNameOperator RepositoryNameOperator { get; } = T0108.RepositoryNameOperator.Instance;
    }
}
