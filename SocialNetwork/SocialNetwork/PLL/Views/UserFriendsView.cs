using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendsView
    {
        public void Show(IEnumerable<User> friends)
        {
            Console.WriteLine("У вас в друзьях");


            if (friends.Count() == 0)
            {
                Console.WriteLine("У вас пока нет друзей. Воспользуйтесь главным меню и добавьте друга!");
                return;
            }

            friends.ToList().ForEach(friend =>
            {
                Console.WriteLine("Почтовый адрес друга: {0}. Имя друга: {1}. Фамилия друга: {2}", friend.Email, friend.FirstName, friend.LastName);
            });

        }
    }
}
