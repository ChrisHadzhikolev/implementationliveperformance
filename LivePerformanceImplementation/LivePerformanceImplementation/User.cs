using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceImplementation
{
    public class User : IEquatable<User>
    {
        private static int _idSeeder = 0;
        public int Id { get; }
        public string Username { get; }
        public string RealName { get; }
        public string Email { get; }
        public DateTime DateOfBirth { get; }
        public string EncryptedPassword { get; }

        public User(string username, string realName, string email, DateTime dateOfBirth, string encryptedPassword)
        {
            Id = _idSeeder;
            _idSeeder++;
            Username = username;
            RealName = realName;
            Email = email;
            DateOfBirth = dateOfBirth;
            EncryptedPassword = encryptedPassword;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as User);
        }

        public bool Equals(User other)
        {
            return other != null &&
                   Id == other.Id;           
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public static bool operator ==(User left, User right)
        {
            return EqualityComparer<User>.Default.Equals(left, right);
        }

        public static bool operator !=(User left, User right)
        {
            return !(left == right);
        }
    }
}
