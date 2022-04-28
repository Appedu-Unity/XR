using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAsProjectionSurfaceElement : MonoBehaviour
{
    [Header("OVR路徑的公共引用")]
    public OVRPassthroughLayer passthrough;
    [Header("更新變化的布林直")]
    public bool updateTransForm = false;
    // Start is called before the first frame update
    void Start()
    {
        passthrough.AddSurfaceGeometry(gameObject, updateTransForm);
        GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
