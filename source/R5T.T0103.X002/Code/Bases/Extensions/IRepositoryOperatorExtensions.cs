using System;
using System.Threading.Tasks;

using R5T.T0103;
using R5T.T0106;

using Instances = R5T.T0103.X002.Instances;


namespace System
{
    public static class IRepositoryOperatorExtensions
    {
        public static async Task InRepositoryContext(this IRepositoryOperator _,
            string repositoryDirectoryPath,
            Func<ILocalRepositoryContext, Task> localRepositoryContextAction = default)
        {
            var repositoryDirectoryName = Instances.PathOperator.GetDirectoryNameOfDirectoryPath(repositoryDirectoryPath);

            var repositoryName = Instances.RepositoryNameOperator.GetRepositoryName(repositoryDirectoryName);

            var localRepositoryContext = new LocalRepositoryContext
            {
                DirectoryPath = repositoryDirectoryPath,
                Name = repositoryName,
            };

            await FunctionHelper.Run(localRepositoryContextAction, localRepositoryContext);
        }
    }
}