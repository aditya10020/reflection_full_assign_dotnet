namespace Rentlib;
[LuxuryTax(Limit =10)]
class PremiumTours
{
     private double amount = 1200;
   public double GetDaysRentForCommom(int day, int nopersons)
   {       
        double m = day > 6 ?amount-100:amount;
         m = nopersons>=4?amount-100:amount;    
        return m*day*nopersons;
   } 
   public double GetDaysRentForSeniors(int day, int nopersons) =>GetDaysRentForCommom(day,nopersons)-100*day;
   public double GetDaysRentForWomen(int day, int nopersons) =>GetDaysRentForCommom(day,nopersons)-200*day;

}