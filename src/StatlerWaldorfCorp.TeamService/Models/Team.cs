using System;
using System.Collections.Generic;

namespace StatlerWaldorfCorp.TeamService.Models
{ 
    public class Team 
    { 
        #region Constructors
        public Team(string name) : this() { this.Name = name; } 
        public Team(string name, Guid id) : this(name) { this.ID = id; } 
        public Team() { this.Members = new List<Member>(); } 
        #endregion

        #region Members
        public string Name { get; set; } 
        public Guid ID { get; set; } 
        public ICollection<Member> Members { get; set; } 
        #endregion
        
        #region Behaviours
        public override string ToString() { return this.Name; } }
        #endregion
}