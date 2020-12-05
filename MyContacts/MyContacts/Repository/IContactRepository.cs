using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyContacts
{
    interface IContactRepository
    {
        DataTable SelectAll();
        DataTable SelectRow(int ContactID);
        DataTable Search(string parameter);
        bool Insert(string Name, string Family, int Age, string Mobile, string Email, string Address);
        bool Update(int ContactID, string Name, string Family, int Age, string Mobile, string Email, string Address);
        bool Delete(int ContactID);


    }
}
