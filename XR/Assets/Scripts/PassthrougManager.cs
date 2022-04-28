using System.Collections.Generic;
using UnityEngine;

public class PassthrougManager : MonoBehaviour

{
    public OVRPassthroughLayer passthrough;
    public OVRInput.Button button;
    public OVRInput.Controller controller;
    public List<Gradient> ColorMapGradient;
    [Header("調整UI介面開關")]
    public GameObject passthroughgstylerCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(button,controller))
        {
            passthrough.hidden = !passthrough.hidden;
        }
        //UI畫面開關
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            passthroughgstylerCanvas.SetActive(!passthroughgstylerCanvas.activeSelf);
        }
    }
    public void SetOpacity(float value)
    {
        passthrough.textureOpacity = value;
    }
    public void SetColorMapGradient(int index)
    {
        passthrough.colorMapEditorGradient = ColorMapGradient[index];
    }
    /// <summary>
    /// 亮度設置
    /// </summary>
    /// <param name="value"></param>
    public void SetBrightness(float value)
    {
        passthrough.colorMapEditorBrightness = value;
        //設置顏色映射編輯器
    }
    /// <summary>
    /// 對比度設置
    /// </summary>
    /// <param name="value"></param>
    public void SetContrast(float value)
    {
        passthrough.colorMapEditorContrast = value;
        //設置顏色映射對比
    }
    /// <summary>
    /// 位置設置
    /// </summary>
    /// <param name="value"></param>
    public void SetPosterize(float value)
    {
        passthrough.colorMapEditorPosterize = value;
    }
    /// <summary>
    /// 通過扁元渲染進行護進囗滑動方塊啟用等值等
    /// </summary>
    /// <param name="value"></param>
    public void SetgeRendering(bool value)
    {
        passthrough.edgeRenderingEnabled = value;
    }
    /// <summary>
    /// 紅色設定
    /// </summary>
    /// <param name="value"></param>
    public void SetEdgeRed(float value)
    {
        //創建新顏色 = 新顏色(改動顏色值，綠色顏色直保持原樣，藍色數值保持原樣)
        Color newColor = new Color(value, passthrough.edgeColor.g, passthrough.edgeColor.b);
        passthrough.edgeColor = newColor; 
    }
    public void SetEdgeGreen(float value)
    {
        Color newColor = new Color(passthrough.edgeColor.r, value, passthrough.edgeColor.b);
        passthrough.edgeColor = newColor;
    }
    public void SetEdgeBlue(float value)
    {
        Color newColor = new Color(passthrough.edgeColor.a, passthrough.edgeColor.g, value);
        passthrough.edgeColor = newColor;
    }
}
