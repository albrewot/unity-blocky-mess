using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAnchorControl : MonoBehaviour
{
    //Variables
    [SerializeField] public RectTransform textRT;

    //Methods
    public void OnButtonDown() {
        textRT.anchorMin = new Vector2(0, 0);
        textRT.anchorMax = new Vector2(1, 0.77f);
    }

    public void OnButtonRelease() {
        textRT.anchorMin = new Vector2(0, 0.23f);
        textRT.anchorMax = new Vector2(1, 1);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
