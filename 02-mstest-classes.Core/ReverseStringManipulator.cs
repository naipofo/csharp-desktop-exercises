using System.Linq;

namespace _02_mstest_classes.Core;
public class ReverseStringManipulator: IStringManipulator
{
    public string Manipulate(string input) => new String(input.Reverse().ToArray());
}
