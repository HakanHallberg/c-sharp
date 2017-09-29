using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsolApp
{
    class Student
    {   //två fält i klassen Student
        public string Name;
        public string Email;
        private int StudyHarderCounter = 0;
        public event EventHandler TooTired;



        // håkan.StudyHarder(); //Metoder ska alltid ha stor bokstav i början
        //Här gör man så att appen nu retunerar namnet och email istället för tidigare Hello world to OOPConsolApp
        public override string ToString()
        {
            return $"{this.Name} \n{this.Email}"; //$ kallas för interpolationssträng. Dollar gör att det som finns i måsvingarna plockas in i strängen
        }

        internal void StudyHarder()
        {
            StudyHarderCounter++;
            if (StudyHarderCounter > 2)
            
                TooTired?.Invoke(this, null); //arg eller null på andra
            
            Name = "Super " + Name;
        }
    }
}
