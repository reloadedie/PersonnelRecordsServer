using ModelApi;

namespace PersonnelRecordsServer.db
{
    public partial class User
    {
        public static explicit operator UserApi(User user)
        {
            return new UserApi
            {
                Id = user.Id,                
                Login = user.Login,
                Password = user.Password,
                TypeUser = user.TypeUser               


            };
        }

        public static explicit operator User(UserApi user)
        {
            return new User
            {
                Id = user.Id,
                Login = user.Login,
                Password = user.Password,
                TypeUser = user.TypeUser
            };
        }
    }
}