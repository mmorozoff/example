using No1.Solution.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace No1.Solution
{
    public class ListRepository : IRepository
    {
        private List<string> repository;

        public ListRepository()
        {
            this.repository = new List<string>();
        }

        public void Create(string password)
        {
            if (password is null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            this.repository.Add(password);
        }

        public string[] Show() => this.repository.ToArray();
    }
}
