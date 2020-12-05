using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bank
{
    public class DbContext
    {
        public DbSet<User> Users;
        public DbSet<Card> Cards;
        public DbContext()
        {
            Users = new DbSet<User>();
            Cards = new DbSet<Card>();
            AddDefaultUsers();
            AddDefaultCards();
        }
        private List<User> defaultUsers = new List<User> 
        {

            new User { Id = Ibentificator<User>.GetId(), name = "AliMan", Surname = "Sekrentarovich", Email = "alisekrentar@gmail.com", Password = "Aliloxa1234" },
        new User { Id = Ibentificator<User>.GetId(), name = "PozziMan", Surname = "Superevich", Email = "SuperPozzi@gmail.com", Password = "Superpozzi" },

        };
        private void AddDefaultUsers()
        {
          
            Users.Add(defaultUsers[0]);
            Users.Add(defaultUsers[1]);
        }
        private void AddDefaultCards()
        {

            Cards.Add(new CardManager2("BeynaxalgBank", "5", "MasterCard", defaultUsers[1]).GetCard());
            Cards.Add(new CardManager2("KapitalBank", "1", "Visa", defaultUsers[0]).GetCard());

        }
    }
}
