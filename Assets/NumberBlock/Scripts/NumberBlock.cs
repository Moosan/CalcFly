using UnityEngine;

public class NumberBlock : MonoBehaviour {
    [SerializeField]
    private int Number;
    private bool isDestroy = false;
    private void Start()
    {
        SetSprite(Number);
    }

    public void SetNumber(int number)
    {
        Number = number;
        SetSprite(Number);
    }

    public void SetSprite(int number)
    {
        GetComponent<SpriteRenderer>().sprite = NumberSpriteManager.Singleton.NumSpriteArray[number];
    }

    private void DestroyOwn()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isDestroy) return;
        if(other.tag == "Player")
        {
            CalculateManager.Singleton.AddValue(Number);
            DestroyOwn();
        }
    }
}
