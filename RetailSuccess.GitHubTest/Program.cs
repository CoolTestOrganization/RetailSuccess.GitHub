using System;
using RetailSuccess.GitHub;

namespace RetailSuccess.GitHubTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //DON"T CALL AGAIN
                //SetUpRepository.Run("Bless.GitApiTest2").GetAwaiter().GetResult();
                SetUpRepository.Run("RetailSuccess.SlackGitIntegration3", "CoolTestOrganization", "Retail Success").GetAwaiter()
                    .GetResult();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
