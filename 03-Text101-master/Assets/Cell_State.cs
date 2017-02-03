namespace Assets
{
    public class Cell_State : State
    {
     
        public Cell_State()
        {
            Options = new string[] { "Press 1 to view Sheets\n", "Press 2 to view Mirror\n", "Press 3 to view Lock\n" };
            Content = "You are in a prison cell, and you want to escape. There are " +
                   "some dirty sheets on the bed, a mirror on the wall, and the door " +
                   "is locked from the outside.\n\n";
            SetOptionsDictionary(Options);
        }

        public override void DoTransition(int option)
        {
            throw new System.NotImplementedException();
        }

        public override State GetNextState(int option)
        { 
            switch (option)
            {
                case 1: 
                    return new Sheets_State();
                case 2:
                    return new Mirror_State();
                case 3:
                    return new Lock_State();
                case 0:
                    return new Cell_State();
                default:
                    return this;
            }
        }
    }
}