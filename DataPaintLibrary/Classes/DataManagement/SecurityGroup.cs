using DataPaintLibrary.Enums;
using System;
using System.Collections.Generic;

namespace DataPaintLibrary.Classes.Input
{
    public class SecurityGroup
    {
        public Guid Id { get; set; }
        public string GroupName { get; set; }
        public SecurityType SecurityType { get; set; } //needs to be added to database when created
        public AuthorisationType AuthorisationType { get; set; } //needs to be added to database when created
        public bool VisibleToAll { get; set; } 
        public List<Guid> Admins { get; set; } = new List<Guid>();
        public List<Guid> Users { get; set; } = new List<Guid>();

        /// <summary>
        ///Used when retrieving data from data source
        /// </summary>
        /// <param name="id"></param>
        /// <param name="groupName"></param>
        /// <param name="authorisers"></param>
        /// <param name="users"></param>
        public SecurityGroup(Guid id, string groupName, List<Guid> authorisers = null, List<Guid> users = null)
        {
            Id = id;
            GroupName = groupName;
            Admins = authorisers ?? new List<Guid>();
            Users = users ?? new List<Guid>();
        }

        //Used when building the securiy class
        public SecurityGroup(Guid id, string groupName) 
        {
            Id = id;
            GroupName = groupName;
        }
    }
}