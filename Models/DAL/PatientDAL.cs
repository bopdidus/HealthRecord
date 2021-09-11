using HealthRecord.Models.BO;
using HealthRecord.Models.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthRecord.Models.DAL
{
    public class PatientDAL : IList<Patient>
    {
        public Patient this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(PatientViewModel  item)
        {

            Patient patient = new Patient();
            patient.LastName = item.LastName;
            patient.FirstName = item.FirstName;
            patient.Birthdate = item.Birthdate;
            patient.Email = item.Email;
            patient.PhoneNumber = item.PhoneNumber;
            patient.Gender = (GenderType)Enum.Parse(typeof(GenderType), item.Gender);

            Address addr = new Address();
            addr.Country = item.Country;
            addr.State = item.State;
            addr.Street = item.Street;

            patient.Address = addr;

            this.Add(patient);

        }

        public void Add(Patient item)
        {
            
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Patient item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Patient[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Patient> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(Patient item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, Patient item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Patient item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
