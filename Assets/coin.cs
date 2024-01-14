using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    public Text coinTxt;
    public int coins;

    // Start is called before the first frame update
    void Start()
    {
        coinTxt.text = coins.ToString();
        coins = PlayerPrefs.GetInt("coins");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
        coins++;
        PlayerPrefs.GetInt("coins", coins);
        coinTxt.text = coins.ToString();
        Destroy(other.gameObject);
        }
        
    }
}
