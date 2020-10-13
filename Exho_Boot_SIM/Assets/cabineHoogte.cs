using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabineHoogte : MonoBehaviour
{
    // dit is de script om de stuurcabine hoger of lager te zetten. Volgens meerdere zijn er schepen die dit kan.

    [SerializeField] private int maxHeight;
    [SerializeField] private int minHeight;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Plus))
        {
            if(this.transform.position.y < maxHeight)
            {
                this.transform.position -= new Vector3(0, 0.01f, 0);
            }

        }
        if (Input.GetKeyDown(KeyCode.Minus))
        {
            if (this.transform.position.y > minHeight)
            {
                this.transform.position += new Vector3(0, 0.01f, 0);
            }
        }
    }
}
