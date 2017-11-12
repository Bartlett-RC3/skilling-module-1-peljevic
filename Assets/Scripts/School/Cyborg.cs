// References


    public class Cyborg : Human
    {
    //Variables
    float mechanicsPercentage;



        public Cyborg(int _age, float _height, bool _gender, string _firstName, string _familyName, float _mechanicsPercentage)
            {
            age = _age;
            height = _height;
            gender = _gender;
            firstName = _firstName;
            familyName = _familyName;
            hungry = true;
            energy = 100;
            mechanicsPercentage = _mechanicsPercentage;
            }

         private Ageing()
        {
        age = age+1;
        energy = energy + 1;
        }
    }

   
