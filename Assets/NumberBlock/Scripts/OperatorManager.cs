using System.Collections;
using System.Collections.Generic;

public class OperatorManager {
    public List<OperatorEunm> OperaList
    {
        get;
        private set;
    }
    public OperatorManager()
    {
        Init();
    }

    public void Init()
    {
        OperaList = new List<OperatorEunm>();
    }

    public void AddValue(OperatorEunm opera)
    {
        OperaList.Add(opera);
    }
}
public enum OperatorEunm
{
    plus, minus, time
}
