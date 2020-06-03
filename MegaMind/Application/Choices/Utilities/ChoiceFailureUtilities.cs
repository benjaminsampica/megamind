using System;

namespace MegaMind.Application.Choices.Utilities
{
    public class ChoiceFailureUtilities
    {
        public static int CalculateHappinessFailure()
        {
            var happinessFailurePercentage = new Random().Next(10, 25);

            return happinessFailurePercentage;
        }

        public static int CalculateFundsFailure(int maximumFundsAvailable)
        {
            var lowerFailureBoundary = (int)(maximumFundsAvailable * .1);
            var upperFailureBoundary = (int)(maximumFundsAvailable * .25);
            var fundsFailureAmount = new Random().Next(lowerFailureBoundary, upperFailureBoundary);

            return fundsFailureAmount;
        }
    }
}
