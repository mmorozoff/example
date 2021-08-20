using No1.Solution.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private IChecker checker;
        private IRepository repository;

        public PasswordCheckerService(IChecker checker, IRepository repository)
        {
            if (checker is null || repository is null)
            {
                throw new ArgumentNullException(nameof(checker));
            }

            this.checker = checker;
            this.repository = repository;
        }

        public (bool, string) VerifyPassword(string password)
        {
            (bool verify, string message) result = this.checker.Verify(password);
            if (result.verify)
            {
                this.repository.Create(password);
            }

            return result;
        }

        public string[] Show() => this.repository.Show();
    }
}
