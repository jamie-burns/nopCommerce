using Nop.Core.Caching;
using Nop.Services.ScheduleTasks;

namespace Nop.Services.Caching
{
    /// <summary>
    /// Clear cache scheduled task implementation
    /// </summary>
    [SlowFox.InjectDependencies(typeof(IStaticCacheManager))]
    public partial class ClearCacheTask : IScheduleTask
    {
        #region Methods

        /// <summary>
        /// Executes a task
        /// </summary>
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
            await _staticCacheManager.ClearAsync();
        }

        #endregion
    }
}