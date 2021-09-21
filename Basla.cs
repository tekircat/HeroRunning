using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basla : MonoBehaviour
{

    public GameObject Bas;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Baslaa()
    {
        
        
        Time.timeScale = 1;
        
        Bas.SetActive(false);

    }
}
