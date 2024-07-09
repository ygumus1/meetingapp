namespace MeetingApp.Models
{
    public static class Repository{

        private static List<UserInfo> _users = new();


        static Repository()
        {
            _users.Add(new UserInfo(){ Id = 1,Name="Yahya",Phone="05458963231",Email="yahyygumus@gmail.com",WillAttend=true});
            _users.Add(new UserInfo(){ Id = 2,Name="Emre",Phone="05489632562",Email="emre@gmail.com",WillAttend=false});
            _users.Add(new UserInfo(){ Id = 3,Name="Burak",Phone="0563895486",Email="burak@gmail.com",WillAttend=true});
        }

        public static List<UserInfo> Users{
            get{
                return _users;
            }
        }

        public static void CreateUser(UserInfo user){

            user.Id= Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id){
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}