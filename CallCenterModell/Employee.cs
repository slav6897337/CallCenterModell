namespace CallCenterModell
{
    /// <summary>
    /// Employee.
    /// </summary>
    public abstract class Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        protected Employee()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="name">Name employee.</param>
        /// <param name="post">Post employee.</param>
        protected Employee(string name, string post)
            : this()
        {
            Name = name;
            Post = post;
        }

        /// <summary>
        /// Gets or sets name employee.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets post employee.
        /// </summary>
        public string Post { get; set; }

        /// <summary>
        /// Gets a value indicating whether ability to take a call employee.
        /// </summary>
        public bool State { get; private set; } = true;

        /// <summary>
        /// Answer the Call.
        /// </summary>
        /// <returns>Ability to take a call.</returns>
        public bool AnswerCall()
        {
            if (State)
            {
                State = false;
                System.Console.WriteLine($"Your call will be answered {Post} {Name}");
                return true;
            }

            return false;
        }
    }
}
