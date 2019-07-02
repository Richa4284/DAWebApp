using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwnerRegistration.Model
{
    public class OwnRegistration
    {
        List<Owner> OwnerList;
        static OwnRegistration Ownerregd = null;
        private OwnRegistration()
        {
            OwnerList = new List<Owner>();
        }


  
        public static OwnRegistration getInstance()
        {
            if (Ownerregd == null)
            {
                Ownerregd = new OwnRegistration();
                return Ownerregd;
            }
            else
            {
                return Ownerregd;
            }
        }
        public void Add(Owner Owner)
        {
            OwnerList.Add(Owner);
        }
        public String Remove(String registrationNumber)
        {
            for (int i = 0; i < OwnerList.Count; i++)
            {
                Owner Ownern = OwnerList.ElementAt(i);
                if (Ownern.RegistrationNumber.Equals(registrationNumber))
                {
                    OwnerList.RemoveAt(i);//update the new record
                    return "Delete successful";
                }
            }
            return "Delete un-successful";
        }
        public List<Owner> getAllOwner()
        {
            return OwnerList;
        }
        public String UpdateOwner(Owner Owner)
        {
            for (int i = 0; i < OwnerList.Count; i++)
            {
                Owner Ownern = OwnerList.ElementAt(i);
                if (Ownern.RegistrationNumber.Equals(Owner.RegistrationNumber))
                {
                    OwnerList[i] = Owner;//update the new record
                    return "Update successful";
                }
            }
            return "Update un-successful";
        }
    }
}

