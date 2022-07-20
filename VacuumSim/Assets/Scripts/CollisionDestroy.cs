using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class CollisionDestroy : MonoBehaviour
{
    public Canvas canvas;
    public Text candyCtrText;
    public TextMeshProUGUI gameOverText;
    public AudioSource candySound;
    private int candyCtr = 0;
    public int candyMax;

    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.SetActive(true);
        candyCtrText.text = candyCtr + " / " + candyMax;
    }

    // Update is called once per frame
    void Update()
    {
        candyCtrText.text = candyCtr + " / " + candyMax;
    }

    void OnTriggerEnter(Collider col)
    {;
        if (col.gameObject.tag == "item")
        {
            Debug.Log("Kill " + col.gameObject.name + (candyCtr + 1));
            Destroy(col.gameObject);
            candyCtr++;
            candySound.Play();
        }
        if (candyCtr >= candyMax)
        {
            gameOverText.gameObject.SetActive(true);
        }
    }
}
