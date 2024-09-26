using System.Collections.Generic;

namespace DataPaintLibrary.Classes.Input
{
    public class SecurityGroup
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public List<int> Authorisers { get; set; }
        public List<int> Users { get; set; }
        public SecurityParameters Parameters { get; set; }

        public SecurityGroup(int id, string groupName, List<int> authorisers = null, List<int> users = null, SecurityParameters parameters = null)
        {
            Id = id;
            GroupName = groupName;
            Authorisers = authorisers ?? new List<int>();
            Users = users ?? new List<int>();
            Parameters = parameters;
        }
    }
}