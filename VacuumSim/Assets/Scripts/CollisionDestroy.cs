using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CollisionDestroy : MonoBehaviour
{
    public Canvas canvas;
    public Text candyCtrText;
    public AudioSource candySound;
    private int candyCtr = 0;

    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.SetActive(true);
        candyCtrText.text = candyCtr + " / 60";
    }

    // Update is called once per frame
    void Update()
    {
        candyCtrText.text = candyCtr + " / 60";
    }

    void OnCollisionEnter(Collision col)
    {;
        if (col.gameObject.tag == "item")
        {
            Destroy(col.gameObject);
            candyCtr++;
            candySound.Play();
        }
    }
}
