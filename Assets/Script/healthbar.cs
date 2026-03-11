using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    [SerializeField]
    private Image fillImage;

    [SerializeField]
    private Gradient gradient;

    

    public void SetHealth(float healthNormalized)
    {
        fillImage.fillAmount = healthNormalized;
        fillImage.color = gradient.Evaluate(healthNormalized);
    }
    
}
