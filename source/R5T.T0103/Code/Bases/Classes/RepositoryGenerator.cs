using System;


namespace R5T.T0103
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class RepositoryGenerator : IRepositoryGenerator
    {
        #region Static
        
        public static RepositoryGenerator Instance { get; } = new();

        #endregion
    }
}