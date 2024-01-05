using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatPhases : MonoBehaviour
{
    public GameObject cat1, cat2, cat3;
    public bool cat1Enable = true, cat2Enable = false, cat3Enable = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(cat1Enable == true)
            {
                cat1Enable = false;
                cat2Enable = true;
                cat3Enable = false;
                cat1.SetActive(true);
                cat2.SetActive(false);
                cat3.SetActive(false);
            }
            else if (cat2Enable == true)
            {
                cat1Enable = false;
                cat2Enable = false;
                cat3Enable = true;
                cat2.SetActive(true);
                cat1.SetActive(false);
                cat3.SetActive(false);
            }
            else if (cat3Enable == true)
            {
                cat1Enable = true;
                cat2Enable = false;
                cat3Enable = false;
                cat3.SetActive(true);
                cat2.SetActive(false);
                cat1.SetActive(false);
            }
        }
    }
}
