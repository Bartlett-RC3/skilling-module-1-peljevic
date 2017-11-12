using System;
namespace Application
{
    public class Dogs
    {
        public int age;
        public int weight;
        public int walkingsPerDay;
        public bool canBeKeptinAparatment;
        public string nameOfBreed;
        public string petName;

        public Dogs(int _age, int _weight, int _walkingsPerDay, bool _canBeKeptinAparatment, string _nameOfBreed, string _petName)
        {
            age = _age;
            weight = _weight;
            walkingsPerDay = _walkingsPerDay;
            canBeKeptinAparatment = _canBeKeptinAparatment;
            nameOfBreed = _nameOfBreed;
            petName = _petName;
        }
        public void SetPetName(string newPetName)
        {
            petName = newPetName;
        }
        private void Ageing()
        {
            age = age + 1;
            walkingsPerDay = walkingsPerDay + 1;
        }
     
    }
}
