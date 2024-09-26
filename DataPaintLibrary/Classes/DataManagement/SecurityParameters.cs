namespace DataPaintLibrary.Classes
{
    public class SecurityParameters
    {
        public int Id { get; set; }
        public bool AuthorisationToView { get; set; }
        public int AuthorisationViewGroup { get; set; }
        public bool AuthorisationToRun { get; set; }
        public int AuthorisationRunGroup { get; set; }
        public bool AuthorisationToChange { get; set; }
        public int AuthorisationChangeGroup { get; set; }

        public SecurityParameters(int id, bool authorisationToView, int authorisationViewGroup,
                                  bool authorisationToRun, int authorisationRunGroup,
                                  bool authorisationToChange, int authorisationChangeGroup)
        {
            Id = id;
            AuthorisationToView = authorisationToView;
            AuthorisationViewGroup = authorisationViewGroup;
            AuthorisationToRun = authorisationToRun;
            AuthorisationRunGroup = authorisationRunGroup;
            AuthorisationToChange = authorisationToChange;
            AuthorisationChangeGroup = authorisationChangeGroup;
        }
    }
}