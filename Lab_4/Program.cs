using Lab_4;

public class program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter choise of program :");
        int n = Convert.ToInt32(Console.ReadLine());
        switch(n)
        {
            case 1:
                Addition a1 = new Addition();
                a1.add(5,6);
                a1.add(5.2f, 6.2f);
                break;
            case 2:
                squareandrectangle a2 = new squareandrectangle();
                a2.area(5);
                a2.area(5, 6);
                break;
            case 3:
                RBI rbi= new RBI();
                HDFC hdfc = new HDFC();
                ICICI icic = new ICICI();
                SBI sbi = new SBI();
                rbi.calculateInterest(1, 2, 3);
                hdfc.calculateInterest(1, 2, 3);
                sbi.calculateInterest(1, 2, 3);
                icic.calculateInterest(1, 2, 3);
                break;
            case 4:
                Hospital h = new Hospital();
                Apollo a = new Apollo();
                Wockhardt w = new Wockhardt();
                Gokul_Superspeciality gs = new Gokul_Superspeciality();
                h.HospitalDetails();
                a.HospitalDetails();
                w.HospitalDetails();
                gs.HospitalDetails();
                break;
            case 5:
                shape sp = new shape();
                sp.area(5);
                sp.area(5, 6);
                sp.area(3.2);
                break;

        }

    }
}