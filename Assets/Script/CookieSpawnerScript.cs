using UnityEngine;
using System.Collections;

public class CookieSpawnerScript : MonoBehaviour
{
    public GameObject realCookie;
    public GameObject fakeCookie;
    int interval = 0;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        interval++;
        if (interval % 10 == 0)
        {
            spawn();
        }
    }

    void spawn()
    {
        Instantiate(realCookie, new Vector2(Random.Range(-20, 20), Random.Range(-20, 20)), Quaternion.identity);
        Instantiate(realCookie, new Vector2(Random.Range(-20, 20), Random.Range(-20, 20)), Quaternion.identity);
        Instantiate(fakeCookie, new Vector2(Random.Range(-20, 20), Random.Range(-20, 20)), Quaternion.identity);
    }
}
