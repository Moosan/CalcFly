using System.Collections.Generic;

public class CalculateManager
{
    public static CalculateManager Singleton;
    private NumberManager NumberManager;
    private List<int> NumList
    {
        get
        {
            return NumberManager.NumberList;
        }
    }
    private OperatorManager OperatorManager;
    private List<OperatorEunm> OperaList
    {
        get
        {
            return OperatorManager.OperaList;
        }
    }
    public int CalcAnswer()
    {
        int answer = NumList[0];
        for(int i = 0; i < OperaList.Count; i++)
        {
            int nextNum = NumList[i + 1];
            switch(OperaList[i]) {
                case OperatorEunm.plus:
                    answer += nextNum;
                    break;
                case OperatorEunm.minus:
                    answer -= nextNum;
                    break;
                case OperatorEunm.time:
                    answer *= nextNum;
                    break;
            }
        }
        return answer;
    }

    public CalculateManager()
    {
        Init();
    }
    public void Init()
    {
        NumberManager = new NumberManager();
        OperatorManager = new OperatorManager();
    }
    public void AddValue(int number)
    {
        NumberManager.AddValue(number);
    }
    private void AddValue(OperatorEunm opera)
    {
        OperatorManager.AddValue(opera);
    }
}
