namespace Assets
{
    public class Lock_State : State
    {

        public Lock_State()
        {
            Options = new string[] { "Press Backspace to return to cell.\n" };
            Content = "This is one of those button locks. You have no idea what the " +
                        "combination is. You wish you could somehow see where the dirty " +
                        "fingerprints were, maybe that would help.\n\n";
            //SetOptionsDictionary(Options);

        }

        public override void DoTransition(int option)
        {
            throw new System.NotImplementedException();
        }

        public override State GetNextState(int option)
        {
            switch (option)
            {
                case 0:
                    return new Cell_State();
                default:
                    return this;
            }
        }
    }
}
