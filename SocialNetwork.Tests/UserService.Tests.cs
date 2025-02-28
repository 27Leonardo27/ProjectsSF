using SocialNetwork.BLL.Services;
using SocialNetwork.BLL.Models;
using NUnit.Framework.Legacy;

namespace SocialNetwork.Tests
{
    class UserServiceTests
    {
        private UserService userService = new UserService();

        [Test]
        public void GetAddFriendCorrectly()
        {
            userService.Register(new UserRegistrationData 
            {
                Email = "19@a",
                FirstName = "And",
                LastName = "aa",
                Password = "12345678"
            });

            userService.Register(new UserRegistrationData
            {
                Email = "18@a",
                FirstName = "Misha",
                LastName = "AA",
                Password = "12345678"
            });

            var data = new UserAddingFriendData
            {
                UserId = 1,
                FriendEmail = "18@a"
            };

            userService.AddFriend(data);

            var friends = userService.GetFriendsByUserId(data.UserId);
            var friend = friends.FirstOrDefault(x => x.Email == data.FriendEmail);

            Assert.That(friend.Email, Is.EqualTo(data.FriendEmail));
        }
    }
}
