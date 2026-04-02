namespace ClassesInheritance{

    class ClassesInheritanceExcercise
    {
        public class BasicAsset
        {
            //semua asset memiliki nama, fields ini akan di inherited ke semua subclass
            public string Name = string.Empty; //pake string.Empty untuk inisialisai default biar ngga null.

            public DateTime AcquisitionDate {get; set;} = DateTime.Now;

            //simple method yang bisa semua asset gunakan
            public void DisplayBasicInfo()
            {
                Console.WriteLine($"Assset: {Name}, Acquired : {AcquisitionDate}");
            }   
        }

        //BasicStock class inherits dari BasicAsset Class menggunakan : syntax
        // artinya class BasicStock merukapan bagian dari BasicAsset, dan dari bagian dirinya
        public class BasicStock : BasicAsset
        {
            public long SharesOwned {get; set;}
            public decimal CurrentPrice {get; set;}
            public string TrickerSymbol {get; set;} = string.Empty;

            //hitung total nilai dari stock holding
            public decimal TotalValue => SharesOwned * CurrentPrice;

            public void ShowStockDetails()
            {
                Console.WriteLine($"Stock Details : {TrickerSymbol} - {SharesOwned} shares at ${CurrentPrice:F2} = ${TotalValue:F2}");                
            }
        }
        public class BasicHouse : BasicAsset
        {
            //House-specific properties
            public decimal Mortgage {get; set;}
            public decimal MarketValue {get; set;}
            public string Address {get; set;}
            public int Bedrooms {get; set;}

            public decimal Equity => MarketValue - Mortgage;
            //House spesific method
            public void ShowHouseDetails()
            {
                Console.WriteLine($"House: {Address}, Value : ${MarketValue:F2}, Mortgage: ${Mortgage:F2}, Equity: ${Equity:F2}");
            }
            }
        public class BasicBond : BasicAsset
        {
            public decimal FaceValue {get; set;}
            public decimal InterestRate {get; set;}
            public DateTime MaturityDate {get; set;}
            public decimal AnnualInterest => FaceValue * (InterestRate/100);
            public void ShowBondDetails()
            {
                Console.WriteLine($"Bond: {Name}, Face Value: ${FaceValue:F2}, Rate: {InterestRate:F2}%, Annual Interest: ${AnnualInterest:F2}");
            }
        }

        public static void InheritanceDemo()
        {
            var microsoftStock = new BasicStock
            {
                Name = "Microsoft Corporation",
                TrickerSymbol = "MSFT",
                SharesOwned = 100,
                CurrentPrice = 350.75m
            };

            var dreamHouse = new BasicHouse
            {
                Name = "Dream House",
                Address = "123 Main Street, Seattle",
                MarketValue = 750000,
                Mortgage = 4000,
                Bedrooms = 4

            };

            var treasuryBond = new BasicBond
            {
                Name = "US Treasury Bond",
                FaceValue = 10000,
                InterestRate = 3.5m,
                MaturityDate = DateTime.Now.AddYears(10)
            };

            // Notice how all objects can call methods from both base and derived classes
            Console.WriteLine("1. Inherited methods work on all objects:");
            microsoftStock.DisplayBasicInfo();  // This comes from Asset base class
            dreamHouse.DisplayBasicInfo();      // Same method, different object
            treasuryBond.DisplayBasicInfo();    // All three can use it!
            
            Console.WriteLine("\n2. Each class also has its own specific methods:");
            microsoftStock.ShowStockDetails();  // Only Stock has this
            dreamHouse.ShowHouseDetails();      // Only House has this  
            treasuryBond.ShowBondDetails();     // Only Bond has this
            
            // This is the key benefit: we wrote DisplayBasicInfo() once in Asset,
            // but all three derived classes can use it. That's code reuse through inheritance!
            
            Console.WriteLine("\n3. All derived classes have the same base properties:");
            Console.WriteLine($"Stock name: {microsoftStock.Name}");
            Console.WriteLine($"House name: {dreamHouse.Name}");
            Console.WriteLine($"Bond name: {treasuryBond.Name}");
            
            Console.WriteLine($"\nStock acquired: {microsoftStock.AcquisitionDate}");
            Console.WriteLine($"House acquired: {dreamHouse.AcquisitionDate}");
            Console.WriteLine($"Bond acquired: {treasuryBond.AcquisitionDate}");
        }
    }

}