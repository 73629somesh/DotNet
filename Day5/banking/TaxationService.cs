namespace taxation;

public class TaxationService{

    public void payIncomeTax(float amount){

           Console.WriteLine(amount+" of IncomeTax is deducted from your account") ;
    }

    public void payGstTax(float amount){

          Console.WriteLine(amount+" of GST Tax is deducted from your account") ;
    }

    public void paySalesTax(float amount){

          Console.WriteLine(amount+" of Sales Tax is deducted from your account") ;
    }

    public void payServiceTax(float amount){

          Console.WriteLine(amount+" of Service Tax is deducted from your account") ;
    }
}