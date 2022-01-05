using System;


namespace R5T.T0103
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class RepositoryOperator : IRepositoryOperator
    {
        #region Static
        
        public static RepositoryOperator Instance { get; } = new();

        #endregion
    }
}