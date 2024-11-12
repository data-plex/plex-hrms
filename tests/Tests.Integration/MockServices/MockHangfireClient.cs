using Hangfire;
using Hangfire.Annotations;
using Hangfire.Common;
using Hangfire.States;

namespace Tests.Integration.MockServices
{
    internal class MockHangfireClient : IBackgroundJobClient
    {
        public bool ChangeState([NotNull] string jobId, [NotNull] IState state, [CanBeNull] string expectedState)
        {
            return true;
        }

        public string Create([NotNull] Job job, [NotNull] IState state)
        {
            return "Test";
        }
    }
}
