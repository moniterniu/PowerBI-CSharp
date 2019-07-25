// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for GroupUserAccessRight.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(GroupUserAccessRightConverter))]
    public struct GroupUserAccessRight : System.IEquatable<GroupUserAccessRight>
    {
        private GroupUserAccessRight(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Removes permission to content in workspace
        /// </summary>
        public static readonly GroupUserAccessRight None = "None";

        /// <summary>
        /// Grants read access to content in workspace
        /// </summary>
        public static readonly GroupUserAccessRight Member = "Member";

        /// <summary>
        /// Grants administrator rights to workspace
        /// </summary>
        public static readonly GroupUserAccessRight Admin = "Admin";

        /// <summary>
        /// Grants read and write access to content in group
        /// </summary>
        public static readonly GroupUserAccessRight Contributor = "Contributor";


        /// <summary>
        /// Underlying value of enum GroupUserAccessRight
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for GroupUserAccessRight
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type GroupUserAccessRight
        /// </summary>
        public bool Equals(GroupUserAccessRight e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to GroupUserAccessRight
        /// </summary>
        public static implicit operator GroupUserAccessRight(string value)
        {
            return new GroupUserAccessRight(value);
        }

        /// <summary>
        /// Implicit operator to convert GroupUserAccessRight to string
        /// </summary>
        public static implicit operator string(GroupUserAccessRight e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum GroupUserAccessRight
        /// </summary>
        public static bool operator == (GroupUserAccessRight e1, GroupUserAccessRight e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum GroupUserAccessRight
        /// </summary>
        public static bool operator != (GroupUserAccessRight e1, GroupUserAccessRight e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for GroupUserAccessRight
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is GroupUserAccessRight && Equals((GroupUserAccessRight)obj);
        }

        /// <summary>
        /// Returns for hashCode GroupUserAccessRight
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
