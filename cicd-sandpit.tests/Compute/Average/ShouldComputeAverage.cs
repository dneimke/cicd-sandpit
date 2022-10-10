using Shouldly;
using static cicd_sandpit.tests.Test;

namespace cicd_sandpit.tests.Compute.Average
{
    public class ShouldComputeAverage : ContainerTestBase
    {
        List<int>?_numbers;
        double? _average;
        double _expected = 4;
        
        void GivenAListOfNumbers()
        {
            _numbers = new List<int>()
            {
                2, 4, 6
            };
        }

        void WhenTheAverageIsComputed()
        {
            _average = cicd_sandpit.Compute.Average(_numbers!);
        }

        void ThenTheAverageShouldBeCorrect()
        {
            _average.ShouldBe(_expected);
        }
    }
}
