using System;
using System.Collections.Generic;
using System.Text;

namespace No1.Solution.Interface
{
    public interface IRepository
    {
        void Create(string password);

        string[] Show();
    }
}
