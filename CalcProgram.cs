using System.Security.Authentication;

namespace CalcProjectV2
{
    class CalcProgram
    {
       private static void Main(string[] args)
       {
           //start of both programs
           GetCalcProgramData getdata = new GetCalcProgramData();
           getdata.ContinueYorN();
       } 
    }
}