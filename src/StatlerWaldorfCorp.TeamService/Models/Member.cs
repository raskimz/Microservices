using System;

namespace StatlerWaldorfCorp.TeamService.Models
{ 
    public class Member 
    { 
        #region 
        public Member() { } 
        public Member(Guid id) : this() { this.ID = id; } 
        public Member(string firstName, string lastName, Guid id) : this(id) 
        { 
            this.FirstName = firstName;
            this.LastName = lastName; 
        } 
        #endregion

        #region Members
        public Guid ID { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        #endregion

        #region Behaviour
        public override string ToString() { return this.LastName; } 
        #endregion
    }
}