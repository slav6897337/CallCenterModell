namespace CallCenterModell
{
    /// <summary>
    /// Respondent.
    /// </summary>
    public class Respondent : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Respondent"/> class.
        /// </summary>
        public Respondent()
            : this("No data")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Respondent"/> class.
        /// </summary>
        /// <param name="name">Name employee.</param>
        public Respondent(string name)
            : base(name)
        {
            Post = "Respondent";
        }
    }
}
