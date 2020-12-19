using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCharacterScale : MonoBehaviour
{
    public float scale = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setScale()
    {
        string holderName = gameObject.name + " holder";

        Debug.Log(holderName);

        GameObject holder = GameObject.Find(holderName);

        Vector2 sd = holder.GetComponent<RectTransform>().sizeDelta;
        sd.x *= scale;
        sd.y *= scale;
        holder.GetComponent<RectTransform>().sizeDelta = sd;
    }
}
