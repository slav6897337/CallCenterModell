namespace CallCenterModell
{
    using System.Collections.Generic;

    /// <summary>
    /// Call Center.
    /// </summary>
    public class CallCenter : IDispatchCall
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallCenter"/> class.
        /// </summary>
        public CallCenter()
        {
            for (int i = 0; i < 10; i++)
            {
                Respondents.Add(new Respondent());
            }

            for (int i = 0; i < 3; i++)
            {
                Managers.Add(new Manager());
            }

            DirectorCenter = new Director();
        }

        /// <summary>
        /// Gets or sets respondents.
        /// </summary>
        public List<Respondent> Respondents { get; set; } = new List<Respondent>();

        /// <summary>
        /// Gets or sets managers.
        /// </summary>
        public List<Manager> Managers { get; set; } = new List<Manager>();

        /// <summary>
        /// Gets or sets director.
        /// </summary>
        public Director DirectorCenter { get; set; }

        /// <summary>
        /// Assigns a call to the first available employee.
        /// </summary>
        /// <param name="number">The phone number from which the call is made.</param>
        public void DispatchCall(string number)
        {
            while (true)
            {
                foreach (var respondent in Respondents)
                {
                    if (respondent.AnswerCall())
                    {
                        return;
                    }
                }

                foreach (var manager in Managers)
                {
                    if (manager.AnswerCall())
                    {
                        return;
                    }
                }

                if (DirectorCenter.AnswerCall())
                {
                    return;
                }

                System.Console.WriteLine("Please wait a minute, all employees are busy.");
            }
        }
    }
}
