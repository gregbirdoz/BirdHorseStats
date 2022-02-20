using System.Collections.Generic;

namespace BirdHorseStats.Models
{
    public static class SurvivalSubmit
    {
        private static List<SurvivalModel> submission = new List<SurvivalModel>();
        public static IEnumerable<SurvivalModel> Submission => submission;
        public static void SaveSubmission(SurvivalModel submitData)
        {
            submission.Clear();
            submission.Add(submitData);
        }
    }
}
