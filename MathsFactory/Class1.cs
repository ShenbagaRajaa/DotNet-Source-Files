using MathsComponent;
using MathsInterface;

namespace MathsFactory;

public class AFactory
{
    public static IAinterface CreateAOperation(){  //we use hear dynamic function
        return new Arithmatic(); 
    }
}
