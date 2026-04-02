namespace Classes{
    class CatExercise
    {
        public class Cat
        {
            public string Name {get; set;} ="";
            public string Color {get; set;} = "Grey";
            public int Age {get; set;} = 3;
            public double Weight {get; set;}= 3.2;
            public bool IsFriendly {get; set;} = true;
            public string FavoriteFood {get; set;} = "Fish";
            public  bool LikesFish {get; set;} = true;
            public bool LikesHumans {get; set;} = true; 

            //property dengan init-only setter, hanya dapat di set ketika initialization dan setelah itu jadi read-only dan tidak dapat diubah
            public DateTime BirthDate {get; init;} = DateTime.Now;

            //computed property yang dibentuk dari properties lain dalam class
            // menggunakan expression body method dengan mengganti {} menjadi => untuk retrun value
            public string Description => $"{Color} Cat name {Name}, age{Age}, love {FavoriteFood}";

            //default constructor
            public Cat()
            {
                Console.WriteLine ($" Created a Cat");
            }

            //Constructor dengan parameter
            public Cat (string name) : this ()
            {
                Name = name;
                Console.WriteLine ($"Created Cat named {name}");
            }

            //method do make the cat hop
            public void Hop()
            {
                Console.WriteLine($" {Name} hops around happily!");
            }

            //method to ffed the cat
            public void Feed (string food)
            {
                if (food.ToLower() == FavoriteFood.ToLower())
                {
                    Console.WriteLine($"{Name} loves the {food}! *munch munch* ");
                }
                else
                {
                    Console.WriteLine($"{Name} sniffs the {food} but prefers {FavoriteFood}");
                }
            }

            //method to pet the cat
            public void Pet()
            {
                if (IsFriendly)
                {
                    Console.WriteLine($"{Name} enjoy being petted and purrs sofly");
                }
                else
                {
                    Console.WriteLine($"{Name} is not in the mood for petting right now");
                }
            }

            //method to display cat's information
            public void DisplayInfo()
            {
                Console.WriteLine($" Cat's Info : ");
                Console.WriteLine($" Name : {Name}");
                Console.WriteLine($" Color : {Color}");
                Console.WriteLine($" Age : {Age} years old");
                Console.WriteLine($" Weight : {Weight} kg");
                Console.WriteLine($" Friendly : {(IsFriendly ? "Yes" : "No")}");
                Console.WriteLine($" Favorite Food: {FavoriteFood}");
                Console.WriteLine($" Birth Date: {BirthDate:yyyy-MM-dd}");

            }

            public override string ToString()
            {
                return Description;
            }


        }
        public static void CatDemo()
        {
            //object cat1 name soul
            Cat cat1 = new Cat("Soul");
            //call method by object
            cat1.DisplayInfo();
            cat1.Hop();
            cat1.Pet();
            cat1.DisplayInfo();
            cat1.Feed("Salmon");

            //new object initializer 
            var cat2 = new Cat("Body")
            {   //ubah sebagian property 
                Age = 2,
                Color = "White",
                FavoriteFood="Tuna"
            };
            cat2.DisplayInfo();
            cat2.Hop();
            cat2.Pet();
            cat2.Feed("Salmon");

            //new object initializer dengan mengubah semua default value
            Cat cat3 = new Cat("Soju")
            {
                Age=1,
                Color="Light Gray",
                Weight=0.8,
                IsFriendly=false,
                FavoriteFood="tuna"
            };
            cat3.DisplayInfo();
            cat3.Hop();
            cat3.Pet();
            cat3.Feed("Salmon");
        }
    }
}
