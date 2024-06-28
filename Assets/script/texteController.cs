using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class texteController : MonoBehaviour
{
    private TextMeshProUGUI munitionText;
    [SerializeField] private bulletGenerator bulletGenerator;
    // Start is called before the first frame update
    void Start()
    {
        munitionText = GetComponent<TextMeshProUGUI>();
        munitionText.text = "30";
    }

    // Update is called once per frame
    void Update()
    {
        munitionText.text = bulletGenerator.munition.ToString();
    }
}
