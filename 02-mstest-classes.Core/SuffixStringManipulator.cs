namespace _02_mstest_classes.Core;
public class SuffixStringManipulator: IStringManipulator
{
    public string Manipulate(string input) => input + "_123";
}
