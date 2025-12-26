namespace MauiApp1.Models;

public class User
{
	public string Username { get; set; }
	public string Password { get; set; }

	public User(string username, string password)
	{
		Username = username;
		Password = password;
	}
}

public static class UserList
{
	public static List<User> GetUsers()
	{
		return new List<User>
		{
			new User("admin", "password123"),
			new User("john_doe", "secure@123"),
			new User("jane_smith", "jane#456"),
			new User("user01", "user@pass"),
			new User("test_user", "test1234")
		};
	}
}
