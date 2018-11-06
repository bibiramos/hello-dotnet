using Microsoft.Extensions.Configuration;

namespace OdeToFood
{
  public interface IGreeter
  {
    string GetMessageOfTheDay();
  }

  public class Greeter : IGreeter
  {
    private IConfiguration _configuration;

    public Greeter(IConfiguration configuration) {
      _configuration = configuration;
    }

    public string GetMessageOfTheDay() {
      if (!string.IsNullOrEmpty(_configuration["Greeting"]))
      {
        return _configuration["Greeting"];
      }
      return "Hellow";
    }
  }
}