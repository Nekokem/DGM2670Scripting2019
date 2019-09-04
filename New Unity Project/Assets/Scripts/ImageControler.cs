using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageControler : MonoBehaviour
{
    private Image ImageComponent;
    public UnityEvent UpdateImageEvnet;
    private void Start()
    {
        ImageComponent = GetComponent<Image>();
    }
    
    public void UpdateImageComponent(FloatData dataobj)
    {
        ImageComponent.fillAmount = dataobj.value;
    }

    private void Update()
    {
       UpdateImageEvnet.Invoke();
    }
}
