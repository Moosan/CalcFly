using UnityEngine;

public class NumberBlockManager : MonoBehaviour {
    [SerializeField]
    private GameObject NumberBlock;
    //数字を指定してブロックを生成する
    private void MakeNumberBlock(Vector3 position, Quaternion rotation,int number)
    {
        var block = (GameObject)Instantiate(NumberBlock, position, rotation);
        block.GetComponent<NumberBlock>().SetNumber(number);
    }

    //ランダムな数字のブロックを生成する
    private void MakeRandomNumberBlok(Vector3 position,Quaternion rotation,int maxNumber)
    {
        MakeNumberBlock(position, rotation, Random.Range(0, maxNumber));
    }
    
}
