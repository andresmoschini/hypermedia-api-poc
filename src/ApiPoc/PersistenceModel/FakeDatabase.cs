﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPoc.PersistenceModel
{
    public class FakeDatabase : IDatabase
    {
        private readonly Account _currentAccount;
        private readonly List<Account> _accounts;

        public FakeDatabase()
        {
            _currentAccount = new Account()
            {
                Id = 128,
                FirstName = "Andrés",
                LastName = "Moschini",
                Birthday = DateTime.Parse("1978-12-02"),
                Email = "private@andresmoschini.com",
                AllSubscribers = Enumerable.Range(1, 1134).Select(x => new Subscriber()
                {
                    Id = x,
                    FirstName = "Juan" + x,
                    LastName = "Perez" + x,
                    Birthday = DateTime.Parse("1980-01-01"),
                    Email = "juan" + x + "@perez.com"
                }).ToList()
            };

            _accounts = new List<Account>()
            {
                _currentAccount
            };
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accounts;
        }

        public Account GetCurrentAccount()
        {
            return _currentAccount;
        }

        public Account GetAccountById(int accountId)
        {
            return _accounts.Where(x => x.Id == accountId).FirstOrDefault();
        }
    }
}
