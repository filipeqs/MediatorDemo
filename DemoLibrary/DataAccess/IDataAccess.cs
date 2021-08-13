using DemoLibrary.Models;
using System.Collections.Generic;

namespace DemoLibrary.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetPerson();
        PersonModel InsertPerson(string firstName, string lastName);
    }
}