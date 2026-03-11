using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    [SerializeField]
    private Image fillImage;

    

    public void SetHealth(float healthNormalized)
    {
        fillImage.fillAmount = healthNormalized;
    }
    
}
