using System;
using System.Net;
using System.Threading.Tasks;

namespace CSharp6._0Samples
{
    //ExceptionFilter syntax: catch (HttpRequestException e) when (e.Message.Contains("301"))
    public class ExceptionFiltersDemo
    {
        public ExceptionFiltersDemo()
        {

        }

        public void MakeRequest()
        {
            string text = null;
            try
            {
                var responseText = text.Length;
                Console.WriteLine("Success");
            }
            catch (NullReferenceException e) when (LogException(e))
            {
                //If when true exception will be handled by catch
                //If when false exception will not be handle by catch
                Console.WriteLine("Error");
            }
            catch (Exception e)
            {
                Console.WriteLine("When returns false, So 1st Catch Doesn't handle exception and catched by 2nd Catch");
            }
            Console.WriteLine("Completed");
        }
        public bool LogException(Exception e)
        {
            //custom logic
            Console.WriteLine("Null Value");
            return false;
        }

        public static void Main(string[] args)
        {
            ExceptionFiltersDemo demo = new ExceptionFiltersDemo();
            demo.MakeRequest();
        }
    }
}
