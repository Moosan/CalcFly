using System.Collections.Generic;

public class NumberManager{
    public List<int> NumberList
    {
        get;
        private set;
    }
    public NumberManager()
    {
        Init();
    }

    public void Init()
    {
        NumberList = new List<int>();
    }

    public void AddValue(int number)
    {
        NumberList.Add(number);
    }

}
